namespace AdmissionsCommittee.DataAccessLayer.Entities {
    public class Faculty {
        public int Id { get; }
        public string Name { get; }

        public Faculty(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
