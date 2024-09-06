namespace AdmissionsCommittee {
    class ExamResult {
        public int _id { get; set; }
        public int _applicantId { get; set; }
        public int _subjectId { get; set; }
        public int _mark { get; set; }

        public ExamResult(int id, int applicantId, int subjectId, int mark) {
            _id = id;
            _applicantId = applicantId;
            _subjectId = subjectId;
            _mark = mark;
        }
    }
}
