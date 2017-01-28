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
 *  Date:        01/27/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #2--WinForms                                             *
 *  Description: A GUI based program that utilizes the Random class to       *
 *               generate 10,000 random integers (range [0, 20000]) and      *
 *               stores them into a list. The list is then converted to a    *
 *               hashset to determine the number of distinct values in the   *
 *               set. The program also discusses the variuos time            *
 *               complexities of each storing/sorting functions              *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace WinForms
{
    public partial class Form1 : Form
    {
        // Variables and Constants
        private static readonly Random random = new Random();
        private static readonly int MAX_SIZE = 10000;
        private static List<int> randomList = new List<int>();
        private static List<int> sortedList = new List<int>();
        private static HashSet<int> distinctList = new HashSet<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomList = createList();  // Create the random list
            distinctList = createHashSet(randomList);   // Create the Hash Set
            sortedList = sortList(randomList);  // Sort the Hash Set

            displayTextBox.AppendText("1. HashSet method: " +
                uniqueNumCount(distinctList).ToString() +
                " unique numbers\n");
            displayTextBox.AppendText("   The time complexity of this " +
                "function is O(n), because when creating the HashSet," +
                "it iterates n times, and the retrieval time for the " +
                "count is O(1).\n");
            displayTextBox.AppendText("2. O(1) storage method: " +
                distinctNumCount(randomList).ToString() +
                " unique numbers\n");
            displayTextBox.AppendText("3. Sorted method: " +
                uniqueNumCount(sortedList).ToString() +
                " unique numbers\n");
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    randNumGen()                                        * 
         *  Input:       None                                                *
         *  Output:      Integer                                             *
         *  Description: A function that utilizes the Random class to return *
         *               return a random number between [0, 20000].          *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int randNumGen()
        {
            return random.Next(0, 20001);   // Random integer generation
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    createList()                                        * 
         *  Input:       None                                                *
         *  Output:      List                                                *
         *  Description: A function that creates a List full of random       *
         *               integers given from randNumGen(). The size of the   *
         *               list is deteremined my the MAX_SIZE constant        *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public List<int> createList()
        {
            for (int i = 0; i < MAX_SIZE; i++)
            {
                randomList.Add(randNumGen());   // Add value to the list
            }
            return randomList;
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    dispListCont()                                      * 
         *  Input:       List                                                *
         *  Output:      Void                                                *
         *  Description: A function that iterates through each value in the  *
         *               given list, and appends it to the textbox. This     *
         *               function is purely for testing purposes to ensure   *
         *               the list was created properly.                      *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void dispListCont(List<int> list)
        {
            for (int i = 0; i < list.Capacity; i++)
            {
                // Print to the textbox
                displayTextBox.AppendText(list[i].ToString() + "\t");
            }
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    createHashSet()                                     * 
         *  Input:       List                                                *
         *  Output:      HashSet                                             *
         *  Description: A function that takes a list, and converts it to a  *
         *               hashset, and it gets rid of any duplicates.         *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public HashSet<int> createHashSet(List<int> list)
        {
            return distinctList = new HashSet<int>(list);
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    dispHashSetCont()                                   * 
         *  Input:       HashSet                                             *
         *  Output:      Void                                                *
         *  Description: A function that appends to the textbox all of the   *
         *               values in the hashset. This function is purely for  *
         *               testing purposes to ensure the hashset was created  *
         *               properly.                                           *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void dispHashSetCont(HashSet<int> set)
        {
            for (int i = 0; i < set.Count; i++)
            {
                // Print to the textbox
                displayTextBox.AppendText(set.ElementAt(i).ToString() + "\t");
            }
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    sortList()                                          * 
         *  Input:       List                                                *
         *  Output:      List                                                *
         *  Description: A function that takes a list and calls the built-in *
         *               sort function to sort the values in the list in     *
         *               ascending order and returns it.                     *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public List<int> sortList(List<int> list)
        {
            list.Sort();
            return list;
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    uniqueNumCount()                                    * 
         *  Input:       List                                                *
         *  Output:      Integer                                             *
         *  Description: A function that takes a list and returns the number *
         *               of distinct values as an integer.                   *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int uniqueNumCount(List<int> sortedList)
        {
            return sortedList.Distinct().Count();
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    uniqueNumCount()                                    * 
         *  Input:       HashSet                                             *
         *  Output:      Integer                                             *
         *  Description: A function that takes a hashset and returns the     *
         *               number of distinct values as an integer.            *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int uniqueNumCount(HashSet<int> set)
        {
            return set.Count;
        }   // End Function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    distinctNumCount()                                  * 
         *  Input:       List                                                *
         *  Output:      Integer                                             *
         *  Description: A function that takes a list and iterates through   *
         *               comparing the current value with the previous to    *
         *               determine if it is a new distinct value, whilst     *
         *               keeping track of the distinct number count.         *
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public int distinctNumCount(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                    count++;
                else if (list[i] != list[i - 1])    // Check if distinct num
                {
                    count++;
                }
            }
            return count;
        }   // End Function
    }
}
