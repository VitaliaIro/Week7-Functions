using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm küsib kasutajala sisestada numbrit 1 kuni 3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja nimi pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1 kuni 3:");
            int userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    BackwardsName(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    NameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
            /*if (userNumber == '1')
            {
                BackwardsName(userName);               
            }
            else if (userNumber == '2')
            {
                FirstLetter(userName);
            }
            else if (userNumber == '3')
            {
                NameLength(userName);
            }
            else
            {
                Console.WriteLine("Kena päeva!");
            }*/



        }
        //funktsioonid siin
        public static void BackwardsName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void FirstLetter(string userInput)
        {
           
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void NameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

    }
}
