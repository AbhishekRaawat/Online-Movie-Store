using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
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


            Console.WriteLine("Welcome to our Multiplex");
            Console.WriteLine("We are presently showing:");

            Console.WriteLine("1.Rush (15)");
            Console.WriteLine("2.How I Live Now (15)");
            Console.WriteLine("3.Thor: The Dark World (12)");
            Console.WriteLine("4.Filth (18)");
            Console.WriteLine("5.Planes (3)");
            do
            {
                Console.WriteLine("Enter the number of film you want to see:");
                userValue1 = Console.ReadLine();
                result = int.TryParse(userValue1, out value);

                if (result && int.Parse(userValue1) >= 1 && int.Parse(userValue1) <= 5)
                {
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
                                Console.WriteLine("Enjoy the movie");
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("This is the invaliid Age \nKindly enter the valid Age");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the valid number film");
                }
            } while (undee == false);


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