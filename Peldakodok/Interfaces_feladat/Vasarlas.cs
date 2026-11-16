using Interfaces_feladat.Targyak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat
{
    internal class Vasarlas
    {
        public List<Targy> VasaroltTermekek { get; set; } = new List<Targy>();
        public IFizetesiRendszer FizetesiRendszer { get; set; }

        public int Vegosszeg { get; set; }


        public Vasarlas(IFizetesiRendszer fizetesiRendszer)
        {
            FizetesiRendszer = fizetesiRendszer;
        }

        // hívja meg a fizetési módunk szerinti fizetést - próbáljunk Vegosszeg-nyi dolgot kigizetni
        //ha sikertelen volt: próbálja meg fele ekkora összeggel
        //ha az sikeres: írja ki, hogy leárazásban vásárolt
        //ha nem: írja ki, hogy sajnos megint sikertelen volt a vásárlás
        public void Fizetes()
        {
            VegosszegKiszamolasa();
            bool sikeres = FizetesiRendszer.Fizetes(Vegosszeg);
            if (sikeres == false)
            {
                Console.WriteLine("♦ A vásárlási kisérlet meghiusult\n");
                bool sikeres2 = FizetesiRendszer.Fizetes(Vegosszeg / 2);
                if (sikeres2 = true)
                {
                    Console.WriteLine("♦ Leárazásban vásárolt\n");
                }
                else
                {
                    Console.WriteLine("♦ Sajnos ismét sikertelen volt a váráslási kisérlet\n");
                }
            }
        }
        public void Kosarbatetel(Targy targy)
        {
            VasaroltTermekek.Add(targy);
        }
        public void VegosszegKiszamolasa()
        {
            Vegosszeg = 0;
            foreach (var targy in VasaroltTermekek)
            {
                Vegosszeg += targy.Ar;
            }

        }
    }
}