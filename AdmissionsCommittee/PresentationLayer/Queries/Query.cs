namespace AdmissionsCommittee.PresentationLayer.Commands {
    public abstract class Query { 
        public string Name { get; }

        protected Query(string name) {
            Name = name;
        }

        public abstract void Execute();
    }
}
