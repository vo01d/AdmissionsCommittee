using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer {
    class QueryInvoker {
        public List<Query> Queries { get; } = new List<Query>();
        public int CommandsCount => Queries.Count; 
        
        public void SetCommand(Query command) {
            Queries.Add(command);
        }

        public void ExecuteCommand(int commandNumber) {
            Queries[commandNumber - 1].Execute();
        }
    }
}
