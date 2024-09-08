using AdmissionsCommittee.PresentationLayer.Commands;

namespace AdmissionsCommittee.PresentationLayer {
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
        
        public void DrawQueriesMenu() { 
            Console.WriteLine("Queries menu: ");
            for (int i = 0; i < _commands.Count; i++) {
                Console.WriteLine($"{i + 1}. {_commands[i].CommandName}");
            }
        }
    }
}
