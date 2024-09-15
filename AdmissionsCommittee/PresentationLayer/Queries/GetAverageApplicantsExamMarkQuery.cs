using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetAverageApplicantsExamMarkQuery : ApplicantsQuery {
        public GetAverageApplicantsExamMarkQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageApplicantsExamMark = _queryHandler.GetAverageApplicantsExamMark();

            Console.WriteLine();
            if (averageApplicantsExamMark.Any()) {
                Console.WriteLine($"Average exam mark for each applicant: ");

                var table = new ConsoleTable("Applicant id", "Last name", "First name", "Middle name", "Average exam mark"); 
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var averageApplicantExamMark in averageApplicantsExamMark) {
                    table.AddRow(averageApplicantExamMark.ApplicantId, averageApplicantExamMark.LastName, averageApplicantExamMark.FirstName, 
                        averageApplicantExamMark.MiddleName, averageApplicantExamMark.AverageExamMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No applicants or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
