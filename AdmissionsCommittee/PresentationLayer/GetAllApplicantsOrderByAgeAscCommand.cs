using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer {
    class GetAllApplicantsOrderByAgeAscCommand : Command {
        public GetAllApplicantsOrderByAgeAscCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applicants = _queryHandler.getAllApplicantsOrderByAgeAsc();

            Console.WriteLine("Applicants sorted by birthday in ascending order");
            foreach (var applicant in applicants) {
                Console.WriteLine(applicant);
            }
        }
    }
}
