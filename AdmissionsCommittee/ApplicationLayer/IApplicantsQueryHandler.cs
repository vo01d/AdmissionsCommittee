using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    interface IApplicantsQueryHandler {
        IEnumerable<Applicant> GetAllApplicants();
        IEnumerable<ApplicationView> GetAllApplications(); 
        IEnumerable<ExamResultView> GetAllExamResults();
        IEnumerable<Faculty> GetAllFaculties();
        IEnumerable<PassMarkView> GetAllPassMarks();
        IEnumerable<SpecialityView> GetAllSpecialities();
        IEnumerable<Subject> GetAllSubjects();
    }
}
