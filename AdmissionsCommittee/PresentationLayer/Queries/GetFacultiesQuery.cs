using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetFacultiesQuery : ApplicantsQuery {
        public GetFacultiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var faculties = _queryHandler.GetFaculties();

            Console.WriteLine("Faculties: ");
            foreach (var faculty in faculties) {
                Console.WriteLine(faculty);
            }
        }
    }
}
