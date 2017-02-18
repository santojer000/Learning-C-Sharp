using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSortApp
{
    public partial class BubbleSortAppGUI : Form
    {
        Random randNum = new Random();  // Pseudo random
        int[] array;                    // Initial array
        int[] sortedArr;                // Array after being sorted
        int arrLen = 0;                 // Length of the initial array

        public BubbleSortAppGUI()
        {
            InitializeComponent();
        }   // Constructor

        private void BubbleSortAppGUI_Load(object sender, EventArgs e)
        {
            clearText();
            sortButton.Enabled = false;
            inputTextBox.Focus();
        }   // End event

        private void genRandArrButton_Click(object sender, EventArgs e)
        {
            clearText();
            arrLen = Int32.Parse(inputTextBox.Text);
            array = randArray(arrLen);
            DisplayTextBox.AppendText("Unsorted Array:\n");
            displayArray(array);
            sortButton.Enabled = true;
        }   // End event

        private void sortButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.AppendText("Sorted Array:\n");
            sortedArr = bubbleSort(array);
            displayArray(sortedArr);
            sortButton.Enabled = false;
            inputTextBox.Focus();
            inputTextBox.SelectAll();
        }   // End event

        private int randNumGen()
        {
            int number = randNum.Next(100);
            return number;
        }   // End funcion

        private int[] randArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = randNumGen();
            }
            return arr;
        }   // End function

        private void displayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                DisplayTextBox.AppendText(array[i] + "    ");
                if ((i + 1) % 10 == 0)
                {
                    // Only allows 10 numbers per line
                    DisplayTextBox.AppendText("\n");
                }
            }
        }   // End function

        private int[] bubbleSort(int[] array)
        {
            sortedArr = array;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return sortedArr;
        }   // End function

        private void clearText()
        {
            DisplayTextBox.Clear();     // Clears everything in the text box
        }   // End function
    }
}
