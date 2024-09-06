namespace AdmissionsCommittee {
    class ApplicationsRepository : IRepository<Application, int> {
        private List<Application> _applications;

        public ApplicationsRepository() {
            _applications = new List<Application>();
        }

        public IEnumerable<Application> getAll() {
            return _applications;
        }
    }
}
