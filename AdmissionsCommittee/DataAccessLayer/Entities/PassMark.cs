namespace AdmissionsCommittee.DataAccessLayer.Entities {
    class PassMark {
        public int Id { get; }
        public int SpecialityId { get; }
        public int SubjectId { get; }
        public int Mark { get; }

        public PassMark(int id, int specialityId, int subjectId, int mark) {
            Id = id;
            SpecialityId = specialityId;
            SubjectId = subjectId;
            Mark = mark;
        }

        public override string ToString() {
            return $"{Id} {SpecialityId} {SubjectId} {Mark}";
        }
    }
}
