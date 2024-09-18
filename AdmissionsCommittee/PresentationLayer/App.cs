using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    class App {
        private readonly QueryInvoker _queryInvoker;

        public App(QueryInvoker queryInvoker) {
            _queryInvoker = queryInvoker;
        }

        public void StartExecution() {
            ConsoleOutputHelper.WriteQueriesMenu(_queryInvoker.Queries);
            Console.WriteLine();

            while (true) {
                Console.Write("Enter query number: ");
                string userInput = Console.ReadLine() ?? throw new ArgumentNullException();

                int queryNumber;
                try {
                    queryNumber = InputValidationHelper.ValidateInt32InRange(userInput, 1, _queryInvoker.CommandsCount);
                }
                catch (FormatException) {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                    continue;
                }
                catch (Exception ex) when (ex is ArgumentOutOfRangeException || ex is OverflowException) {
                    Console.WriteLine($"Unknown query number! Please enter a number in range from 1 to {_queryInvoker.CommandsCount}.");
                    continue;
                }

                _queryInvoker.ExecuteCommand(queryNumber);
            }
        }
    }
}
