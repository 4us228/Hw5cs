using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
   public static class Message    {
        #region Задание 2
        private static string[] separators = { ",", ".", "!", "?", "-", ";", ":", " " };
        //Задание 2.А
        public static void Printwords(string message,int countLeters)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length < countLeters) Console.WriteLine(words[i]);
            }


        }
        //Задание 2.Б
        public static void DeleteLastSymbol(string message, char symbol)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length-1] != symbol)
                {
                    sb.Append(words[i] + " ");
                }
            
            
           }
           
        Console.WriteLine(sb.ToString());
        
        
        }
        //Задание 2.В и Г (решил совместить)
        public static void MaxLength(string message)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int maximumLenght=0, index=0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maximumLenght) 
                {
                    maximumLenght = words[i].Length; 
                    index=i;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Length == maximumLenght)
                {
                    stringBuilder.Append(words[i] + " ");
                }
            }
            Console.WriteLine($"Слово с максимальным количеством символов: {words[index]}");
            Console.WriteLine("Слова с максимальным количеством символов:");
            Console.WriteLine(stringBuilder.ToString());
        }
        #endregion
    }
}

