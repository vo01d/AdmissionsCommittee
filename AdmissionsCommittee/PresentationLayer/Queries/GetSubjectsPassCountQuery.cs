using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetSubjectsPassCountQuery : ApplicantsQuery {
        public GetSubjectsPassCountQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var subjectsPassCount = _queryHandler.GetSubjectsPassCount();

            Console.WriteLine();
            if (subjectsPassCount.Any()) {
                Console.WriteLine($"Pass count for each subject: ");

                var table = new ConsoleTable("Subject name", "Pass count");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var subjectPassCount in subjectsPassCount) {
                    table.AddRow(subjectPassCount.SubjectName, subjectPassCount.PassCount);
                }
                table.Write();
            } else {
                Console.WriteLine($"No subjects or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
