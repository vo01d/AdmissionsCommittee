using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    interface IApplicantsQueryHandler {
        IEnumerable<Applicant> GetApplicants();
        IEnumerable<ApplicationView> GetApplications();
        IEnumerable<ExamResultView> GetExamResults();
        IEnumerable<Faculty> GetFaculties();
        IEnumerable<PassMarkView> GetPassMarks();
        IEnumerable<SpecialityView> GetSpecialities();
        IEnumerable<Subject> GetSubjects();
        IEnumerable<Applicant> GetApplicantsByFirstName(string firstName);
        IEnumerable<ExamResultView> GetExamResultsEqualOrAbove(int lowerBound);
        IEnumerable<(string SubjectName, double AverageExamMark)> GetAverageSubjectsExamMark();
        IEnumerable<(int ApplicantId, string LastName, string FirstName, string MiddleName, double AverageExamMark)> GetAverageApplicantsExamMark();
        IEnumerable<(int SpecialityNumber, string SpecialityName, string FacultyName, double AveragePassMark)> GetAverageSpecialitiesPassMark();
        IEnumerable<(string FacultyName, int NumberOfApplicants)> GetNumberOfApplicantsInEachFaculty();
        IEnumerable<(string SubjectName, int PassCount)> GetSubjectsPassCount();
        IEnumerable<(string SubjectName, int LowestExamMark)> GetSubjectsLowestExamMark();
    }
}
