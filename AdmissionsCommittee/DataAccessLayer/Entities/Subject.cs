namespace AdmissionsCommittee.DataAccessLayer.Entities {
    class Subject {
        public int Id { get; }
        public string Name { get; }

        public Subject(int id, string name) {
            Id = id;
            Name = name;
        }

        public override string ToString() {
            return $"{Id} {Name}";
        }
    }
}
