using Moq;
using TheJoshProject.Api.Services;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess.Repositories;
using Microsoft.Extensions.Logging.Abstractions;

namespace TheJoshProject.Tests;

public class SkillServiceTests
{
    [Fact]
    public async Task GetSkillsByExperienceId_ForwardsSqlAndReturnsResults()
    {
        // Arrange
        var repoMock = new Mock<ISkillRepository>();
        var expected = new List<Skill>
        {
            new Skill { SkillId = 1, SkillName = "C#", SkillDescription = "desc" }
        };

        repoMock.Setup(r => r.GetByExperienceIdAsync(It.IsAny<int>()))
            .ReturnsAsync(expected);

        var service = new SkillService(repoMock.Object, NullLogger<SkillService>.Instance);

        // Act
        var result = await service.GetSkillsByExperienceId(5);

        // Assert
        Assert.Same(expected, result);

        repoMock.Verify(r => r.GetByExperienceIdAsync(5), Times.Once);
    }

    [Fact]
    public async Task GetSkillsByEmployerAndJob_ForwardsSqlAndReturnsResults()
    {
        // Arrange
        var repoMock = new Mock<ISkillRepository>();
        var expected = new List<Skill>
        {
            new Skill { SkillId = 1, SkillName = "SQL", SkillDescription = "db" }
        };

        repoMock.Setup(r => r.GetByEmployerAndJobAsync(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(expected);

        var service = new SkillService(repoMock.Object, NullLogger<SkillService>.Instance);

        // Act
        var result = await service.GetSkillsByEmployerAndJob("ACME", "Developer");

        // Assert
        Assert.Same(expected, result);

        repoMock.Verify(r => r.GetByEmployerAndJobAsync("ACME", "Developer"), Times.Once);
    }
}
