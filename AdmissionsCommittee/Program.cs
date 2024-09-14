using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.PresentationLayer;

namespace AdmissionsCommittee {
    class Program {
        static void Main(string[] args) {
            QueryInvoker queryInvoker = new QueryInvoker();
            ManualApplicantsDB manualApplicantsDB = new ManualApplicantsDB();
            IApplicantsQueryHandler queryHandler = new ApplicantsDBQueryHandler(manualApplicantsDB);

            App app = new App(queryInvoker, queryHandler);
            app.Start();
        }
    }
}
