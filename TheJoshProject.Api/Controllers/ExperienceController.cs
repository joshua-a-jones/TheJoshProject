using Microsoft.AspNetCore.Mvc;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.Services;

[ApiController]
[Route("/api/[controller]")]
public class ExperienceController : ControllerBase
{
    private readonly IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    /// <summary>
    /// Get all experiences
    /// </summary>
    /// <returns></returns>
    /// <response code="200">Returns all experiences</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/experience/all
    ///     
    /// </remarks>
    [HttpGet("all")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<List<Experience>>> GetAllExperiencesAsync()
    {
        var result = await _experienceService.GetAllExperience();

        return Ok(result);
    }

    /// <summary>
    /// Get experience by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <response code="200">Returns experience for id</response>
    /// <response code="404">If experience id is not found</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/experience?id=1
    ///     
    /// </remarks>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Experience>> GetExperience([FromQuery] int id)
    {
        var experience =  await _experienceService.GetExperience(id);

        return experience == null
            ? NotFound($"Experience with id {id} was not found")
            :  Ok(experience);
    }

    /// <summary>
    /// Get experiences filtered by employer and/or date range
    /// </summary>
    /// <param name="employerName"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    /// <response code="200">Returns filtered experiences</response>
    /// <response code="404">If filters are invalid or no data found</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /api/experience/filter?employerName=ACME&startDate=2020-01-01&endDate=2021-01-01
    ///
    /// </remarks>
    [HttpGet("filter")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<List<Experience>>> GetExperienceByFilter([
        FromQuery] string? employerName,
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate)
    {
        if (startDate.HasValue && endDate.HasValue && startDate > endDate)
        {
            return NotFound("Invalid date range");
        }

        var results = await _experienceService.GetExperienceByFilters(employerName, startDate, endDate);

        return results.Count == 0 ? NotFound("No experiences found") : Ok(results);
    }
}