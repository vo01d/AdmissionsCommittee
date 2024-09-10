using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllFacultiesQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllFacultiesQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var faculties = _queryHandler.GetAllFaculties();

            Console.WriteLine("Faculties: ");
            foreach (var faculty in faculties) {
                Console.WriteLine(faculty);
            }
        }
    }
}
