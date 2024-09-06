namespace AdmissionsCommittee {
    abstract class Command {
        protected QueryHandler _queryHandler;

        protected Command() { 
            _queryHandler = new QueryHandler();
        }
        public abstract void Execute();
    }

    class GetAllApplicantsCommand : Command {
        public override void Execute() {
            var applicants = _queryHandler._applicantsDB._applicantsRepository.getAll();

            foreach (var applicant in applicants) {
                Console.WriteLine($"{applicant._id} {applicant._lastName} {applicant._firstName} {applicant._middleName} " +
                    $"{applicant._birthday} {applicant._phoneNumber}");
            }
        }
    }

    class GetAllApplicantsOrderByAgeAscCommand : Command {
        public override void Execute() {
            var applicants = from applicant in _queryHandler._applicantsDB._applicantsRepository.getAll()
                             orderby applicant._birthday
                             select applicant; 

            foreach (var applicant in applicants) {
                Console.WriteLine($"{applicant._id} {applicant._lastName} {applicant._firstName} {applicant._middleName} " +
                    $"{applicant._birthday} {applicant._phoneNumber}");
            }
        }
    }
}
