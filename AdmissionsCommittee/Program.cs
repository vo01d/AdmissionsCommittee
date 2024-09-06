namespace AdmissionsCommittee {
    class Program {
        static void Main(string[] args) {
            try {
                QueryInvoker queryInvoker = new QueryInvoker();
                do {
                    Console.Clear();

                    Console.WriteLine("Queries:");
                    Console.WriteLine("1. Print all information about applicants");
                    Console.WriteLine("2. Print all applicants sorted by birthday(asc)");

                    Console.Write("Enter query number: ");
                    string queryNumber = Console.ReadLine(); // як це правильно обробити
                    switch (queryNumber) {
                        case "1": {
                            Console.WriteLine("\nApplicants: ");
                            queryInvoker.SetCommand(new GetAllApplicantsCommand());
                            break;
                        }
                        case "2": {
                            Console.WriteLine("\nApplicants sorted by birthday(asc): ");
                            queryInvoker.SetCommand(new GetAllApplicantsOrderByAgeAscCommand());
                            break;
                        }
                        default: {
                            Console.WriteLine($"Unknown query!");
                            Console.WriteLine("Press <ESC> to exit or any other key to continue...");
                            continue;
                        }
                    }
                    queryInvoker.ExecuteCommand();

                    Console.WriteLine("Press <ESC> to exit or any other key to continue...");
                }
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
