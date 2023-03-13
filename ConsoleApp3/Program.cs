namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }


        static void ScribblePredavanja1()
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
        }

        static void ScribblePredavanja2()
        {
            // Logične operacije

            bool zunajPadaDez = false;

            // Negacija - operator !
            Console.WriteLine($"Ali zunaj pada dež?: {!zunajPadaDez}");

            // Logični IN - &&
            bool zunajJeVroce = true;

            bool rezultat = zunajPadaDez && zunajJeVroce;
            Console.WriteLine($"Rezultat: {rezultat}");


            // Logični ALI - ||
            rezultat = zunajPadaDez || zunajJeVroce;
            Console.WriteLine($"Rezultat: {rezultat}");


            // Operacije enakosti in primerjanja

            int stevilo1 = 7;
            int stevilo2 = 8;

            rezultat = stevilo1 < stevilo2;
            Console.WriteLine($"{stevilo1} < {stevilo2} - Rezultat: {rezultat}");

            rezultat = stevilo1 > stevilo2;
            Console.WriteLine($"{stevilo1} > {stevilo2} - Rezultat: {rezultat}");

            rezultat = stevilo1 <= stevilo2;
            Console.WriteLine($"{stevilo1} <= {stevilo2} - Rezultat: {rezultat}");

            rezultat = stevilo1 >= stevilo2;
            Console.WriteLine($"{stevilo1} >= {stevilo2} - Rezultat: {rezultat}");

            rezultat = stevilo1 == stevilo2;
            Console.WriteLine($"{stevilo1} == {stevilo2} - Rezultat: {rezultat}");

            rezultat = stevilo1 != stevilo2;
            Console.WriteLine($"{stevilo1} != {stevilo2} - Rezultat: {rezultat}");

            rezultat = "mama" == "Mama";
            Console.WriteLine($" mama == Mama - Rezultat: {rezultat}");



            // Stavek IF

            // Vrednosti so med 1 in 10
            int ocena = 10;

            if (ocena == 10)
            {
                Console.WriteLine("Vaša ocena je odlično!");
            }
            else if (ocena == 8 || ocena == 9)
            {
                Console.WriteLine("Vaša ocena je prav dobro!");
            }
            else if (ocena == 7)
            {
                Console.WriteLine("Vaša ocena je dobro!");
            }
            else if (ocena < 6)
            {
                Console.WriteLine("Vaša ocena je nezadostno!");
            }
            else
            {
                Console.WriteLine("Vaša ocena je zadostno!");
            }



            int stevilo = 10;

            if (stevilo % 2 == 0)
            {
                Console.WriteLine($"Število {stevilo} je sodo.");
            }
            if (stevilo % 5 == 0)
            {
                Console.WriteLine($"Število {stevilo} deljivo s 5.");
            }


            // Ternarni operator
            int procentiNaIzpitu = 64;
            string uspesen = procentiNaIzpitu >= 50 ? "Opravil!" : "Ni opravil :(";
            Console.WriteLine($"Študent je izpit {uspesen}");
        }
    }
}