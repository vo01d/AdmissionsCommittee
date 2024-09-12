using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    abstract class ApplicantsQuery : Query {
        protected readonly IApplicantsQueryHandler _queryHandler;

        protected ApplicantsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }
    }
}
