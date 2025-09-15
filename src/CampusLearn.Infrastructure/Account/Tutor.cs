using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusLearn.Domain.Account;

namespace CampusLearn.Infrastructure.Account
{
    public class Tutor : IAccount
    {
        private readonly string name;
        private readonly string subject;

        public Tutor(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public string GetDetails()
        {
            return $"Tutor: {name}, Subject: {subject}";
        }
    }
}
