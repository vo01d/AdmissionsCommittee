using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.DataAccessLayer {
    interface IApplicantDB {
        IEnumerable<Applicant> Applicants { get; }
        IEnumerable<Application> Applications { get; }
        IEnumerable<ExamResult> ExamResults { get; }
        IEnumerable<Faculty> Faculties { get; }
        IEnumerable<PassMark> PassMarks { get; }
        IEnumerable<Speciality> Specialities { get; }
        IEnumerable<Subject> Subjects { get; }
    }
}
