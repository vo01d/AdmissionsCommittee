using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public class GetAverageApplicantsExamMarkQuery : ApplicantsQuery {
        public GetAverageApplicantsExamMarkQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageApplicantsExamMark = _queryHandler.GetAverageApplicantsExamMark();

            Console.WriteLine();
            if (averageApplicantsExamMark.Any()) {
                Console.WriteLine($"Average exam mark for each applicant: ");

                var table = new ConsoleTable("Applicant id", "Last name", "First name", "Middle name", "Average exam mark"); 
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var (ApplicantId, LastName, FirstName, MiddleName, AverageExamMark) in averageApplicantsExamMark) {
                    table.AddRow(ApplicantId, LastName, FirstName, 
                        MiddleName, AverageExamMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No applicants or exam results were found");
                Console.WriteLine();
            }
        }
    }
}
