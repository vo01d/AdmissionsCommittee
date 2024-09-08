using AdmissionsCommittee.ApplicationLayer;

namespace AdmissionsCommittee.PresentationLayer.Commands {
    abstract class Command {
        public string CommandName { get; }
        protected readonly QueryHandler _queryHandler;

        protected Command(string name, QueryHandler queryHandler) {
            CommandName = name;
            _queryHandler = queryHandler;
        }

        public abstract void Execute();
    }
}
