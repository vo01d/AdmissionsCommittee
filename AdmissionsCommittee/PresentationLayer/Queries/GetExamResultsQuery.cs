using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    public class GetExamResultsQuery : ApplicantsQuery {
        public GetExamResultsQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
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
