using System;
using System.Collections.Generic;
using System.IO;
using Email;
using OfficeOpenXml;

namespace EmailV2 {
    internal class Program {
        public static void Main(string[] args) {
            ExcelReader reader = new ExcelReader();
            EmailSender sender = new EmailSender();

            // Specify the path to your Excel file
            string filePath = "C:\\Users\\Cafer Celal Evrenüz\\Desktop\\mails.xlsx";

            // Read data from Excel file
            List<string> data = reader.ReadExcelColumn(filePath);

            // Print the data
            foreach (string item in data) {
                sender.send(item);
            }
            
        }

        
    }
}