using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.Utils {
    static class DisplayHelper {
        public static void DisplayQueriesMenu(IEnumerable<Query> queries) { 
            Console.WriteLine("Queries menu: ");
            foreach (var (query, index) in queries.Select((query, index) => (query, index))) { 
                Console.WriteLine($"{index + 1}. {query.Name}");
            }
        }
    }
}
