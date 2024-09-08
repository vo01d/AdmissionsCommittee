namespace AdmissionsCommittee.ApplicationLayer.Views {
    class PassMarkView {
        public required int PassMarkId { get; init; }
        public required int SpecialityNumber { get; init; }
        public required string SpecialityName { get; init; }
        public required string FacultyName { get; init; }
        public required string SubjectName { get; init; }
        public required int Mark { get; init; }

        public override string ToString() {
            return $"{PassMarkId} {SpecialityNumber} {SpecialityName} {FacultyName} {SubjectName} {Mark}";
        }
    }
}
