using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.DataAccessLayer.Initializers;

namespace AdmissionsCommittee.DataAccessLayer {
    class ApplicantsDb {
        public IEnumerable<Applicant> Applicants { get; set; } = [];
        public IEnumerable<Application> Applications { get; set; } = [];
        public IEnumerable<ExamResult> ExamResults { get; set; } = [];
        public IEnumerable<Faculty> Faculties { get; set; } = [];
        public IEnumerable<PassMark> PassMarks { get; set; } = [];
        public IEnumerable<Speciality> Specialities { get; set; } = [];
        public IEnumerable<Subject> Subjects { get; set; } = [];

        public ApplicantsDb(IDbInitializer<ApplicantsDb> initializer) {
            initializer.Initialize(this);
        }
    }
}
