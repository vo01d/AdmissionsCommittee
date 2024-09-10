using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer {
    class QueryInvoker {
        private readonly List<Query> _queries = new List<Query>();
        public int CommandsCount => _queries.Count; // Function or property?
        public IReadOnlyList<Query> Queries => _queries.AsReadOnly(); // How to return correctly immutable list???
        

        public void SetCommand(Query command) {
            _queries.Add(command);
        }

        public void ExecuteCommand(int commandNumber) {
            _queries[commandNumber - 1].Execute();
        }
    }
}
