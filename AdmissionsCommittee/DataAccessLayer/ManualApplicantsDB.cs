﻿using AdmissionsCommittee.DataAccessLayer.Entities;

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
                new Applicant(id: 1, lastName: "Donnelly", firstName: "Hanna", middleName: "Jules", birthday: new DateOnly(2001, 4, 12), phoneNumber: "+380313543072"),
                new Applicant(id: 2, lastName: "Leffler", firstName: "Heath", middleName: "Kai", birthday: new DateOnly(1950, 8, 26), phoneNumber: "+380493641018"),
                new Applicant(id: 3, lastName: "Schulist", firstName: "Alysa", middleName: "Greer", birthday: new DateOnly(1992, 1, 13), phoneNumber: "+380592935603"),
                new Applicant(id: 4, lastName: "Bayer", firstName: "Janessa", middleName: "Addison", birthday: new DateOnly(1972, 10, 22), phoneNumber: "+380681864700"),
                new Applicant(id: 5, lastName: "Nolan", firstName: "Makayla", middleName: "Logan", birthday: new DateOnly(1946, 3, 18), phoneNumber: "+380116977701"),
                new Applicant(id: 6, lastName: "Dooley", firstName: "Nikko", middleName: "Alex", birthday: new DateOnly(1987, 1, 7), phoneNumber: "+380912756130"),
                new Applicant(id: 7, lastName: "Hagenes", firstName: "Samara", middleName: "Bailey", birthday: new DateOnly(1951, 12, 13), phoneNumber: "+380684676219"),
                new Applicant(id: 8, lastName: "Roberts", firstName: "Annabelle", middleName: "Reese", birthday: new DateOnly(1944, 4, 14), phoneNumber: "+380699873156"),
                new Applicant(id: 9, lastName: "Skiles", firstName: "Cassie", middleName: "Jaden", birthday: new DateOnly(1981, 5, 8), phoneNumber: "+380176601683"),
                new Applicant(id: 10, lastName: "Treutel", firstName: "Lucas", middleName: "Jordan", birthday: new DateOnly(1965, 8, 14), phoneNumber: "+380392755727")
            };
            _applications = new List<Application> {
                new Application(id: 1, applicationDate: new DateOnly(2024, 8, 1), applicantId: 1, specialityId: 1),
                new Application(id: 2, applicationDate: new DateOnly(2024, 8, 1), applicantId: 1, specialityId: 2),
                new Application(id: 3, applicationDate: new DateOnly(2024, 8, 2), applicantId: 2, specialityId: 3),
                new Application(id: 4, applicationDate: new DateOnly(2024, 8, 2), applicantId: 2, specialityId: 4),
                new Application(id: 5, applicationDate: new DateOnly(2024, 8, 3), applicantId: 3, specialityId: 5),
                new Application(id: 6, applicationDate: new DateOnly(2024, 8, 3), applicantId: 3, specialityId: 6),
                new Application(id: 7, applicationDate: new DateOnly(2024, 8, 4), applicantId: 4, specialityId: 7),
                new Application(id: 8, applicationDate: new DateOnly(2024, 8, 4), applicantId: 4, specialityId: 8),
                new Application(id: 9, applicationDate: new DateOnly(2024, 8, 5), applicantId: 5, specialityId: 9),
                new Application(id: 10, applicationDate: new DateOnly(2024, 8, 5), applicantId: 5, specialityId: 10),
                new Application(id: 11, applicationDate: new DateOnly(2024, 8, 6), applicantId: 6, specialityId: 11),
                new Application(id: 12, applicationDate: new DateOnly(2024, 8, 6), applicantId: 6, specialityId: 12),
                new Application(id: 13, applicationDate: new DateOnly(2024, 8, 7), applicantId: 7, specialityId: 13),
                new Application(id: 14, applicationDate: new DateOnly(2024, 8, 7), applicantId: 7, specialityId: 14),
                new Application(id: 15, applicationDate: new DateOnly(2024, 8, 8), applicantId: 8, specialityId: 15),
                new Application(id: 16, applicationDate: new DateOnly(2024, 8, 8), applicantId: 8, specialityId: 16),
                new Application(id: 17, applicationDate: new DateOnly(2024, 8, 9), applicantId: 9, specialityId: 1),
                new Application(id: 18, applicationDate: new DateOnly(2024, 8, 9), applicantId: 9, specialityId: 3),
                new Application(id: 19, applicationDate: new DateOnly(2024, 8, 10), applicantId: 10, specialityId: 5),
                new Application(id: 20, applicationDate: new DateOnly(2024, 8, 10), applicantId: 10, specialityId: 7),
                new Application(id: 21, applicationDate: new DateOnly(2024, 8, 11), applicantId: 1, specialityId: 8),
                new Application(id: 22, applicationDate: new DateOnly(2024, 8, 11), applicantId: 1, specialityId: 9),
                new Application(id: 23, applicationDate: new DateOnly(2024, 8, 12), applicantId: 2, specialityId: 11),
                new Application(id: 24, applicationDate: new DateOnly(2024, 8, 12), applicantId: 2, specialityId: 12),
                new Application(id: 25, applicationDate: new DateOnly(2024, 8, 13), applicantId: 3, specialityId: 13),
                new Application(id: 26, applicationDate: new DateOnly(2024, 8, 13), applicantId: 3, specialityId: 15),
                new Application(id: 27, applicationDate: new DateOnly(2024, 8, 14), applicantId: 4, specialityId: 16),
                new Application(id: 28, applicationDate: new DateOnly(2024, 8, 14), applicantId: 4, specialityId: 2),
                new Application(id: 29, applicationDate: new DateOnly(2024, 8, 15), applicantId: 5, specialityId: 4),
                new Application(id: 30, applicationDate: new DateOnly(2024, 8, 15), applicantId: 5, specialityId: 6),
                new Application(id: 31, applicationDate: new DateOnly(2024, 8, 16), applicantId: 6, specialityId: 7),
                new Application(id: 32, applicationDate: new DateOnly(2024, 8, 16), applicantId: 6, specialityId: 1)
            };
            _examResults = new List<ExamResult> {
                new ExamResult(id: 1, applicantId: 1, subjectId: 1, mark: 85),
                new ExamResult(id: 2, applicantId: 1, subjectId: 2, mark: 79),
                new ExamResult(id: 3, applicantId: 1, subjectId: 3, mark: 88),
                new ExamResult(id: 4, applicantId: 1, subjectId: 4, mark: 75),
                new ExamResult(id: 5, applicantId: 2, subjectId: 1, mark: 91),
                new ExamResult(id: 6, applicantId: 2, subjectId: 6, mark: 86),
                new ExamResult(id: 7, applicantId: 2, subjectId: 7, mark: 83),
                new ExamResult(id: 8, applicantId: 2, subjectId: 3, mark: 88),
                new ExamResult(id: 9, applicantId: 3, subjectId: 4, mark: 80),
                new ExamResult(id: 10, applicantId: 3, subjectId: 5, mark: 75),
                new ExamResult(id: 11, applicantId: 3, subjectId: 2, mark: 78),
                new ExamResult(id: 12, applicantId: 3, subjectId: 7, mark: 82),
                new ExamResult(id: 13, applicantId: 4, subjectId: 3, mark: 88),
                new ExamResult(id: 14, applicantId: 4, subjectId: 6, mark: 81),
                new ExamResult(id: 15, applicantId: 4, subjectId: 7, mark: 84),
                new ExamResult(id: 16, applicantId: 4, subjectId: 1, mark: 92),
                new ExamResult(id: 17, applicantId: 5, subjectId: 5, mark: 72),
                new ExamResult(id: 18, applicantId: 5, subjectId: 2, mark: 77),
                new ExamResult(id: 19, applicantId: 5, subjectId: 4, mark: 82),
                new ExamResult(id: 20, applicantId: 5, subjectId: 3, mark: 79),
                new ExamResult(id: 21, applicantId: 6, subjectId: 1, mark: 86),
                new ExamResult(id: 22, applicantId: 6, subjectId: 6, mark: 80),
                new ExamResult(id: 23, applicantId: 6, subjectId: 7, mark: 83),
                new ExamResult(id: 24, applicantId: 6, subjectId: 3, mark: 85),
                new ExamResult(id: 25, applicantId: 7, subjectId: 2, mark: 78),
                new ExamResult(id: 26, applicantId: 7, subjectId: 4, mark: 80),
                new ExamResult(id: 27, applicantId: 7, subjectId: 5, mark: 75),
                new ExamResult(id: 28, applicantId: 7, subjectId: 1, mark: 88),
                new ExamResult(id: 29, applicantId: 8, subjectId: 3, mark: 82),
                new ExamResult(id: 30, applicantId: 8, subjectId: 7, mark: 79),
                new ExamResult(id: 31, applicantId: 8, subjectId: 6, mark: 84),
                new ExamResult(id: 32, applicantId: 8, subjectId: 2, mark: 78),
                new ExamResult(id: 33, applicantId: 9, subjectId: 1, mark: 89),
                new ExamResult(id: 34, applicantId: 9, subjectId: 5, mark: 76),
                new ExamResult(id: 35, applicantId: 9, subjectId: 4, mark: 82),
                new ExamResult(id: 36, applicantId: 9, subjectId: 3, mark: 87),
                new ExamResult(id: 37, applicantId: 10, subjectId: 2, mark: 80),
                new ExamResult(id: 38, applicantId: 10, subjectId: 7, mark: 86),
                new ExamResult(id: 39, applicantId: 10, subjectId: 6, mark: 81),
                new ExamResult(id: 40, applicantId: 10, subjectId: 1, mark: 88)
            };
            _faculties = new List<Faculty> {
                new Faculty(id: 1, name: "Engineering"),
                new Faculty(id: 2, name: "Arts"),
                new Faculty(id: 3, name: "Sciences"),
                new Faculty(id: 4, name: "Business"),
                new Faculty(id: 5, name: "Law"),
                new Faculty(id: 6, name: "Medicine"),
                new Faculty(id: 7, name: "Education"),
                new Faculty(id: 8, name: "Social Sciences"),
                new Faculty(id: 9, name: "Computer Science")
            };
            _passMarks = new List<PassMark> {
                new PassMark(id: 1, specialityId: 1, subjectId: 1, mark: 75),
                new PassMark(id: 2, specialityId: 1, subjectId: 6, mark: 70),
                new PassMark(id: 3, specialityId: 1, subjectId: 7, mark: 65),
                new PassMark(id: 4, specialityId: 2, subjectId: 1, mark: 78),
                new PassMark(id: 5, specialityId: 2, subjectId: 6, mark: 72),
                new PassMark(id: 6, specialityId: 2, subjectId: 7, mark: 68),
                new PassMark(id: 7, specialityId: 3, subjectId: 2, mark: 80),
                new PassMark(id: 8, specialityId: 3, subjectId: 4, mark: 75),
                new PassMark(id: 9, specialityId: 3, subjectId: 5, mark: 70),
                new PassMark(id: 10, specialityId: 4, subjectId: 4, mark: 82),
                new PassMark(id: 11, specialityId: 4, subjectId: 2, mark: 78),
                new PassMark(id: 12, specialityId: 4, subjectId: 5, mark: 73),
                new PassMark(id: 13, specialityId: 5, subjectId: 3, mark: 85),
                new PassMark(id: 14, specialityId: 5, subjectId: 7, mark: 80),
                new PassMark(id: 15, specialityId: 5, subjectId: 6, mark: 75),
                new PassMark(id: 16, specialityId: 6, subjectId: 7, mark: 88),
                new PassMark(id: 17, specialityId: 6, subjectId: 3, mark: 82),
                new PassMark(id: 18, specialityId: 6, subjectId: 1, mark: 77),
                new PassMark(id: 19, specialityId: 7, subjectId: 2, mark: 72),
                new PassMark(id: 20, specialityId: 7, subjectId: 1, mark: 74),
                new PassMark(id: 21, specialityId: 7, subjectId: 4, mark: 70),
                new PassMark(id: 22, specialityId: 8, subjectId: 2, mark: 73),
                new PassMark(id: 23, specialityId: 8, subjectId: 1, mark: 75),
                new PassMark(id: 24, specialityId: 8, subjectId: 4, mark: 71),
                new PassMark(id: 25, specialityId: 9, subjectId: 4, mark: 85),
                new PassMark(id: 26, specialityId: 9, subjectId: 2, mark: 80),
                new PassMark(id: 27, specialityId: 9, subjectId: 5, mark: 75),
                new PassMark(id: 28, specialityId: 10, subjectId: 3, mark: 90),
                new PassMark(id: 29, specialityId: 10, subjectId: 7, mark: 88),
                new PassMark(id: 30, specialityId: 10, subjectId: 6, mark: 85),
                new PassMark(id: 31, specialityId: 11, subjectId: 2, mark: 70),
                new PassMark(id: 32, specialityId: 11, subjectId: 5, mark: 68),
                new PassMark(id: 33, specialityId: 11, subjectId: 4, mark: 65),
                new PassMark(id: 34, specialityId: 12, subjectId: 2, mark: 72),
                new PassMark(id: 35, specialityId: 12, subjectId: 5, mark: 70),
                new PassMark(id: 36, specialityId: 12, subjectId: 4, mark: 67),
                new PassMark(id: 37, specialityId: 13, subjectId: 4, mark: 78),
                new PassMark(id: 38, specialityId: 13, subjectId: 2, mark: 75),
                new PassMark(id: 39, specialityId: 13, subjectId: 5, mark: 72),
                new PassMark(id: 40, specialityId: 14, subjectId: 4, mark: 80),
                new PassMark(id: 41, specialityId: 14, subjectId: 2, mark: 77),
                new PassMark(id: 42, specialityId: 14, subjectId: 5, mark: 74),
                new PassMark(id: 43, specialityId: 15, subjectId: 1, mark: 85),
                new PassMark(id: 44, specialityId: 15, subjectId: 6, mark: 82),
                new PassMark(id: 45, specialityId: 15, subjectId: 2, mark: 78),
                new PassMark(id: 46, specialityId: 16, subjectId: 1, mark: 87),
                new PassMark(id: 47, specialityId: 16, subjectId: 6, mark: 83),
                new PassMark(id: 48, specialityId: 16, subjectId: 2, mark: 79)
            };
            _specialities = new List<Speciality> {
                new Speciality(id: 1, number: 101, name: "Mechanical Engineering", facultyId: 1),
                new Speciality(id: 2, number: 102, name: "Civil Engineering", facultyId: 1),
                new Speciality(id: 3, number: 201, name: "English Literature", facultyId: 2),
                new Speciality(id: 4, number: 202, name: "History", facultyId: 2),
                new Speciality(id: 5, number: 301, name: "Biology", facultyId: 3),
                new Speciality(id: 6, number: 302, name: "Chemistry", facultyId: 3),
                new Speciality(id: 7, number: 401, name: "Business Administration", facultyId: 4),
                new Speciality(id: 8, number: 402, name: "Marketing", facultyId: 4),
                new Speciality(id: 9, number: 501, name: "Law", facultyId: 5),
                new Speciality(id: 10, number: 601, name: "Medicine", facultyId: 6),
                new Speciality(id: 11, number: 701, name: "Elementary Education", facultyId: 7),
                new Speciality(id: 12, number: 702, name: "Secondary Education", facultyId: 7),
                new Speciality(id: 13, number: 801, name: "Psychology", facultyId: 8),
                new Speciality(id: 14, number: 802, name: "Sociology", facultyId: 8),
                new Speciality(id: 15, number: 901, name: "Software Engineering", facultyId: 9),
                new Speciality(id: 16, number: 902, name: "Data Science", facultyId: 9)
            };
            _subjects = new List<Subject> {
                new Subject(id: 1, name: "Math"),
                new Subject(id: 2, name: "English"),
                new Subject(id: 3, name: "Biology"),
                new Subject(id: 4, name: "History"),
                new Subject(id: 5, name: "Geography"),
                new Subject(id: 6, name: "Physics"),
                new Subject(id: 7, name: "Chemistry")
            };
        }
    }
}
