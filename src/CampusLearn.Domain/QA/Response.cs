using CampusLearn.Domain.Common;
namespace CampusLearn.Domain.QA;
public class Response : EntityBase
{
    public int ResponseId { get; set; }
    public string Content { get; set; } = "";
    public string PostedByUserId { get; set; } = "";
    public int Upvotes { get; set; }
    public void AddUpvote() => Upvotes++;
}