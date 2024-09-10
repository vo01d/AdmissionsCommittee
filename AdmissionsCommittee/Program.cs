using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer;

namespace AdmissionsCommittee {
    class Program {
        static void Main(string[] args) {
            QueryInvoker queryInvoker = new QueryInvoker();
            IApplicantsQueryHandler queryHandler = new ApplicantsDBQueryHandler();

            App app = new App(queryInvoker, queryHandler);
            app.Start();
        }
    }
}
