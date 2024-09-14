using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer {
    class App { // how to correcly implement that class?
        private readonly QueryInvoker _queryInvoker;
        private readonly IApplicantsQueryHandler _queryHandler; 

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
            _queryInvoker.SetCommand(new GetApplicantsByFirstNameQuery("Print information about applicants with specified first name",
                _queryHandler));
            _queryInvoker.SetCommand(new GetExamResultsEqualOrAboveQuery("Print information about applicants exam results that " +
                "equal or greater than specified number", _queryHandler));
            _queryInvoker.SetCommand(new GetAverageSubjectsExamMarkQuery("Print average exam mark for each subject", _queryHandler));
        }

        public void Start() {
            DisplayHelper.DisplayQueriesMenu(_queryInvoker.Queries);

            while (true) {
                Console.WriteLine();
                Console.Write("Enter query number: ");
                string userInput = Console.ReadLine() ?? throw new ArgumentNullException();

                int queryNumber;
                try {
                    queryNumber = InputValidator.ValidateInt32InRange(userInput, 1, _queryInvoker.CommandsCount);
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
