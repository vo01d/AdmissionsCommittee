using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetSpecialitiesQuery : ApplicantsQuery {
        public GetSpecialitiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var specialities = _queryHandler.GetSpecialities();

            if (specialities.Any()) {
                Console.WriteLine("Specialities: ");
                ConsoleOutputHelper.WriteSpecialityViewsTable(specialities);   
            } else {
                Console.WriteLine($"No specialities were found");
                Console.WriteLine();
            }
        }
    }
}
