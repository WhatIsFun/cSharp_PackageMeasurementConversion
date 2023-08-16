namespace cSharp_PackageMeasurementConversion;
using System;
using System.Collections.Generic;
class Program
{
    static List<int> Decode(string encodedString)
    {
        List<int> encodedValues = new List<int>();
        int currentIndex = 0;

        while (currentIndex < encodedString.Length)
        {
            int count = encodedString[currentIndex] - 'a' + 1;
            currentIndex++;

            if (count == ('_' - 'a' + 1)) // Handle '_' as 0
            {
                encodedValues.Add(0);
            }
            else
            {
                string package = encodedString.Substring(currentIndex, count);
                currentIndex += count;

                int packageSum = 0;
                foreach (char character in package)
                {
                    packageSum += character - 'a' + 1;
                }
                encodedValues.Add(packageSum);
            }
        }

        return encodedValues;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the encoded string: ");
        string encodedString = Console.ReadLine();
        List<int> decodedValues = Decode(encodedString);
        Console.WriteLine("Decoded values: " + string.Join(", ", decodedValues));
    }
}