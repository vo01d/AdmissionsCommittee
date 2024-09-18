using System.Text.Json;

namespace AdmissionsCommittee.Utils {
    static class FileOperationsHelper {
        public static T ReadJSON<T>(string filepath) {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(filepath)) 
                ?? throw new InvalidDataException("Deserialization resulted in a null object.");
        }
    }
}
