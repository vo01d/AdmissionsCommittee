using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public class GetAverageSubjectsExamMarkQuery : ApplicantsQuery {
        public GetAverageSubjectsExamMarkQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageSubjectsExamMark = _queryHandler.GetAverageSubjectsExamMark();

            Console.WriteLine();
            if (averageSubjectsExamMark.Any()) {
                Console.WriteLine($"Average exam mark for each subject: ");

                var table = new ConsoleTable("Subject name", "Average exam mark"); // ???
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var (SubjectName, AverageExamMark) in averageSubjectsExamMark) {
                    table.AddRow(SubjectName, AverageExamMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No subjects or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
