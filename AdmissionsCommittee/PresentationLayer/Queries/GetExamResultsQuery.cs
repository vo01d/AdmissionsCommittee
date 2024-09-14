using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetExamResultsQuery : ApplicantsQuery {
        public GetExamResultsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var examResults = _queryHandler.GetExamResults();

            if (examResults.Any()) {
                Console.WriteLine("Exam results: ");
                foreach (var examResult in examResults) {
                    Console.WriteLine(examResult);
                }
            } else {
                Console.WriteLine($"No exam results were found");
            }
        }
    }
}
