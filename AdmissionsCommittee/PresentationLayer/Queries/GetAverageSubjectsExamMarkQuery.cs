using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    class GetAverageSubjectsExamMarkQuery : ApplicantsQuery {
        public GetAverageSubjectsExamMarkQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var averageSubjectsExamMark = _queryHandler.GetAverageSubjectsExamMark();

            Console.WriteLine();
            if (averageSubjectsExamMark.Any()) {
                Console.WriteLine($"Average exam mark for each subject: ");
                foreach (var averageSubjectExamMark in averageSubjectsExamMark) {
                    Console.WriteLine($"{averageSubjectExamMark.SubjectName} {averageSubjectExamMark.AverageMark}");
                }
            } else {
                Console.WriteLine($"No subjects or exam results were found");
            }
        }
    }
}
