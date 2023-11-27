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
            char userSymbol;
            string frame;
            string userName;
            string formatedInput;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите желаемый символ: ");
            userSymbol = Convert.ToChar(Console.Read());
            formatedInput = $"{userSymbol} " + userName + $" {userSymbol}";
            frame = new string(userSymbol, formatedInput.Length);
            Console.Clear();
            Console.WriteLine($"{frame}\n{formatedInput}\n{frame}");
        }
    }
}
