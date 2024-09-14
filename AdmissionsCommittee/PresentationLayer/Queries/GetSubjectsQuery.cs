using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.PresentationLayer.Queries;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    class GetSubjectsQuery : ApplicantsQuery {
        public GetSubjectsQuery(string name, IApplicantsQueryHandler queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            var subjects = _queryHandler.GetSubjects();

            if (subjects.Any()) {
                Console.WriteLine("Subjects: ");
                ConsoleOutputHelper.WriteSubjecsTable(subjects);
            } else {
                Console.WriteLine($"No subjects were found");
                Console.WriteLine();
            }
        }
    }
}
