using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class BablevesFozes
    {
        /*
        - Mivel lesznek abstract metódusaink, ezért az osztályunk abstract
        - A receptben vannak kötelező lépések, ezek közül van kötelező közös 
        és kötelező nem közös illetve opcionális
        - A kötelező közös lépéseket az ősben kifejtjük
        - A kötelező nem közös lépéseket ráhagyjuk a gyermekosztályra, ezek az ősben asbtractok
        - Az opcionális lépések pedig hook-ok
        - Csak a Foz() metódus public, azon kívül minden private vagy protected
        ez azért van, mert a lépések sorrendjét rögzítjük a Foz() metódusban
        */
        public void Foz()
        {
            elokeszites(); //kötelező, de nem közös, IOC
            fozes(); //kötelező közös
            cukorBele();//opcionális, IOC
            izesites(); //opcionális, IOC
            talalas(); //kötelező, de nem közös, IOC

            /* 
            Akkor van IOC, ha az ős olyan metódust hív, ami benne abstract vagy hook
            Ezeknek a kifejtése a gyermekosztály feladata.
            A gyermekosztály ezt kifejti, és a késői kötés miatt a gyermekben lévő kód fut le
            */

        }
         
        /*
        - inversion of control: IOC, control megfordítása
        - IOC esetében nem a gyermek hívja az ősmetódusát, hanem az
        ős hívja a gyermek metódusát
        - OOP-ben természetes, hogy a gyermek hívhatja az ős metódusát, hiszen azokat megörökli
        - Ez veszélyes, mert implementációs függőséget okozhat, ha megváltoztatom az őst, akkor
        előfordulhat hogy a gyermeknek is meg kell változnia
        - Ennek a megfordítása az hogy az ős hívja a gyermeket, ez sokkal biztonságosabb
        */
        protected virtual void cukorBele()
        {
            
        }

        protected abstract void talalas();

        /*
        - hook készítésekor: private helyett protected és virtual, törzse pedig legyen teljesen üres
        - A hook az egy olyan metódus, amelynek van törzse, de az üres
        - Ha nem void-os akkor kell benne lenni egy return-nek, de semmi más nem lehet benne
        - Fontos kérdés hogy a ToString hook metódus-e? Mert ha nem, akkor folyton megszegem az
        OCP-t hiszen a ToString-et mindig felülírom
        - A hook metódusnak muszáj virtual-nak lenni, mert felülírhatónak kell lennie
        azért nem abstract, mert azt muszáj felülírni
        - A hook metódus opcionális: vagy felülírom, vagy nem
        */
        protected virtual void izesites()
        {

        }


        private void fozes()
        {
            Console.WriteLine("Megfőzöm a levest!");
        }


        //majd a gyermekosztály kifejti a viselkedését
        //azért protected, mert a template method-ra jellemző hogy csak egy publikus metódus lehet
        //mert az rögzíti a lépések sorrendjét
        protected abstract void elokeszites();

        public BablevesFozes()
        {

        }
    }
}
