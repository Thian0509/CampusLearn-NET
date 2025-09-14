namespace CampusLearn.Domain.Comms;
public interface INotificationService
{
    Task SendNotificationAsync(string recipient, string messageContent, string apiType = "Email");
}