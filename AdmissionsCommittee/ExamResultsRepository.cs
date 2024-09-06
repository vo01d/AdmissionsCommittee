namespace AdmissionsCommittee {
    class ExamResultsRepository : IRepository<ExamResult, int> {
        private List<ExamResult> _examResults;

        public ExamResultsRepository() {
            _examResults = new List<ExamResult>();
        }

        public IEnumerable<ExamResult> getAll() {
            return _examResults;
        }
    }
}
