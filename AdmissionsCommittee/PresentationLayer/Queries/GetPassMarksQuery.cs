using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetPassMarksQuery : ApplicantsQuery {
        public GetPassMarksQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var passMarks = _queryHandler.GetPassMarks();

            if (passMarks.Any()) {
                Console.WriteLine("Pass marks: ");
                foreach (var passMark in passMarks) {
                    Console.WriteLine(passMark);
                }
            } else {
                Console.WriteLine($"No pass marks were found");
            }
        }
    }
}
