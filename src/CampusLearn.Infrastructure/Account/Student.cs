using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusLearn.Domain.Account;

namespace CampusLearn.Infrastructure.Account
{
    public class Student : IAccount
    {
        private readonly string name;
        private readonly string studentId;

        public Student(string name, string studentId)
        {
            this.name = name;
            this.studentId = studentId;
        }

        public string GetDetails()
        {
            return $"Student: {name}, ID: {studentId}";
        }
    }
}
