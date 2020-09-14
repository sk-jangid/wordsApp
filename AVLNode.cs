using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsApp
{
    public class AVLNode
    {
        public Word word;
        public int height;
        public AVLNode leftNode, rightNode;
        public AVLNode(Word word)
        {
            this.word = word;
            height = 1;
            leftNode = null;
            rightNode = null;

        }
    }
}
