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
 *  Description: A class that templates a binary node. This class provides   *
 *               basic statistics, such as the value of the node, and its    *
 *               current left and right children.                            *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace BSTConsole
{
    class BinaryNode
    {
        private int value;               // Number value of the node
        public BinaryNode leftChild;     // Left child of the binary node
        public BinaryNode rightChild;    // Right child of the binary node

        // Constructor
        public BinaryNode()
        {
            leftChild = null;
            rightChild = null;
        }

        // Constructor
        public BinaryNode(int number)
        {
            value = number;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    isLeaf                                              *
         *  Input:       none                                                *
         *  Output:      Boolean                                             *
         *  Description: A function that determines if the current node is   *
         *               a leaf node, by checking if the left and right      *
         *               children are both null.                             *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public bool isLeaf()
        {
            // Checks if left and right child are empty
            if (leftChild == null && rightChild == null)
                return true;
            else
                return false;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setValue                                            *
         *  Input:       Integer                                             *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the node          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setValue(int number)
        {
            value = number;     // Sets the value of the node
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getValue                                            *
         *  Input:       none                                                *
         *  Output:      Integer                                             *
         *  Description: A function that gets the value of the node          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int getValue()
        {
            return value;       // Gets the current value of the node
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setLeftChild                                        *
         *  Input:       BinaryNode                                          *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the left child    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setLeftChild(BinaryNode left)
        {
            leftChild = left;   // Sets the left child of the current node
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getLeftChild                                        *
         *  Input:       none                                                *
         *  Output:      BinaryNode                                          *
         *  Description: A function that gets the value of the left child    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public BinaryNode getLeftChild()
        {
            return leftChild;   // Retrieve left child of current node
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setRightChild                                       *
         *  Input:       BinaryNode                                          *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the right child   *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setRightChild(BinaryNode right)
        {
            rightChild = right; // Sets the right child of the current node
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getRightChild                                       *
         *  Input:       none                                                *
         *  Output:      BinaryNode                                          *
         *  Description: A function that gets the value of the right child   *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public BinaryNode getRightChild()
        {
            return rightChild;  // Retrieve right child of current node
        }   // End Function
    }   // End class
}
