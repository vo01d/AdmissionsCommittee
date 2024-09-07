using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    class App { // ???
        private QueryInvoker _queryInvoker;
        private QueryHandler _queryHandler; // how to cover situation when we need other queryhandler???

        public App(QueryInvoker queryInvoker, QueryHandler queryHandler) {
            _queryInvoker = queryInvoker;
            _queryHandler = queryHandler;
            SetCommands();
        }

        private void SetCommands() { // ???
            _queryInvoker.SetCommand(new GetAllApplicantsCommand("Print information about all applicants", _queryHandler));
            _queryInvoker.SetCommand(new GetAllApplicantsOrderByAgeAscCommand("Print information sorted by birthday in ascending order about all applicants ", _queryHandler));
        } 

        public void Start() {
            do {
                Console.Clear();

                _queryInvoker.DrawQueriesMenu();

                Console.WriteLine();
                Console.Write("Enter query number: ");
                string queryNumber = Console.ReadLine() ?? "";

                try {
                    _queryInvoker.ExecuteCommand(InputValidator.ValidateInt32InRange(queryNumber, 1, _queryInvoker.GetCommandsCount()));
                }
                catch (Exception) {
                    Console.WriteLine($"Unknown query! Please enter a number in range from 1 to {_queryInvoker.GetCommandsCount()}");
                }

                Console.WriteLine();
                Console.WriteLine("Press <ESC> to exit or any other key to continue...");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
