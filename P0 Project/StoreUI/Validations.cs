using System;
namespace StoreUI
{
    public class Validations : IValidations
    {
        public int ValidateInt(string prompt)
        {
            int response = 0;
            bool repeat = true;
            do{
                Console.WriteLine(prompt);
                try{
                    response = Int32.Parse(Console.ReadLine());
                    if (response > -1)
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Input must be nonnegative... OOF");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input. Please enter and integer value.");
                }


            }while (repeat);
            return response;
        }
        public string ValidateString(string prompt)
        {
            string response;
            bool repeat;
            do{
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                repeat =  string.IsNullOrWhiteSpace(response);
                if (repeat) Console.WriteLine("Please input a non empty string");
            } while(repeat);
            return response;

        }

        public double ValidateDouble(string prompt)
        {
            double response = 0.0;
            bool repeat = true;
            do{
                Console.WriteLine(prompt);
                try{
                    response = Int32.Parse(Console.ReadLine());
                    if (response > -.01)
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Input must be nonnegative... OOF");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input. Please enter and integer value.");
                }


            }while (repeat);
            return response;
        }
    }
}