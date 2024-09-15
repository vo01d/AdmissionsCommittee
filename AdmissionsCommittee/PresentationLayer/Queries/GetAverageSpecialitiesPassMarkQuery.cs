using AdmissionsCommittee.ApplicationLayer;
using ConsoleTables;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetAverageSpecialitiesPassMarkQuery : ApplicantsQuery {
        public GetAverageSpecialitiesPassMarkQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageSpecialitiesExamMark = _queryHandler.GetAverageSpecialitiesPassMark();

            Console.WriteLine();
            if (averageSpecialitiesExamMark.Any()) {
                Console.WriteLine($"Average pass mark for each speciality: ");

                var table = new ConsoleTable("Speciality number", "Speciality name", "Faculty name", "Average pass mark");
                table.Configure(tableOptions => tableOptions.EnableCount = false);
                foreach (var averageSpecialityExamMark in averageSpecialitiesExamMark) {
                    table.AddRow(averageSpecialityExamMark.SpecialityNumber, averageSpecialityExamMark.SpecialityName,
                        averageSpecialityExamMark.FacultyName, averageSpecialityExamMark.AveragePassMark);
                }
                table.Write();
            } else {
                Console.WriteLine($"No specialities or pass marks were found");
                Console.WriteLine();
            }
        }
    }
}
