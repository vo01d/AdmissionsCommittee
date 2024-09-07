using AdmissionsCommittee.DataAccessLayer;

namespace AdmissionsCommittee.ApplicationLayer {
    class DefaultQueryHandler : QueryHandler {
        public DefaultQueryHandler(ApplicantsDB applicantsDB) : base(applicantsDB) {
        }

        public override IEnumerable<Applicant> getAllApplicants() {
            return _applicantsDB._applicants;
        }

        public override IEnumerable<Applicant> getAllApplicantsOrderByAgeAsc() {
            return from applicant in _applicantsDB._applicants
                   orderby applicant.Birthday
                   select applicant;
        }
    }
}
