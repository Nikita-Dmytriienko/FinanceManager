namespace CS02_12_24.Models
{
    public class RunProgram()
    {
        public static void Run()
        {
            string dataPath = "Data/data.json";
            FinanceManager financeManager = new FinanceManager(dataPath);

            while (true)
            {
                Console.Write("Choose an option: \n");
                Console.WriteLine("1. Add operation");
                Console.WriteLine("2. Check the balance");
                Console.WriteLine("3. History");
                Console.WriteLine("4. Clear history");
                Console.WriteLine("5. Save & Exit");

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
                            financeManager.ClearHistory();
                            break;
                        }
                    case "5":
                        {

                            financeManager.SaveTransactions();
                            Console.WriteLine("Exit.");
                            return;
                        }
                    default:
                        Console.WriteLine("TRY AGAIN.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}