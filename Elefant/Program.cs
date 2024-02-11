using System;

namespace Elefant
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Elephant laura = new Elephant()
            {
                Name = "Laura",
                EarSize = 80
            };

            Elephant lucek = new Elephant()
            {
                Name = "Lucek",
                EarSize = 100
            };


            Console.WriteLine("Wciśnij 1 (Lucek) lub 2 (Laura) lub 3 (przestawienie)");


            while (true) {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Wcisnąłeś: " + input);


                if (input ==  '1') {
                    lucek.WhoAmI();
                }

                else if (input == '2') {
                    laura.WhoAmI();
                }

                else if (input == '3')
                {
                    Console.WriteLine("Referencje zostały przestawione.");
                    Elephant holder;
                    holder = lucek;
                    lucek = laura;
                    laura = holder;
        
                }

                else if (input == '4')
                {
                    lucek = laura;
                    lucek.EarSize = 4321;
                    lucek.WhoAmI();
                }

                else if(input == '5')
                {
                    laura.SpeakTo(lucek, "Cześć, Lucku!");
                }

                else {
                    Console.WriteLine("Wcisnij 1,  2 lub 3");
                    //lucek.HearMessage("Cześć", laura);
                }


            
            }
            */




            Elephant[] elephants = new Elephant[7];

            elephants[0] = new Elephant() { Name = "Lucek", EarSize = 100 };
            elephants[1] = new Elephant() { Name = "Laura", EarSize = 80 };
            elephants[2] = new Elephant() { Name = "Laurenty", EarSize = 105 };
            elephants[3] = new Elephant() { Name = "Lucyna", EarSize = 87 };
            elephants[4] = new Elephant() { Name = "Lambert", EarSize = 110 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 90 };
            elephants[6] = new Elephant() { Name = "Hubert", EarSize = 112 };


            Elephant biggestEars = elephants[0];

            for(int i = 1; i <elephants.Length; i++)
            {
                Console.WriteLine("Iteracja nr: " + i);

                if (elephants[i].EarSize > biggestEars.EarSize) {
                    biggestEars = elephants[i];
                }

                Console.WriteLine(biggestEars.EarSize.ToString());
            }

        }
    }
}
