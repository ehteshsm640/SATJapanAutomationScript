using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Utilities.Helper
{
    public partial class ExcelHelper
    {
        private XLWorkbook Workbook;
        private IXLWorksheet Worksheet;
        private IXLRow HeaderRow;
        private IXLRow DataRow;

        public ExcelHelper(string filePath, string sheetName)
        {

            Workbook = new XLWorkbook(filePath);
            Worksheet = Workbook.Worksheet(sheetName);
        }
        // Method to set the worksheet by name (in case you need to change)
        public void SetWorksheet(string sheetName)
        {
            Worksheet = Workbook.Worksheet(sheetName);
        }
        public void SetHeaderRow()
        {
            HeaderRow=Worksheet.Row(1);
        }
        public void SetDataRow(int Row)
        {
            DataRow=Worksheet.Row(Row);
        }
        public void CloseWorkBook()
        {
            Workbook.Dispose();
        }

    }
}
