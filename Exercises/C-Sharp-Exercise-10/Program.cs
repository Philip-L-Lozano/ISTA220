using System;
using System.Globalization;

namespace C_Sharp_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key to continue or 'Q' to quit.");
            string exit = Console.ReadLine();
            if (exit == "Q" || exit == "q")
                Environment.Exit(0);

           
            
            Console.Write("Enter the base to convert from: 2, 8, 10, 16: ");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine("Enter the number to convert: ");
            string n1 = Console.ReadLine();
            bool success = Int32.TryParse(n1, out int number);
            if (success)
                Console.WriteLine($"     Number : {number}, base: {from} \n");
            else
                Console.WriteLine($"     Number: {n1}, base: {from} \n");

            long result;
            string str_result;

            if (from == 2)
            {
                result = binaryToDecimal(number);
                Console.WriteLine($"Decimal conversion is {result}");
                result = binaryToOctal(number);
                Console.WriteLine($"Octal conversion is {result}");
                str_result = binaryToHex(number);
                Console.WriteLine($"Hex conversion is {str_result}");
            }

            else if (from == 8)
            {
                result = octalToBinary(number);
                Console.WriteLine($"Binary conversion is {result}");
                result = octalToDecimal(number);
                Console.WriteLine($"Decimal conversion is {result}");
                str_result = octalToHex(number);
                Console.WriteLine($"Hex conversion is {str_result}");
            }

            else if (from == 10)
            {
                result = decimalToBinary(number);
                Console.WriteLine($"Binary conversion is {result}");
                result = decimalToOctal(number);
                Console.WriteLine($"Octal conversion is {result}");
                str_result = decimalToHex(number);
                Console.WriteLine($"Hex conversion is {str_result}");
            }

            else if (from == 16)
            {
                result = hexToBinary(n1);
                Console.WriteLine($"Binary conversion is {result}");
                result = hexToOctal(n1);
                Console.WriteLine($"Octal conversion is {result}");
                result = hexToDecimal(n1);
                Console.WriteLine($"Decimal conversion is {result}");
            }
            else
                Console.WriteLine("Error in 'base to convert from'");

        }
        private static long binaryToDecimal(int number)
        {
            int dec = 0;
            int count = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                int baseToPowerOfCount = (int)Math.Pow(2, count);
                dec += remainder * baseToPowerOfCount;
                number /= 10;
                count++;
            }
            return dec;
        }

        private static long binaryToOctal(int number) 
        {
            long dec = binaryToDecimal(number);
            long octal = decimalToOctal((int)dec);
            return octal;
        }

        private static string binaryToHex(int number)
        {
            long dec = binaryToDecimal(number);
            string hex = decimalToHex((int)dec);
            return hex;
        }

        private static long octalToBinary(int number) 
        {
            long dec = octalToDecimal(number);
            long binary = decimalToBinary((int)dec);
            return binary;            
        }

        private static long octalToDecimal(int number)
        {
            int dec = 0;
            int count = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                int baseToPowerOfCount = (int)Math.Pow(8, count);
                dec += remainder * baseToPowerOfCount;
                number /= 10;
                count++;
            }
            return dec;
        }

        private static string octalToHex(int number)
        {
            long dec = octalToDecimal(number);
            string hex = decimalToHex((int)dec);
            return hex;
        }

        private static long decimalToBinary(int number)
        {
            int binary = 0;
            int count = 0;
            while (number != 0)
            {
                int remainder = number % 2;
                int baseToPowerOfCount = (int)Math.Pow(10, count);
                binary += remainder * baseToPowerOfCount;
                number /= 2;
                count++;             
            }
            return binary;
        }

        private static long decimalToOctal(int number)
        {
            int octal = 0;
            int count = 0;
            while (number != 0)
            {
                int remainder = number % 8;
                int baseToPowerOfCount = (int)Math.Pow(10, count);
                octal += remainder * baseToPowerOfCount;
                number /= 8;
                count++;
            }
            return octal;
        }

        private static string decimalToHex(int number)
        {
            string hexValue = number.ToString("X"); 
            return hexValue;

        }

        private static long hexToBinary(string n1)
        {
            long dec = hexToDecimal(n1);
            long binary = decimalToBinary((int)dec);
            return binary;

        }

        private static long hexToOctal(string n1)
        {
            long dec = hexToDecimal(n1);
            long octal = decimalToOctal((int)dec);
            return octal;
        }

        private static long hexToDecimal(string n1)
        {
            int dec = int.Parse(n1, NumberStyles.HexNumber);
            return dec;
        }
    }
}
