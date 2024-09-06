namespace AdmissionsCommittee {
    internal class PassMarksRepository : IRepository<PassMark, int> {
        private List<PassMark> _passMarks;

        public PassMarksRepository() {
            _passMarks = new List<PassMark>();
        }

        public IEnumerable<PassMark> getAll() {
            return _passMarks;
        }
    }
}
