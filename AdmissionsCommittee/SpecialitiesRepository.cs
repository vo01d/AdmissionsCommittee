namespace AdmissionsCommittee {
    class SpecialitiesRepository : IRepository<Speciality, int> {
        private List<Speciality> _specialities;

        public SpecialitiesRepository() {
            _specialities = new List<Speciality>();
        }

        public IEnumerable<Speciality> getAll() {
            return _specialities;
        }
    }
}
