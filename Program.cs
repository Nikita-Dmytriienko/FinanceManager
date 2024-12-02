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
using System;
using System.IO;
using Newtonsoft.Json;


internal class Program
{
    private static void Main(string[] args)
    {
        string dataPath = "Data/data.json";
        FinanceManager financeManager = new FinanceManager(dataPath);

        while (true)
        {
            Console.WriteLine("1.Add operation");
            Console.WriteLine("2.Check the balance");
            Console.WriteLine("3.History");
            Console.WriteLine("4.Save & Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    financeManager.AddTransaction();
                    break;

                case "2":
                    financeManager.ShowBalance();
                    break;

                case "3":
                    financeManager.ShowHistory();
                    break;

                case "4":
                    financeManager.SaveTransactions();
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}








