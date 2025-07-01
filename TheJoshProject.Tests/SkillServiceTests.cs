using Moq;
using TheJoshProject.Api.Services;
using TheJoshProject.Api.DataAccess;
using TheJoshProject.Api.Models;

namespace TheJoshProject.Tests;

public class SkillServiceTests
{
    [Fact]
    public async Task GetSkillsByExperienceId_ForwardsSqlAndReturnsResults()
    {
        // Arrange
        var repoMock = new Mock<IRepository>();
        var expected = new List<Skill>
        {
            new Skill { SkillId = 1, SkillName = "C#", SkillDescription = "desc" }
        };

        repoMock.Setup(r => r.GetAllDataAsync<Skill>(It.IsAny<string>(), It.IsAny<object?>()))
            .ReturnsAsync(expected);

        var service = new SkillService(repoMock.Object);

        // Act
        var result = await service.GetSkillsByExperienceId(5);

        // Assert
        Assert.Same(expected, result);

        var expectedSql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";

        repoMock.Verify(r => r.GetAllDataAsync<Skill>(
                It.Is<string>(s => s == expectedSql && s.Contains("SkillId")),
                It.Is<object>(o =>
                    (int)o!.GetType().GetProperty("Id")!.GetValue(o)! == 5)
            ), Times.Once);
    }

    [Fact]
    public async Task GetSkillsByEmployerAndJob_ForwardsSqlAndReturnsResults()
    {
        // Arrange
        var repoMock = new Mock<IRepository>();
        var expected = new List<Skill>
        {
            new Skill { SkillId = 1, SkillName = "SQL", SkillDescription = "db" }
        };

        repoMock.Setup(r => r.GetAllDataAsync<Skill>(It.IsAny<string>(), It.IsAny<object?>()))
            .ReturnsAsync(expected);

        var service = new SkillService(repoMock.Object);

        // Act
        var result = await service.GetSkillsByEmployerAndJob("ACME", "Developer");

        // Assert
        Assert.Same(expected, result);

        var expectedSql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";

        repoMock.Verify(r => r.GetAllDataAsync<Skill>(
                It.Is<string>(s => s == expectedSql && s.Contains("SkillId")),
                It.Is<object>(o =>
                    (string)o!.GetType().GetProperty("EmployerName")!.GetValue(o)! == "ACME" &&
                    (string)o.GetType().GetProperty("JobTitle")!.GetValue(o)! == "Developer")
            ), Times.Once);
    }
}
