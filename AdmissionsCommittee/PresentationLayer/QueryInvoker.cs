using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer {
    public class QueryInvoker {
        public List<Query> Queries { get; } = [];
        public int CommandsCount => Queries.Count; 
        
        public QueryInvoker SetQuery(Query command) {
            Queries.Add(command);
            return this;
        }

        public void ExecuteQuery(int commandNumber) {
            Queries[commandNumber - 1].Execute();
        }
    }
}
