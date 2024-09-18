namespace AdmissionsCommittee.DataAccessLayer.Initializers {
    interface IDbInitializer<T> {
        void Initialize(T database);
    }
}
