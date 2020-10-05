using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeWars
{
    class Program
    {
        public static int CountBits(int n)
        {
            //преобразовать десятичное число в двоичное и посчитать в нем количество символов 1 (единиц)
            int counter = 0;
            string tempString;
            tempString = Convert.ToString(n, 2);

            for (int i = 0; i < tempString.Length; i++)
            {
                if (tempString[i] == '1') //можно сравнить i-тый стринговый элемент, который будет приобразован в чаровый элемент с другим char
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234));
            Console.ReadKey();




        }
    }
}
