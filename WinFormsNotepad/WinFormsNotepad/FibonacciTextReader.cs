using System;
using System.IO;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *  Programmer:  Jerome Santos                                               *
 *  Date:        02/03/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #3--WinForms Notepad                                     *
 *  Description: A class that inherits from the TextReader class. This class *
 *               provides the user with numbers in the Fibonacci sequence    *
 *               based off of a number n passed to the constructor. This     *
 *               class includes various functions such as:                   *
 *                  - calcNextFib() to calculate the next number in the      *
 *                    sequence                                               *
 *                  - overriden ReadLine() to return the next number         *
 *                  - overriden ReadToEnd() to return a string containing    *
 *                    all of the calculated Fibonacci numbers                *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace WinFormsNotepad
{
    class FibonacciTextReader : TextReader
    {
        // The max amount of Fibonacci numbers to be calculated
        int numOfLines = 0;
        // The current Fibonacci index
        int lineNum = 1;
        // First base number in the Fibonacci sequence
        BigInteger prevFib = new BigInteger(0);
        // Second base number in the Fibonacci sequence
        BigInteger currFib = new BigInteger(1);
        // Next number in the fibonacci sequence by adding the previous 2
        BigInteger nextFib = 0;
        // String to hold the Fibonacci sequence
        StringBuilder fibString = new StringBuilder();

        // Constructor
        public FibonacciTextReader(int maxLines) : base()
        {
            numOfLines = maxLines;
        }   // End constructor

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       calcNextFib()                                       *
         *  Input:       void                                                *
         *  Output:      BigInteger                                          *
         *  Description: A function that calculates and returns the next     *
         *               Fibonacci number based off the previous 2 numbers.  *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private BigInteger calcNextFib()
        {
            nextFib = prevFib + currFib;
            prevFib = currFib;
            currFib = nextFib;
            return nextFib;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       ReadLine()                                          *
         *  Input:       void                                                *
         *  Output:      string                                              *
         *  Description: An overriden function that returns a string of the  *
         *               next Fibonacci number in the sequence.              *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override string ReadLine()
        {
            string nextLine = "";
            if (lineNum == 1)
            {
                return nextLine = lineNum + ": 0";
            }
            else if (lineNum == 2)
            {
                return nextLine = lineNum + ": 1";
            }
            else
            {
                return nextLine = lineNum + ": " + calcNextFib();
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       ReadToEnd()                                         *
         *  Input:       void                                                *
         *  Output:      string                                              *
         *  Description: An overriden function that returns a string of the  *
         *               StringBuilder object used to append all of the      *
         *               calculated Fibonacci numbers.                       *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override string ReadToEnd()
        {
            for (int i = 0; i < numOfLines; i++)
            {
                fibString.AppendLine(ReadLine());
                lineNum++;
            }
            return fibString.ToString();
        }
    }   // End class
}
