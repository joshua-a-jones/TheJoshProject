using Microsoft.AspNetCore.Mvc;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.Services;

namespace TheJoshProject.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class SkillController : ControllerBase
{
    private readonly ISkillService _skillService;
    private readonly IExperienceService _experienceService;

    public SkillController(ISkillService skillService, IExperienceService experienceService)
    {
        _skillService = skillService;
        _experienceService = experienceService;
    }

    /// <summary>
    /// Get all skills
    /// </summary>
    /// <returns></returns>
    /// <response code="200">Returns all skills</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/skill/all
    ///     
    /// </remarks>
    [HttpGet("all")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult>GetAllSkillsAsync()
    {
        return Ok(await _skillService.GetAllSkills());
    }

    /// <summary>
    /// Get skill by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <response code="200">Returns skill for id</response>
    /// <response code="404">If id is not found</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    ///     
    ///     GET /api/skill?id=1
    ///     
    /// </remarks>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetSkillByIdAsync([FromQuery] int id)
    {
        var skill =  await _skillService.GetSkill(id);

        if (skill == null)
        {
            return NotFound($"Skill with id {id} not found");
        }

        return Ok(skill);
    }

    /// <summary>
    /// Get skills by experience id
    /// </summary>
    /// <param name="experienceId"></param>
    /// <returns></returns>
    /// <response code="200">Returns skills for experience id</response>
    /// <response code="404">If experience id is not found</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/skill/experience?experienceId=1
    ///     
    /// </remarks>
    /// 
    [HttpGet("experience")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetSkillsByExperienceIdAsync([FromQuery] int experienceId)
    {
        if (await _experienceService.GetExperience(experienceId) == null) {
            return NotFound($"Experience with id {experienceId} not found");
        }

        var skills = await _skillService.GetSkillsByExperienceId(experienceId);

        return Ok(skills);
    }
}