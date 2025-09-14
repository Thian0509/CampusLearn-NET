using CampusLearn.Domain.TopicsNS;
namespace CampusLearn.Domain.Comms;
public class PrivateMessage
{
    public string MessageId { get; set; } = Guid.NewGuid().ToString();
    public string SenderId { get; set; } = "";
    public string ReceiverId { get; set; } = "";
    public string Content { get; set; } = "";
    public List<Resource> Attachments { get; set; } = new();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}