using Interfaces_feladat.FizetesiModok;
using Interfaces_feladat.Targyak;

namespace Interfaces_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("----TESZTELÉS----\n \n");

            Console.WriteLine("♦ BANKKÁRTYÁS FIZETÉS: ");
            Bankkartya bankkartya = new Bankkartya();
            bankkartya.Egyenleg = 1000;
            Vasarlas bankkartyasfizetes = new Vasarlas(bankkartya);
            bankkartyasfizetes.Vegosszeg = 2000;
            bankkartyasfizetes.Fizetes();

            Console.WriteLine("♦ KÉSZPÉNZES FIZETÉS: ");
            Keszpenz keszpenz = new Keszpenz();
            keszpenz.Egyenleg = 1000;
            Vasarlas keszpenzesfizetes = new Vasarlas(keszpenz);
            keszpenzesfizetes.Vegosszeg = 500;
            keszpenzesfizetes.Fizetes();

            Console.WriteLine("♦ REVOLUT FIZETÉS:");
            Revolut revolut = new Revolut();
            revolut.Egyenleg = 1000;
            Vasarlas revolutosfizetes = new Vasarlas(revolut);
            revolutosfizetes.Vegosszeg = 3000;
            revolutosfizetes.Fizetes();

            Cigi cigi = new Cigi();
            cigi.Ar = 2720;
            revolutosfizetes.Kosarbatetel(cigi);

            //hozz létre egy új vásárlást Bankkártyával
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 2000 értékben
            * => először nem sikerül, aztán igen
            */


            //hozz létre egy új vásárlást készpénzzel
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 500 értékben
            * => elsőre sikerül
            */


            //hozz létre egy új vásárlást revolut-al
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 3000 értékben
            * => elsőre és másodikra se fog sikerülni
            */

        }
    }
}
