using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigthFridge = 0;
            int widthFridge = 0;
            int depthFridge = 0;
            int heigthDoors = 0;
            int widthDoors = 0;


            Console.WriteLine("Вас вiтає помiчник квартирного крадiя! \nДавайте дiзнаємось, чи можна винести великогабаратну технiку!\n");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("\nЩо Ви хочете винести в першу чергу?");
            string userIn = Console.ReadLine();
            string userInput = userIn.ToLower();

            switch (userInput)
            {
                case "холодильник":
                    Console.WriteLine("Отже, щоб дiзнатись чи можливо винести {0}, менi потрiбно знати його розмiри.\n", userInput);
                    break;

                default:
                    Console.WriteLine("Не зрозумiв, що ви мали наувазi...\nМожливо, ви хочете винести холодильник?(yes/no)");
                    string askUser = Console.ReadLine();
                    switch (askUser)
                    {
                        case "yes":
                            Console.WriteLine("Отже, щоб дiзнатись чи можливо винести холодильник, менi потрiбно знати його розмiри.\n");
                            break;
                        default:
                            Console.WriteLine("Ви щось не те ввели, краще тiкайте з цiєї хати поки не пiзно...");
                            Console.ReadKey();
                            return;
                    }
                    break;
            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Будь-ласка, вимiряйте основнi габарити холодильника та розмiри дверей (використовуйте одиницi вимiру - сантиметри)");

            Console.Write("Введiть висоту холодильника: ");
            heigthFridge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть ширину холодильника: ");
            widthFridge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть глибину холодильника: ");
            depthFridge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.Write("Ви хочете винести холодильник через дверi?(yes/no)");
            string userThink = Console.ReadLine();

            switch (userThink)
            {
                case "yes":
                    Console.Write("Введiть висоту дверей: ");
                    heigthDoors = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введiть ширину дверей: ");
                    widthDoors = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Тобто нi? Я в таких експериментах участi не беру!");
                    Console.ReadKey();
                    return;
            }

            int comfHeigth = heigthDoors - 10;
            int comfWidth = widthDoors - 5;

            if ((heigthFridge < (comfHeigth)) && (widthFridge < comfWidth))
            {
                Console.WriteLine("Так, цей холодильник можна винести через данi дверi!");
            }
            else if ((heigthFridge < comfHeigth) && (depthFridge < comfWidth))
            {
                Console.WriteLine("Так, цей холодильник можна винести через данi дверi, але потрiбно його повернути боком!");
            }
            else if ((comfHeigth > widthFridge) && (comfWidth > depthFridge))
            {
                Console.WriteLine("Так, якщо холодильник спочатку покласти, перевернути на бiк i в такому положеннi виносити!");
            }
            else if ((comfHeigth > depthFridge) && (comfWidth > widthFridge))
            {
                Console.WriteLine("Так, якщо холодильник спочатку покласти i в такому положеннi виносити!");
            }
            else
            {
                Console.WriteLine("Нi, так не пройде!");
            }
            Console.ReadKey();
        }
    }
}
