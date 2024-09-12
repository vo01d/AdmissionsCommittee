using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.PresentationLayer.Queries;
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
            _queryInvoker.SetCommand(new GetApplicantsQuery("Print information about applicants", _queryHandler));
            _queryInvoker.SetCommand(new GetApplicationsQuery("Print information about applications", _queryHandler));
            _queryInvoker.SetCommand(new GetExamResultsQuery("Print information about exam results", _queryHandler));
            _queryInvoker.SetCommand(new GetFacultiesQuery("Print information about faculties", _queryHandler));
            _queryInvoker.SetCommand(new GetPassMarksQuery("Print information about pass marks", _queryHandler));
            _queryInvoker.SetCommand(new GetSpecialitiesQuery("Print information about specialities", _queryHandler));
            _queryInvoker.SetCommand(new GetSubjectsQuery("Print information about subjects", _queryHandler));
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
