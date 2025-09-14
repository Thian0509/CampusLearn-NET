using CampusLearn.Domain.Common;
namespace CampusLearn.Domain.QA;
public class Question : EntityBase
{
    public int QuestionId { get; set; }
    public string Content { get; set; } = "";
    public string PostedByStudentId { get; set; } = "";
    public bool IsAnonymous { get; set; }
    public List<Response> Responses { get; set; } = new();
}