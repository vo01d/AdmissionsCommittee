namespace AdmissionsCommittee {
    class ApplicantsDB {
        public ApplicantsRepository _applicantsRepository;
        public ExamResultsRepository _examResultsRepository;
        public ApplicationsRepository _applicationsRepository;
        public PassMarksRepository _passMarksRepository;
        public SubjectsRepository _subjectsRepository;
        public SpecialitiesRepository _specialitiesRepository;
        public FacultiesRepository _facultiesRepository;

        public ApplicantsDB() {
            _applicantsRepository = new ApplicantsRepository();
            _examResultsRepository = new ExamResultsRepository();
            _applicationsRepository = new ApplicationsRepository();
            _passMarksRepository = new PassMarksRepository();
            _subjectsRepository = new SubjectsRepository();
            _specialitiesRepository = new SpecialitiesRepository();
            _facultiesRepository = new FacultiesRepository();
        }
    }
}
