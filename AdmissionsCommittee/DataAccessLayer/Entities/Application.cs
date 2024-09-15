namespace AdmissionsCommittee.DataAccessLayer.Entities {
    class Application {
        public int Id { get; }
        public DateOnly ApplicationDate { get; }
        public int ApplicantId { get; }
        public int SpecialityId { get; }

        public Application(int id, DateOnly applicationDate, int applicantId, int specialityId) {
            Id = id;
            ApplicationDate = applicationDate;
            ApplicantId = applicantId;
            SpecialityId = specialityId;
        }
    }
}
