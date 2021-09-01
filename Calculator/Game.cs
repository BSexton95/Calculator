using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        //Calculators answer
        float answer;

        /// <summary>
        /// Adds two values
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns></returns>
        float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Subtracts two values
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns></returns>
        float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Divides two values
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns></returns>
        float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Multiplys two values
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns></returns>
        float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Function takes two input values from user, converts them to floats, and preforms operation 
        /// user has selected to use.
        /// </summary>
        /// <param name="description">Tells user to choose operatio they would like to use</param>
        /// <param name="add"></param>
        /// <param name="sub"></param>
        /// <param name="div"></param>
        /// <param name="mult"></param>
        /// <returns></returns>
        float Calculate(string description, string add, string sub, string div, string mult)
        {
            string input = "";

            //Displays menu user
            Console.WriteLine(description);
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mult);

            input = Console.ReadLine();

            //user input first value
            string value1 = "";
            //user input second value
            string value2 = "";
            float num1;
            float num2;

            Console.WriteLine("Enter 2 numbers.");
            value1 = Console.ReadLine();
            value2 = Console.ReadLine();

            //Converts the first value from a string to a float
            if (!float.TryParse(value1, out num1))
            {
                Console.WriteLine("Invalid Input!");
            }

            //Converts the second value from a string to a float
            if (!float.TryParse(value2, out num2))
            {
                Console.WriteLine("Invaild Input!");
            }

            //If user wants to add two numbers
            if (input == "1")
            {
                answer = Add(num1, num2);
                Console.WriteLine(answer);
                
            }
            //If user wants to subtract two numbers
            else if (input == "2")
            {
                answer = Subtraction(num1, num2);
                Console.WriteLine(answer);
                
            }
            //If user wants to divide two numbers
            else if (input == "3")
            {
                answer = Division(num1, num2);
                Console.WriteLine(answer);
                
            }
            //If user wants to multiply two numbers
            else if (input == "4")
            {
                answer = Multiplication(num1, num2);
                Console.WriteLine(answer);
                
            }
            //User enter and invalid input
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

            //While loop, loops user through choosing an operation after ever calculation
            while (!(inputRecieved == 1 || inputRecieved == 2 || inputRecieved == 3 || inputRecieved == 4))
            {
                Calculate("Which operation would you like to preform?", "\n Enter 1 for Addition",
                    "\n Enter 2 for Subtraction", "\n Enter 3 for Division", "\n Enter 4 for Multiplication");
            }
        }
    }
}
