using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetApplicationsQuery : ApplicantsQuery {
        public GetApplicationsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applications = _queryHandler.GetApplications();

            if (applications.Any()) {
                Console.WriteLine("Applications: ");
                ConsoleOutputHelper.WriteApplicationViewsTable(applications);
            } else {
                Console.WriteLine($"No applications were found");
                Console.WriteLine();
            }
        }
    }
}
