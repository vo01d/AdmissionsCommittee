namespace AdmissionsCommittee.ApplicationLayer.Views {
    class ApplicationView {
        public required int ApplicationId { get; init; }
        public required DateOnly ApplicationDate { get; init; }
        public required string Lastname { get; init; }
        public required string FirstName { get; init; }
        public required string MiddleName { get; init; }
        public required int SpecialityNumber { get; init; }
        public required string SpecialityName { get; init; }
        public required string FacultyName { get; init; }

        public override string ToString() {
            return $"{ApplicationId} {ApplicationDate} {Lastname} {FirstName} {MiddleName} {SpecialityNumber} {SpecialityName} {FacultyName}"; 
        }
    }
}
