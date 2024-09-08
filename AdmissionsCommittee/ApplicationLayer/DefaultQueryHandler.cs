using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.ApplicationLayer {
    class DefaultQueryHandler : QueryHandler {
        public DefaultQueryHandler(ApplicantsDB applicantsDB) : base(applicantsDB) {
        }

        public override IEnumerable<Applicant> GetAllApplicants() {
            return _applicantsDB._applicants;
        }

        public override IEnumerable<ApplicationView> GetAllApplications() {
            return from application in _applicantsDB._applications
                   join applicant in _applicantsDB._applicants on application.ApplicantId equals applicant.Id
                   join speciality in _applicantsDB._specialities on application.SpecialityId equals speciality.Id
                   join faculty in _applicantsDB._faculties on speciality.FacultyId equals faculty.Id
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
            
            //return _applicantsDB._applications
            //    .Join(
            //        _applicantsDB._applicants,
            //        application => application.ApplicantId,
            //        applicant => applicant.Id,
            //        (application, applicant) => new { application, applicant }
            //    )
            //    .Join(
            //        _applicantsDB._specialities,
            //        combinedTable => combinedTable.application.SpecialityId,
            //        speciality => speciality.Id,
            //        (combinedTable, speciality) => new { combinedTable, speciality }
            //    )
            //    .Join(
            //        _applicantsDB._faculties,
            //        combinedTable => combinedTable.speciality.FacultyId,
            //        faculty => faculty.Id,
            //        (combinedTable, faculty) => new ApplicationView {
            //            ApplicationId = combinedTable.combinedTable.application.Id,
            //            ApplicationDate = combinedTable.combinedTable.application.ApplicationDate,
            //            Lastname = combinedTable.combinedTable.applicant.LastName,
            //            FirstName = combinedTable.combinedTable.applicant.FirstName,
            //            MiddleName = combinedTable.combinedTable.applicant.MiddleName,
            //            SpecialityNumber = combinedTable.speciality.Number,
            //            SpecialityName = combinedTable.speciality.Name,
            //            FacultyName = faculty.Name

            //        }
            //    );
        }

        public override IEnumerable<ExamResultView> GetAllExamResults() {
            return from examResult in _applicantsDB._examResults
                   join applicant in _applicantsDB._applicants on examResult.ApplicantId equals applicant.Id
                   join subject in _applicantsDB._subjects on examResult.SubjectId equals subject.Id
                   select new ExamResultView {
                       ExamResultId = examResult.Id,
                       Lastname = applicant.LastName,
                       FirstName = applicant.FirstName,
                       MiddleName = applicant.MiddleName,
                       SubjectName = subject.Name,
                       Mark = examResult.Mark
                   };
        }

        public override IEnumerable<Faculty> GetAllFaculties() {
            return _applicantsDB._faculties;
        }

        public override IEnumerable<PassMarkView> GetAllPassMarks() {
            return from passMark in _applicantsDB._passMarks
                   join speciality in _applicantsDB._specialities on passMark.SpecialityId equals speciality.Id
                   join faculty in _applicantsDB._faculties on speciality.FacultyId equals faculty.Id
                   join subject in _applicantsDB._subjects on passMark.SubjectId equals subject.Id
                   select new PassMarkView {
                       PassMarkId = passMark.Id,
                       SpecialityNumber = speciality.Number,
                       SpecialityName = speciality.Name,
                       FacultyName = faculty.Name,
                       SubjectName = subject.Name,
                       Mark = passMark.Mark
                   };
        }

        public override IEnumerable<SpecialityView> GetAllSpecialities() {
            return from speciality in _applicantsDB._specialities
                   join faculty in _applicantsDB._faculties on speciality.FacultyId equals faculty.Id
                   select new SpecialityView {
                       SpecialityId = speciality.Id,
                       SpecialityNumber = speciality.Number,
                       SpecialityName = speciality.Name,
                       FacultyName= faculty.Name,
                   };
        }

        public override IEnumerable<Subject> GetAllSubjects() {
            return _applicantsDB._subjects;
        }
    }
}
