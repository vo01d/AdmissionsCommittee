using AdmissionsCommittee.DataAccessLayer.Entities;

namespace AdmissionsCommittee.DataAccessLayer {
    class HardCodedApplicantsDB : ApplicantsDB {
        public HardCodedApplicantsDB() {
            _applicants.AddRange(new List<Applicant> {
                new Applicant(1, "Ivanov", "Ivan", "Ivanovich", new DateOnly(1990, 5, 15), "+380671234567"),
                new Applicant(2, "Petrov", "Petr", "Petrovich", new DateOnly(1992, 8, 23), "+380671234568"),
                new Applicant(3, "Sidorov", "Ivan", "Sidorovich", new DateOnly(1991, 10, 5), "+380671234569"),
                new Applicant(4, "Koval", "Mykola", "Orestovych", new DateOnly(1993, 11, 30), "+380671234570"),
                new Applicant(5, "Shevchenko", "Taras", "Hryhorovych", new DateOnly(1985, 3, 9), "+380671234571")
            });
            _applications.AddRange(new List<Application> {
                new Application(1, new DateOnly(2024, 1, 10), 1, 1),
                new Application(2, new DateOnly(2024, 1, 12), 2, 2),
                new Application(3, new DateOnly(2024, 1, 15), 3, 3),
                new Application(4, new DateOnly(2024, 1, 20), 4, 4),
                new Application(5, new DateOnly(2024, 1, 25), 5, 1)
            });
            _examResults.AddRange(new List<ExamResult> {
                new ExamResult(1, 1, 1, 85),
                new ExamResult(2, 1, 2, 75),
                new ExamResult(3, 2, 1, 90),
                new ExamResult(4, 2, 3, 80),
                new ExamResult(5, 3, 2, 88),
                new ExamResult(6, 3, 4, 70),
                new ExamResult(7, 4, 4, 85),
                new ExamResult(8, 4, 5, 90),
                new ExamResult(9, 5, 3, 95),
                new ExamResult(10, 5, 5, 75)
            });
            _faculties.AddRange(new List<Faculty> {
                new Faculty(1, "Computer Science"),
                new Faculty(2, "Mechanical Engineering"),
                new Faculty(3, "Civil Engineering"),
                new Faculty(4, "Electrical Engineering")
            });
            _passMarks.AddRange(new List<PassMark> {
                new PassMark(1, 1, 1, 80),
                new PassMark(2, 1, 2, 80),
                new PassMark(3, 1, 3, 85),
                new PassMark(4, 2, 1, 70),
                new PassMark(5, 2, 4, 75),
                new PassMark(6, 3, 2, 80),
                new PassMark(7, 3, 4, 70),
                new PassMark(8, 4, 5, 75)
            });
            _specialities.AddRange(new List<Speciality> {
                new Speciality(1, 101, "Software Engineering", 1),
                new Speciality(2, 201, "Automotive Engineering", 2),
                new Speciality(3, 301, "Structural Engineering", 3),
                new Speciality(4, 401, "Power Systems Engineering", 4)
            });
            _subjects.AddRange(new List<Subject> {
                new Subject(1, "Mathematics"),
                new Subject(2, "Physics"),
                new Subject(3, "Programming"),
                new Subject(4, "Mechanics"),
                new Subject(5, "Electronics")
            });
        }
    }
}
