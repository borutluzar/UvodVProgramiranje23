namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Večvrstični 
             k
             o
             m
             e
             n
             t
             a
             r */
            Console.WriteLine("Hello, World!");

            // Tole je moja prva spremenljivka
            int stevec;
            stevec = 5;

            byte manjsaVrednost = 3;
            short maloVecjaVrednost = 347;

            Console.WriteLine(stevec);

            float decimalkaMala = 3.14F;
            double decimalkaVecja = 3.1428;

            decimal najboljNatancnaDecimalka = 1243.34859M;

            bool logicnaVrednost = true; // false;


            char znak = '€';
            Console.WriteLine(znak);
            string beseda = "To je moje besedilo in še več besedila...";
            Console.WriteLine(beseda);


            // Operatorji
            Console.WriteLine("Zaporedje operacij:");
            int stevilo = 4 + 5;
            Console.WriteLine(stevilo);
            stevilo = stevilo - 3;
            Console.WriteLine(stevilo);
            stevilo = stevilo * stevilo;
            Console.WriteLine(stevilo);
            stevilo = stevilo / 9;
            Console.WriteLine(stevilo);
            stevilo = stevilo % 3;
            Console.WriteLine(stevilo);

            int primerCelostevilskegaDeljenja = 7 / 3;
            Console.WriteLine(primerCelostevilskegaDeljenja);

            double primerCelostevilskegaDeljenja2 = 7 / (double)3;
            Console.WriteLine(primerCelostevilskegaDeljenja2);


            string pravljica = "volk " + "rdeča kapica";
            Console.WriteLine(pravljica);

            string opis = "Sem Borut in nisem težak " + (100 + 10) + " kilogramov.";
            Console.WriteLine(opis);


            // Knjižnica Math

            double sinusKota = Math.Sin(Math.PI / 2);
            Console.WriteLine(sinusKota);

            Console.Read();
        }
    }
}