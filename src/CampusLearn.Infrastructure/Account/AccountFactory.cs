using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusLearn.Domain.Account;

namespace CampusLearn.Infrastructure.Account
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
