namespace AdmissionsCommittee {
    class SubjectsRepository : IRepository<Subject, int> {
        private List<Subject> _subjects;

        public SubjectsRepository() {
            _subjects = new List<Subject>();
        }

        public IEnumerable<Subject> getAll() {
            return _subjects;
        }
    }
}
