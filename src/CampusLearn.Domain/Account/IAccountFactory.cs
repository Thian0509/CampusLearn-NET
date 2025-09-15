using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusLearn.Domain.Account
{
    public interface IAccountFactory
    {
        IAccount CreateStudent(string name, int id);
        IAccount CreateTutor(string name, string subject);
        IAccount CreateAdmin(string name);
    }
}
