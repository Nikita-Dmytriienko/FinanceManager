﻿/*1. Цели проекта

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
using System.Transactions;


internal class Program
{
    string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
    private static void Main(string[] args)
    {


        File.WriteAllText("Data/data.json", JsonConvert.SerializeObject(transactions));
        if (File.Exists("Data/data.json"))
        {
            transactions = JsonConvert.DeserializeObject<List<Transaction>>(File.ReadAllText("Data/data.json"));
        }

        while (true)
        {
            Console.WriteLine("1.Add operation");
            Console.WriteLine("2.Check the balance");
            Console.WriteLine("3.History");
            Console.WriteLine("4.Exit");
            string choice=Console.ReadLine();

            switch (choice)
            {
                case "1":

                    break;

                    case "2":

                        break;

                    case "3":

                    break;

                    case "4":

                    return;
                 
           
            }





        }

    }
}






