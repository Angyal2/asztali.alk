using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat.FizetesiModok
{
    //implementálja a IFizetésiRendszer interfészt
    internal class Revolut : IFizetesiRendszer
    {
        public int Egyenleg { get; set; }
        public bool Fizetes(int osszeg)
        {
            if (Egyenleg >= osszeg)
            {
                Egyenleg -= osszeg;
                Console.WriteLine("♦ Sikeres fizetés revoluton");
                return true;
            }
            else
            {
                Console.WriteLine("♦ Sikertelen fizetés revoluton");
                return false;
            }
        }
    
        //fizetés:
        /*
         * - ha van elég pénzünk (egyenleg)
         *      - vonja le
         *      - írja ki, hogy "Sikeres fizetés revoluton"
         *      - adjon vissza 'true'-t
         * - ha nincs:
         *      - írja ki, hogy "Sikertelen fizetés revoluton"
         *      - adjon vissza 'false'-ot
         */
    }
}
