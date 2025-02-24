using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    public class GetPassMarksQuery : ApplicantsQuery {
        public GetPassMarksQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var passMarks = _queryHandler.GetPassMarks();

            if (passMarks.Any()) {
                Console.WriteLine("Pass marks: ");
                ConsoleOutputHelper.WritePassMarkViewsTable(passMarks);
            } else {
                Console.WriteLine($"No pass marks were found");
                Console.WriteLine();
            }
        }
    }
}
