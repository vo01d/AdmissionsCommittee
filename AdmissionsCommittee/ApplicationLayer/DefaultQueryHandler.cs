using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    class DefaultQueryHandler : QueryHandler {
        public DefaultQueryHandler(ApplicantsDB applicantsDB) : base(applicantsDB) {
        }

        public override IEnumerable<Applicant> GetAllApplicants() {
            return _applicantsDB._applicants;
        }

        public override IEnumerable<Application> GetAllApplications() {
            return _applicantsDB._applications;
        }

        public override IEnumerable<ExamResult> GetAllExamResults() {
            return _applicantsDB._examResults;
        }

        public override IEnumerable<Faculty> GetAllFaculties() {
            return _applicantsDB._faculties;
        }

        public override IEnumerable<PassMark> GetAllPassMarks() {
            return _applicantsDB._passMarks;
        }

        public override IEnumerable<Speciality> GetAllSpecialities() {
            return _applicantsDB._specialities;
        }

        public override IEnumerable<Subject> GetAllSubjects() {
            return _applicantsDB._subjects;
        }
    }
}
