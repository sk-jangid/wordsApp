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
    public partial class Display_Collocation : Form
    {
        AVLTree tree = Form1.tree;
        public Display_Collocation()
        {
            InitializeComponent();
        }

        
        int strcmp(string s1, string s2)
        {
            int i = 0, j = 0;
            int l1 = s1.Length;
            int l2 = s2.Length;

            while (i < l1 && j < l2)
            {
                if (s1[i] < s2[j])
                    return -1;
                else if (s1[i] > s2[j])
                    return 1;
                i++; j++;
            }
            return (l1 - l2);
        }
        int get_collorative(Word w1, Word w2) {
            int c = 0;
            
        for(LinkedListNode<Location> it = w1.locations.First; it != null; it = it.Next)
            {
                
                for(LinkedListNode<Location> it2 = w2.locations.First; it2 != null; it2 = it2.Next)
                {
                    //MessageBox.Show(it.Value.line_number + " " + it.Value.position);
                    //MessageBox.Show(it2.Value.line_number + " " + it2.Value.position);
                    
                    if(it.Value.line_number == it2.Value.line_number)
                    {
                        if (it.Value.position == it2.Value.position + 1)
                        {
                            c++;
                        }else if(it2.Value.position == it.Value.position + 1)
                        {
                            c++;
                        }
                    }
                }
            }
           
            return c;
        }

        



        Word get_word(AVLNode node,String word)
        {
            if (node == null)
            {
                return null;
            }
            if (node.word.word == word)
            {
                return node.word;
            }

            
            if (strcmp(word, node.word.word)<0)
            {
                return get_word(node.leftNode, word);
            }
            else
            {
                return get_word(node.rightNode, word); ;
            }
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Word word1 = get_word(tree.root,first.Text);
            Word word2 = get_word(tree.root,second.Text);
            if (word1==null)
            {
                MessageBox.Show(first.Text + " is not present in the Tree");
                return;
            }

            if (word2==null)
            {
                MessageBox.Show(second.Text + " is not present in the Tree");
                return;
            }

            int c = get_collorative(word1, word2);
            get.Text = "Collocation between " + word1.word + " and " + word2.word + " is " + c;
            get.Visible = true;


        }
    }
}
