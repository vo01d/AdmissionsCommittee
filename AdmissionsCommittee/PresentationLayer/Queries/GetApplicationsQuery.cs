using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    public class GetApplicationsQuery : ApplicantsQuery {
        public GetApplicationsQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
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
