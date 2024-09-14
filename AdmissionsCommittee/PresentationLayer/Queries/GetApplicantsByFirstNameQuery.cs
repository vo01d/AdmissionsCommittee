using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetApplicantsByFirstNameQuery : ApplicantsQuery {
        public GetApplicantsByFirstNameQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine() ?? throw new ArgumentNullException();

            var applicants = _queryHandler.GetApplicantsByFirstName(firstName);

            Console.WriteLine();
            if (applicants.Any()) {
                Console.WriteLine($"Applicants with first name \"{firstName}\": ");
                foreach (var applicant in applicants) {
                    Console.WriteLine(applicant);
                }
            } else {
                Console.WriteLine($"No applicants found with the first name \"{firstName}\"");
            }
        }
    }
}
