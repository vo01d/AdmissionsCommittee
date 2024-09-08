using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    abstract class QueryHandler {
        protected readonly ApplicantsDB _applicantsDB;

        public QueryHandler(ApplicantsDB applicantsDB) {
            _applicantsDB = applicantsDB;
        }

        public abstract IEnumerable<Applicant> GetAllApplicants();
        public abstract IEnumerable<Application> GetAllApplications();
        public abstract IEnumerable<ExamResult> GetAllExamResults();
        public abstract IEnumerable<Faculty> GetAllFaculties();
        public abstract IEnumerable<PassMark> GetAllPassMarks();
        public abstract IEnumerable<Speciality> GetAllSpecialities();
        public abstract IEnumerable<Subject> GetAllSubjects();
    }
}
