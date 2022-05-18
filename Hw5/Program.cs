using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    /// <summary>
    /// Выполнил Цубера Кристиан
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Привет меня зовут аня и елтонд";
            string enterlog;
            Console.WriteLine("Здравствуйте введите ваш логин");
            enterlog = Console.ReadLine();
            if (checkLogin(enterlog)) Console.WriteLine("Логин неверный");
            if (!checkLogin(enterlog)) Console.WriteLine("Логин принят");
            Console.ReadKey();

            Message.DeleteLastSymbol(test, 'я');
            Console.ReadLine();
            Message.MaxLength(test);
            Console.ReadLine();
        }







        #region Задание 1
        static bool checkLogin(string login)
            {
                char[] log = login.ToCharArray();

                for (int i = 0; i < log.Length; i++)
                {
                    if (!char.IsLetterOrDigit(log[i]) || char.IsDigit(log[0]) || log.Length < 2 || log.Length > 10)
                    {
                        return true;
                    }
                }
                return false;
            }

        #endregion






    }
}