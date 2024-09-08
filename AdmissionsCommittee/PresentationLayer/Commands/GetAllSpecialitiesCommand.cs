using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllSpecialitiesCommand : Command {
        public GetAllSpecialitiesCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
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
