using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public class GetSubjectsPassCountQuery : ApplicantsQuery {
        public GetSubjectsPassCountQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var subjectsPassCount = _queryHandler.GetSubjectsPassCount();

            Console.WriteLine();
            if (subjectsPassCount.Any()) {
                Console.WriteLine($"Pass count for each subject: ");

                var table = new ConsoleTable("Subject name", "Pass count");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var (SubjectName, PassCount) in subjectsPassCount) {
                    table.AddRow(SubjectName, PassCount);
                }
                table.Write();
            } else {
                Console.WriteLine($"No subjects or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
