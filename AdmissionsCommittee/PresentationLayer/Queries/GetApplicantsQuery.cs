using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetApplicantsQuery : ApplicantsQuery {
        public GetApplicantsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applicants = _queryHandler.GetApplicants();

            if (applicants.Any()) {
                Console.WriteLine("Applicants: ");
                ConsoleOutputHelper.WriteApplicantsTable(applicants);
            } else {
                Console.WriteLine($"No applicants were found");
                Console.WriteLine();
            }
        }
    }
}
