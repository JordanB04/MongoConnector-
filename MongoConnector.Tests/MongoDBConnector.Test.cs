using Testcontainers.MongoDb;
using Xunit;

namespace MongoConnector.Tests;

public class MongoDBConnectorTests
{
    private readonly MongoDbContainer _mongo;

    public MongoDBConnectorTests()
    {
        _mongo = new MongoDbBuilder().Build();
        _mongo.StartAsync().Wait();
    }

    [Fact]
    public void Ping_ReturnsTrue_WhenServerIsRunning()
    {
        var connector = new MongoDBConnector(_mongo.GetConnectionString());
        Assert.True(connector.Ping());
    }

    [Fact]
public void Ping_ReturnsFalse_WhenConnectionInvalid()
{
    var connector = new MongoDBConnector("mongodb://localhost:9999");
    Assert.False(connector.Ping());
}

}
