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
        IEnumerable<(string SubjectName, double AverageMark)> GetAverageSubjectsExamMark();
        IEnumerable<Applicant> GetApplicantsByFirstName(string firstName);
        IEnumerable<ExamResultView> GetExamResultsEqualOrAbove(int lowerBound);
    }
}
