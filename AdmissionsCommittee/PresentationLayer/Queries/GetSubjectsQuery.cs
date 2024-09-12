using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetSubjectsQuery : ApplicantsQuery {
        public GetSubjectsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var subjects = _queryHandler.GetSubjects();

            Console.WriteLine("Subjects: ");
            foreach (var subject in subjects) {
                Console.WriteLine(subject);
            }
        }
    }
}
