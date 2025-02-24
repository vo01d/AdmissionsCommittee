namespace AdmissionsCommittee.DataAccessLayer.Initializers {
    public interface IDbInitializer<in T> {
        void Initialize(T database);
    }
}
