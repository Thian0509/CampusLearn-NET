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
