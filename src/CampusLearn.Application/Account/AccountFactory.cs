using CampusLearn.Domain.Account;

namespace CampusLearn.Application.Account
{
    public class AccountFactory : IAccountFactory
    {
        public IAccount CreateStudent(string name, int id)
        {
            return new Student(name, id);
        }

        public IAccount CreateTutor(string name, string subject)
        {
            return new Tutor(name, subject);
        }

        public IAccount CreateAdmin (string name)
        {
            return new Admin(name);
        }
    }
}
