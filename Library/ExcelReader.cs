using System;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public class ExcelReader
    {
        public string[] Read(string filename)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);

            Console.WriteLine($"File {filename} is opened.");

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange.Columns["D"];

            Array myvalues = (Array)xlRange.Cells.Value;
            string[] strArray = myvalues
                .OfType<object>()
                .Select(o => o.ToString())
                .Distinct()
                .ToArray();

            Console.WriteLine("Excel data reading is finished.");

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            Console.WriteLine($"File {filename} is closed.");

            return strArray;
        }
    }
}
