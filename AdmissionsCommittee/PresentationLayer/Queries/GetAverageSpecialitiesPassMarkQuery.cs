using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public class GetAverageSpecialitiesPassMarkQuery : ApplicantsQuery {
        public GetAverageSpecialitiesPassMarkQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageSpecialitiesExamMark = _queryHandler.GetAverageSpecialitiesPassMark();

            Console.WriteLine();
            if (averageSpecialitiesExamMark.Any()) {
                Console.WriteLine($"Average pass mark for each speciality: ");

                var table = new ConsoleTable("Speciality number", "Speciality name", "Faculty name", "Average pass mark");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var (SpecialityNumber, SpecialityName, FacultyName, AveragePassMark) in averageSpecialitiesExamMark) {
                    table.AddRow(SpecialityNumber, SpecialityName,
                        FacultyName, AveragePassMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No specialities or pass marks were found");
                Console.WriteLine();
            }
        }
    }
}
