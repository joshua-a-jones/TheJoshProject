using Moq;
using TheJoshProject.Api.Services;
using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess.Repositories;
using Microsoft.Extensions.Logging.Abstractions;

namespace TheJoshProject.Tests;

public class EmployerServiceTests
{
    [Fact]
    public async Task GetAllEmployers_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IEmployerRepository>();
        var expected = new List<Employer> { new Employer { EmployerId = 1, EmployerName = "ACME" } };
        repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(expected);
        var service = new EmployerService(repoMock.Object, NullLogger<EmployerService>.Instance);

        // Act
        var result = await service.GetAllEmployers();

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetAllAsync(), Times.Once);
    }

    [Fact]
    public async Task GetEmployer_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IEmployerRepository>();
        var expected = new Employer { EmployerId = 5, EmployerName = "Globex" };
        repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(expected);
        var service = new EmployerService(repoMock.Object, NullLogger<EmployerService>.Instance);

        // Act
        var result = await service.GetEmployer(8);

        // Assert
        Assert.Same(expected, result);
        repoMock.Verify(r => r.GetByIdAsync(8), Times.Once);
    }

    [Fact]
    public async Task GetEmployerIdByName_ForwardsToRepository()
    {
        // Arrange
        var repoMock = new Mock<IEmployerRepository>();
        repoMock.Setup(r => r.GetIdByNameAsync(It.IsAny<string>())).ReturnsAsync(4);
        var service = new EmployerService(repoMock.Object, NullLogger<EmployerService>.Instance);

        // Act
        var result = await service.GetEmployerIdByName("Umbrella");

        // Assert
        Assert.Equal(4, result);
        repoMock.Verify(r => r.GetIdByNameAsync("Umbrella"), Times.Once);
    }
}
