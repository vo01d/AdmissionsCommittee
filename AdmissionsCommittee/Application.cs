namespace AdmissionsCommittee {
    class Application {
        public int _id { get; set; }
        public DateOnly _applicationDate { get; set; }
        public int _applicantId { get; set; }
        public int _specialityId { get; set; }

        public Application(int id, DateOnly applicationDate, int applicantId, int specialityId) {
            _id = id;
            _applicationDate = applicationDate;
            _applicantId = applicantId;
            _specialityId = specialityId;
        }
    }
}
