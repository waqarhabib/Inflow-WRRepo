﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inflow.Shared.Infrastructure.MongoDb;

public abstract class MongoDbUnitOfWork<T> : IUnitOfWork where T : DbContext
{
    private readonly T _dbContext;

    protected MongoDbUnitOfWork(T dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task ExecuteAsync(Func<Task> action)
    {
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            await action();
            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}