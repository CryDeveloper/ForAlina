using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlina.Classes
{
    internal class Zad2
    {
        private static string myString;

        public Zad2()
        {
            Console.WriteLine("Введите строку");
            myString = Console.ReadLine();
        }
        static void ReverseString()
        {
            string reverseString = ""; //строка в которой будут буквы перевернуты
            string[] masStr = myString.Split(' '); //разделяешь исходную строку на слова по пробелам
            foreach (string word in masStr) //проходишь каждое слово
            {
                char[] array = word.ToCharArray(); //преобразовываешь строку в массив символов
                Array.Reverse(array); //переворачиваешь массив символов
                reverseString += new String(array) + ' '; //преобразовываешь полученный массив символов в строку и прибавляешь к reverseString
            }
            myString = reverseString;
        }
        public override string ToString()
        {
            ReverseString();
            return myString;
        }
    }
}
