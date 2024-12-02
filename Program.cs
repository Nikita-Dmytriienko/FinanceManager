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
    public static object JsonConvert { get; private set; }

    private static void Main(string[] args)
    {
        string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
        List<Transaction> transactions = new List<Transaction>();

        if (File.Exists(dataPath))
        {
            transactions = JsonConvert.DeserializeObject<List<Transaction>>(File.ReadAllText(dataPath));
        }
        else
        {
            Console.WriteLine("Файл данных не найден. Будет создан новый файл при сохранении.");
        }
        while (true)
        {
            Console.WriteLine("1.Add operation");
            Console.WriteLine("2.Check the balance");
            Console.WriteLine("3.History");
            Console.WriteLine("4.Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTransaction(transactions);
                    break;

                case "2":
                    ShowBalance(transactions);
                    break;

                case "3":
                    ShowHistory(transactions);
                    break;

                case "4":
                    File.WriteAllText(dataPath, JsonConvert.SerializeObject(transactions));
                    Console.WriteLine("Данные успешно сохранены.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;


            }
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = 100,
                Type = "Доход",
                Description = "Зарплата"
            });




        }

    }
}






