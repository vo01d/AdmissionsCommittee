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
                       LastName = applicant.LastName,
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

        public IEnumerable<Applicant> GetApplicantsByFirstName(string firstName) {
            return _applicantsDB.Applicants.Where(applicant => applicant.FirstName == firstName);
        }

        public IEnumerable<ExamResultView> GetExamResultsEqualOrAbove(int lowerBound) {
            return GetExamResults().Where(examResult => examResult.Mark >= lowerBound);
        }

        public IEnumerable<(string SubjectName, double AverageExamMark)> GetAverageSubjectsExamMark() {
            return from examResult in GetExamResults()
                   group examResult by examResult.SubjectName into examResultGroup
                   select (
                       SubjectName: examResultGroup.Key,
                       AverageMark: examResultGroup.Average(examResult => examResult.Mark)
                   );
        }

        public IEnumerable<(int ApplicantId, string LastName, string FirstName, string MiddleName, double AverageExamMark)>
            GetAverageApplicantsExamMark() {
            return from examResult in _applicantsDB.ExamResults
                   join applicant in _applicantsDB.Applicants on examResult.ApplicantId equals applicant.Id
                   group examResult by new {
                       applicant.Id,
                       applicant.LastName,
                       applicant.FirstName,
                       applicant.MiddleName
                   } into examResultGroupByApplicant
                   select (
                        ApplicantID: examResultGroupByApplicant.Key.Id,
                        LastName: examResultGroupByApplicant.Key.LastName,
                        FirstName: examResultGroupByApplicant.Key.FirstName,
                        MiddleName: examResultGroupByApplicant.Key.MiddleName,
                        AverageExamMark: examResultGroupByApplicant.Average(examResult => examResult.Mark)
                   );
        }

        public IEnumerable<(int SpecialityNumber, string SpecialityName, string FacultyName, double AveragePassMark)>
            GetAverageSpecialitiesPassMark() {
            return from passMark in GetPassMarks()
                   group passMark by new {
                       passMark.SpecialityNumber,
                       passMark.SpecialityName,
                       passMark.FacultyName
                   } into passMarkGroupBySpeciality
                   select (
                        SpecialityNumber: passMarkGroupBySpeciality.Key.SpecialityNumber,
                        SpecialityName: passMarkGroupBySpeciality.Key.SpecialityName,
                        FacultyName: passMarkGroupBySpeciality.Key.FacultyName,
                        AveragePassMark: passMarkGroupBySpeciality.Average(passMark => passMark.Mark)
                   );
        }

        public IEnumerable<(string FacultyName, int NumberOfApplicants)> GetNumberOfApplicantsInEachFaculty() {
            return from application in _applicantsDB.Applications
                   join speciality in _applicantsDB.Specialities on application.SpecialityId equals speciality.Id
                   join faculty in _applicantsDB.Faculties on speciality.FacultyId equals faculty.Id
                   group application by faculty.Name into facultyApplicationGroup
                   select (
                        FacultyName: facultyApplicationGroup.Key,
                        NumberOfApplicants: facultyApplicationGroup
                                            .Select(application => application.ApplicantId)
                                            .Distinct()
                                            .Count()
                   );
        }

        public IEnumerable<(string SubjectName, int PassCount)> GetSubjectsPassCount() {
            return from examResult in _applicantsDB.ExamResults
                   join subject in _applicantsDB.Subjects on examResult.SubjectId equals subject.Id
                   group examResult by subject.Name into examResultGroupBySubject
                   select (
                        SubjectName: examResultGroupBySubject.Key,
                        PassCount: examResultGroupBySubject
                                    .Select(examResult => examResult.ApplicantId)
                                    .Distinct()
                                    .Count()
                   );
        }

        public IEnumerable<(string SubjectName, int LowestExamMark)> GetSubjectsLowestExamMark() {
            return from examResult in _applicantsDB.ExamResults
                   join subject in _applicantsDB.Subjects on examResult.SubjectId equals subject.Id
                   group examResult.Mark by subject.Name into examMarkGroupBySubject
                   select (
                        SubjectName: examMarkGroupBySubject.Key,
                        LowestExamMark: examMarkGroupBySubject.Min()
                   );
        }
    }
}
