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
            taskTitleLabel.Text = taskTreeView.SelectedNode.Text;
            dataGridView1.Rows.Clear();

            try
            {

                TaskNode tasknode = ((TaskNode)taskTreeView.SelectedNode);
                dataGridView1.Rows.Add(tasknode.Text, tasknode.OriginalEstimated, tasknode.CurrentEstimated, tasknode.Elapsed);
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.SlateGray;
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Tomato;


                foreach (var node in taskTreeView.SelectedNode.Nodes)
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
                    //change the cursor to a wait cursor while the nodes populate
                    this.Cursor = Cursors.WaitCursor;

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(dlg.FileName);
                    //clear out the treeview and add the first (root) node
                    taskTreeView.Nodes.Clear();
                    taskTreeView.Nodes.Add(new TaskNode(               xmlDocument.DocumentElement.Attributes[0].Value + "",
                                                     TimeSpan.Parse(xmlDocument.DocumentElement.Attributes[1].Value + ""),
                                                     TimeSpan.Parse(xmlDocument.DocumentElement.Attributes[2].Value + ""),
                                                     TimeSpan.Parse(xmlDocument.DocumentElement.Attributes[3].Value + "")
                                                     ));
                    
                    //recursively add all descendants
                    addTaskNode(xmlDocument.DocumentElement, (TaskNode)taskTreeView.Nodes[0]);

                    //Expand the treeview to show all nodes
                    taskTreeView.ExpandAll();
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
        private void addTaskNode(XmlNode passedXmlNode, TaskNode passedTreeNode)
        {
            int count = 0;

            foreach (XmlNode xmlNode in passedXmlNode.ChildNodes)
            {
                passedTreeNode.Nodes.Add(new TaskNode(xmlNode.Attributes[0].Value + "", TimeSpan.Parse(xmlNode.Attributes[1].Value + ""), TimeSpan.Parse(xmlNode.Attributes[2].Value + ""), TimeSpan.Parse(xmlNode.Attributes[3].Value + "")));
                addTaskNode(xmlNode, (TaskNode)passedTreeNode.Nodes[count]);
                count++;
            }
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
                string filename = saveFileDialog1.FileName;

                XmlTextWriter xmlwriter = new XmlTextWriter(filename, System.Text.Encoding.UTF8);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                xmlwriter.WriteStartDocument();

                //Write our root node
                TaskNode firstNode = (TaskNode)taskTreeView.Nodes[0];
                xmlwriter.WriteStartElement("Task");

                //Write attributes for Root Node
                xmlwriter.WriteAttributeString("Task_Name", firstNode.Text + "");
                xmlwriter.WriteAttributeString("Original_Estimated_Time", firstNode.OriginalEstimated + "");
                xmlwriter.WriteAttributeString("Current_Estimated_Time", firstNode.CurrentEstimated + "");
                xmlwriter.WriteAttributeString("Elapsed_Time", firstNode.Elapsed + "");


                foreach (TreeNode node in taskTreeView.Nodes)
                {
                    saveNode(xmlwriter, node.Nodes);
                }


                //Close the root node
                xmlwriter.WriteEndElement();
                xmlwriter.Close();
            }

        }

        private void saveNode(XmlTextWriter xmlWriter, TreeNodeCollection tnc)
        {
            if (tnc.Count > 0)
            {
                foreach (TreeNode treenode in tnc)
                {
                    TaskNode node = (TaskNode)treenode;
                    xmlWriter.WriteStartElement("Task");

                    //Write attributes for Node
                    xmlWriter.WriteAttributeString("Task_Name", node.Text + "");
                    xmlWriter.WriteAttributeString("Original_Estimated_Time", node.OriginalEstimated + "");
                    xmlWriter.WriteAttributeString("Current_Estimated_Time", node.CurrentEstimated + "");
                    xmlWriter.WriteAttributeString("Elapsed_Time", node.Elapsed + "");
                    saveNode(xmlWriter, node.Nodes);
                    xmlWriter.WriteEndElement();
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
            taskTreeView.Nodes.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (taskTreeView.Nodes.Count != 0)
            {
                taskTreeView.SelectedNode.Remove();
            }
        }
    }
}
