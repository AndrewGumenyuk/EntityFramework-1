// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Migrations
{
    /// <summary>
    ///     <para>
    ///         Service dependencies parameter class for <see cref="HistoryRepository" />
    ///     </para>
    ///     <para>
    ///         This type is typically used by database providers (and other extensions). It is generally
    ///         not used in application code.
    ///     </para>
    ///     <para>
    ///         Do not construct instances of this class directly from either provider or application code as the
    ///         constructor signature may change as new dependencies are added. Instead, use this type in 
    ///         your constructor so that an instance will be created and injected automatically by the 
    ///         dependency injection container. To create an instance with some dependent services replaced, 
    ///         first resolve the object from the dependency injection container, then replace selected 
    ///         services using the 'With...' methods. Do not call the constructor at any point in this process.
    ///     </para>
    ///     <para>
    ///         Do not construct instances of this class directly from either provider or application code as the
    ///         constructor signature may change as new dependencies are added. Instead, use this type in 
    ///         your constructor so that an instance will be created and injected automatically by the 
    ///         dependency injection container. To create an instance with some dependent services replaced, 
    ///         first resolve the object from the dependency injection container, then replace selected 
    ///         services using the 'With...' methods. Do not call the constructor at any point in this process.
    ///     </para>
    /// </summary>
    public sealed class HistoryRepositoryDependencies
    {
        /// <summary>
        ///     <para>
        ///         Creates the service dependencies parameter object for a <see cref="HistoryRepository" />.
        ///     </para>
        ///     <para>
        ///         Do not call this constructor directly from either provider or application code as it may change 
        ///         as new dependencies are added. Instead, use this type in your constructor so that an instance 
        ///         will be created and injected automatically by the dependency injection container. To create 
        ///         an instance with some dependent services replaced, first resolve the object from the dependency 
        ///         injection container, then replace selected services using the 'With...' methods. Do not call 
        ///         the constructor at any point in this process.
        ///     </para>
        ///     <para>
        ///         This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///         directly from your code. This API may change or be removed in future releases.
        ///     </para>
        /// </summary>
        /// <param name="databaseCreator"> The database creator. </param>
        /// <param name="rawSqlCommandBuilder"> A command builder for building raw SQL commands. </param>
        /// <param name="connection"> The connection to the database. </param>
        /// <param name="options"> Options for the current context instance. </param>
        /// <param name="modelDiffer"> The model differ. </param>
        /// <param name="migrationsSqlGenerator"> The SQL generator for Migrations operations. </param>
        /// <param name="annotations"> Access to relational metadata for the model. </param>
        /// <param name="sqlGenerationHelper"> Helpers for generating update SQL. </param>
        public HistoryRepositoryDependencies(
            [NotNull] IDatabaseCreator databaseCreator,
            [NotNull] IRawSqlCommandBuilder rawSqlCommandBuilder,
            [NotNull] IRelationalConnection connection,
            [NotNull] IDbContextOptions options,
            [NotNull] IMigrationsModelDiffer modelDiffer,
            [NotNull] IMigrationsSqlGenerator migrationsSqlGenerator,
            [NotNull] IRelationalAnnotationProvider annotations,
            [NotNull] ISqlGenerationHelper sqlGenerationHelper)
        {
            Check.NotNull(databaseCreator, nameof(databaseCreator));
            Check.NotNull(rawSqlCommandBuilder, nameof(rawSqlCommandBuilder));
            Check.NotNull(connection, nameof(connection));
            Check.NotNull(options, nameof(options));
            Check.NotNull(modelDiffer, nameof(modelDiffer));
            Check.NotNull(migrationsSqlGenerator, nameof(migrationsSqlGenerator));
            Check.NotNull(annotations, nameof(annotations));
            Check.NotNull(sqlGenerationHelper, nameof(sqlGenerationHelper));

            DatabaseCreator = (IRelationalDatabaseCreator)databaseCreator;
            RawSqlCommandBuilder = rawSqlCommandBuilder;
            Connection = connection;
            Options = options;
            ModelDiffer = modelDiffer;
            MigrationsSqlGenerator = migrationsSqlGenerator;
            Annotations = annotations;
            SqlGenerationHelper = sqlGenerationHelper;
        }

        /// <summary>
        ///     The database creator.
        /// </summary>
        public IRelationalDatabaseCreator DatabaseCreator { get; }

        /// <summary>
        ///     A command builder for building raw SQL commands.
        /// </summary>
        public IRawSqlCommandBuilder RawSqlCommandBuilder { get; }

        /// <summary>
        ///     The connection to the database.
        /// </summary>
        public IRelationalConnection Connection { get; }

        /// <summary>
        ///     Options for the current context instance.
        /// </summary>
        public IDbContextOptions Options { get; }

        /// <summary>
        ///     The model differ.
        /// </summary>
        public IMigrationsModelDiffer ModelDiffer { get; }

        /// <summary>
        ///     The SQL generator for Migrations operations.
        /// </summary>
        public IMigrationsSqlGenerator MigrationsSqlGenerator { get; }

        /// <summary>
        ///     Access to relational metadata for the model.
        /// </summary>
        public IRelationalAnnotationProvider Annotations { get; }

        /// <summary>
        ///     Helpers for generating update SQL.
        /// </summary>
        public ISqlGenerationHelper SqlGenerationHelper { get; }
    }
}
