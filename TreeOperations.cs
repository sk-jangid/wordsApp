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
    public partial class TreeOperations : Form
    {

        AVLTree tree = Form1.tree;
        int count = 0;
        int horizontal = 80;
        int vertical = 200;
        void preOrder(AVLNode node)
        {
            if (node == null)
            {
                return;
            }
           
            preOrder(node.leftNode);
            //MessageBox.Show(node.word.word);
            Label wordName = new Label();
            wordName.Text = node.word.word;

            // Set the location of the Label
            wordName.Location = new Point(horizontal, vertical);
            wordName.AutoSize = true;
            wordName.Font = new Font("Microsoft Sans Serif", 10);
            this.Controls.Add(wordName);
            Label wordCount = new Label();
            wordCount.Text = node.word.count.ToString();
            wordCount.Location = new Point(horizontal+200, vertical);
            wordCount.AutoSize = true;
            wordCount.Font = new Font("Microsoft Sans Serif", 10);
            this.Controls.Add(wordCount);

            vertical = vertical + 30;
            count++;
            preOrder(node.rightNode);
        }



        public TreeOperations()
        {
            InitializeComponent();

        }
       

        private void TreeOperations_Load(object sender, EventArgs e)
        {
            preOrder(tree.root);
            wordCount.Text = count.ToString();
            edit_word.Location = new Point(edit_word.Location.X, vertical);
            remove_word.Location = new Point(remove_word.Location.X, vertical);
            search.Location = new Point(search.Location.X, vertical);
            display_collocation.Location = new Point(search.Location.X, vertical+50);
            most_unique_word.Location = new Point(most_unique_word.Location.X, vertical + 50);
            display.Location = new Point(display.Location.X, vertical + 100);
        }


        private void remove_word_Click(object sender, EventArgs e)
        {
            remove form = new remove();
            form.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search_word form = new Search_word();
            form.Show();
        }

        private void display_collocation_Click(object sender, EventArgs e)
        {
            Display_Collocation form = new Display_Collocation();
            form.Show();
        }

        private void most_unique_word_Click(object sender, EventArgs e)
        {
            unique_word form = new unique_word();
            form.Show();
        }

        private void edit_word_Click(object sender, EventArgs e)
        {
            edit_word form = new edit_word();
            form.Show();
        }

        private void display_Click(object sender, EventArgs e)
        {
            Display form = new Display();
            form.Show();
        }
    }
}
