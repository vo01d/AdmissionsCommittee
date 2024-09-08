namespace AdmissionsCommittee.ApplicationLayer.Views {
    class SpecialityView {
        public required int SpecialityId { get; init; }
        public required int SpecialityNumber { get; init; }
        public required string SpecialityName { get; init; }
        public required string FacultyName { get; init; }

        public override string ToString() {
            return $"{SpecialityId} {SpecialityNumber} {SpecialityName} {FacultyName}";
        }
    }
}
