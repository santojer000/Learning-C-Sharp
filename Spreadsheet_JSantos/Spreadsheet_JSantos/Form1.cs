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
 *  Date:        02/10/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #7--Spreadsheet_JSantos                                  *
 *  Description: A Program that utilizes an abstract Cell class, as well as  *
 *               a spreadsheet class to create the logic engine behind the   *
 *               spreadsheet. This class uses property changing event        *
 *               handlers to update the values in the cells                  *
 *               (FROM THE SPREADSHEET LOGIC ENGINE!).                       *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace Spreadsheet_JSantos
{
    public partial class Form1 : Form
    {
        // Variables
        int numOfCol = 26;
        int numOfRow = 50;
        char colName = 'A';
        int rowName = 1;
        SpreadsheetLogicEngine.Spreadsheet ss;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createColumns();        // Add the columns
            createRows(numOfRow);   // Add the rows
            addRowHeaders(infoDataGridView);    //Add the row headers
            ss = new SpreadsheetLogicEngine.Spreadsheet(50, 26);
            infoDataGridView.CellBeginEdit += OnCellBeginEdit;
            infoDataGridView.CellEndEdit += OnCellEndEdit;
            ss.CellPropertyChanged += OnCellPropertyChanged;
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    createColumns                                       *
         *  Input:       none                                                *
         *  Output:      void                                                *
         *  Description: A function that programmatically adds columns       *
         *               A to Z to the DataGridView.                         *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void createColumns()
        {
            // 26 letters in English alphabet
            for (int i = 0; i < numOfCol; i++)
            {
                // Add current letter as new column in dataViewGrid
                infoDataGridView.Columns.Add("Column " + colName,
                    colName.ToString());
                colName++;  // Get the next letter in the alphabet
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    createRows                                          *
         *  Input:       integer                                             *
         *  Output:      void                                                *
         *  Description: A function that programmatically adds rows to the   *
         *               DataGridView.                                       *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void createRows(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                // Add current number as new row in dataViewGrid
                infoDataGridView.Rows.Add();
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    addRowHeaders                                       *
         *  Input:       DataGridView                                        *
         *  Output:      void                                                *
         *  Description: A function that programmatically adds header labels *
         *               to the rows of the DataGridView.                    *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void addRowHeaders(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.HeaderCell.Value = rowName.ToString();
                rowName++;
            }
            grid.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }   // End function

        private void OnCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            infoDataGridView.CurrentCell.Value =
                ss.getCell(infoDataGridView.CurrentCell.RowIndex,
                infoDataGridView.CurrentCell.ColumnIndex).Text;
        }   // End event

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       SS_CellPropertyChanged                              *
         *  Input:       object, PropertyChangedEventArgs                    *
         *  Output:      void                                                *
         *  Description: An event that triggers when a Cell property is      *
         *               changed.                                            *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellEventHandler handler = OnCellEndEdit;
            if (handler != null)
            {
                ss.getCell(infoDataGridView.CurrentCell.RowIndex,
                    infoDataGridView.CurrentCell.ColumnIndex).Text =
                    infoDataGridView.CurrentCell.Value.ToString();

                infoDataGridView.CurrentCell.Value =
                    ss.getCell(infoDataGridView.CurrentCell.RowIndex,
                    infoDataGridView.CurrentCell.ColumnIndex).Value;
            }
        }   // End event

        public void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SpreadsheetLogicEngine.SpreadsheetCell currCell =
                sender as SpreadsheetLogicEngine.SpreadsheetCell;
            if ("Value" == e.PropertyName)
            {
                infoDataGridView.Rows[currCell.RowIndex].
                    Cells[currCell.ColIndex].Value = currCell.Value;
            }
        }   // End event
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Event:       demoButton_Click                                    *
         *  Input:       object, EventArgs                                   *
         *  Output:      void                                                *
         *  Description: An event that triggers when you click the demo      *
         *               button. The event entails various demonstrations    *
         *               on how the updates are happening through the logic  *
         *               engine and not the UI.                              *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void demoButton_Click(object sender, EventArgs e)
        {
            
        }   // End event
    }
}
