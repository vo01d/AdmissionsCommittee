namespace AdmissionsCommittee {
    class ApplicantsRepository : IRepository<Applicant, int> {
        private List<Applicant> _applicants;

        public ApplicantsRepository() {
            _applicants = new List<Applicant> {
                new Applicant(1, "Ivanov", "Ivan", "Ivanovich", new DateOnly(1990, 5, 15), "+380671234567"),
                new Applicant(2, "Petrov", "Petr", "Petrovich", new DateOnly(1992, 8, 23), "+380671234568"),
                new Applicant(3, "Sidorov", "Ivan", "Sidorovich", new DateOnly(1991, 10, 5), "+380671234569"),
                new Applicant(4, "Koval", "Mykola", "Orestovych", new DateOnly(1993, 11, 30), "+380671234570"),
                new Applicant(5, "Shevchenko", "Taras", "Hryhorovych", new DateOnly(1985, 3, 9), "+380671234571")
        };
        }

        public IEnumerable<Applicant> getAll() {
            return _applicants;
        }
    }
}
