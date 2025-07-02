using Moq;
using TheJoshProject.Api.Services;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess.Repositories;
using Microsoft.Extensions.Logging.Abstractions;

namespace TheJoshProject.Tests;

public class ExperienceServiceTests
{
    [Fact]
    public async Task GetAllExperience_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IExperienceRepository>();
        var expected = new List<Experience>
        {
            new Experience
            {
                ExperienceId = 1,
                EmployerName = "Example",
                JobTitle = "Dev",
                StartDate = DateTime.UtcNow
            }
        };
        repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(expected);
        var service = new ExperienceService(repoMock.Object, NullLogger<ExperienceService>.Instance);

        // Act
        var result = await service.GetAllExperience();

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetAllAsync(), Times.Once);
    }

    [Fact]
    public async Task GetExperience_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IExperienceRepository>();
        var expected = new Experience
        {
            ExperienceId = 2,
            EmployerName = "ACME",
            JobTitle = "QA",
            StartDate = DateTime.UtcNow
        };
        repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(expected);
        var service = new ExperienceService(repoMock.Object, NullLogger<ExperienceService>.Instance);

        // Act
        var result = await service.GetExperience(7);

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetByIdAsync(7), Times.Once);
    }

    [Fact]
    public async Task GetExperienceIdByEmployerAndJob_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IExperienceRepository>();
        repoMock.Setup(r => r.GetIdByEmployerAndJobAsync(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(99);
        var service = new ExperienceService(repoMock.Object, NullLogger<ExperienceService>.Instance);

        // Act
        var result = await service.GetExperienceIdByEmployerAndJob("ACME", "Dev");

        // Assert
        Assert.Equal(99, result);
        repoMock.Verify(r => r.GetIdByEmployerAndJobAsync("ACME", "Dev"), Times.Once);
    }
}
