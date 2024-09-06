namespace AdmissionsCommittee {
    class QueryInvoker {
        private Command _command; // як це правильно обробити
        public void SetCommand(Command command) {
            _command = command;
        }

        public void ExecuteCommand() {
            _command.Execute();
        }
    }
}
