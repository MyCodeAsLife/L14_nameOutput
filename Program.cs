using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_nameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSymbol;
            int identation = 4;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите желаемый символ: ");
            userSymbol = Convert.ToChar(Console.Read());

            Console.Clear();
            Console.WriteLine(new string(userSymbol, userName.Length + identation));
            Console.WriteLine($"{userSymbol} " + userName + $" {userSymbol}");
            Console.WriteLine(new string(userSymbol, userName.Length + identation));
        }
    }
}
