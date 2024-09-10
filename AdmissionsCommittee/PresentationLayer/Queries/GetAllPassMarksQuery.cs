using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllPassMarksQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllPassMarksQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var passMarks = _queryHandler.GetAllPassMarks();

            Console.WriteLine("Pass marks: ");
            foreach (var passMark in passMarks) {
                Console.WriteLine(passMark);
            }
        }
    }
}
