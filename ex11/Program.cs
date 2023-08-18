using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Console.Write("Введите кол-во рублей: ");
            int rubWallet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во долларов: ");
            int usdWallet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во евро: ");
            int eurWallet = Convert.ToInt32(Console.ReadLine());

            while (isOpen)
            {
                Console.WriteLine("Какую валюты вы хотите сконвертировать?\n1 - Рубли\n2 - Доллары\n3 - Евро\n4 - выйти из программы.");
                int chosenOperation1 = Convert.ToInt32(Console.ReadLine());
                switch (chosenOperation1)
                {
                    case 1:
                        Console.WriteLine("В какую валюты вы хотите сконвертировать рубли?\n1 - Доллары\n2 - Евро\n3 - вернуться назад");
                        int chosenOperation2 = Convert.ToInt32(Console.ReadLine());

                        switch (chosenOperation2)
                        {
                            case 1:

                                break;
                        }

                        break;
                }

            }
        }
    }
}
