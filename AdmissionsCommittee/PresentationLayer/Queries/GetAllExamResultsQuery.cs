using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllExamResultsQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllExamResultsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var examResults = _queryHandler.GetAllExamResults();

            Console.WriteLine("Exam results: ");
            foreach (var examResult in examResults) {
                Console.WriteLine(examResult);
            }
        }
    }
}
