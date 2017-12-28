using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_08_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            listView1.Clear();
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Nodes != null)
                    foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                        listView1.Items.Add(node.Text, node.SelectedImageIndex);
            }
        }
    }
}
