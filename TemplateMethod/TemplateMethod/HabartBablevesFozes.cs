using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class HabartBablevesFozes : BablevesFozes
    {
        protected override void elokeszites()
        {
            Console.WriteLine("Beáztatom a tarkababot");
        }

        protected override void talalas()
        {
            Console.WriteLine("Kenyérrel és tejföllel tálalom");
        }

        protected override void izesites()
        {
            Console.WriteLine("Behabarom, sóval ízesítem");
        }
    }
}
