using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *  Programmer:  Jerome Santos                                               *
 *  SID:         011555815                                                   *
 *  Date:        03/22/2017                                                  *
 *  Course:      CPT_S 350--Algorithm Analysis                               *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #5                                                       *
 *  Description: A Program that calculates the longest common subsequence    *
 *               between two strings, either manually typed in, or randomly  *
 *               generated. The program display various statistics such as,  *
 *               LCS, length of LCS, and number of iterations (work).        *
 *                                                                           *
 *  Problem 7:   We could improve on the runtime of these algorithms, if we  *
 *               take into consideration the size of both strings before     *
 *               having to unnecessarily iterate through the rest of the     *
 *               string.  For example, there is no need to iterate/compare   *
 *               strings if we have already surpassed the size of the smaller*
 *               of bother strings.                                          * 
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace CPTS350__HW5
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); // Random generator
        int[,] matrix;              // 2D array for dynamic programming
        string DNA1 = "";           // DNA1 string
        string DNA2 = "";           // DNA2 string
        string longestSubSeqD = ""; // Longest common subsequence dynamic
        string longestSubSeqBF = "";// Longest common subsequence brute force
        string alphabet = "ACGT";   // Possible DNA letter
        int limit = 0;              // DNA length limit
        int iterCounter = 0;        // Iteration counter

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = findLCSButton;
        }   // End constructor

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       generateButton_Click                                *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that will generate new random strings      *
         *               within the given alphabet, and display them to the  *
         *               two string textboxes.                               *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void generateButton_Click(object sender, EventArgs e)
        {
            StringBuilder newDNA1 = new StringBuilder();
            StringBuilder newDNA2 = new StringBuilder();

            try
            {
                // Grab value from the textbox and try to convert it to an int
                limit = Int32.Parse(limitTextBox.Text);

                string1TextBox.Clear(); // Flush out 
                string2TextBox.Clear(); // Flush out

                // Build StringBuilder of letters
                for (int i = 0; i < limit; i++)
                {
                    newDNA1.Append(randomLetterGenerator()); // Append letter
                    newDNA2.Append(randomLetterGenerator()); // Append letter
                }

                // Convert to strings
                DNA1 = newDNA1.ToString();
                DNA2 = newDNA2.ToString();

                if (string.IsNullOrWhiteSpace(string1TextBox.Text))
                {
                    string1TextBox.AppendText(DNA1);
                }

                if (string.IsNullOrWhiteSpace(string2TextBox.Text))
                {
                    string2TextBox.AppendText(DNA2);
                }
            }
            catch (Exception)
            {
                // Allows integers only
                MessageBox.Show("Please enter a number!", "ERROR");
                limitTextBox.Focus();
                limitTextBox.SelectAll();
            }
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       clearButton_Click                                   *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that will clear the form of all info.      *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();    // Call clearForm function
        }   // end event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       findLCSButton_Click                                 *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that will calculate the longest common     *
         *               subsequence (brute force & dynamic) for the given   *
         *               DNA strings, and displays the statistics to the     *
         *               output textbox.                                     *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void findLCSButton_Click(object sender, EventArgs e)
        {
            try
            {
                DNA1 = string1TextBox.Text.ToUpper();
                DNA2 = string2TextBox.Text.ToUpper();

                // Check if text fields are empty
                if (DNA1 == "" || DNA2 == "")
                {
                    throw new Exception();
                }

                displayTextBox.AppendText("------------------------------\n");
                displayTextBox.AppendText("\nDNA 1 -- " + DNA1 + "\n");
                displayTextBox.AppendText("\nDNA 2 -- " + DNA2 + "\n");
                displayTextBox.AppendText("\n");
                iterCounter = 0;
                longestSubSeqBF = bruteForceLCS(DNA1, DNA2);
                // Displays the brute force statistics
                if (longestSubSeqBF.Length == 0)
                {
                    displayTextBox.AppendText("\nLCS Brute Force -- None\n");
                }
                else
                {
                    displayTextBox.AppendText("\nLCS Brute Force -- " +
                        longestSubSeqBF + "\n");
                }
                displayTextBox.AppendText("\nLCS Brute Force Length -- " +
                    longestSubSeqBF.Length + "\n");
                displayTextBox.AppendText("\nBrute Force Iterations -- " +
                    iterCounter + "\n");
                displayTextBox.AppendText("\n");

                iterCounter = 0;
                longestSubSeqD = dynamicLCS(DNA1, DNA2);
                // Displays the dynamic statistics
                if (longestSubSeqBF.Length == 0)
                {
                    displayTextBox.AppendText("\nLCS Dynamic -- None\n");
                }
                else
                {
                    displayTextBox.AppendText("\nLCS Dynamic -- " +
                        longestSubSeqBF + "\n");
                }
                displayTextBox.AppendText("\nLCS Dynamic Length -- " +
                    longestSubSeqBF.Length + "\n");
                displayTextBox.AppendText("\nDynamic Iterations -- " +
                    iterCounter + "\n");
            }
            catch (Exception)
            {
                // Catch if user is missing inputs
                if (string.IsNullOrWhiteSpace(string1TextBox.Text))
                {
                    MessageBox.Show("Please fill in DNA strand 1!", "ERROR");
                    string1TextBox.Focus();
                    string1TextBox.SelectAll();
                }
                else if (string.IsNullOrWhiteSpace(string2TextBox.Text))
                {
                    MessageBox.Show("Please fill in DNA strand 2!", "ERROR");
                    string2TextBox.Focus();
                    string2TextBox.SelectAll();
                }
                else
                {
                    MessageBox.Show("Please fill in both DNA 1 & 2!", "ERROR");
                    string2TextBox.Focus();
                    string2TextBox.SelectAll();
                }
            }
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    randomLetterGenerator                               *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function that generates a random letter based on  *
         *               the random index generated from the random class.   *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private string randomLetterGenerator()
        {
            int index = rand.Next(4);  // Generate random number from 0 - 3
            string letter = alphabet[index].ToString(); // Get letter at index
            return letter;
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    clearForm                                           *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function that clears the form of all info.        *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void clearForm()
        {
            displayTextBox.Clear(); // Clear the display
            string1TextBox.Clear(); // Clear string 1
            string2TextBox.Clear(); // Clear string 2
            limitTextBox.Focus();   // Gain focus
            limitTextBox.SelectAll();   // Highlight all text for edit
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    bruteForceLCS                                       *
         *  Input:       string, string                                      *
         *  Output:      string                                              *
         *  Description: A function that will calculate the LCS using the    *
         *               brute force method.                                 *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private string bruteForceLCS(string str1, string str2)
        {
            string dna1 = str1.ToString();
            string dna2 = str2.ToString();
            string subDNA1 = dna1.Substring(0, (dna1.Length - 1 < 0) ?
                0 : dna1.Length - 1);
            string subDNA2 = dna2.Substring(0, (dna2.Length - 1 < 0) ?
                0 : dna2.Length - 1);

            iterCounter++;
            if (dna1.Length == 0 || dna2.Length == 0)
            {
                return "";  // return empty string
            }
            else if (dna1[dna1.Length - 1] == dna2[dna2.Length - 1])
            {
                return bruteForceLCS(subDNA1, subDNA2) +
                    dna1[dna1.Length - 1];
            }
            else
            {
                string lcs1 = bruteForceLCS(dna1, subDNA2);
                string lcs2 = bruteForceLCS(subDNA1, dna2);
                if (lcs1.Length > lcs2.Length)
                {
                    return lcs1;
                }
                else
                {
                    return lcs2;
                }
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    dynamicLCS                                          *
         *  Input:       string, string                                      *
         *  Output:      string                                              *
         *  Description: A function that calculates the LCS for two strings  *
         *               using dynamic programming.                          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private string dynamicLCS(string str1, string str2)
        {
            StringBuilder longestStr = new StringBuilder();
            char[] str1CharArr = str1.ToCharArray();
            char[] str2CharArr = str2.ToCharArray();

            matrix = new int[str1CharArr.Length + 1, str2CharArr.Length + 1];

            // Zero out the matrix
            for (int i = 0; i < str1CharArr.Length; i++)
            {
                for (int j = 0; j < str2CharArr.Length; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            // Fill in matrix
            for (int i = 1; i <= str1CharArr.Length; i++)
            {
                for (int j = 1; j <= str2CharArr.Length; j++)
                {
                    if (j > i)
                    {
                        matrix[i, j] = matrix[i, j - 1];
                    }
                    else if (str1CharArr[i - 1] == str2CharArr[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                        iterCounter++;
                    }
                    else
                    {
                        matrix[i, j] =
                            Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                        iterCounter++;
                    }
                }
            }

            int countdown = matrix[str1CharArr.Length, str2CharArr.Length];
            int x = str1CharArr.Length;
            int y = str2CharArr.Length;

            while (countdown != 0)
            {
                // Check if the two squares are the same value
                if (matrix[x - 1, y] == matrix[x, y - 1] &&
                    str1CharArr[x - 1] == str2CharArr[y - 1])
                {
                    longestStr.Append(str1CharArr[x - 1]);
                    x--;
                    y--;
                }
                else if (matrix[x - 1, y] > matrix[x, y - 1])
                {
                    // Shift left one square
                    y--;
                }
                else
                {
                    // Shift up one square
                    x--;
                }
                countdown = matrix[x, y];
            }
            longestSubSeqD = longestStr.ToString().Reverse().ToString();
            return longestSubSeqD;
        }   // End function
    }   // End program
}
