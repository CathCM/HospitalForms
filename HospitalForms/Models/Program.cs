using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            
            DataRandomGenerator data = new DataRandomGenerator();
            
            data.Menu();
            
      
    
            Console.ReadLine();
        }

       
    }
}
