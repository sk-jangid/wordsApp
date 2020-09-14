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
    public partial class unique_word : Form
    {
        AVLTree tree = Form1.tree;
        int h1, v1;
        private System.Windows.Forms.Label[] words=null;
        int index;

        Word most_unique_word(AVLNode node)
        {
            if(node == null)
            {
                return null;
            }
            Word l = most_unique_word(node.leftNode);
            Word r = most_unique_word(node.rightNode);
            int lc = 0;
            int rc = 0;

            if (l != null)
            {
                lc = l.count;
            }
            if (r != null)
            {
                rc = r.count;
            }
            
            if (node.word.count > lc && node.word.count > rc)
            {
                return node.word;
            }else if (lc > rc)
            {
                return l;
            }
            else
            {
                return r;
            }
        }
        public unique_word()
        {
            InitializeComponent();
            words = new System.Windows.Forms.Label[0];
        }

        
        void search_with_count(AVLNode node,int count)
        {
            if (node == null)
            {
                return;
            }
            search_with_count(node.leftNode, count);
            if (node.word.count >= count)
            {
                Label l = new Label();
                l.Text =  node.word.word;
                l.Location = new Point(h1, v1);
                l.AutoSize = true;
                l.Font = new Font("Microsoft Sans Serif", 10);
                words[index] = l;
                index++;
                this.Controls.Add(l);
                v1 = v1 + 30;
            }
            search_with_count(node.rightNode, count);
        }
        

        
        int count_words(AVLNode node, int count)
        {
            if (node == null)
            {
                return 0;
            }
            int c = 0;
            if (node.word.count >= count)
            {
                c = 1;
            }
            return c + count_words(node.leftNode, count) + count_words(node.rightNode, count);
        }

        private void unique_word_Load(object sender, EventArgs e)
        {
            Word w = most_unique_word(tree.root);
            if (w!= null)
            {
                most_unique.Text = w.word;
                most_unique.Visible = true;
            }
            else
            {
                MessageBox.Show("No words in Tree");
            }
            //MessageBox.Show("No words in Tree");
        }

        private void get_words_Click(object sender, EventArgs e)
        {
            int minimum_count;
            bool isInt = int.TryParse(count.Text, out minimum_count);
            if (isInt)
            {
                if (minimum_count > 0)
                {
                    for(int i = 0; i < words.Length; i++)
                     {
                        this.Controls.Remove(words[i]);
                     }
                    
                    int c = count_words(tree.root, minimum_count);
                  
                    words = new System.Windows.Forms.Label[c];
                    words_label.Text = "There are "+c+" Words with more than or equal to " + minimum_count + " occurences.";
                    words_label.Visible = true;
                    index = 0;
                    h1 = 115;v1 = 200;
                    search_with_count(tree.root,minimum_count);
                }
            }
        }
    }
}
