using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Utilities.Helper
{
    public partial class ExcelHelper
    {
        public int GetColumnNumberByHeader(string headerName)
        {
            
            foreach (IXLCell cell in HeaderRow.CellsUsed())  // Loop through used cells in the row
            {
                if (cell.GetString().Trim().Equals(headerName))
                {
                    return cell.Address.ColumnNumber;  // Return the column number
                }
            }
            ReportHelper.LogFail($"Header '{headerName}' not found in row {HeaderRow}");
            throw new Exception($"Header '{headerName}' not found in row {HeaderRow}");
           
        }
        public string ReadDataFromExcel(string headerName)
        {
          int columnNumber = GetColumnNumberByHeader(headerName); // Get column number by header
          string value =DataRow.Cell(columnNumber).Value.ToString().Trim();
          return value;  // Return the cell value as a string
        }
        // Function to get all row numbers where the TestCaseName matches the given value
        public static List<int>  GetTestCaseRows(string workbook,string worksheet, string testCaseName)
        {
            var wb=new XLWorkbook(workbook);
            var ws = wb.Worksheet(worksheet);
            List<int> rowNumbers = new List<int>();
            int testCaseColumn=1;
            var Header = ws.Row(1);
            foreach (IXLCell cell in Header.CellsUsed())  // Loop through used cells in the row
            {
                if (cell.GetString().Trim().Equals("TestCaseName"))
                {
                    testCaseColumn = cell.Address.ColumnNumber;  // Return the column number
                }
            }

            foreach (var row in ws.RowsUsed().Skip(1)) // Skip header
            {
                if (row.Cell(testCaseColumn).GetString().Equals(testCaseName))
                {
                    rowNumbers.Add(row.RowNumber());
                }
            }
            return rowNumbers;
        }
    }
}
