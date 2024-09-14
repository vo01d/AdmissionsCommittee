using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetApplicationsQuery : ApplicantsQuery {
        public GetApplicationsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applications = _queryHandler.GetApplications();

            if (applications.Any()) {
                Console.WriteLine("Applications: ");
                foreach (var applicantion in applications) {
                    Console.WriteLine(applicantion);
                }
            } else {
                Console.WriteLine($"No applications were found");
            }
        }
    }
}
