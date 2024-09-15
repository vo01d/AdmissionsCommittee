using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetNumberOfApplicantsInEachFacultyQuery : ApplicantsQuery {
        public GetNumberOfApplicantsInEachFacultyQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var numberOfApplicantsInEachFaculty = _queryHandler.GetNumberOfApplicantsInEachFaculty();

            Console.WriteLine();
            if (numberOfApplicantsInEachFaculty.Any()) {
                Console.WriteLine($"Number of applicants in each faculty: ");

                var table = new ConsoleTable("Faculty name", "Number of applicants");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var numberOfApplicantsInFaculty in numberOfApplicantsInEachFaculty) {
                    table.AddRow(numberOfApplicantsInFaculty.FacultyName, numberOfApplicantsInFaculty.NumberOfApplicants);
                }
                table.Write();
            } else {
                Console.WriteLine($"No faculties or applicants were found");
                Console.WriteLine();
            }
        }
    }
}
