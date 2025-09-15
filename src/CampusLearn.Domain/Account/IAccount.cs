using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusLearn.Domain.Account
{
    public interface IAccount
    {
        string GetDetails();
        void Register();
        void LogIn();
        void LogOut();
        void UpdateProfile(string name);
    }
}
