using Inflow.Shared.Infrastructure.MongoDb;
using Inflow.Shared.Infrastructure.Postgres;
using Inflow.Shared.Infrastructure.Sqlite;

namespace Inflow.Modules.Customers.Core.DAL;

internal class CustomersUnitOfWork :MongoDbUnitOfWork<CustomersDbContext>//  SqliteUnitOfWork<CustomersDbContext>
{
    public CustomersUnitOfWork(CustomersDbContext dbContext) : base(dbContext)
    {
    }
}