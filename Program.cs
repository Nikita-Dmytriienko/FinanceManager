﻿
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

public class Transaction
{
    DateTime Date { get; set; }
    decimal Amount { get; set; }
    public string Type { get; set; }
    string Description { get; set; }


}

public class FinanceManager
{
    public void AddTransaction(decimal amount, string type, string description)
    {

    }
    decimal GetBalance()
    {
        return 
    }

        private void ShowHistory()
    {

    }


}







class Main
{
    static void main(String[] args)
    {
        Console.WriteLine("Hello, World!");

    }
}






