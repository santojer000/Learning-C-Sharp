using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *  Programmer:  Jerome Santos                                               *
 *  SID:         011555815                                                   *
 *  Date:        02/24/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #6--Expression Trees Part 2                              *
 *  Description: An expression node class that provides the user with a node *
 *               that has a string as a value. This class also comes with    *
 *               the necessary getters and setters.                          *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace SpreadsheetLogicEngine
{
    public class ExpNode
    {
        private string value;       // Number value of the node
        public ExpNode leftChild;   // Left child of the node
        public ExpNode rightChild;  // Right child of the node

        // Constructor
        public ExpNode(string str)
        {
            value = str;
            leftChild = null;
            rightChild = null;
        }   // End constructor

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
         *  Input:       string                                              *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the node          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setValue(string number)
        {
            value = number;     // Sets the value of the node
        } // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getValue                                            *
         *  Input:       none                                                *
         *  Output:      string                                              *
         *  Description: A function that gets the value of the node          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public string getValue()
        {
            return value;       // Gets the current value of the node
        } // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setLeftChild                                        *
         *  Input:       ExpNode                                             *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the left child    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setLeftChild(ExpNode left)
        {
            leftChild = left;   // Sets the left child of the current node
        } // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getLeftChild                                        *
         *  Input:       none                                                *
         *  Output:      ExpNode                                             *
         *  Description: A function that gets the value of the left child    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public ExpNode getLeftChild()
        {
            return leftChild;   // Retrieve left child of current node
        } // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setRightChild                                       *
         *  Input:       ExpNode                                             *
         *  Output:      void                                                *
         *  Description: A function that sets the value of the right child   *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setRightChild(ExpNode right)
        {
            rightChild = right;   // Sets the left child of the current node
        } // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getRightChild                                       *
         *  Input:       none                                                *
         *  Output:      ExpNode                                             *
         *  Description: A function that gets the value of the right child   *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public ExpNode getRightChild()
        {
            return rightChild;   // Retrieve left child of current node
        } // End Function
    }   // End class
}
