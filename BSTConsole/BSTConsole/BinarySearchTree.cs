using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *  Programmer:  Jerome Santos                                               *
 *  SID:         011555815                                                   *
 *  Date:        01/20/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #1--BST Console                                          *
 *  Description: A class that templates a binary tree. This class provides   *
 *               basic tree statistics, such as the root node, the number of *
 *               nodes in the tree, the height of the tree, and the          *
 *               theoretical minimum height of the tree based on the number  *
 *               of nodes                                                    *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace BSTConsole
{
    class BinarySearchTree
    {
        private BinaryNode root;     // Root of the binary tree
        public int numOfNodes = 0;   // Number of nodes in the tree
        public int levels = 0;       // Levels in the tree
        public int minLevels = 0;    // Minimum number of levels possible

        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getRoot                                             *
         *  Input:       none                                                *
         *  Output:      BinaryNode                                          *
         *  Description: A function that gets the root node                  *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public BinaryNode getRoot()
        {
            return root;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    insert                                              *
         *  Input:       Integer                                             *
         *  Output:      void                                                *
         *  Description: A function that creates a new root node if one does *
         *               not exist, otherwise calls the insertNode function  *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void insert(int newValue)
        {
            // Check to see if root exists
            if (root == null)
            {
                root = new BinaryNode(newValue);    // Create new root node
                numOfNodes++;
            }
            else
                insertNode(root, newValue);     // Otherwise call function
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    insertNode                                          *
         *  Input:       BinaryNode, Integer                                 *
         *  Output:      BinaryNode                                          *
         *  Description: A function that compares the values of nodes with   *
         *               incoming values and determines if they are less     *
         *               than or greater than the current value and makes    *
         *               the appropriate connections.
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public BinaryNode insertNode(BinaryNode root, int newValue)
        {
            // Check to see if root exists
            if (root == null)
            {
                return root = new BinaryNode(newValue);     // Create new node
            }
            else if (root.getValue() < newValue)    // Moves to the right
            {
                // Checks if right child exists
                if (root.getRightChild() == null)
                {
                    // Set a new node to be the right child
                    root.setRightChild(new BinaryNode(newValue));
                    numOfNodes++;   // Keeps track of when new nodes are added
                }
                return insertNode(root.rightChild, newValue);
            }
            else if (root.getValue() > newValue)    // Moves to the left
            {
                // Checks if left child exists
                if (root.getLeftChild() == null)
                {
                    // Set a new node to be the left child
                    root.setLeftChild(new BinaryNode(newValue));
                    numOfNodes++;   // Keeps track of when new nodes are added
                }
                return insertNode(root.leftChild, newValue);
            }
                return root;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    calcMinLevel                                        *
         *  Input:       Integer                                             *
         *  Output:      Integer                                             *
         *  Description: A function that utilizes the complete binary tree   *
         *               height formula to calculate the minimum number of   *
         *               levels in the tree (if each level was full before   *
         *               going on to the next level)                         *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int calcMinLevel(int nodes)
        {
            int minLevel = 0;   // Base minimum level

            // Calculate the theoretical minimum tree level
            minLevel = (int) Math.Ceiling(Math.Log(nodes + 1, 2));

            return minLevel;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    calcTreeLevel                                       *
         *  Input:       BinarySearchTree, BinaryNode, Integer               *
         *  Output:      void                                                *
         *  Description: A recursive function that calculates the actual     *
         *               height of the current tree using a counter          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void calcTreeLevel(BinarySearchTree tree, BinaryNode root,
            int count)
        {
            // Check to see if root exists
            if (root == null)
                return;
            count++;    // Increase the count
            // Keep traversing left until you hit a leaf node
            calcTreeLevel(tree, root.getLeftChild(), count);
            // Check to see if the node is a leaf
            if (root.isLeaf() == true)
            {
                if (count > tree.levels)
                    tree.levels = count;
            }
            // Keep traversing right until finished
            calcTreeLevel(tree, root.getRightChild(), count);
        }   // End function
    }   // End class
}
