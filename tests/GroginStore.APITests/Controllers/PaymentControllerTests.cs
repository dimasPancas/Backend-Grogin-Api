using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace GroginStore.API.Controllers.Tests;

public class PaymentControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> factory;

    public PaymentControllerTests(WebApplicationFactory<Program> webApplicationFactory)
    {
        factory = webApplicationFactory;
    }

    [Fact]
    public async Task GetAll_ForValidRequest_Returns200Ok()
    {
        // Arrange
        var client = factory.CreateClient();

        // Act
        var response = await client.GetAsync("/api/Payment");

        // Assert
        //Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
    }
}
