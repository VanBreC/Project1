//Brendan VandeVoorde
//Project 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    // hello 
    public class Project
    {
        public static void playerList()
        {


            Console.WriteLine("{0,5} {1,25} {2,25} {3,25} {4,25} {5,25}", "Position", "The Best", "2nd Best", "3rd Best", "4th Best", "5th Best");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,25} {2,25} {3,23} {4,26} {5,26}", "Quarterback", "Maso Rudolph", "Lamar Jackson", "Josh Rosen", "Sam Darnold", "Baker Mayfield");
            Console.WriteLine("{0,39} {1,22} {2,22} {3,31} {4,21}", "(Oklahoma State)", "(Louisville)", "(UCLA)", "(South California)", "(Oklahoma)");
            Console.WriteLine("{0,36} {1,25} {2,24} {3,26} {4,24}", "$26,400,100", "$20,300,100", "$17,420,300", "$13,100,145", "$10,300,000");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,24} {2,25} {3,23} {4,28} {5,24}", "Running back", "Saquon Barkley", "Derrius Guice", "Bryce Love", "Ronald Jones II", "Damien Harris");
            Console.WriteLine("{0,36} {1,21} {2,28} {3,29} {4,21}", "(Penn State)", "(LSU)", "(Stanford)", "(South California)", "(Alabama)");
            Console.WriteLine("{0,35} {1,26} {2,25} {3,24} {4,26}", "$24,500,100", "$19,890,200", "$18,700,800", "$15,000,000", "$11,600,400");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,24} {2,25} {3,24} {4,25} {5,24}", "Wide-Reciever", "Courtland Sutton", "James Washington", "Marcell Ateman", "Anthony Miller", "Calvin Ridley");
            Console.WriteLine("{0,40} {1,23} {2,25} {3,21} {4,25}", "(Southern Methodist)", "(Oklahoma State)", "(Oklahoma State)", "(Memphis)", "(Alabama)");
            Console.WriteLine("{0,35} {1,26} {2,24} {3,25} {4,25}", "$23,400,000", "$21,900,300", "$19,300,230", "$13,400,230", "$10,000,000");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,18} {2,23} {3,26} {4,26} {5,28}", "Defensive Lineman", "Maurice Hurst", "Vita Vea", "Taven Bryan", "Da'Ron Payne", "Harrison Phillips");
            Console.WriteLine("{0,34} {1,27} {2,23} {3,25} {4,26}", "(Michigan)", "(Washington)", "(Florida)", "(Alabama)", "(Stanford)");
            Console.WriteLine("{0,35} {1,26} {2,24} {3,25} {4,25}", "$26,200,300", "$22,000,000", "$16,000,000", "$18,000,000", "$13,000,000");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,21} {2,25} {3,24} {4,29} {5,22}", "Defensive-Back", "Joshua Jackson", "Derwin James", "Denzel Ward", "Minkah Fitzpatrick", "Isaiah Oliver");
            Console.WriteLine("{0,32} {1,31} {2,22} {3,24} {4,26}", "(Iowa)", "(Florida State)", "(Ohio State)", "(Alabama)", "(Colorado)");
            Console.WriteLine("{0,35} {1,26} {2,24} {3,25} {4,25}", "$24,000,000", "$22,500,249", "$20,000,100", "$16,000,200", "$11,899,999");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,24} {2,27} {3,24} {4,25} {5,26}", "Tight Ends", "Mark Andrews", "Dallas Goedert", "Jaylen Samuels", "Mike Gesicki", "Troy Fumagalli");
            Console.WriteLine("{0,34} {1,30} {2,20} {3,27} {4,25}", "(Oklahoma)", "(So. Dakota State)", "(NC State)", "(Penn State)", "(Wisconsin)");
            Console.WriteLine("{0,35} {1,26} {2,23} {3,26} {4,26}", "$27,800,900", "$21,000,800", "$17,499,233", "$27,900,200", "$14,900,333");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,21} {2,28} {3,24} {4,25} {5,26}", "Line-Backer's", "Roquan Smith", "Tremaine Edmunds", "Kendall Joseph", "Dorian O'Daniel", "Malik Jefferson");
            Console.WriteLine("{0,33} {1,30} {2,21} {3,25} {4,25}", "(Georgia)", "(Virginia Tech)", "(Clemson)", "(Clemson)", "(Texas)");
            Console.WriteLine("{0,34} {1,27} {2,24} {3,25} {4,26}", "$22,900,300", "$19,000,590", "$18,000,222", "$12,999,999", "$10,000,100");
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,5} {1,18} {2,26} {3,28} {4,23} {5,25}", "Offensive Tackles", "Orlando Brown", "Kolton Miller", "Chuckwuma Okorafor", "Connor Williams", "Mike McGlinchey");
            Console.WriteLine("{0,34} {1,24} {2,32} {3,18} {4,28}", "(Oklahoma)", "(UCLA)", "(Western Michigan)", "(Texas)", "(Notre Dame)");
            Console.WriteLine("{0,34} {1,27} {2,25} {3,25} {4,25}", "$23,000,000", "$20,000,000", "$19,400,000", "$16,200,700", "$15,900,000");
            Console.WriteLine("\n\n");
            Console.WriteLine("You have $65000000 still to spend\n");
        }
        public static Int32 Cash(int i)
        {
            int moneyLeft = i;
            moneyLeft = moneyLeft - i;

            Console.WriteLine("You Have $" + moneyLeft + " left to spend");
            return moneyLeft;
        }
        static bool repeat = true;
        public static void TeamSelect()
        {
            while (repeat)
            {

                Console.WriteLine("Enter the Number Corresponding to the Position of the Player you Wish to Select\n");
                Console.WriteLine("1. Quarterback\n2. Running back\n3. Wide-Reciever\n4. Defensive Lineman\n5. Defensive-Back\n6. Tight Ends\n7. Line-Backer's\n8. Offensive Tackles\n\nEnter E to Quit");
                string Position = Console.ReadLine();
                
                if (Position == "1")
                {
                    int moneySpent = QuarterBack(Convert.ToInt32(Position));
                  
                }
                if (Position == "2")
                {
                    int moneySpent = Runningback(Convert.ToInt32(Position));
                    
                }
                if (Position == "3")
                {
                    int moneySpent = WideReciever(Convert.ToInt32(Position));

                }
                if (Position == "4")
                {
                    int moneySpent = DefensiveLineman(Convert.ToInt32(Position));
                    
                }
                if (Position == "5")
                {
                    int moneySpent = DefensiveBack(Convert.ToInt32(Position));
                    
                }
                if (Position == "6")
                {
                    int moneySpent = TightEnds(Convert.ToInt32(Position));
                    
                }
                if (Position == "7")
                {
                    int moneySpent = LineBackers(Convert.ToInt32(Position));
                    
                }
                if (Position == "8")
                {
                    int moneySpent = OffensiveTacklers(Convert.ToInt32(Position));
                    
                }
                ConsoleKeyInfo Exit = Console.ReadKey();
                if (Exit.Key == ConsoleKey.E)
                    repeat = false;
                
            }
        }

        public static Int32 QuarterBack(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Quarterbacks");
            Console.WriteLine("1. Maso Rudolph\n2. Lamar Jackson\n3. Josh Rosen\n4. Sam Darnold\n5. Baker Mayfield\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Maso Rudolp has been added to the team\n");
                i = 26400100;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Lamar Jackson has been added to the team\n");
                i = 20300100;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Josh Rosen has been added to the team\n");
                i = 17420300;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Sam Darnold has been added to the team\n");
                i = 13100145;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Baker Mayfield has been added to the team\n");
                i = 10300000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 Runningback(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Running backs");
            Console.WriteLine("1. Saquon Barkley\n2. Derrius Guice\n3. Bryce Love\n4. Ronald Jones II\n5. Damien Harris\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Saquon Barkley has been added to the team\n");
                i = 24500100;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Derrius Guice has been added to the team\n");
                i = 19890200;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Bryce Love has been added to the team\n");
                i = 18700800;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Ronald Jones II has been added to the team\n");
                i = 15000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Damien Harris has been added to the team\n");
                i = 11600400;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 WideReciever(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Wide-Reciever");
            Console.WriteLine("1. Courtland Sutton\n2. James Washington\n3. Marcell Ateman\n4. Anthony Miller\n5. Calvin Ridley\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Courtland Sutton has been added to the team\n");
                i = 23400000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("James Washington has been added to the team\n");
                i = 21900300;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Marcell Ateman has been added to the team\n");
                i = 19300230;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Anthony Miller has been added to the team\n");
                i = 13400230;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Calvin Ridley has been added to the team\n");
                i = 10000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 DefensiveLineman(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Defensive Lineman");
            Console.WriteLine("1. Maurice Hurst\n2. Vita Vea\n3. Taven Bryan\n4. Da'Ron Payne\n5. Harrison Phillips\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Maurice Hurst has been added to the team\n");
                i = 26200300;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Vita Vea has been added to the team\n");
                i = 22000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Taven Bryan has been added to the team\n");
                i = 16000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Da'Ron Payne has been added to the team\n");
                i = 18000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Harrison Phillips has been added to the team\n");
                i = 13000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 DefensiveBack(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Defensive-Back");
            Console.WriteLine("1. Joshua Jackson\n2. Derwin James\n3. Denzel Ward\n4. Minkah Fitzpatrick\n5. Isaiah Oliver\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Joshua Jackson has been added to the team\n");
                i = 24000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Derwin James has been added to the team\n");
                i = 22500249;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Denzel Ward has been added to the team\n");
                i = 20000100;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Minkah Fitzpatrick has been added to the team\n");
                i = 16000200;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Isaiah Oliver has been added to the team\n");
                i = 11899999;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 TightEnds(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Tight Ends");
            Console.WriteLine("1. Mark Andrews\n2. Dallas Goedert\n3. Jaylen Samuels\n4. Mike Gesicki\n5. Troy Fumagalli\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Mark Andrews has been added to the team\n");
                i = 27800900;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Dallas Goedert has been added to the team\n");
                i = 21000800;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Jaylen Samuels has been added to the team\n");
                i = 17499233;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Mike Gesicki has been added to the team\n");
                i = 27900200;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Troy Fumagalli has been added to the team\n");
                i = 14900333;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 LineBackers(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Line-Backer's");
            Console.WriteLine("1. Roquan Smith\n2. Tremaine Edmunds\n3. Kendall Joseph\n4. Dorian O'Daniel\n5. Malik Jefferson\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Roquan Smith has been added to the team\n");
                i = 22900300;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Tremaine Edmunds has been added to the team\n");
                i = 19000590;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Kendall Joseph has been added to the team\n");
                i = 18000222;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Dorian O'Daniel has been added to the team\n");
                i = 12999999;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Malik Jefferson has been added to the team\n");
                i = 10000100;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
        public static Int32 OffensiveTacklers(int i)
        {
            Console.WriteLine("\nEnter the Number Corresponding to the Player you Want\n");
            Console.WriteLine("Offensive Tacklers");
            Console.WriteLine("1. Orlando Brown\n2. Kolton Miller\n3. Chuckwuma Okorafor\n4. Connor Williams\n5. Mike McGlinchey\n");
            i = Convert.ToInt32(Console.ReadLine());
            int input = i;
            if (i == 1)
            {
                Console.WriteLine("Orlando Brown has been added to the team\n");
                i = 23000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 2)
            {
                Console.WriteLine("Kolton Miller has been added to the team\n");
                i = 20000000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Chuckwuma Okorafor has been added to the team\n");
                i = 19400000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 4)
            {
                Console.WriteLine("Connor Williams has been added to the team\n");
                i = 16200700;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            if (i == 5)
            {
                Console.WriteLine("Mike McGlinchey has been added to the team\n");
                i = 15900000;
                if (Cash(i) <= 0)
                {
                    Console.WriteLine("Cannot Choose This Player, Not Enough Money\nYou Currently Have " + Cash(i));
                }
            }
            return i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Project.playerList();
            Project.TeamSelect();

        }
        

    }
}
