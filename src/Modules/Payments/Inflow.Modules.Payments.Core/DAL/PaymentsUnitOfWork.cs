using Inflow.Shared.Infrastructure.MongoDb;
using Inflow.Shared.Infrastructure.Postgres;
using Inflow.Shared.Infrastructure.Sqlite;

namespace Inflow.Modules.Payments.Core.DAL;

internal class PaymentsUnitOfWork : MongoDbUnitOfWork<PaymentsDbContext>// SqliteUnitOfWork<PaymentsDbContext>
{
    public PaymentsUnitOfWork(PaymentsDbContext dbContext) : base(dbContext)
    {
    }
}