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
            string identation;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите желаемый символ: ");
            userSymbol = Convert.ToChar(Console.Read());
            userName = $"{userSymbol} " + userName + $" {userSymbol}";
            identation = new string(userSymbol, userName.Length);
            Console.Clear();
            Console.WriteLine($"{identation}\n{userName}\n{identation}");
        }
    }
}
