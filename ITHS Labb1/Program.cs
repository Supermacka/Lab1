using System;

namespace ITHS_Labb1
{
    class Program
    {
        //Lab1 - Hitta tal i sträng med tecken
        // ”29535123p48723487597645723645”
        static void Main(string[] args)
        {
            SubstringFinder("29535123p48723487597645723645");
        }

        static void SubstringFinder(string stringInput)
        {
            int indexFound; 
            int firstIndex = 0;
            int lastIndex = 0;
             
            string concatenateSubStrings = "";
            double subStringTotal = 0;

            for (int x = 0; x < stringInput.Length; x++)
            {
                concatenateSubStrings = "";
                indexFound = 1;

                for (int y = x + 1; y < stringInput.Length; y++)
                {
                    if (!Char.IsNumber(stringInput[y]) && !Char.IsLetter(stringInput[y]) && stringInput[y] != ' ')
                    {
                        Console.WriteLine("The string that is entered must contain only numbers, letters and/or spaces.");
                        return;
                    }

                    if (Char.IsLetter(stringInput[y]))
                    {
                        break;
                    }

                    if (stringInput[x] == stringInput[y] && y > x)
                    {
                        indexFound++;

                        if (indexFound == 2)
                        {
                            firstIndex = x;
                            lastIndex = y;

                            PrintSubString();
                            Console.WriteLine();

                            subStringTotal += Convert.ToDouble(concatenateSubStrings);
                        }
                    }
                }
            }

            void PrintSubString()
            {
                for (int i = 0; i < stringInput.Length; i++)
                {
                    if (i >= firstIndex && i <= lastIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        concatenateSubStrings += stringInput[i];
                    }

                    Console.Write(stringInput[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (subStringTotal > 0)
            {
                Console.WriteLine($"The sum is: {subStringTotal}");
            }
            else
            {
                Console.WriteLine($"No duplicates were found");
            }
        }
    }
}
