using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsApp
{
    public partial class remove : Form
    {
        AVLTree tree = Form1.tree;
        public remove()
        {
            InitializeComponent();
        }
        

        private void remove_button_Click(object sender, EventArgs e)
        {

            if (tree.search(word.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you Sure to remove this word", "Alert", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tree.remove(word.Text);
                }
                else
                {
                    // Do something  
                }

            }
        }
    }
}
