using System;

namespace scripting_final
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string HeroName = "input name";
            string HeroType = "input class";
            Hero hero = new Hero(HeroName, HeroType);
            int kills = 0;
           
            Properties.Monster[] monsters = {
                //easy monsters
                new Properties.Monster("Slime",1), new Properties.Monster("ogere",2),new Properties.Monster("elf",3)
            };
            Properties.Monster enemy = new Properties.Monster("place holder", 0);

            menu();
            void menu()
            {
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose a optie:");
                Console.WriteLine("start");
                Console.WriteLine("rules ");
                Console.WriteLine("quit ");
                Console.Write("\r\nWhat do you choose?: ");
                string Menu = Console.ReadLine();

                switch (Menu)
                {
                    case "start":
                        start();
                        break;

                    case "rules":
                        rules();
                        break;

                    case "quit":
                        quit();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("thats way off");
                        Console.WriteLine("press enter for menu and retry");
                        Console.Read();
                        menu();
                        break;
                }
            }
            void quit()
            {
                Console.Clear();
                Environment.Exit(0);
            }
            void rules()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("hello these are the rules ");
                Console.WriteLine("you can pick the name of your hero");
                Console.WriteLine("you can pick your class");
                Console.WriteLine("you need to defeat monsters");
                Console.WriteLine("most inportantly have fun ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("press enter to go back to menu");
                Console.Read();
                menu();
            }
            void start()
            {
                Console.Clear();
                Console.WriteLine("hello traveller what is your name?");
                HeroName = Console.ReadLine();
                hero.Name = HeroName;
                Console.WriteLine("so your name is "+HeroName+" nice to meet you");
                Console.WriteLine("are you "+HeroName+" from the legends?");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "yes":
                        yes();
                        break;

                    case "no":
                        no();
                        break;
                    default:
                        Console.WriteLine("are you it or are you not YES or NO ?");
                        string choice2 = Console.ReadLine();
                        switch (choice2)
                        {
                            case "YES":
                                yes();
                                break;
                            case "yes":
                                yes();
                                break;

                            case "NO":
                                no();
                                break;
                            case "no":
                                no();
                                break;
                            default:Console.WriteLine("just start over ");
                                Console.WriteLine("press enter for menu and retry");
                                Console.Read();
                                menu();

                                break;
                        }

                        break;
                }
            }

            void no()
            {
                Console.WriteLine("");
                Console.WriteLine("good to know you are not the legendary " + HeroName);
                Console.WriteLine("thats unfortunate we have been having a huge monster problem only the choosen one could solve");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("this is the end of the voyage");
                Console.WriteLine("press enter to go back to menu");
                Console.ResetColor();
                Console.ReadLine();
                menu();

            }
            void yes()
            {
                Console.Clear();
                Console.WriteLine("good to hear you are the choosen one ");
                Console.WriteLine("what type of hero are you?");
                Console.WriteLine("\n Knight ");
                Console.WriteLine("he has 110 health, 20 attack and 80 defence ");
                Console.WriteLine("\n Assasin ");
                Console.WriteLine("he has 60 health, 40 attack and 85 defence ");
                Console.WriteLine("\n Tank ");
                Console.WriteLine("he has 150 health, 7 attack and 70 defence ");
                HeroType = Console.ReadLine();
                if(HeroType == "Knight"||HeroType == "Assasin"||HeroType == "Tank") { }
                else
                {
                    Console.Clear();
                    Console.WriteLine("please press enter and try a valid type");
                    Console.ReadLine();
                    yes();
                }

                
                hero = new Hero(HeroName, HeroType);

                Console.WriteLine("Now i know what type of fighter you are please to the basment and fight");
                Console.Clear();
                castenemy();
                battle();

            }

            void battle()
            {
                Console.WriteLine("enemy has " + enemy.Health + " health");
                Console.WriteLine("hero has " + hero.Health + " health");
                hero.Health -= hero.Defense / 100 * enemy.Attack;
                
                if (enemy.Health <= 0 && hero.Health > 0)
                {
                    kills++;
                    Console.WriteLine("you have killed a enemy\npress enter to go to the next enemy");
                    Console.ReadLine();
                    Console.Clear();
                    castenemy();
                    battle();
                }
                else if (enemy.Health > 0 && hero.Health > 0)
                {
                    enemy.Health -= enemy.Defense / 100 * hero.Attack;
                    Console.WriteLine("you have attacked an enemy");
                    Console.ReadLine();
                    Console.Clear();
                    battle();
                }
                else if (enemy.Health > 0 && hero.Health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("you are dead");
                    Console.WriteLine("you made " + kills+ " kills");
                    Console.ReadLine();
                }
                Console.Clear();
            }

            void castenemy()
            {
                Random rnd = new Random();
                enemy = monsters[rnd.Next(1, 3)];
                Console.WriteLine("the enemy you are fighting is " + enemy.Name);

            }


        }
    }
}
