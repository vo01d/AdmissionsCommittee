using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllFacultiesCommand : Command {
        public GetAllFacultiesCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
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
