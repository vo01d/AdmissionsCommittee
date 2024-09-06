namespace AdmissionsCommittee {
    class Applicant {
        public int _id { get; set; }
        public string _lastName { get; set; }
        public string _firstName { get; set; }
        public string _middleName { get; set; }
        public DateOnly _birthday { get; set; }
        public string _phoneNumber { get; set; }

        public Applicant(int id, string lastName, string firstName, string middleName, DateOnly birthday, string phoneNumber) {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthday = birthday;
            _phoneNumber = phoneNumber;
        }
    }
}
