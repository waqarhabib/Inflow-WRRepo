// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace IoTSharp.EntityFrameworkCore.MongoDB.Diagnostics;

/// <summary>
///     A <see cref="DiagnosticSource" /> event payload class for MongoDB query events.
/// </summary>
/// <remarks>
///     See <see href="https://aka.ms/efcore-docs-diagnostics">Logging, events, and diagnostics</see> for more information and examples.
/// </remarks>
public class MongoDBQueryEventData : EventData
{
    /// <summary>
    ///     Constructs the event payload.
    /// </summary>
    /// <param name="eventDefinition">The event definition.</param>
    /// <param name="messageGenerator">A delegate that generates a log message for this event.</param>
    /// <param name="containerId">The ID of the MongoDB container being queried.</param>
    /// <param name="partitionKey">The key of the MongoDB partition that the query is using.</param>
    /// <param name="parameters">Name/values for each parameter in the MongoDB Query.</param>
    /// <param name="querySql">The SQL representing the query.</param>
    /// <param name="logSensitiveData">Indicates whether the application allows logging of sensitive data.</param>
    public MongoDBQueryEventData(
        EventDefinitionBase eventDefinition,
        Func<EventDefinitionBase, EventData, string> messageGenerator,
        string containerId,
        string? partitionKey,
        IReadOnlyList<(string Name, object? Value)> parameters,
        string querySql,
        bool logSensitiveData)
        : base(eventDefinition, messageGenerator)
    {
        ContainerId = containerId;
        PartitionKey = partitionKey;
        Parameters = parameters;
        QuerySql = querySql;
        LogSensitiveData = logSensitiveData;
    }

    /// <summary>
    ///     The ID of the MongoDB container being queried.
    /// </summary>
    public virtual string ContainerId { get; }

    /// <summary>
    ///     The key of the MongoDB partition that the query is using.
    /// </summary>
    public virtual string? PartitionKey { get; }

    /// <summary>
    ///     Name/values for each parameter in the MongoDB Query.
    /// </summary>
    public virtual IReadOnlyList<(string Name, object? Value)> Parameters { get; }

    /// <summary>
    ///     The SQL representing the query.
    /// </summary>
    public virtual string QuerySql { get; }

    /// <summary>
    ///     Indicates whether the application allows logging of sensitive data.
    /// </summary>
    public virtual bool LogSensitiveData { get; }
}