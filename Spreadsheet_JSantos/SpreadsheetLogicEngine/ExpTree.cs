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
 *  Description: A class that creates an expression tree from a infix string.*
 *               This class provides the user with functions that allow for  *
 *               variables utilizing dictionaries, aw well as an evaluation  *
 *               function to return the evaluation of the infix expression.  *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace SpreadsheetLogicEngine
{
    public class ExpTree
    {
        private ExpNode root;           // Root of the expression tree
        private string[] strArray;      // String array to hold values
        private string[] postFixArr;    // String array to hold the postfix values
        private StringBuilder postFixStr = new StringBuilder();
        private Stack<string> operatorStack = new Stack<string>();
        private Stack<ExpNode> ExpTreeStack = new Stack<ExpNode>();
        public Dictionary<string, double> variables =
            new Dictionary<string, double>();   // Dictionary for the variables

        // Constructor
        public ExpTree(string expression)
        {
            root = null;
            constructTree(expression);
        }   // End constructor

        public ExpTree()
        {
            root = null;
        }   // End constructor

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    constructTree                                       *
         *  Input:       string                                              *
         *  Output:      void                                                *
         *  Description: A function that helps construct the expresssion     *
         *               tree.                                               *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void constructTree(string expression)
        {
            strArray = expression.Split(' ');   // Take 
            buildExpTree(infixToPostfix(strArray));
        }   // End function

        public ExpNode getRoot()
        {
            return root;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    inFixToPostfix                                      *
         *  Input:       string[]                                            *
         *  Output:      string[]                                            *
         *  Description: A function converts the expression from infix order *
         *               to postfix order, in order to aid tree building.    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public string[] infixToPostfix(string[] infix)
        {
            for (int i = 0; i < infix.Length; i++)
            {
                if (infix[i] == "(")
                {
                    operatorStack.Push(infix[i]);
                }
                else if (infix[i] == ")")
                {
                    string op = operatorStack.Pop();
                    while (op != "(")
                    {
                        postFixStr.Append(op + " ");
                        op = operatorStack.Pop();
                    }
                }
                else if (infix[i] == "+" || infix[i] == "-" ||
                         infix[i] == "*" || infix[i] == "/")
                {
                    operatorStack.Push(infix[i]);
                }
                else
                {
                    postFixStr.Append(infix[i] + " ");
                }
            }

            while (operatorStack.Count > 0)
            {
                postFixStr.Append(operatorStack.Pop() + " ");
            }
            return postFixArr = postFixStr.ToString().Trim().Split(' ');
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    buildExpTree                                        *
         *  Input:       string[]                                            *
         *  Output:      void                                                *
         *  Description: A function makes the necessary connections between  *
         *               the nodes, and sets the root of the tree.           *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void buildExpTree(string[] postFix)
        {
            for (int i = 0; i < postFix.Length; i++)
            {
                if (postFix[i] == "+" || postFix[i] == "-" ||
                    postFix[i] == "*" || postFix[i] == "/")
                {
                    ExpNode temp1 = ExpTreeStack.Pop();
                    ExpNode temp2 = ExpTreeStack.Pop();
                    ExpNode newOperatorNode = new ExpNode(postFix[i]);
                    newOperatorNode.setLeftChild(temp2);
                    newOperatorNode.setRightChild(temp1);
                    ExpTreeStack.Push(newOperatorNode);
                }
                else
                {
                    ExpTreeStack.Push(new ExpNode(postFix[i]));
                }
            }
            root = ExpTreeStack.Pop();
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    setVar                                              *
         *  Input:       string, double                                      *
         *  Output:      void                                                *
         *  Description: A function that sets variables to certain values,   *
         *               and saves them to a dictionary.                     *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void setVar(string varName, double varValue)
        {
            if (variables.ContainsKey(varName))
            {
                variables.Remove(varName);      // Removes if key exists
            }
            variables.Add(varName, varValue);   // Sets key to the value.
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    eval                                                *
         *  Input:       string                                              *
         *  Output:      double                                              *
         *  Description: A function evaluates the operations in the tree,    *
         *               by calling the recursive eval funcion.              *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public double eval()
        {
            double result = 0;
            if (root.getValue() == "")
            {
                Console.WriteLine("No expression tree exists!");
                return 0;
            }
            else
            {
                return result = recursEval(root); // Calls recursive function
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    recursEval                                          *
         *  Input:       ExpNode                                             *
         *  Output:      double                                              *
         *  Description: A function that recursively traverse the expresssion*
         *               tree making the appropriate operations, and returns *
         *               the result.                                         *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public double recursEval(ExpNode currNode)
        {
            if (currNode == null)
            {
                return 0;
            }
            else if (variables.ContainsKey(currNode.getValue()))
            {
                return variables[currNode.getValue()];
            }
            else
            {
                switch (currNode.getValue())
                {
                    case "+":
                        {
                            return recursEval(currNode.getLeftChild()) +
                                recursEval(currNode.getRightChild());
                        }
                        break;
                    case "-":
                        {
                            return recursEval(currNode.getLeftChild()) -
                                recursEval(currNode.getRightChild());
                        }
                        break;
                    case "*":
                        {
                            return recursEval(currNode.getLeftChild()) *
                                recursEval(currNode.getRightChild());
                        }
                        break;
                    case "/":
                        {
                            return recursEval(currNode.getLeftChild()) /
                                recursEval(currNode.getRightChild());
                        }
                        break;
                }
                return Double.Parse(currNode.getValue());
            }
        }   // End function
    }   // End class
}

