using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas.ConsoleApp
{
    internal class Data
    {
        public void CalculaData()
        {
            DateTime data1, data2, data3;
            TimeSpan result1, result2, result3;

            data1 = DateTime.Parse("23/03/2022");
            data2 = DateTime.Parse("10/10/2015");
            data3 = DateTime.Parse("15/09/2005");



            
            result1 = DateTime.Today - data1;
            result2 = DateTime.Today - data2;
            result3 = DateTime.Today - data3;

            string resultados = result1.TotalDays.ToString()+ "\n" + result2.TotalDays.ToString() + "\n" + result3.TotalDays.ToString();
            Console.WriteLine(resultados);

            Console.ReadLine();
        }
    }
}
