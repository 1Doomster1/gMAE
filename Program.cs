using System.Security.AccessControl;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Камень ножницы или бумага?");
            string choise = Console.ReadLine();

            while (choise == "")
            {
                Console.WriteLine("Не выбрал: ");
                choise = Console.ReadLine();
            }

            string bot = Random.Shared.Next(1, 4) switch
            {
                1 => bot = "Камень",
                2 => bot = "Ножницы",
                3 => bot = "Бумага"
            };

            Console.WriteLine(bot);

            if (choise == bot)
            { Console.WriteLine("Ничья"); Environment.Exit(0); }


            switch (bot)
            {
                case "Камень":
                    {
                        switch (choise)
                        {
                            case "Ножницы":
                                {
                                    Console.WriteLine("Победа бота");
                                    break;
                                }
                            case "Бумага":
                                {
                                    Console.WriteLine("Победа игрока");
                                    break;
                                }
                        }
                        break;
                    }
                case "Ножницы":
                    {
                        switch (choise)
                        {
                            case "Камень":
                                {
                                    Console.WriteLine("Победа игрока");
                                    break;
                                }
                            case "Бумага":
                                {
                                    Console.WriteLine("Победа бота");
                                    break;
                                }
                        }
                        break;
                    }
                case "Бумага":
                    {
                        switch(choise)
                        {
                            case "Ножницы":
                                {
                                    Console.WriteLine("Победа игрока");
                                    break;
                                }
                            case "Камень":
                                {
                                    Console.WriteLine("Победа бота");
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
