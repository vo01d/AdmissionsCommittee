using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllSubjectsCommand : Command {
        public GetAllSubjectsCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
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
