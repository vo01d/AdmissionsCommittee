using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetApplicantsQuery : ApplicantsQuery {
        public GetApplicantsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var applicants = _queryHandler.GetApplicants();

            Console.WriteLine("Applicants: ");
            foreach (var applicant in applicants) {
                Console.WriteLine(applicant);
            }
        }
    }
}
