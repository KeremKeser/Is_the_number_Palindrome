using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string RawInputStr = Console.ReadLine();

            char[] ProcessedInputStr = new char[RawInputStr.Length];
            char[] ReversedProcessedInputStr = new char[RawInputStr.Length];
            bool succes; 

            int InputLength = 0;

            foreach (char Char in RawInputStr)
            {
                ProcessedInputStr[InputLength] = Char;
                InputLength++;
            }
            
            ReversedProcessedInputStr.CopyTo(ReversedProcessedInputStr, 0);
            Array.Reverse(ReversedProcessedInputStr);

            if (InputLength % 2 == 1)
            {
                InputLength--;
            }

            succes = true;
            for (int i = 0; i < (InputLength / 2); i++)
            {
                if (!(ProcessedInputStr[i] == ReversedProcessedInputStr[i]))
                {
                    succes = false;
                    break;
                }
            }

            if (succes)
            {
                Console.WriteLine("Sayı Palindromdur");
            }
            else
            {
                Console.WriteLine("Sayı Palindrom Değildir");
            }
        }
    }
}
