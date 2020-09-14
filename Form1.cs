using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsApp
{
    public partial class Form1 : Form
    {
        public static AVLTree tree = new AVLTree();
        OpenFileDialog file;
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            file = null;
            file = new OpenFileDialog(); 
            file.Title = "C# Corner Open File Dialog";
            file.InitialDirectory = @"c:\";
            file.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
               label1.Text = file.FileName;
            }
            else
            {
                file = null;
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            tree = null;
            if (file == null)
            {
                MessageBox.Show("Please select a valid file");
                return;
            }
            // Word word = new Word("skj");
            tree = new AVLTree();
            Location location;
            int lineNumber = 0;
            int position = 1;
            using (var mappedFile1 = MemoryMappedFile.CreateFromFile(file.FileName))
            {
                using (Stream mmStream = mappedFile1.CreateViewStream())
                {
                    using (StreamReader sr = new StreamReader(mmStream, ASCIIEncoding.ASCII))
                    {
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            lineNumber++;
                            var lineWords = line.Split(new Char[] {' ','\n','\t','\0'});
                            position = 1;
                            for (int i = 0; i < lineWords.Length; i++)
                            {
                                lineWords[i].Trim();

                                if(lineWords[i]!=""&&lineWords[i]!=" " && lineWords[i] != "\0"&& lineWords[i] != "\n" && lineWords[i]!="\t")
                                {
                                    location = new Location(lineNumber, position);
                                   // MessageBox.Show(lineWords[i] + " " + lineNumber + " " + position);
                                   // MessageBox.Show(lineWords[i]);
                                    tree.insert(lineWords[i], location);
                                    position++;
                                }

                            }
                        }
                    }
                }
            }

            TreeOperations form2 = new TreeOperations();
            form2.Show();

        }
    }
}
