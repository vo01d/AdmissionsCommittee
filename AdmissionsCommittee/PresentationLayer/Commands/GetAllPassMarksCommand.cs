using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetAllPassMarksCommand : Command {
        public GetAllPassMarksCommand(string name, QueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var passMarks = _queryHandler.GetAllPassMarks();

            Console.WriteLine("Pass marks: ");
            foreach (var passMark in passMarks) {
                Console.WriteLine(passMark);
            }
        }
    }
}
