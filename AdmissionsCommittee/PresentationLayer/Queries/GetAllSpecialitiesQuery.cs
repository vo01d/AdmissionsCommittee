using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllSpecialitiesQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllSpecialitiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var specialities = _queryHandler.GetAllSpecialities();

            Console.WriteLine("Specialities: ");
            foreach (var speciality in specialities) {
                Console.WriteLine(speciality);
            }
        }
    }
}
