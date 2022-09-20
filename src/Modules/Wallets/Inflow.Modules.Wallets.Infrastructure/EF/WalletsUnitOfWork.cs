using Inflow.Shared.Infrastructure.MongoDb;
using Inflow.Shared.Infrastructure.Postgres;
using Inflow.Shared.Infrastructure.Sqlite;

namespace Inflow.Modules.Wallets.Infrastructure.EF;

internal class WalletsUnitOfWork : MongoDbUnitOfWork<WalletsDbContext>// SqliteUnitOfWork<WalletsDbContext>
{
    public WalletsUnitOfWork(WalletsDbContext dbContext) : base(dbContext)
    {
    }
}