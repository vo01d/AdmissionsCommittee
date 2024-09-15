using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetSubjectsLowestExamMarkQuery : ApplicantsQuery {
        public GetSubjectsLowestExamMarkQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var subjectsLowestExamMark = _queryHandler.GetSubjectsLowestExamMark();

            Console.WriteLine();
            if (subjectsLowestExamMark.Any()) {
                Console.WriteLine($"The lowest exam mark for each subject: ");

                var table = new ConsoleTable("Subject name", "Lowest exam mark");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var subjectLowestExamMark in subjectsLowestExamMark) {
                    table.AddRow(subjectLowestExamMark.SubjectName, subjectLowestExamMark.LowestExamMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No subjects or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
