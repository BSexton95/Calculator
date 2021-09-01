using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        void StringIntConversion()
        {
            int num1;
            int num2;
            string value1 = "";
            string value2 = "";

            Console.WriteLine("Enter 2 numbers to be added together.");
            value1 = Console.ReadLine();
            value2 = Console.ReadLine();

            int.TryParse(value1, out num1);
            int.TryParse(value2, out num2);
        }
        int Add(int num1, int num2)
        {
            StringIntConversion();
            return num1 + num2;
        }

        int Subtraction(int num1, int num2)
        {
            StringIntConversion();
            return num1 - num2;
        }

        float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        int Multiplication(int num1, int num2)
        {
            StringIntConversion();
            return num1 * num2;
        }

        public void Run()
        {
            string input = "";
            int inputRecieved = 0;

            Console.WriteLine("Which operation would you like to preform?" +
                "\n Enter 1 for Addition" + "\n Enter 2 for Subtraction" + "\n Enter 3 for Division" + 
                "\n Enter 4 for Multiplication");

            input = Console.ReadLine();


            while (!(inputRecieved == 1 || inputRecieved == 2 || inputRecieved == 3 || inputRecieved == 4))
            {
                if (input == "1")
                {
                    Add();
                }
                else if (input == "2")
                {
                    Subtraction();
                }
                else if (input == "3")
                {
                    Division();
                }
                else if (input == "4")
                {
                    Multiplication();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
                Console.Clear();
            }
    }
}
