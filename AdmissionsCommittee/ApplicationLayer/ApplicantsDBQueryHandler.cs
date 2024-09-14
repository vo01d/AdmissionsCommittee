using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    class ApplicantsDBQueryHandler : IApplicantsQueryHandler {
        private readonly IApplicantDB _applicantsDB;

        public ApplicantsDBQueryHandler(IApplicantDB applicantDB) {
            _applicantsDB = applicantDB;
        }

        public IEnumerable<Applicant> GetApplicants() {
            return _applicantsDB.Applicants;
        }

        public IEnumerable<ApplicationView> GetApplications() {
            return from application in _applicantsDB.Applications
                   join applicant in _applicantsDB.Applicants on application.ApplicantId equals applicant.Id
                   join speciality in _applicantsDB.Specialities on application.SpecialityId equals speciality.Id
                   join faculty in _applicantsDB.Faculties on speciality.FacultyId equals faculty.Id
                   select new ApplicationView {
                       ApplicationId = application.Id,
                       ApplicationDate = application.ApplicationDate,
                       Lastname = applicant.LastName,
                       FirstName = applicant.FirstName,
                       MiddleName = applicant.MiddleName,
                       SpecialityNumber = speciality.Number,
                       SpecialityName = speciality.Name,
                       FacultyName = faculty.Name
                   };
        }

        public IEnumerable<ExamResultView> GetExamResults() {
            return from examResult in _applicantsDB.ExamResults
                   join applicant in _applicantsDB.Applicants on examResult.ApplicantId equals applicant.Id
                   join subject in _applicantsDB.Subjects on examResult.SubjectId equals subject.Id
                   select new ExamResultView {
                       ExamResultId = examResult.Id,
                       Lastname = applicant.LastName,
                       FirstName = applicant.FirstName,
                       MiddleName = applicant.MiddleName,
                       SubjectName = subject.Name,
                       Mark = examResult.Mark
                   };
        }

        public IEnumerable<Faculty> GetFaculties() {
            return _applicantsDB.Faculties;
        }

        public IEnumerable<PassMarkView> GetPassMarks() {
            return from passMark in _applicantsDB.PassMarks
                   join speciality in _applicantsDB.Specialities on passMark.SpecialityId equals speciality.Id
                   join faculty in _applicantsDB.Faculties on speciality.FacultyId equals faculty.Id
                   join subject in _applicantsDB.Subjects on passMark.SubjectId equals subject.Id
                   select new PassMarkView {
                       PassMarkId = passMark.Id,
                       SpecialityNumber = speciality.Number,
                       SpecialityName = speciality.Name,
                       FacultyName = faculty.Name,
                       SubjectName = subject.Name,
                       Mark = passMark.Mark
                   };
        }

        public IEnumerable<SpecialityView> GetSpecialities() {
            return from speciality in _applicantsDB.Specialities
                   join faculty in _applicantsDB.Faculties on speciality.FacultyId equals faculty.Id
                   select new SpecialityView {
                       SpecialityId = speciality.Id,
                       SpecialityNumber = speciality.Number,
                       SpecialityName = speciality.Name,
                       FacultyName = faculty.Name,
                   };
        }

        public IEnumerable<Subject> GetSubjects() {
            return _applicantsDB.Subjects;
        }

        public IEnumerable<(string SubjectName, double AverageMark)> GetAverageSubjectsExamMark() {
            return from examResult in GetExamResults()
                   group examResult by examResult.SubjectName into examResultGroup
                   select (
                       SubjectName: examResultGroup.Key,
                       AverageMark: examResultGroup.Average(examResultGroup => examResultGroup.Mark)
                   );
        }

        public IEnumerable<Applicant> GetApplicantsByFirstName(string firstName) {
            return _applicantsDB.Applicants.Where(applicant => applicant.FirstName == firstName);
        }

        public IEnumerable<ExamResultView> GetExamResultsEqualOrAbove(int lowerBound) {
            return GetExamResults().Where(examResult => examResult.Mark >= lowerBound);
        }
    }
}
