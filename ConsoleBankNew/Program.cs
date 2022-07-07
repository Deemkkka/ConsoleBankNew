using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankNew
{
    internal class Program
    {
               
        static void Main(string[] args)
        {
            GoApp();
            Console.ReadKey();
        }

        static void GoApp()
        {
            WelcomeUser();
        }
        
        /// <summary>
        /// Приветствие пользователя
        /// </summary>
        static void WelcomeUser()
        {
            SetTextColor(Colors.TextColor.green);
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Hello my friend! Рады тебя видеть!\n");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Для входа в личный кабинет необходимо ввести номер карты и pin");
        }


        #region Text Color
        /// <summary>
        /// Цвет текста
        /// </summary>
        /// <param name="textColors"></param>
        static void SetTextColor(Colors.TextColor textColors)
        {
            switch (textColors)
            {
                case Colors.TextColor.white:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Colors.TextColor.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Colors.TextColor.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
        }
    } 
    #endregion
}
