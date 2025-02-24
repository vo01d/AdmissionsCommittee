using AdmissionsCommittee.ApplicationLayer;
using AdmissionsCommittee.DataAccessLayer;
using AdmissionsCommittee.DataAccessLayer.Initializers;
using AdmissionsCommittee.PresentationLayer;
using AdmissionsCommittee.PresentationLayer.Commands;
using AdmissionsCommittee.PresentationLayer.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace AdmissionsCommittee {
    public class Program {
        static void Main(string[] args) {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<QueryInvoker>();
            services.AddSingleton<IDbInitializer<ApplicantsDb>, JsonApplicantsDbInitializer>();
            services.AddSingleton<ApplicantsDb>();
            services.AddTransient<IApplicantsQueryService, ApplicantsQueryService>();
            services.AddSingleton<UIHandler>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            IApplicantsQueryService applicantsDBQueryHandler = serviceProvider.GetRequiredService<IApplicantsQueryService>();

            var queryInvoker = serviceProvider.GetRequiredService<QueryInvoker>()
                .SetQuery(new GetApplicantsQuery("Print applicants", applicantsDBQueryHandler))
                .SetQuery(new GetApplicationsQuery("Print applications", applicantsDBQueryHandler))
                .SetQuery(new GetExamResultsQuery("Print exam results", applicantsDBQueryHandler))
                .SetQuery(new GetFacultiesQuery("Print faculties", applicantsDBQueryHandler))
                .SetQuery(new GetPassMarksQuery("Print pass marks", applicantsDBQueryHandler))
                .SetQuery(new GetSpecialitiesQuery("Print specialities", applicantsDBQueryHandler))
                .SetQuery(new GetSubjectsQuery("Print subjects", applicantsDBQueryHandler))
                .SetQuery(new GetApplicantsByFirstNameQuery("Print applicants with specified first name", applicantsDBQueryHandler))
                .SetQuery(new GetExamResultsEqualOrAboveQuery("Print exam results that equal or greater than specified number", applicantsDBQueryHandler))
                .SetQuery(new GetAverageSubjectsExamMarkQuery("Print average exam mark for each subject", applicantsDBQueryHandler))
                .SetQuery(new GetAverageApplicantsExamMarkQuery("Print average exam mark for each applicant", applicantsDBQueryHandler))
                .SetQuery(new GetAverageSpecialitiesPassMarkQuery("Print average pass mark for each speciality", applicantsDBQueryHandler))
                .SetQuery(new GetNumberOfApplicantsInEachFacultyQuery("Print number of applicants in each faculty", applicantsDBQueryHandler))
                .SetQuery(new GetSubjectsPassCountQuery("Print pass count for each subject", applicantsDBQueryHandler))
                .SetQuery(new GetSubjectsLowestExamMarkQuery("Print the lowest exam mark for each subject", applicantsDBQueryHandler));

            var UIHandler = serviceProvider.GetRequiredService<UIHandler>();
            UIHandler.Start();
        }
    }
}
