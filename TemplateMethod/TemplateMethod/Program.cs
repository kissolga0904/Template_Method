using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //GOF1 - programozzunk felületre!
            //GOF1 a legősibb típust használom!
            BablevesFozes f2 = new BabGulyasFozes();
            f2.Foz();

            BablevesFozes f3 = new HabartBablevesFozes();
            f3.Foz();
            Console.ReadKey();
        }

    }
}
