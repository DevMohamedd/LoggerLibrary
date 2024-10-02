using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Logger
{
    public class ExcelLogDestination : ILogDestination
    {
        private readonly string _filePath;

        public ExcelLogDestination(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(string message)
        {
            Application excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Open(_filePath);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            int lastRow = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            worksheet.Cells[lastRow + 1, 1] = DateTime.Now.ToString();
            worksheet.Cells[lastRow + 1, 2] = message;

            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }
    }
}
