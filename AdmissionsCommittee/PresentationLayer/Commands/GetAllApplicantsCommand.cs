using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllApplicantsCommand : Command {
        public GetAllApplicantsCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applicants = _queryHandler.GetAllApplicants();

            Console.WriteLine("Applicants: ");
            foreach (var applicant in applicants)
            {
                Console.WriteLine(applicant);
            }
        }
    }
}
