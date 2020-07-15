using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Basic Calculator!!");
            var stay = true;
            do
            {

                Console.WriteLine("Menu");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiply");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 for Halt!");

                var choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        var input1 = double.Parse (Console.ReadLine()); // explicit casting with exception
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2); // explicit casting with null
                        Add(input1, input2);
                        break;

                    case "2":
                        double input3;
                        double input4;

                        if(double.TryParse(Console.ReadLine(), out input3))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("not valid");
                        }

                        if(double.TryParse(Console.ReadLine(), out input4))
                        {
                            System.Console.WriteLine("valid");
                        }

                        else
                        {
                            System.Console.WriteLine("not valid");
                        }

                        Subtract(input3, input4);
                    break;

                        

                    case "5":
                    //default: 
                        stay = false;
                        break;
                }
            }
             while (stay); 


            /*
            casting
            "2" to 2.0
            "2a" makes error

            parsing
            "2a" to 2.0
            */
            
        }

        static void Add(double operand1, double operand2)
        {
            var result = operand1 + operand2;
            //System.Console.WriteLine(result);
            System.Console.WriteLine($"your answer is: {result}");
            //System.Console.WriteLine(operand1 + operand2);
        }
        static void Subtract(double operand1, double operand2)
        {
            var result = operand1 - operand2;
            //System.Console.WriteLine(result);
            System.Console.WriteLine($"your answer is: {result}");
            //System.Console.WriteLine(operand1 + operand2);
        }

        static void Multiply()
        {
            var result = operand1 * operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }

        static void Division()
        {
            var result = operand1/operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }
    }
}
