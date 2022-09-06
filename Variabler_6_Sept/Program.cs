using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
              // Övning 1

              Console.Write("Hej, vad heter du? ");
              string namn = Console.ReadLine();
              Console.WriteLine("Hej " + namn);


              // Övning 2

              int kalle;
              int pelle;

              Console.Write("Hur många äpplen har Kalle? ");
              kalle = int.Parse(Console.ReadLine());
              Console.Write("Hur många äpplen har Pelle? ");
              pelle = int.Parse(Console.ReadLine());

              int svar = kalle + pelle;

              Console.WriteLine("De har " + svar + " äpplen tillsammans");


              // Övning 3 

              int freddy;
              int michael;

              Console.Write("Hur många har Freddy Krueger dödat? ");
              freddy = int.Parse(Console.ReadLine());
              Console.Write("Hur många har Freddy Krueger dödat? ");
              michael = int.Parse(Console.ReadLine());
              int skillnad = (freddy - michael);
              Console.WriteLine("Det skiljer med " + skillnad + " offer.");
           

            // Övning 4 

            int mofoA;
            int moviesA;

            Console.Write("Hur många gånger sa Samuel L Jackson MF-ordet?: ");
            mofoA = int.Parse(Console.ReadLine());
            Console.Write("I hur många filmer?: ");
            moviesA = int.Parse(Console.ReadLine());
            double snittTwo = mofoA / moviesA;

            Console.WriteLine("Samuel L Jackson säger i snitt MF-ordet " + snittTwo + " gånger per film"); // förstår ej varför den avrundar nedåt 

            

            // Övning 4 min version
                      
            bool outcome;
            bool outcomeTwo;

            Console.Write("Hur många gånger sa Samuel L Jackson MF-ordet? ");
            string mofo = Console.ReadLine();
            outcome = Int32.TryParse(mofo, out int mofoAsInt);

            Console.Write("I hur många filmer? ");
            string movies = Console.ReadLine();
            outcomeTwo = Int32.TryParse(movies, out int movieAsInt);

            double snitt = (mofoAsInt / movieAsInt); // Förstår ej varför den avrundar nedåt 

            Console.WriteLine("Samuel L Jackson säger i snitt MF-ordet " + snitt + " gånger per film");
            Console.WriteLine(mofoAsInt);
            Console.WriteLine(movieAsInt);


            // Övning 5

            string animal;
            string animalDescription;
            string clothing;
            string clothingDescription;
            string water;
            string waterDescription;

            Console.Write("Vad är ditt favoritdjur? ");
            animal = Console.ReadLine();
            Console.Write("Ange tre orsaker/adjektiv som beskriver " + animal + ": ");
            animalDescription = Console.ReadLine();
            Console.Write("Vad är ditt favoritklädesplagg? ");
            clothing = Console.ReadLine();
            Console.Write("Ange tre orsaker/adjektiv som beskriver " + clothing + ": ");
            clothingDescription = Console.ReadLine();
            Console.Write("Ange din favoritform av vatten (ex hav, flod, vattenfall is mm): ");
            water = Console.ReadLine();
            Console.Write("Ange tre orsaker/adjektiv som beskriver " + water + ": ");
            waterDescription = Console.ReadLine();

            Console.WriteLine("Här kommer din Pseudo-Freudianska tolkning:");
            Console.WriteLine("Djuret (" + animal + ") är hur du ser på dig själv: (" + animalDescription + ").");
            Console.WriteLine("Klädesplaget (" + clothing + ") är hur andra ser på dig: " + clothingDescription + ".");
            Console.WriteLine("Vattenformen (" + water + ") är hur du ser på ditt sexliv: " + waterDescription + "."); 


        }
    }
}
