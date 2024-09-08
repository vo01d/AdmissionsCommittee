using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllApplicationsCommand : Command {
        public GetAllApplicationsCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
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
