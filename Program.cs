/*1. Цели проекта

Создать консольное приложение на C# для ведения учёта личных финансов с возможностью добавления расходов/доходов и просмотра баланса.

2. Основные функции

Добавление доходов и расходов.

Просмотр общего баланса.

История операций.

Фильтрация операций по дате.

3. Технические требования

Язык: C#

Среда разработки: Visual Studio или VS Code.

Используемые концепции: классы, коллекции, работа с файлами для сохранения данных.

4. Шаги разработки

Шаг 1: Создание структуры проекта

Создайте новый проект типа Console Application.

Назовите проект, например, "FinanceTracker".*/
using CS02_12_24.Models;


internal class Program
{
    public static void Run()
    {
        string dataPath = "Data/data.json";
        FinanceManager financeManager = new FinanceManager(dataPath);

        while (true)
        {
            Console.Write("Choose an option: ");
            Console.WriteLine("1. Add operation");
            Console.WriteLine("2. Check the balance");
            Console.WriteLine("3. History");
            Console.WriteLine("4. Save & Exit");
            Console.WriteLine("5. Clear history");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        financeManager.AddTransaction();
                        break;
                    }

                case "2":
                    {
                        financeManager.ShowBalance();
                        break;
                    }

                case "3":
                    {
                        financeManager.ShowHistory();
                        break;
                    }
                case "4":
                    {
                        financeManager.SaveTransactions();
                        Console.WriteLine("Exit.");
                        return;
                    }
                case "5":
                    {
                        financeManager.ClearHistory();
                        break;
                    }
                default:
                    Console.WriteLine("TRY AGAIN.");
                    break;
            }
        }
    }
    public static void Main(string[] args)
    {
        Run();

        
    }
}








