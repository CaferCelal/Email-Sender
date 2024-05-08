using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace EmailV2 {
    public class ExcelReader {
        public List<string> ReadExcelColumn(string filePath) {
            List<string> dataList = new List<string>();

            // Load the Excel file into an ExcelPackage
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo)) {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Get the number of rows in the worksheet
                int rowCount = worksheet.Dimension.Rows;

                // Loop through each row in the worksheet (starting from row 1)
                for (int row = 1; row <= rowCount; row++) {
                    // Get the value in the first column of the row
                    object cellValue = worksheet.Cells[row, 1].Value;

                    // Add the cell value to the list
                    if (cellValue != null)
                        dataList.Add(cellValue.ToString());
                }
            }

            return dataList;
        }
    }
}