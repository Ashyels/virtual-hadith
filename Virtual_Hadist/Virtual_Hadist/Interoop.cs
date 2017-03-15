using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Virtual_Hadist
{
    class Excel_Access
    {

        public Excel_Access()
        {

        }

        public List<ExcelHadist> read_all_info()
        {
            List<ExcelHadist> Hadist = new List<ExcelHadist>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open("D:\\DataBase1.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 1; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 2].ToString() == "Bab")
                {
                    row = 3;
                    Hadist.Add(new ExcelHadist( valueArray[row, 2].ToString(),
                                                valueArray[row, 3].ToString(),
                                                valueArray[row, 4].ToString(),
                                                valueArray[row, 5].ToString(),
                                                valueArray[row, 6].ToString()));
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return Hadist;
        }




    }
}