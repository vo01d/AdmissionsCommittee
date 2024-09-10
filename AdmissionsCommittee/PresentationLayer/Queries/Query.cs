using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    abstract class Query { // Does this class need QueryHandler?
        public string Name { get; }

        protected Query(string name) {
            Name = name;
        }

        public abstract void Execute();
    }
}
