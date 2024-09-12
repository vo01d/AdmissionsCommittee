using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetApplicationsQuery : ApplicantsQuery {
        public GetApplicationsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applications = _queryHandler.GetApplications();

            Console.WriteLine("Applications: ");
            foreach (var applicantion in applications) {
                Console.WriteLine(applicantion);
            }
        }
    }
}
