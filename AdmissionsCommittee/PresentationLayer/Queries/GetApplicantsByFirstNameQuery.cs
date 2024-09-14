using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetApplicantsByFirstNameQuery : ApplicantsQuery {
        public GetApplicantsByFirstNameQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine() ?? throw new ArgumentNullException();

            var applicants = _queryHandler.GetApplicantsByFirstName(firstName);

            Console.WriteLine();
            if (applicants.Any()) {
                Console.WriteLine($"Applicants with first name \"{firstName}\": ");
                ConsoleOutputHelper.WriteApplicantsTable(applicants);
            } else {
                Console.WriteLine($"No applicants found with the first name \"{firstName}\"");
                Console.WriteLine();
            }
        }
    }
}
