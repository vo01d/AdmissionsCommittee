using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public abstract class ApplicantsQuery : Query {
        protected readonly IApplicantsQueryService _queryHandler;

        protected ApplicantsQuery(string name, IApplicantsQueryService queryHandler) : base(name) {
            _queryHandler = queryHandler;
        }
    }
}
