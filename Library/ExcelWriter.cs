using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public class ExcelWriter
    {
        private static readonly string[] columns = new string[] { "IP", "Country", "City" };

        public void CreateFile(string filename, IEnumerable<Response> responses)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application
            {
                Visible = false,
                DisplayAlerts = false
            };

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();

            Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            xlWorksheet.Name = "Ip data";

            // column headings
            for (var i = 0; i < columns.Length; i++)
            {
                xlWorksheet.Cells[1, i + 1] = columns[i];
            }

            var data = CreateArray(responses);
            Console.WriteLine("Data is prepared.");

            Excel.Range xlRange = xlWorksheet
                .Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[1 + responses.Count(), columns.Length]];
            xlRange.Value = data;
            xlRange.EntireColumn.AutoFit();

            xlWorkbook.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            //cleanup

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            Console.WriteLine($"File {filename} is created.");
        }

        private string[,] CreateArray(IEnumerable<Response> data)
        {
            var array = new string[data.Count(), 3];
            int i = 0;
            foreach (var item in data)
            {
                array[i, 0] = item.Ip;
                array[i, 1] = item.Country;
                array[i, 2] = item.City;
                ++i;
            }
            return array;
        }
    }
}
