using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.PresentationLayer;

namespace AdmissionsCommittee {
    class Program {
        static void Main(string[] args) {
            try {
                QueryInvoker queryInvoker = new QueryInvoker();
                HardCodedApplicantsDB hardCodedApplicantsDB = new HardCodedApplicantsDB();
                QueryHandler queryHandler = new DefaultQueryHandler(hardCodedApplicantsDB);

                App app = new App(queryInvoker, queryHandler);
                app.Start();
            }
            catch (Exception ex) {
                Console.WriteLine($"Critical error: {ex.Message}");
            }
        }
    }
}
