using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    abstract class QueryHandler {
        protected readonly ApplicantsDB _applicantsDB;

        public QueryHandler(ApplicantsDB applicantsDB) {
            _applicantsDB = applicantsDB;
        }

        public abstract IEnumerable<Applicant> GetAllApplicants();
        public abstract IEnumerable<ApplicationView> GetAllApplications(); 
        public abstract IEnumerable<ExamResultView> GetAllExamResults();
        public abstract IEnumerable<Faculty> GetAllFaculties();
        public abstract IEnumerable<PassMarkView> GetAllPassMarks();
        public abstract IEnumerable<SpecialityView> GetAllSpecialities();
        public abstract IEnumerable<Subject> GetAllSubjects();
    }
}
