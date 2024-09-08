namespace AdmissionsCommittee.DataAccessLayer.Entities {
    class Speciality {
        public int Id { get; }
        public int Number { get; }
        public string Name { get; }
        public int FacultyId { get; }

        public Speciality(int id, int number, string name, int facultyId) {
            Id = id;
            Number = number;
            Name = name;
            FacultyId = facultyId;
        }

        public override string ToString() {
            return $"{Id} {Number} {Name} {FacultyId}";
        }
    }
}
