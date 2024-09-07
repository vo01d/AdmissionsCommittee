namespace AdmissionsCommittee.DataAccessLayer {
    class Applicant {
        public int Id { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public DateOnly Birthday { get; }
        public string PhoneNumber { get; }

        public Applicant(int id, string lastName, string firstName, string middleName, DateOnly birthday, string phoneNumber) {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
        }

        public override string ToString() {
            return $"{Id} {LastName} {FirstName} {MiddleName} {Birthday} {PhoneNumber}";
        }
    }
}
