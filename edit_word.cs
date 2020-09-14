using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WordsApp
{
    public partial class edit_word : Form
    {
        AVLTree tree = Form1.tree;
        int countT;
        
        private System.Windows.Forms.TextBox[] line;
        private System.Windows.Forms.TextBox[] position;
        public edit_word()
        {
            InitializeComponent();

        }

    



        
        

        private void validate_Click(object sender, EventArgs e)
        {
            if (tree.search(word.Text))
            {
                
                bool isInt = int.TryParse(count.Text, out countT);
                if (isInt)
                {
                    if (countT > 0)
                    {
                        label_location.Visible = true;
                        label_line.Visible = true;
                        label_position.Visible = true;
                        word.Enabled = false;
                        count.Enabled = false;
                        line= new System.Windows.Forms.TextBox[countT];
                        position = new System.Windows.Forms.TextBox[countT];
                        int h1 = 205, v1 = 200, h2 = 345, v2 = 200;
                        for (int i = 0; i < countT; i++)

                        {
                            line[i] = new System.Windows.Forms.TextBox();
                            position[i] = new System.Windows.Forms.TextBox();
                            line[i].Location = new Point(h1,v1);
                            line[i].Width = 50;
                            position[i].Width = 50;
                            position[i].Location = new Point(h2, v2);
                            this.Controls.Add(position[i]);
                            this.Controls.Add(line[i]);
                            v1 = v1 + 25;
                            v2 = v2 + 25;
                        }
                        validate.Visible = false;
                        edit.Location = new Point(edit.Location.X, v1);
                        edit.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Count value is not greater than zero or not int!");
                    count.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Word can not be found in DS");
                word.Text = "";
            }
        }

        void update(AVLNode node,LinkedList<Location> locations)
        {
            if (node== null)
            {
                return;
            }

            if(node.word.word == word.Text)
            {
                node.word.count = locations.Count;
                node.word.locations = locations;
                return;
            }

            update(node.leftNode, locations);
            update(node.rightNode, locations);
            return;
        }

        private void edit_Click(object sender, EventArgs e)
        {

            int lineNumber;
            int positionNumber;
            LinkedList<Location> locations = new LinkedList<Location>();
            Location l;
            for (int i = 0; i < countT; i++)
            {
              
                bool isInt1 = int.TryParse(line[i].Text, out lineNumber);
                bool isInt2 = int.TryParse(position[i].Text, out positionNumber);

                if (isInt1 && isInt2)
                {
                    if (lineNumber > 0 && positionNumber>0)
                    {
                        l = new Location(lineNumber, positionNumber);
                        locations.AddLast(l);
                    }
                    else
                    {
                        MessageBox.Show("Input "+i+1+" has some error review it");
                        line[i].Text = "";
                        position[i].Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Input " + i+1+ " has some error review it");
                    line[i].Text = "";
                    position[i].Text = "";
                    return;
                }
            }
            update(tree.root, locations);
        }
        
    }
}
