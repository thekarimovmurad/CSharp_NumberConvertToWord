using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NumberConvertToWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number.GetType() != typeof(int))
            {
                Console.WriteLine("Please enter number");
            }
            string[] number_to_words = new string[] {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };
            int num = 1555;
            string reversed_num = new string(num.ToString().Reverse().ToArray());
            int reversed_number = int.Parse(reversed_num);
            int numLength = (int)Math.Floor(Math.Log10(number) + 1); ;
            for (int i = -1; i <= numLength; i++)
            {
                Console.WriteLine(number_to_words[reversed_number % 10]);
                reversed_number = (reversed_number - reversed_number % 10) / 10;
                numLength--;
            }
        }
    }
}
