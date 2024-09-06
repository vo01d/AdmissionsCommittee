namespace AdmissionsCommittee {
    class FacultiesRepository : IRepository<Faculty, int> {
        private List<Faculty> _faculties;

        public FacultiesRepository() {
            _faculties = new List<Faculty>();
        }

        public IEnumerable<Faculty> getAll() {
            return _faculties;
        }
    }
}
