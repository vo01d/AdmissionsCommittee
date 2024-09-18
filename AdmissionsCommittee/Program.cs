using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Initializers;
using AdmissionsCommittee.PresentationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.PresentationLayer.Queries;

namespace AdmissionsCommittee {
    class Program {
        static void Main(string[] args) {
            string dataFolderPath = "C:\\Users\\Asus\\Desktop\\All\\Learning\\Programing\\C#\\projects" +
    "\\AdmissionsCommittee\\AdmissionsCommittee\\Data\\";
            ApplicantsDb applicantsDB = new ApplicantsDb(new JSONApplicantsDbInitializer(dataFolderPath));
            ApplicantsDBQueryHandler applicantsDBQueryHandler = new ApplicantsDBQueryHandler(applicantsDB);

            QueryInvoker queryInvoker = new QueryInvoker();
            queryInvoker.SetCommand(new GetApplicantsQuery("Print information about applicants", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetApplicationsQuery("Print information about applications", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetExamResultsQuery("Print information about exam results", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetFacultiesQuery("Print information about faculties", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetPassMarksQuery("Print information about pass marks", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetSpecialitiesQuery("Print information about specialities", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetSubjectsQuery("Print information about subjects", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetApplicantsByFirstNameQuery("Print information about applicants with specified first name",
                applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetExamResultsEqualOrAboveQuery("Print information about applicants exam results that " +
                "equal or greater than specified number", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetAverageSubjectsExamMarkQuery("Print average exam mark for each subject", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetAverageApplicantsExamMarkQuery("Print average exam mark for each applicant", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetAverageSpecialitiesPassMarkQuery("Print average pass mark for each speciality", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetNumberOfApplicantsInEachFacultyQuery("Print number of applicants in each faculty", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetSubjectsPassCountQuery("Print pass count for each subject", applicantsDBQueryHandler));
            queryInvoker.SetCommand(new GetSubjectsLowestExamMarkQuery("Print the lowest exam mark for each subject", applicantsDBQueryHandler));

            App app = new App(queryInvoker);
            app.StartExecution();
        }
    }
}
