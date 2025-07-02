using Moq;
using TheJoshProject.Api.Services;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess.Repositories;
using Microsoft.Extensions.Logging.Abstractions;

namespace TheJoshProject.Tests;

public class EducationServiceTests
{
    [Fact]
    public async Task GetAllEducationAsync_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IEducationRepository>();
        var expected = new List<Education>
        {
            new Education
            {
                EducationId = 1,
                SchoolName = "Test",
                Degree = "B.S.",
                Major = "CS",
                StartDate = DateTime.UtcNow
            }
        };
        repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(expected);
        var service = new EducationService(repoMock.Object, NullLogger<EducationService>.Instance);

        // Act
        var result = await service.GetAllEducationAsync();

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetAllAsync(), Times.Once);
    }

    [Fact]
    public async Task GetEducationByIdAsync_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IEducationRepository>();
        var expected = new Education
        {
            EducationId = 1,
            SchoolName = "Test",
            Degree = "B.S.",
            Major = "CS",
            StartDate = DateTime.UtcNow
        };
        repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(expected);
        var service = new EducationService(repoMock.Object, NullLogger<EducationService>.Instance);

        // Act
        var result = await service.GetEducationByIdAsync(3);

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetByIdAsync(3), Times.Once);
    }
}
