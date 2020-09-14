using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsApp
{
    public class AVLTree
    {
        public AVLNode root;
        
        // A utility function to find a word
        bool searchUtility(AVLNode node, String text)
        {
            if (node == null)
            {
                return false;
            }
            if (node.word.word == text)
            {
                return true;
            }
            return searchUtility(node.leftNode, text) || searchUtility(node.rightNode, text);
        }
        // A utility function to get 
        // the height of the tree  

        int height(AVLNode node)
        {
            if (node == null)
                return 0;

            return node.height;
        }

        // A utility function to get 
        // maximum of two integers  
        int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // A utility function to right  
        // rotate subtree rooted with y  
        // See the diagram given above.  
        AVLNode rightRotate(AVLNode y)
        {
            AVLNode x = y.leftNode;
            AVLNode T2 = x.rightNode;

            // Perform rotation  
            x.rightNode = y;
            y.leftNode = T2;

            // Update heights  
            y.height = max(height(y.leftNode),
                        height(y.rightNode)) + 1;
            x.height = max(height(x.leftNode),
                        height(x.rightNode)) + 1;

            // Return new root  
            return x;
        }

        // A utility function to left 
        // rotate subtree rooted with x  
        // See the diagram given above.  
        AVLNode leftRotate(AVLNode x)
        {
            AVLNode y = x.rightNode;
            AVLNode T2 = y.leftNode;

            // Perform rotation  
            y.leftNode = x;
            x.rightNode = T2;

            // Update heights  
            x.height = max(height(x.leftNode),
                        height(x.rightNode)) + 1;
            y.height = max(height(y.leftNode),
                        height(y.rightNode)) + 1;

            // Return new root  
            return y;
        }

        // Get Balance factor of node N  
        int getBalance(AVLNode N)
        {
            if (N == null)
                return 0;

            return height(N.leftNode) - height(N.rightNode);
        }
        int strcmp(string s1, string s2) 
        {
            int i = 0, j = 0;
            int l1 = s1.Length;
            int l2 = s2.Length;

             while (i<l1&&j<l2) 
             {
                if (s1[i] < s2[j])
                    return -1;
                else if (s1[i] > s2[j])
                    return 1;
                i++;j++;
             } 
        return(l1-l2); 
        }
    AVLNode insertUtility(AVLNode node, String wordToAdd,Location location)
        {

            /* 1. Perform the normal BST insertion */
            if (node == null)
            {
                Word word = new Word(wordToAdd, location);
                return (new AVLNode(word));
            }
           // MessageBox.Show(wordToAdd + " " + node.word.word);
            if (strcmp(wordToAdd, node.word.word) < 0)
                node.leftNode = insertUtility(node.leftNode, wordToAdd, location);
            else if (strcmp(wordToAdd, node.word.word) > 0)
                node.rightNode = insertUtility(node.rightNode, wordToAdd, location);
            else
            {
                node.word.count++;
                node.word.locations.AddLast(location);
            }
          

            /* 2. Update height of this ancestor node */
            node.height = 1 + max(height(node.leftNode),
                                height(node.rightNode));

            /* 3. Get the balance factor of this ancestor  
                node to check whether this node became  
                unbalanced */
            int balance = getBalance(node);

            // If this node becomes unbalanced, then there  
            // are 4 cases Left Left Case  
            if (balance > 1 && strcmp(wordToAdd, node.leftNode.word.word)<0)
                return rightRotate(node);

            // Right Right Case  
            if (balance < -1 && strcmp(wordToAdd, node.rightNode.word.word)>0)
                return leftRotate(node);

            // Left Right Case  
            if (balance > 1 && strcmp(wordToAdd, node.leftNode.word.word)>0)
            {
                node.leftNode = leftRotate(node.leftNode);
                return rightRotate(node);
            }

            // Right Left Case  
            if (balance < -1 && strcmp(wordToAdd, node.rightNode.word.word)<0)
            {
                node.rightNode = rightRotate(node.rightNode);
                return leftRotate(node);
            }

            /* return the (unchanged) node pointer */
            return node;
        }

        

        AVLNode minValueNode(AVLNode node)
        {
            AVLNode current = node;

            /* loop down to find the leftmost leaf */
            while (current.leftNode != null)
                current = current.leftNode;

            return current;
        }

        AVLNode removeNode(AVLNode root, String wordToRemove)
        {
            // STEP 1: PERFORM STANDARD BST DELETE  
            if (root == null)
                return root;

            // If the key to be deleted is smaller than  
            // the root's key, then it lies in left subtree  
            if (strcmp(wordToRemove, root.word.word)<0)
                root.leftNode = removeNode(root.leftNode, wordToRemove);

            // If the key to be deleted is greater than the  
            // root's key, then it lies in right subtree  
            else if (strcmp(wordToRemove, root.word.word)>0)
                root.rightNode = removeNode(root.rightNode, wordToRemove);

            // if key is same as root's key, then this is the node  
            // to be deleted  
            else
            {

                // node with only one child or no child  
                if ((root.leftNode == null) || (root.rightNode == null))
                {
                    AVLNode temp = null;
                    if (temp == root.leftNode)
                        temp = root.rightNode;
                    else
                        temp = root.leftNode;

                    // No child case  
                    if (temp == null)
                    {
                        temp = root;
                        root = null;
                    }
                    else // One child case  
                        root = temp; // Copy the contents of  
                                     // the non-empty child  
                }
                else
                {

                    // node with two children: Get the inorder  
                    // successor (smallest in the right subtree)  
                    AVLNode temp = minValueNode(root.rightNode);

                    // Copy the inorder successor's data to this node  
                    root.word = temp.word;

                    // Delete the inorder successor  
                    root.rightNode = removeNode(root.rightNode, temp.word.word);
                }
            }

            // If the tree had only one node then return  
            if (root == null)
                return root;

            // STEP 2: UPDATE HEIGHT OF THE CURRENT NODE  
            root.height = max(height(root.leftNode),
                        height(root.rightNode)) + 1;

            // STEP 3: GET THE BALANCE FACTOR 
            // OF THIS NODE (to check whether  
            // this node became unbalanced)  
            int balance = getBalance(root);

            // If this node becomes unbalanced,  
            // then there are 4 cases  
            // Left Left Case  
            if (balance > 1 && getBalance(root.leftNode) >= 0)
                return rightRotate(root);

            // Left Right Case  
            if (balance > 1 && getBalance(root.leftNode) < 0)
            {
                root.leftNode = leftRotate(root.leftNode);
                return rightRotate(root);
            }

            // Right Right Case  
            if (balance < -1 && getBalance(root.rightNode) <= 0)
                return leftRotate(root);

            // Right Left Case  
            if (balance < -1 && getBalance(root.rightNode) > 0)
            {
                root.rightNode = rightRotate(root.rightNode);
                return leftRotate(root);
            }

            return root;
        }
        public void insert(String word, Location location)
        {
            this.root = insertUtility(this.root, word, location);
        }

       public void remove(String word)
        {
            removeNode(this.root, word);
        }

        public bool search(String word)
        {
            return searchUtility(this.root, word);
        }

    }
}
