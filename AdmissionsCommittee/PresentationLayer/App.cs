using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    class App { 
        private QueryInvoker _queryInvoker;
        private QueryHandler _queryHandler; 

        public App(QueryInvoker queryInvoker, QueryHandler queryHandler) {
            _queryInvoker = queryInvoker;
            _queryHandler = queryHandler;
            SetCommands();
        }

        private void SetCommands() {
            _queryInvoker.SetCommand(new GetAllApplicantsCommand("Print information about all applicants", _queryHandler));
            _queryInvoker.SetCommand(new GetAllApplicationsCommand("Print information about all applications", _queryHandler));
            _queryInvoker.SetCommand(new GetAllExamResultsCommand("Print information about all exam results", _queryHandler));
            _queryInvoker.SetCommand(new GetAllFacultiesCommand("Print information about all faculties", _queryHandler));
            _queryInvoker.SetCommand(new GetAllPassMarksCommand("Print information about all pass marks", _queryHandler));
            _queryInvoker.SetCommand(new GetAllSpecialitiesCommand("Print information about all specialities", _queryHandler));
            _queryInvoker.SetCommand(new GetAllSubjectsCommand("Print information about all subjects", _queryHandler));
        }

        public void Start() {
            _queryInvoker.DrawQueriesMenu();
            while (true) {
                Console.WriteLine();
                Console.Write("Enter query number: ");
                string queryNumber = Console.ReadLine() ?? "";

                try {
                    _queryInvoker.ExecuteCommand(InputValidator.ValidateInt32InRange(queryNumber, 1, _queryInvoker.GetCommandsCount()));
                }
                catch (Exception) {
                    Console.WriteLine($"Unknown query! Please enter a number in range from 1 to {_queryInvoker.GetCommandsCount()}");
                }
            }
        }
    }
}
