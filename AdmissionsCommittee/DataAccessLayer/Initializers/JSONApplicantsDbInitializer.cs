using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.Utils;

namespace AdmissionsCommittee.DataAccessLayer.Initializers {
    class JSONApplicantsDbInitializer : IDbInitializer<ApplicantsDb> {
        private readonly string _dataFolderPath;

        public JSONApplicantsDbInitializer(string dataFolderPath) {
            _dataFolderPath = dataFolderPath;
        }

        public void Initialize(ApplicantsDb applicantsDB) {
            applicantsDB.Applicants = FileOperationsHelper.ReadJSON<List<Applicant>>(Path.Combine(_dataFolderPath, "Applicants.json"));
            applicantsDB.Applications = FileOperationsHelper.ReadJSON<List<Application>>(Path.Combine(_dataFolderPath, "Applications.json"));
            applicantsDB.ExamResults = FileOperationsHelper.ReadJSON<List<ExamResult>>(Path.Combine(_dataFolderPath, "ExamResults.json"));
            applicantsDB.Faculties = FileOperationsHelper.ReadJSON<List<Faculty>>(Path.Combine(_dataFolderPath, "Faculties.json"));
            applicantsDB.PassMarks = FileOperationsHelper.ReadJSON<List<PassMark>>(Path.Combine(_dataFolderPath, "PassMarks.json"));
            applicantsDB.Specialities = FileOperationsHelper.ReadJSON<List<Speciality>>(Path.Combine(_dataFolderPath, "Specialities.json"));
            applicantsDB.Subjects = FileOperationsHelper.ReadJSON<List<Subject>>(Path.Combine(_dataFolderPath, "Subjects.json"));
        }
    }
}
