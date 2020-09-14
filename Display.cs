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

   
    public partial class Display : Form
    {
        List<Word> words;
        AVLTree tree = Form1.tree;
        static int Compare(Word x, Word y)
        {
            return x.count - y.count;

        }
        void generate_list(AVLNode node)
        {
            if (node == null)
            {
                return;
            }

            generate_list(node.leftNode);
            words.Add(node.word);
            generate_list(node.rightNode);
            return;

        }
        int h1, v1,h2,v2;
        void display_list()
        {

            for(int i = 0; i < words.Count; i++)
            {
                Label l1 = new Label();
                l1.Text = words[i].word;
                l1.Location = new Point(h1, v1);
                l1.AutoSize = true;
                this.Controls.Add(l1);
                v2 = v1;
                Label l2 = new Label();
                l2.Text = words[i].count.ToString();
                l1.Location = new Point(h1+50, v2);
                l2.AutoSize = true;
                this.Controls.Add(l2);
                v1 = v1 + 30;
            }

            return;
        }
        public Display()
        {
            InitializeComponent();
           words = new List<Word>();
            generate_list(tree.root);
            words.Sort(Compare);    
            h1 = 100;h2=150;v1 = 100;
            display_list();
        }
        
        
    }
}
