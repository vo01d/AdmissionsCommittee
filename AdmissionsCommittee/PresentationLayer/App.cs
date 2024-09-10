using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    class App { // how to correcly implement that class?
        private QueryInvoker _queryInvoker;
        private IApplicantsQueryHandler _queryHandler; 

        public App(QueryInvoker queryInvoker, IApplicantsQueryHandler queryHandler) {
            _queryInvoker = queryInvoker;
            _queryHandler = queryHandler;
            SetCommands();
        }

        private void SetCommands() {
            _queryInvoker.SetCommand(new GetAllApplicantsQuery("Print information about all applicants", _queryHandler));
            _queryInvoker.SetCommand(new GetAllApplicationsQuery("Print information about all applications", _queryHandler));
            _queryInvoker.SetCommand(new GetAllExamResultsQuery("Print information about all exam results", _queryHandler));
            _queryInvoker.SetCommand(new GetAllFacultiesQuery("Print information about all faculties", _queryHandler));
            _queryInvoker.SetCommand(new GetAllPassMarksQuery("Print information about all pass marks", _queryHandler));
            _queryInvoker.SetCommand(new GetAllSpecialitiesQuery("Print information about all specialities", _queryHandler));
            _queryInvoker.SetCommand(new GetAllSubjectsQuery("Print information about all subjects", _queryHandler));
        }

        public void Start() {
            DisplayHelper.DisplayQueriesMenu(_queryInvoker.Queries);
            while (true) {
                Console.WriteLine();
                Console.Write("Enter query number: ");
                string queryNumber = Console.ReadLine() ?? "";

                try {
                    _queryInvoker.ExecuteCommand(InputValidator.ValidateInt32InRange(queryNumber, 1, _queryInvoker.CommandsCount));
                }
                catch (Exception) {
                    Console.WriteLine($"Unknown query! Please enter a number in range from 1 to {_queryInvoker.CommandsCount}");
                }
            }
        }
    }
}
