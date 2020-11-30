﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public class CommonFunctionHelper
    {
        public int SearchGridViewFirstTwoColumn(string searchValue, ref DataGridView dataGridView, ref List<int> foundIndices)
        {
            bool isEnd = false;
            int index = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if ((row.Cells[1].Value.ToString().ToUpper().Contains(searchValue.ToUpper()) || row.Cells[2].Value.ToString().ToUpper().Contains(searchValue.ToUpper()))
                    && !foundIndices.Any(f => f == row.Index))
                {
                    foundIndices.Add(row.Index);
                    index = row.Index;
                    break;
                }
                if (row.Index == dataGridView.Rows.Count - 1) isEnd = true;
            }

            if (isEnd)
            {
                foundIndices.Clear();
                CommonMessageHelper.NoMoreResultFound();
            }

            return index;
        }
    }
}
