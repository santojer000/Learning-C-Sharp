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
 *  Description: A program that prompts the user to input numbers seperated  *
 *               by spaces, and builds a binary tree that does not allow     *
 *               duplicate numbers. The program will also output various     *
 *               statistics of the binary tree such as:                      *
 *                  - Contents of the tree, in order                         *
 *                  - Number of nodes in the tree                            *
 *                  - Number of levels in the tree                           *
 *                  - Minimum number of levels that the tree could have,     *
 *                    based on the number of nodes                           *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace BSTConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construct binary tree
            BinarySearchTree BST = new BinarySearchTree();

            string input;      // String for the users input
            string[] numbers;  // String array to contain the numbers

            // Prompt the user to enter a collection of numbers
            Console.WriteLine("Enter a collection of numbers in the range " +
                "[0, 100], seperated by spaces:");

            // Read the input from the user, and store it in variable
            input = Console.ReadLine();

            // Call the strToArray function to parse the string input
            numbers = strToArray(input);

            // Call the buildBinaryTree function to build your tree
            buildBinaryTree(numbers, BST);

            Console.Write("Tree contents: ");
            /* Call the inorderTrav function to display the contents of the
               binary tree from smallest to largest */
            inorderTrav(BST.getRoot());

            // Display to the user the current tree statistics
            Console.WriteLine("\nTree statistics:");
            // Number of nodes in the tree
            Console.WriteLine("  Number of nodes: " + BST.numOfNodes);
            // Call the calcTreeLevel to the actual height of the tree
            BST.calcTreeLevel(BST, BST.getRoot(), BST.levels);
            // Number of levels in the tree
            Console.WriteLine("  Number of levels: " + BST.levels);
            // Theoretical minimum level if the tree was complete
            Console.WriteLine("  Minimum number of levels that a tree with " +
                BST.numOfNodes + " nodes could have = " +
                BST.calcMinLevel(BST.numOfNodes));
            // Complete
            Console.WriteLine("Done");
        }   // End main

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    strToArray                                          *
         *  Input:       string                                              *
         *  Output:      string[]                                            *
         *  Description: A function that takes in a string and converts it   *
         *               to string array utilizing the split function with   *
         *               a space delimiter.                                  *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public static string[] strToArray(string input)
        {
            string[] strArray;    // String array to hold the numbers
            // Call the split function to create an array with space delimiter
            strArray = input.Split(' ');

            return strArray;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    buildBinaryTree                                     *
         *  Input:       string[], BinarySearchTree                          *
         *  Output:      BinarySearchTree                                    *
         *  Description: A function that takes in a string array and BST,    *
         *               and iterates through the array. Each iteration will *
         *               add the node to the tree if it is within the        *
         *               accetance range of [0, 100].                        *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public static BinarySearchTree buildBinaryTree(string[] numbers,
            BinarySearchTree tree)
        {
            // Iterate through the string array to build your binary tree
            foreach (string number in numbers)
            {
                // Ensure that only numbers within the range [0, 100] accepted
                if (Int32.Parse(number) >= 0 && Int32.Parse(number) <= 100)
                {
                    /* Type cast the inputs into integers as they are
                       being added to the binary tree */
                    tree.insert(Int32.Parse(number));
                }
            }
            return tree;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    inorderTrav                                         *
         *  Input:       BinaryNode                                          *
         *  Output:      void                                                *
         *  Description: A recursive function that traverses a binary tree   *
         *               inorder, and displays the results to the user.      *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public static void inorderTrav(BinaryNode root)
        {
            // Check to see if the tree is empty
            if (root == null)
                return;

            inorderTrav(root.getLeftChild());       // Traverse left
            Console.Write(root.getValue() + " ");   // Print node value
            inorderTrav(root.getRightChild());      // Traverse right
        }   // End function
    }   // End program
}
