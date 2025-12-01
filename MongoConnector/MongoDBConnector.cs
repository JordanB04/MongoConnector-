using MongoDB.Driver;

namespace MongoConnector;

public class MongoDBConnector
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;

    public MongoDBConnector(string connectionString)
    {
        _client = new MongoClient(connectionString);
        _database = _client.GetDatabase("TestDB");
    }

    public bool Ping()
    
    {
    return false; // placeholder for now
    
    }

    }
}
