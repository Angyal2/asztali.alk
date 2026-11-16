using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat.FizetesiModok
{
    internal class Bankkartya : IFizetesiRendszer
    {
        //fizetés:
        /*
         * - ha van elég pénzünk (egyenleg)
         *      - vonja le
         *      - írja ki, hogy "Sikeres bankkártyás fizetés"
         *      - adjon vissza 'true'-t
         * - ha nincs:
         *      - írja ki, hogy "Sikertelen bankkártyás fizetés"
         *      - adjon vissza 'false'-ot
         */
    }
}
