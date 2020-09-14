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
    public partial class Search_word : Form
    {
        AVLTree tree = Form1.tree;
        int c = 0;
        private System.Windows.Forms.TextBox[] box;
        int h1, v1;
        int index;
        int get_count(AVLNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + get_count(node.leftNode) + get_count(node.rightNode);
            
        }
        public Search_word()
        {
            InitializeComponent();

            c = get_count(tree.root);
            box = new System.Windows.Forms.TextBox[c]; ;


        }
        int Compare(String s1, String s2)
        {
            int l1 = s1.Length; int l2 = s2.Length;
            int i = 0, j = 0;

            while (i < l1 && j < l2)
            {
                if (s1[i] != s2[j])
                {
                    return 0;
                }i++;j++;
            }

            if (l2 <= l1)
            {
                return 1;
            }
            return 0;
        }

        void Search(AVLNode node, String word)
        {
            if (node == null)
            {
                return;
            }
            Search(node.leftNode, word);
            if (Compare(node.word.word, word) == 1)
            {
                TextBox b1 = new TextBox();
                b1.Location = new Point(h1, v1);
                b1.Multiline = true; //= TextBoxMode.MultiLine;
                b1.AcceptsReturn = true;
                b1.Width = 400;
                b1.Text = "Word: " + node.word.word + "  || " + "Count: " + node.word.count.ToString() + " || " + "Positions: ";
                
                for (LinkedListNode<Location> it = node.word.locations.First; it != null; it = it.Next)
                {
                    b1.Text = b1.Text + "(" + it.Value.line_number + "," + it.Value.position + ") ";
                }
                this.Controls.Add(b1);
                box[index] = b1;index++;
                v1 = v1 + 50;
            }

            Search(node.rightNode, word);


        }
        
        private void word_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < c; i++)
            {
                if (box[i] != null)
                {
                    this.Controls.Remove(box[i]);
                }
            }index = 0;
            h1 = 50;v1 = 100;
            Search(tree.root, word.Text);
            
        }
    }
}
