using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllExamResultsCommand : Command {
        public GetAllExamResultsCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
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
