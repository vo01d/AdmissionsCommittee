using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetExamResultsQuery : ApplicantsQuery {
        public GetExamResultsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var examResults = _queryHandler.GetExamResults();

            if (examResults.Any()) {
                Console.WriteLine("Exam results: ");
                ConsoleOutputHelper.WriteExamResultViewsTable(examResults);
            } else {
                Console.WriteLine($"No exam results were found");
                Console.WriteLine();
            }
        }
    }
}
