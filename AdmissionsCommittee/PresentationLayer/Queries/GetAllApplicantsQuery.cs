using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllApplicantsQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllApplicantsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var applicants = _queryHandler.GetAllApplicants();

            Console.WriteLine("Applicants: ");
            foreach (var applicant in applicants) {
                Console.WriteLine(applicant);
            }
        }
    }
}
