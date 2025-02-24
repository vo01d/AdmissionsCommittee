namespace AdmissionsCommittee.ApplicationLayer.Views {
    public class ExamResultView {
        public required int ExamResultId { get; init; }
        public required string LastName { get; init; }
        public required string FirstName { get; init; }
        public required string MiddleName { get; init; }
        public required string SubjectName { get; init; }
        public required int Mark { get; init; }
    }
}
