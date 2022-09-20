using Inflow.Shared.Infrastructure.MongoDb;
using Inflow.Shared.Infrastructure.Postgres;
using Inflow.Shared.Infrastructure.Sqlite;

namespace Inflow.Modules.Users.Core.DAL;

internal class UsersUnitOfWork : MongoDbUnitOfWork<UsersDbContext>// SqliteUnitOfWork<UsersDbContext>
{
    public UsersUnitOfWork(UsersDbContext dbContext) : base(dbContext)
    {
    }
}