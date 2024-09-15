using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetFacultiesQuery : ApplicantsQuery {
        public GetFacultiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var faculties = _queryHandler.GetFaculties();

            if (faculties.Any()) {
                Console.WriteLine("Faculties: ");
                ConsoleOutputHelper.WriteFacultiesTable(faculties);
            } else {
                Console.WriteLine($"No faculties were found");
                Console.WriteLine();
            }
        }
    }
}
