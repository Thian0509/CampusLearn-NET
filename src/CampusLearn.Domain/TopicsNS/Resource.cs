using CampusLearn.Domain.Common;
namespace CampusLearn.Domain.TopicsNS;
public class Resource : EntityBase
{
    public int ResourceId { get; set; }
    public string Type { get; set; } = "";
    public string Title { get; set; } = "";
    public string FilePath { get; set; } = "";
    public string UploadedByTutorId { get; set; } = "";
}