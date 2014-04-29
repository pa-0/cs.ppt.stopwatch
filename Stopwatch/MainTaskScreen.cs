using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TaskStopwatch
{
    public partial class MainTaskScreen : Form
    {
        public MainTaskScreen()
        {
            InitializeComponent();
        }

        private void TaskSetup_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            taskTitleLabel.Text = treeView1.SelectedNode.Text;
            dataGridView1.Rows.Clear();

            try
            {

                TaskNode tasknode = ((TaskNode)treeView1.SelectedNode);
                dataGridView1.Rows.Add(tasknode.Text, tasknode.OriginalEstimated, tasknode.CurrentEstimated, tasknode.Elapsed);
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.SlateGray;
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Tomato;


                foreach (var node in treeView1.SelectedNode.Nodes)
                {
                    TaskNode subtasknode = ((TaskNode)node);
                    dataGridView1.Rows.Add(subtasknode.Text, subtasknode.OriginalEstimated, subtasknode.CurrentEstimated, subtasknode.Elapsed);
                }

                e.Node.Expand();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.FileName = Application.StartupPath + "\\..\\..\\example.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Just a good practice -- change the cursor to a 
                    //wait cursor while the nodes populate
                    this.Cursor = Cursors.WaitCursor;
                    //First, we'll load the Xml document
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(dlg.FileName);
                    //Now, clear out the treeview, 
                    //and add the first (root) node
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(new
                      TreeNode(xDoc.DocumentElement.Name));
                    TreeNode tNode = new TreeNode();
                    tNode = (TreeNode)treeView1.Nodes[0];
                    //We make a call to addTreeNode, 
                    //where we'll add all of our nodes
                    addTreeNode(xDoc.DocumentElement, tNode);
                    //Expand the treeview to show all nodes
                    treeView1.ExpandAll();
                }
                catch (XmlException xExc)
                //Exception is thrown is there is an error in the Xml
                {
                    MessageBox.Show(xExc.Message);
                }
                catch (Exception ex) //General exception
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default; //Change the cursor back
                }
            }
        }

        //This function is called recursively until all nodes are loaded
        private void addTreeNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes) //The current node has children
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                //Loop through the child nodes
                {
                    xNode = xmlNode.ChildNodes[x];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[x];
                    addTreeNode(xNode, tNode);
                }
            }
            else //No children, so add the outer xml (trimming off whitespace)
                treeNode.Text = xmlNode.OuterXml.Trim();
        }

        private void saveTaskListButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.Title = "Save Task File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                TreeView tv = treeView1;
                string filename = saveFileDialog1.FileName;

                XmlTextWriter xr = new XmlTextWriter(filename, System.Text.Encoding.UTF8);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                xr.WriteStartDocument();

                //Write our root node
                xr.WriteStartElement(treeView1.Nodes[0].Text);

                //Write current elapsed time for Root Node
                xr.WriteAttributeString("Estimated Time", "3123131");
                xr.WriteAttributeString("Elapsed Time", "3123131");


                foreach (TreeNode node in tv.Nodes)
                {
                    saveNode(xr, node.Nodes);
                }
                //Close the root node
                xr.WriteEndElement();
                xr.Close();
            }

        }

        private void saveNode(XmlTextWriter xr, TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children
                if (node.Nodes.Count > 0)
                {
                    xr.WriteStartElement(node.Text);

                    //Write current elapsed time for Root Node
                    xr.WriteAttributeString("Estimated Time", "3123131");
                    xr.WriteAttributeString("Elapsed Time", "3123131");

                    saveNode(xr, node.Nodes);
                    xr.WriteEndElement();
                }
                else //No child nodes, so we just write the text
                {
                    xr.WriteString(node.Text);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TaskStopwatch stopwatch = new TaskStopwatch();
            stopwatch.Show();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTask at = new AddTask();
            at.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
