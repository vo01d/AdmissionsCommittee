using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    public class UIHandler {
        private readonly QueryInvoker _queryInvoker;

        public UIHandler(QueryInvoker queryInvoker) {
            _queryInvoker = queryInvoker;
        }

        public void Start() {
            ConsoleOutputHelper.WriteQueriesMenu(_queryInvoker.Queries);
            Console.WriteLine();

            while (true) {
                Console.Write("Enter query number: ");
                string userInput = Console.ReadLine() ?? throw new ArgumentNullException();

                int queryNumber;
                try {
                    queryNumber = ToInt32Parser.ParseInRange(userInput, 1, _queryInvoker.CommandsCount);
                }
                catch (FormatException) {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                    continue;
                }
                catch (Exception ex) when (ex is ArgumentOutOfRangeException || ex is OverflowException) {
                    Console.WriteLine($"Unknown query number! Please enter a number in range from 1 to {_queryInvoker.CommandsCount}.");
                    continue;
                }

                _queryInvoker.ExecuteQuery(queryNumber);
            }
        }
    }
}
