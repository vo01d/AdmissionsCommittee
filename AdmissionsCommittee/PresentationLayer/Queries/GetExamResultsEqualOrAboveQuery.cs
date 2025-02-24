using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.PresentationLayer.Queries {
    public class GetExamResultsEqualOrAboveQuery : ApplicantsQuery {
        private const int MinMark = 1;
        private const int MaxMark = 100;
        public GetExamResultsEqualOrAboveQuery(string name, IApplicantsQueryService queryHandler) : base(name, queryHandler) {
        }

        public override void Execute() {
            int lowerBound = GetValidLowerBound();
            var examResults = _queryHandler.GetExamResultsEqualOrAbove(lowerBound);

            Console.WriteLine();
            if (examResults.Any()) {
                Console.WriteLine($"Exam results equal or greater to {lowerBound}: ");
                ConsoleOutputHelper.WriteExamResultViewsTable(examResults);
            } else {
                Console.WriteLine($"No exam results found that equal or greater than {lowerBound}");
                Console.WriteLine();
            }
        }

        private static int GetValidLowerBound() {
            while (true) {
                Console.Write($"Enter lower bound mark in range from {MinMark} to {MaxMark}: ");
                string input = Console.ReadLine() ?? throw new ArgumentNullException();

                try {
                    int lowerBound = ToInt32Parser.ParseInRange(input, MinMark, MaxMark);
                    return lowerBound;
                }
                catch (FormatException) {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }
                catch (ArgumentOutOfRangeException) {
                    Console.WriteLine($"Invalid lower bound mark! Please enter a number in range from {MinMark} to {MaxMark}.");
                }
            }
        }
    }
}
