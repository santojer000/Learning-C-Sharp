using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *  Programmer:  Jerome Santos                                               *
 *  SID:         011555815                                                   *
 *  Date:        02/10/2017                                                  *
 *  Course:      CPT_S 321--Object Oriented Software Principles              *
 *  Term:        Spring 2017                                                 *
 *  Assignment:  HW #4--Spreadsheet_JSantos                                  *
 *  Description: A simple spreadsheet class that creates a 2D array of Cells *
 *               from the Cell class. This class holds all of the logic      *
 *               behind the spreadsheet and when values are being updated    *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace SpreadsheetLogicEngine
{
    public class Spreadsheet
    {
        private Cell ssCell = new SpreadsheetCell();
        private int numOfRows = 0;
        private int numOfCols = 0;
        private SpreadsheetCell[,] container;
        public event PropertyChangedEventHandler CellPropertyChanged;

        // Constructor
        public Spreadsheet(int rows, int columns)
        {
            numOfRows = rows;
            numOfCols = columns;
            container = new SpreadsheetCell[numOfRows, numOfCols];
            fillSpreadsheet(container);
        }   // End constructor

        public int ColumnCount
        {
            get { return numOfCols; }
        }   // End property

        public int RowCount
        {
            get { return numOfRows; }
        }   // End property

        public void fillSpreadsheet(SpreadsheetCell[,] ssc)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    container[i, j] = new SpreadsheetCell(i,j);
                    ssCell.PropertyChanged += OnCellPropertyChanged;
                }
            }
        }   // End function

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         *  Function:    getCell                                             *
         *  Input:       integer, integer                                    *
         *  Output:      Cell                                                *
         *  Description: A function that returns the Cell at that specific   *
         *               index in the 2D Array.                              *
         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public SpreadsheetCell getCell(int rowIndex, int colIndex)
        {
            return container[rowIndex, colIndex];
        }   // End function

        public void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ("Text" == e.PropertyName)
            {
                ssCell = sender as SpreadsheetCell;
                if (ssCell.Text.StartsWith("="))
                {
                    ExpTree tree = new ExpTree(ssCell.Text.Replace("=", ""));
                    ssCell.SetValue(tree.eval().ToString());
                }
            }
        }   // End event
    }   // End class
}
