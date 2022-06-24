using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class BabGulyasFozes : BablevesFozes
    {
        protected override void elokeszites()
        {
            Console.WriteLine("Felvágom a zöldséget és a húst");
        }

        protected override void talalas()
        {
            Console.WriteLine("Tarhonyával tálalom");
        }

        protected override void izesites()
        {
            Console.WriteLine("Pirospaprikával és sóval, borssal ízesítem.");
        }
    }
}
