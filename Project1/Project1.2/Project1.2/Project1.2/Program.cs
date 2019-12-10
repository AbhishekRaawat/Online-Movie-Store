using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userchoice = "";
            do
            {
                int abc, age, value, value1;
                string userValue1, userValue2;
                bool result, result1;
                bool undee = false;


                string[] CinemaArray = new string[8];

                CinemaArray[0] = ("1.Rush (15)");
                CinemaArray[1] = ("2.How I Live Now (15)");
                CinemaArray[2] = ("3.Thor: The Dark World (12)");
                CinemaArray[3] =("4.Filth (18)");
                CinemaArray[4] = ("5.Planes (3)");
                CinemaArray[5] = ("6.Don Jon (18)");
                CinemaArray[6] = ("7.Avengers (10)");
                CinemaArray[7] = ("8.Inception (14)");

                Console.WriteLine("Welcome to our Multiplex");
                Console.WriteLine("We are presently showing:");
                for (int i = 0; i < CinemaArray.Length; i++)
                {
                    Console.WriteLine(CinemaArray[i]);
                }
                do
                {
                    Console.WriteLine("Enter the number of film you want to see:");
                    userValue1 = Console.ReadLine();
                    result = int.TryParse(userValue1, out value);

                    if (result && int.Parse(userValue1) >= 1 && int.Parse(userValue1) <= 8) 
                    
                        undee = true;
                        abc = int.Parse(userValue1);

                        Console.WriteLine("Enter your age:");
                        userValue2 = Console.ReadLine();
                        result1 = int.TryParse(userValue2, out value1);
                    
                        if (result1 && int.Parse(userValue2) >= 1 && int.Parse(userValue2) <= 120)
                        {
                            age = int.Parse(userValue2);

                            switch (abc)
                            {
                                case 1:
                                    if (age <= 15)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;

                                case 2:
                                    if (age <= 15)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 3:
                                    if (age < 12)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 4:
                                    if (age <= 18)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 5:
                                    if (age <= 3)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 6:
                                    if (age <= 18)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 7:
                                    if (age <= 10)
                                    {
                                        Console.WriteLine("Access denied – you are too young ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enjoy the movie");
                                    }
                                    break;
                                case 8:
                                if (age <= 14)
                                {
                                    Console.WriteLine("Access denied – you are too young");

                                }
                                else
                                {
                                    Console.WriteLine("Enjoy the Movie");
                                }
                                break;
                            }
                        }

                        else
                        {
                            Console.WriteLine("This is the invaliid Age \nKindly enter the valid Age");
                        }
                }
                while (undee == false);

                   
                

                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    userchoice = Console.ReadLine().ToUpper();
                    if (userchoice != "Y" && userchoice != "N")
                    {
                        Console.WriteLine("Invalid choice, please say YES(Y) or NO(N)");
                    }
                } while (userchoice != "Y" && userchoice != "N");


            } while (userchoice == "Y");

        }

    }
}
