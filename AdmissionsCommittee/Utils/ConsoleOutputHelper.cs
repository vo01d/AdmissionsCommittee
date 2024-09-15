using AdmissionsCommittee.ApplicationLayer.Views;
using AdmissionsCommittee.DataAccessLayer.Entities;
using AdmissionsCommittee.PresentationLayer.Commands;
using ConsoleTables;

namespace AdmissionsCommittee.Utils {
    static class ConsoleOutputHelper {
        public static void WriteQueriesMenu(IEnumerable<Query> queries) {
            Console.WriteLine("Queries menu: ");
            foreach (var (query, index) in queries.Select((query, index) => (query, index))) {
                Console.WriteLine($"{index + 1}. {query.Name}");
            }
        }

        public static void WriteApplicantsTable(IEnumerable<Applicant> applicants) {
            var table = new ConsoleTable("Id", "Last name", "First name", "Middle name", "Birthday", "Phone number");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var applicant in applicants) {
                table.AddRow(applicant.Id, applicant.LastName, applicant.FirstName, applicant.MiddleName, applicant.Birthday,
                    applicant.PhoneNumber);
            }
            table.Write();
        }

        public static void WriteApplicationViewsTable(IEnumerable<ApplicationView> applications) {
            var table = new ConsoleTable("Id", "Application date", "Last name", "First name", "Middle name", "Speciality number",
                "Speciality name", "Faculty name");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var application in applications) {
                table.AddRow(application.ApplicationId, application.ApplicationDate, application.Lastname, application.FirstName,
                    application.MiddleName, application.SpecialityNumber, application.SpecialityName, application.FacultyName);
            }
            table.Write();
        }

        public static void WriteExamResultViewsTable(IEnumerable<ExamResultView> examResults) {
            var table = new ConsoleTable("Id", "Last name", "First name", "Middle name", "Subject name", "Mark");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var examResult in examResults) {
                table.AddRow(examResult.ExamResultId, examResult.LastName, examResult.FirstName, examResult.MiddleName,
                    examResult.SubjectName, examResult.Mark);
            }
            table.Write();
        }

        public static void WriteFacultiesTable(IEnumerable<Faculty> faculties) {
            var table = new ConsoleTable("Id", "Faculty name");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var faculty in faculties) {
                table.AddRow(faculty.Id, faculty.Name);
            }
            table.Write();
        }

        public static void WritePassMarkViewsTable(IEnumerable<PassMarkView> passMarks) {
            var table = new ConsoleTable("Id", "Speciality number", "Speciality name", "Faculty name", "Subject name", "Mark");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var passMark in passMarks) {
                table.AddRow(passMark.PassMarkId, passMark.SpecialityNumber, passMark.SpecialityName, passMark.FacultyName,
                    passMark.SubjectName, passMark.Mark);
            }
            table.Write();
        }

        public static void WriteSpecialityViewsTable(IEnumerable<SpecialityView> specialityViews) {
            var table = new ConsoleTable("Id", "Speciality number", "Speciality name", "Faculty name");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var specialityView in specialityViews) {
                table.AddRow(specialityView.SpecialityId, specialityView.SpecialityNumber, specialityView.SpecialityName, 
                    specialityView.FacultyName);
            }
            table.Write();
        }

        public static void WriteSubjecsTable(IEnumerable<Subject> subjects) {
            var table = new ConsoleTable("Id", "Subject name");
            table.Configure(tableOptions => tableOptions.EnableCount = false);
            foreach (var subject in subjects) {
                table.AddRow(subject.Id, subject.Name);
            }
            table.Write();
        }
    }
}
