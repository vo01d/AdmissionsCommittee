namespace AdmissionsCommittee.PresentationLayer.Commands {
    abstract class Query { 
        public string Name { get; }

        protected Query(string name) {
            Name = name;
        }

        public abstract void Execute();
    }
}
