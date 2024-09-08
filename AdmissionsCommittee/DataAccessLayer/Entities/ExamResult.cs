namespace AdmissionsCommittee.DataAccessLayer.Entities {
    class ExamResult {
        public int Id { get; }
        public int ApplicantId { get; }
        public int SubjectId { get; }
        public int Mark { get; }

        public ExamResult(int id, int applicantId, int subjectId, int mark) {
            Id = id;
            ApplicantId = applicantId;
            SubjectId = subjectId;
            Mark = mark;
        }

        public override string ToString() {
            return $"{Id} {ApplicantId} {SubjectId} {Mark}";
        }
    }
}
