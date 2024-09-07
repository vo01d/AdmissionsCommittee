namespace AdmissionsCommittee.PresentationLayer {
    // Does QueryInvoker need interface?
    class QueryInvoker {
        private readonly List<Command> _commands = new List<Command>();

        public void SetCommand(Command command) {
            _commands.Add(command);
        }

        public void ExecuteCommand(int commandNumber) {
            _commands[commandNumber - 1].Execute();
        }

        public int GetCommandsCount() {
            return _commands.Count;
        }
        
        // Draw menu or get it as a string?
        public void DrawQueriesMenu() { 
            Console.WriteLine("Queries: ");
            for (int i = 0; i < _commands.Count; i++) {
                Console.WriteLine($"{i + 1}. {_commands[i].CommandName}");
            }
        }
    }
}
