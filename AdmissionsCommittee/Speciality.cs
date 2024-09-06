namespace AdmissionsCommittee {
    class Speciality {
        public int _id { get; set; }
        public int _number { get; set; }
        public string _name { get; set; }
        public int _facultyId { get; set; }

        public Speciality(int id, int number, string name, int facultyId) {
            _id = id;
            _number = number;
            _name = name;
            _facultyId = facultyId;
        }
    }
}
