using Microsoft.AspNetCore.Mvc;
using CampusLearn.Application.Abstractions;

namespace CampusLearn.Api.Controllers;

[ApiController]
[Route("api/topics")]
public class TopicsController : ControllerBase
{
    private readonly ITopicService _topics;
    public TopicsController(ITopicService topics){ _topics = topics; }

    public record CreateTopicReq(string CreatorUserId, string Title, string Description, string ModuleCode);
    public record PostQuestionReq(string TopicId, string StudentId, string Content, bool IsAnonymous);
    public record RespondReq(string TopicId, string QuestionId, string UserId, string Content);

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTopicReq req)
    {
        var t = await _topics.CreateTopicAsync(req.CreatorUserId, req.Title, req.Description, req.ModuleCode);
        return Ok(t);
    }

    [HttpPost("question")]
    public async Task<IActionResult> PostQuestion([FromBody] PostQuestionReq req)
    {
        var q = await _topics.PostQuestionAsync(req.TopicId, req.StudentId, req.Content, req.IsAnonymous);
        return Ok(q);
    }

    [HttpPost("respond")]
    public async Task<IActionResult> Respond([FromBody] RespondReq req)
    {
        var r = await _topics.RespondAsync(req.TopicId, req.QuestionId, req.UserId, req.Content);
        return Ok(r);
    }

    [HttpGet("latest")]
    public async Task<IActionResult> Latest([FromQuery] int take = 10)
    {
        var list = await _topics.GetLatestAsync(take);
        return Ok(list);
    }
}