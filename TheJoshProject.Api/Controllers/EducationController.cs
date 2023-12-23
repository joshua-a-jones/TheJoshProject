using Microsoft.AspNetCore.Mvc;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.Services;

[ApiController]
[Route("/api/[controller]")]
public class EducationController : ControllerBase
{
    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    /// <summary>
    /// Get all education
    /// </summary>
    /// <returns></returns>
    /// <response code="200">Returns skills for education id</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/education/all
    ///     
    /// </remarks>
    [HttpGet("all")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<List<Education>>>GetAllEducationAsync()
    {
        var result = await _educationService.GetAllEducationAsync();

        return Ok(result);
    }

    /// <summary>
    /// Get education by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <response code="200">Returns details education id</response>
    /// <response code="404">If education id is not found</response>
    /// <response code="500">If there is an error</response>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /api/education?id=1
    ///     
    /// </remarks>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Education>> GetEducation([FromQuery] int id)
    {
        var education =  await _educationService.GetEducationByIdAsync(id);

        return education == null
            ? NotFound($"Education with ID {id} was not found")
            : Ok(education);
    }
}