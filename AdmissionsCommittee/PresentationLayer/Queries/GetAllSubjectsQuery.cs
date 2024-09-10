using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllSubjectsQuery : Query {
        private readonly IApplicantsQueryHandler _queryHandler;
        public GetAllSubjectsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }

        public override void Execute() {
            var subjects = _queryHandler.GetAllSubjects();

            Console.WriteLine("Subjects: ");
            foreach (var subject in subjects) {
                Console.WriteLine(subject);
            }
        }
    }
}
