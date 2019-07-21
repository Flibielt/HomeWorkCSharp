using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableGame.Model
{
    class Table
    {

        private int[,] table;

        public Table()
        {
            uploadTable();
        }

        private void uploadTable()
        {
            table = new int[8, 8] {
                { 6, 2, 7, 4, 2, 4, 4, 2},
                { 2, 2, 2, 5, 4, 2, 1, 6},
                { 3, 4, 2, 4, 2, 5, 5, 3},
                { 4, 5, 4, 3, 2, 2, 3, 4},
                { 2, 1, 2, 3, 4, 4, 2, 3},
                { 2, 4, 3, 2, 3, 3, 6, 4},
                { 6, 4, 2, 3, 3, 2, 6, 3},
                { 6, 7, 4, 3, 3, 2, 2, 0}
            };
        }

        public int GetElement(int row, int col)
        {
            return table[row, col];
        }
    }
}
