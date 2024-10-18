using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienteobject
{
    public static class TestZoo
    {
        public static void Launch()
        {
            var monLion = new Lion(new DateTime(2020, 5, 31), "Simba");
            var monMoineau = new Moineau(new DateTime(2018, 10, 19), null);
            var maGirafe = new Girafe(null, "Sophie");


            monLion.PousseMonCri();
            monMoineau.PousseMonCri(); 
            maGirafe.PousseMonCri();

            Console.WriteLine();

            monLion.DisplayFood();
            monMoineau.DisplayFood();
            maGirafe.DisplayFood();

            Console.WriteLine();

            monLion.DisplayAge(); // 4 ans
            monMoineau.DisplayAge(); // 35 ans
            maGirafe.DisplayAge(); // age inconnu
            //var monPelicanAdulte = Pelican.CreatePelican(35, "PelicanPapa");
            //var monPelicanBebe = Pelican.CreatePelicanBebe("PelicanBebe");

        }
    }
}
