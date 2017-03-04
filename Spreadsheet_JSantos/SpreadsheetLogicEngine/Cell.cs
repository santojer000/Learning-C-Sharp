using System;
using System.ComponentModel;
using System.Collections.Generic;
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
 *  Description: A simple Cell class that includes various attributes,       *
 *               properties, and functions. These include:                   *
 *                  - Text, Value, RowIndex, ColIndex                        *
 *                  - event handler that triggers when you change the value  *
 *                    of the text in a cell                                  *
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
namespace SpreadsheetLogicEngine
{
    public abstract class Cell : INotifyPropertyChanged
    {
        private int rowIndex = 0;
        private int colIndex = 0;
        protected string text = "";
        protected string value1 = "";
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Cell()
        {

        }
        public Cell(int row, int col)
        {
            rowIndex = row;
            colIndex = col;
        }
        public int RowIndex
        {
            get { return rowIndex; }
        }   // End property

        public int ColIndex
        {
            get { return colIndex; }
        }   // End property

        public string Text
        {
            get { return text; }

            set
            {
                if (text == value) { return; }
                text = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Text"));
            }
        }   // End property

        public string Value
        {
            get { return value1; }
        }   // End property

        public void SetValue(string value)
        {
            value1 = value;
        }   // End function
    }   // End class
}
