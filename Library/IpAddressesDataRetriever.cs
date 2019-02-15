using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public static class IpAddressesDataRetriever
    {
        public static void GetDataAndSaveToExcel(string sourceFile, string destinationFile)
        {
            var excelReader = new ExcelReader();
            var ipArr = excelReader.Read(sourceFile);

            List<Response> list = new List<Response>();

            var task = Task.Run(async () => {
                int start = 0;
                int page = 100;

                while (start < ipArr.Length)
                {
                    Console.WriteLine($"{start} out of {ipArr.Length} ip adresses is retrieved.");
                    var tempArr = ipArr.Skip(start).Take(page);
                    var ipData = await IpDataRetriever.GetResponse(tempArr);
                    list.AddRange(ipData);
                    start += page;
                    await Task.Delay(500);
                }
            });

            task.Wait();
            Console.WriteLine($"{ipArr.Length} out of {ipArr.Length} ip adresses is retrieved.");

            var excelWriter = new ExcelWriter();
            excelWriter.CreateFile(destinationFile, list);
        }
    }
}
