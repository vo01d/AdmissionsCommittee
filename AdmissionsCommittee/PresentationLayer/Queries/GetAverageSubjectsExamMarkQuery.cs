using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetAverageSubjectsExamMarkQuery : ApplicantsQuery {
        public GetAverageSubjectsExamMarkQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageSubjectsExamMark = _queryHandler.GetAverageSubjectsExamMark();

            Console.WriteLine();
            if (averageSubjectsExamMark.Any()) {
                Console.WriteLine($"Average exam mark for each subject: ");

                var table = new ConsoleTable("Subject name", "Average exam mark"); // ???
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var averageSubjectExamMark in averageSubjectsExamMark) {
                    table.AddRow(averageSubjectExamMark.SubjectName, averageSubjectExamMark.AverageExamMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No subjects or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
