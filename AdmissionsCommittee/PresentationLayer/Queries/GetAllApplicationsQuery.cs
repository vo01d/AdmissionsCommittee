using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllApplicationsQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllApplicationsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var applications = _queryHandler.GetAllApplications();

            Console.WriteLine("Applications: ");
            foreach (var applicantion in applications) {
                Console.WriteLine(applicantion);
            }
        }
    }
}
