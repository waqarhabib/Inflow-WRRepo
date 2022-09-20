using System;
using System.Threading.Tasks;

namespace Inflow.Shared.Infrastructure.MongoDb;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}