using AdmissionsCommittee.DataAccessLayer;

namespace AdmissionsCommittee.ApplicationLayer {
    abstract class QueryHandler {
        protected readonly ApplicantsDB _applicantsDB;

        public QueryHandler(ApplicantsDB applicantsDB) {
            _applicantsDB = applicantsDB;
        }

        public abstract IEnumerable<Applicant> getAllApplicants();
        public abstract IEnumerable<Applicant> getAllApplicantsOrderByAgeAsc();
    }
}
