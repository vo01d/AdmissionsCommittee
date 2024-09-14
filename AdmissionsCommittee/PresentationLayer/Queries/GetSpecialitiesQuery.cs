using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetSpecialitiesQuery : ApplicantsQuery {
        public GetSpecialitiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var specialities = _queryHandler.GetSpecialities();

            if (specialities.Any()) {
                Console.WriteLine("Specialities: ");
                foreach (var speciality in specialities) {
                    Console.WriteLine(speciality);
                }
            } else {
                Console.WriteLine($"No specialities were found");
            }
        }
    }
}
