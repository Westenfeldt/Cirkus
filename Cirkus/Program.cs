using System;

namespace Cirkus
{
    class Program
    {
        static void Main(string[] args)
        {   string valg;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Velkommen til cirkus IT-Support");
            
                Console.WriteLine("Vi har 4 forskellige typer billetter");
                Console.WriteLine("Normal: N");
                Console.WriteLine("Terrasse: T");
                Console.WriteLine("Parket: P");
                Console.WriteLine("Loge: L");
                Console.WriteLine("                 ");

            do
            {
                Console.WriteLine("Vælg en billet: ");
                valg = Console.ReadLine();
            } while (valg.ToLower() != "n" && valg.ToLower() != "t" && valg.ToLower() != "p" && valg.ToLower() != "l");

            int i = 1;
            // Normal
            int kapacitet = 100;
            int pris = 170;
            //Terrasse
            int kapacitetT = 150;
            int prisT = 230;
            //Parket
            int kapacitetP = 125;
            int prisP = 260;
            //Loge
            int kapacitetL = 50;
            int prisL = 350;
            // Bruges i alle cases
            int totalpris = 0;
            int antal = 0;
            switch (valg.ToLower())
            {
                case "n":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    while (i <= 2) {
                     
                    Console.WriteLine("Hvor mange billetter ønsker du at købe?");
                    antal = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("                   ");
                       
                        
                    if(i == 1) {
                            Console.WriteLine("Du har nu købt {0} billetter.", antal);
                            kapacitet = kapacitet - antal;
                            Console.WriteLine("Der er nu {0} tilgængelige billetter tilbage.", kapacitet);

                            totalpris = pris * antal;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din pris er: {0}", totalpris);
                    }else if (i == 2)
                        {
                            totalpris = totalpris + (pris * antal);
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din nye pris er: {0}", totalpris);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Tak for købet af billetter til cirkus IT-Support - Have en god fornøjelse.");
                        }

                        i++;
                    }
                    break;
                case "t":
                    Console.ForegroundColor = ConsoleColor.Red;
                    while (i <= 2)
                    {
                        Console.WriteLine("Hvor mange billetter ønsker du at købe?");
                        antal = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("                   ");
                        

                        if (i == 1)
                        {
                            Console.WriteLine("Du har nu købt {0} billetter.", antal);
                            kapacitetT = kapacitetT - antal;
                            Console.WriteLine("Der er nu {0} tilgængelige billetter tilbage.", kapacitetT);
                            totalpris = prisT * antal;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din pris er: {0}", totalpris);
                        }
                        else if (i == 2)
                        {
                            totalpris = totalpris + (prisT * antal);
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din nye pris er: {0}", totalpris);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Tak for købet af billetter til cirkus IT-Support - Have en god fornøjelse.");
                        }

                        i++;
                    }
                    break;

                case "p":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    while (i <= 2)
                    {
                        Console.WriteLine("Hvor mange billetter ønsker du at købe?");
                        antal = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("                   ");
                        

                        if (i == 1)
                        {
                            Console.WriteLine("Du har nu købt {0} billetter.", antal);
                            kapacitetP = kapacitetP - antal;
                            Console.WriteLine("Der er nu {0} tilgængelige billetter tilbage.", kapacitetP);
                            totalpris = prisP * antal;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din pris er: {0}", totalpris);
                        }
                        else if (i == 2)
                        {
                            totalpris = totalpris + (prisP * antal);
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din nye pris er: {0}", totalpris);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Tak for købet af billetter til cirkus IT-Support - Have en god fornøjelse.");
                        }

                        i++;
                    }
                    break;
                case "l":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    while (i <= 2)
                    {
                        Console.WriteLine("Hvor mange billetter ønsker du at købe?");
                        antal = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("                   ");
                        

                        if (i == 1)
                        {
                            Console.WriteLine("Du har nu købt {0} billetter.", antal);
                            kapacitetL = kapacitetL - antal;
                            Console.WriteLine("Der er nu {0} tilgængelige billetter tilbage.", kapacitetL);
                            totalpris = prisL * antal;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din pris er: {0}", totalpris);
                        }
                        else if (i == 2)
                        {
                            totalpris = totalpris + (prisL * antal);
                            Console.WriteLine("                   ");
                            Console.WriteLine("Din nye pris er: {0}", totalpris);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                   ");
                            Console.WriteLine("Tak for købet af billetter til cirkus IT-Support - Have en god fornøjelse.");
                        }

                        i++;
                    }
                    break;
            }
        }
    }
}
