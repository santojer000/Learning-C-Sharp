using System;
using System.IO;
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
 *  Date:        02/03/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #3--WinForms Notepad                                     *
 *  Description: A GUI based program that resembles a simple notepad         *
 *               application. This program provides several features         *
 *               including:                                                  *
 *                  - Saving text in the textbox display as a .txt file      *
 *                  - Loading text to the textbox display from a .txt file   *
 *                  - Loading first 50 numbers in the Fibonacci sequence     *
 *                  - Loading first 100 numbers in the Fibonacci sequence    *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace WinFormsNotepad
{
    public partial class WinFormNotepadGUI : Form
    {
        // Constructor
        public WinFormNotepadGUI()
        {
            InitializeComponent();
        }   // End constructor

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       WinFormNotepadGUI_Load()                            *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers upon program startup. It     *
         *               calls the clearText function to clear the textbox.  *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void WinFormNotepadGUI_Load(object sender, EventArgs e)
        {
            clearText();    // Clear the text box on initial startup
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       clearToolStripMenuItem_Click()                      *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the clear     *
         *               menu option. It calls the clearText function to     *
         *               clear any existing text in the textbox to empty.    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearText();    // Clear the text box
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       loadFromFileToolStripMenuItem_Click()               *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the load from *
         *               file menu option. It calls the loadFromFile         *
         *               function to load a .txt file if it exists.          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void loadFromFileToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            loadFromFile(); // Call the loadFromFile function
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       loadFibonacciNumbersfirst50ToolStripMenuItem_Click  *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the load 50   *
         *               Fibonacci numbers menu option. It creates a new     *
         *               instance of the FibonacciTextReader class, and      *
         *               displays the first 50 numbers in the Fibonacci      *
         *               sequence.                                           *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void loadFibonacciNumbers50ToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            clearText();
            FibonacciTextReader fib50Sequence = new FibonacciTextReader(50);
            displayTextBox.AppendText(fib50Sequence.ReadToEnd());
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       loadFibonacciNumbersfirst100ToolStripMenuItem_Click *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the load 100  *
         *               Fibonacci numbers menu option. It creates a new     *
         *               instance of the FibonacciTextReader class, and      *
         *               displays the first 100 numbers in the Fibonacci     *
         *               sequence.                                           *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void loadFibonacciNumbersfirst100ToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            clearText();
            FibonacciTextReader fib100Sequence = new FibonacciTextReader(100);
            displayTextBox.AppendText(fib100Sequence.ReadToEnd());
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       saveToFileToolStripMenuItem_Click()                 *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the save to   *
         *               file menu option, and calls the saveTextToFile      *
         *               function to save the text file.                     *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void saveToFileToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            saveTextToFile();   // Call saveTextToFile function
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       exitToolStripMenuItem_Click()                       *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the exit menu *
         *               option, and calls the closeForm function to close   *
         *               the form.                                           *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm();    // Call closeForm function
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    loadFromFile()                                      *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function that allows the user to open a .txt      *
         *               file, and utilizes the loadText function to display *
         *               the text from the file.                             *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void loadFromFile()
        {
            // Create new dialog
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                clearText();
                StreamReader reader = new StreamReader(openFile.FileName);
                loadText(reader);   // Call the loadText function
                reader.Close();
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    loadText()                                          *
         *  Input:       StreamReader                                        *
         *  Output:      void                                                *
         *  Description: A function that takes a StreamReader, reads the     *
         *               text file, and appends the results to the textbox   *
         *               until the end of the file.                          *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void loadText(StreamReader reader)
        {
            clearText();    // Clear any leftover text
            while (!reader.EndOfStream)
            {
                // Display the text file line by line
                displayTextBox.AppendText(reader.ReadToEnd());
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    saveTextToFile()                                    *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function that allows the user save any text from  *
         *               the textbox into a .txt file, using the             *
         *               SaveFileDialog and StreamWriter.                    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void saveTextToFile()
        {
            // Create new dialog
            SaveFileDialog saveFile = new SaveFileDialog();
            // Set the default file name
            saveFile.FileName = "*.txt";
            // Filter the type of file you are allowed to save
            saveFile.Filter = "Plain Text (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Create new stream writer
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                // Write contents of the text box to the new file
                writer.Write(displayTextBox.Text);
                writer.Close();
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    clearText()                                         *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function clears the textbox of leftover text.     *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void clearText()
        {
            displayTextBox.Clear();     // Wipes the text box clean
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    closeForm()                                         *
         *  Input:       void                                                *
         *  Output:      void                                                *
         *  Description: A function closes the form.                         *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void closeForm()
        {
            this.Close();   // Closes the windows form
        }   // End function
    }   // End form
}
