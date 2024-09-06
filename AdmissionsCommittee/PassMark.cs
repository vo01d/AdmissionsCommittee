namespace AdmissionsCommittee {
    class PassMark {
        public int _id { get; set; }
        public int _specialityId { get; set; }
        public int _subjectId { get; set; }
        public int _mark { get; set; }

        public PassMark(int id, int specialityId, int subjectId, int mark) {
            _id = id;
            _specialityId = specialityId;
            _subjectId = subjectId;
            _mark = mark;
        }
    }
}
