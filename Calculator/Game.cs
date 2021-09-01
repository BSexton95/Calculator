using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        float answer;

        float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        float Calculate(string description, string add, string sub, string div, string mult)
        {
            string input = "";

            Console.WriteLine(description);
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mult);

            input = Console.ReadLine();

            
            string value1 = "";
            string value2 = "";
            float num1;
            float num2;

            Console.WriteLine("Enter 2 numbers.");
            value1 = Console.ReadLine();
            value2 = Console.ReadLine();

            if (!float.TryParse(value1, out num1))
            {
                Console.WriteLine("Invalid Input!");
            }

            if (!float.TryParse(value2, out num2))
            {
                Console.WriteLine("Invaild Input!");
            }


            if (input == "1")
            {
                answer = Add(num1, num2);
                Console.WriteLine(answer);
                
            }
            else if (input == "2")
            {
                answer = Subtraction(num1, num2);
                Console.WriteLine(answer);
                
            }
            else if (input == "3")
            {
                answer = Division(num1, num2);
                Console.WriteLine(answer);
                
            }
            else if (input == "4")
            {
                answer = Multiplication(num1, num2);
                Console.WriteLine(answer);
                
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
            Console.Clear();
            return answer;
        }

        public void Run()
        {

            int inputRecieved = 0;

            while (!(inputRecieved == 1 || inputRecieved == 2 || inputRecieved == 3 || inputRecieved == 4))
            {
                Calculate("Which operation would you like to preform?", "\n Enter 1 for Addition", "" +
                    "\n Enter 2 for Subtraction", "\n Enter 3 for Division", "\n Enter 4 for Multiplication");
                /*
                bool calculate = false;
                while(!calculate)
                {
                    Console.WriteLine("Would you like to calculate more numbers?" + "\n yes" + "\n no");
                    Console.ReadLine();

                    string input = Console.ReadLine();

                    if( input == "yes")
                    {
                        Calculate("Which operation would you like to preform?", "\n Enter 1 for Addition", "" +
                         "\n Enter 2 for Subtraction", "\n Enter 3 for Division", "\n Enter 4 for Multiplication");
                    }
                    else if(input == "no")
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }*/
            }
        }
    }
}
