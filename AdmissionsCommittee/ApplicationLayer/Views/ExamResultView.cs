namespace AdmissionsCommittee.ApplicationLayer.Views {
    class ExamResultView {
        public required int ExamResultId { get; init; }
        public required string Lastname { get; init; }
        public required string FirstName { get; init; }
        public required string MiddleName { get; init; }
        public required string SubjectName { get; init; }
        public required int Mark { get; init; }

        public override string ToString() {
            return $"{ExamResultId} {Lastname} {FirstName} {MiddleName} {SubjectName} {Mark}";
        }
    }
}
