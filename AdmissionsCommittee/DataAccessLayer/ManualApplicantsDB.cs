using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.DataAccessLayer { 
    class ManualApplicantsDB : IApplicantDB {
        private readonly List<Applicant> _applicants;
        private readonly List<Application> _applications;
        private readonly List<ExamResult> _examResults;
        private readonly List<Faculty> _faculties;
        private readonly List<PassMark> _passMarks;
        private readonly List<Speciality> _specialities;
        private readonly List<Subject> _subjects;

        public IEnumerable<Applicant> Applicants => _applicants;
        public IEnumerable<Application> Applications => _applications;
        public IEnumerable<ExamResult> ExamResults => _examResults;
        public IEnumerable<Faculty> Faculties => _faculties;
        public IEnumerable<PassMark> PassMarks => _passMarks;
        public IEnumerable<Speciality> Specialities => _specialities;
        public IEnumerable<Subject> Subjects => _subjects;

        public ManualApplicantsDB() {
            _applicants = new List<Applicant> {
                new Applicant(id: 1, lastName: "Ivanov", firstName: "Ivan", middleName: "Ivanovich", birthday: new DateOnly(1990, 5, 15), 
                    phoneNumber: "+380671234567"),
                new Applicant(id: 2, lastName: "Petrov", firstName: "Petr", middleName: "Petrovich", birthday: new DateOnly(1992, 8, 23), 
                    phoneNumber: "+380671234568"),
                new Applicant(id : 3, lastName: "Sidorov", firstName: "Ivan", middleName: "Sidorovich", birthday: new DateOnly(1991, 10, 5), 
                    phoneNumber: "+380671234569"),
                new Applicant(id: 4, lastName: "Koval", firstName: "Mykola", middleName: "Orestovych", birthday: new DateOnly(1993, 11, 30), 
                    phoneNumber: "+380671234570"),
                new Applicant(id: 5, lastName: "Shevchenko", firstName: "Taras", middleName: "Hryhorovych", birthday: new DateOnly(1985, 3, 9), 
                    phoneNumber: "+380671234571")
            };
            _applications = new List<Application> {
                new Application(id: 1, applicationDate: new DateOnly(2024, 1, 10), applicantId: 1, specialityId: 1),
                new Application(id: 2, applicationDate: new DateOnly(2024, 1, 12), applicantId: 2, specialityId: 2),
                new Application(id: 3, applicationDate: new DateOnly(2024, 1, 15), applicantId: 3, specialityId: 3),
                new Application(id: 4, applicationDate: new DateOnly(2024, 1, 20), applicantId: 4, specialityId: 4),
                new Application(id: 5, applicationDate: new DateOnly(2024, 1, 25), applicantId: 5, specialityId: 5)
            };
            _examResults = new List<ExamResult> {
                new ExamResult(id: 1, applicantId: 1, subjectId: 1, mark: 85),
                new ExamResult(id: 2, applicantId: 1, subjectId: 2, mark: 75),
                new ExamResult(id: 3, applicantId: 2, subjectId: 1, mark: 90),
                new ExamResult(id: 4, applicantId: 2, subjectId: 3, mark: 80),
                new ExamResult(id: 5, applicantId: 3, subjectId: 2, mark: 88),
                new ExamResult(id: 6, applicantId: 3, subjectId: 4, mark: 70),
                new ExamResult(id: 7, applicantId: 4, subjectId: 4, mark: 85),
                new ExamResult(id: 8, applicantId: 4, subjectId: 5, mark: 90),
                new ExamResult(id: 9, applicantId: 5, subjectId: 3, mark: 95),
                new ExamResult(id: 10, applicantId: 5, subjectId: 5, mark: 75)
            };
            _faculties = new List<Faculty> {
                new Faculty(id: 1, name: "Computer Science"),
                new Faculty(id: 2, name: "Mechanical Engineering"),
                new Faculty(id: 3, name: "Civil Engineering"),
                new Faculty(id: 4, name: "Electrical Engineering")
            };
            _passMarks = new List<PassMark> {
                new PassMark(id: 1, specialityId: 1, subjectId: 1, mark: 80),
                new PassMark(id: 2, specialityId: 1, subjectId: 2, mark: 80),
                new PassMark(id: 3, specialityId: 1, subjectId: 3, mark: 85),
                new PassMark(id: 4, specialityId: 2, subjectId: 1, mark: 70),
                new PassMark(id: 5, specialityId: 2, subjectId: 4, mark: 75),
                new PassMark(id: 6, specialityId: 3, subjectId: 2, mark: 80),
                new PassMark(id: 7, specialityId: 3, subjectId: 4, mark: 70),
                new PassMark(id: 8, specialityId: 4, subjectId: 5, mark: 75)
            };
            _specialities = new List<Speciality> {
                new Speciality(id: 1, number: 101, name: "Software Engineering", facultyId: 1),
                new Speciality(id: 2, number: 201, name: "Automotive Engineering", facultyId: 2),
                new Speciality(id: 3, number: 301, name: "Structural Engineering", facultyId: 3),
                new Speciality(id: 4, number: 401, name: "Power Systems Engineering", facultyId: 4)
            };
            _subjects = new List<Subject> {
                new Subject(id: 1, name: "Mathematics"),
                new Subject(id: 2, name: "Physics"),
                new Subject(id: 3, name: "Programming"),
                new Subject(id: 4, name: "Mechanics"),
                new Subject(id: 5, name: "Electronics")
            };
        }
    }
}
