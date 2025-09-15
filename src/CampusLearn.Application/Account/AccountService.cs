using CampusLearn.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusLearn.Application.Account
{
    public class AccountService
    {
        private readonly IAccountFactory accountFactory;

        // The factory is injected here. The Application layer only knows about IAccountFactory.
        public AccountService(IAccountFactory accountFactory)
        {
            this.accountFactory = accountFactory;
        }

        public string CreateStudentAccount(string name, string studentId)
        {
            // The service uses the abstract factory to create a student.
            IAccount student = accountFactory.CreateStudent(name, studentId);
            return student.GetDetails();
        }

        public string CreateTutorAccount(string name, string subject)
        {
            // The service uses the abstract factory to create a tutor.
            IAccount tutor = accountFactory.CreateTutor(name, subject);
            return tutor.GetDetails();
        }
    }
}
