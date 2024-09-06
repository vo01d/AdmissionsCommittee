namespace AdmissionsCommittee {
    interface IRepository<T, K> {
        IEnumerable<T> getAll();
        // void insert(T entity);
        // T findById(K id);
        // void update(T entity);
        // void delete(T entity);
    }
}
