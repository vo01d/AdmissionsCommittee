using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.DataAccessLayer {
    abstract class ApplicantsDB {
        public readonly List<Applicant> _applicants = new List<Applicant>();
        public readonly List<Application> _applications = new List<Application>();
        public readonly List<ExamResult> _examResults = new List<ExamResult>();
        public readonly List<Faculty> _faculties = new List<Faculty>();
        public readonly List<PassMark> _passMarks = new List<PassMark>();
        public readonly List<Speciality> _specialities = new List<Speciality>();
        public readonly List<Subject> _subjects = new List<Subject>();
    }
}
