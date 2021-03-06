﻿using System;

namespace CSharpMongoMigrations
{
    /// <summary>
    /// Migration version
    /// </summary>
    public class MigrationVersion
    {
        public static MigrationVersion Min = new MigrationVersion(-1);
        public static MigrationVersion Max = new MigrationVersion(long.MaxValue);

        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Sequence number of the current migration
        /// </summary>
        public long Version { get; private set; }

        /// <summary>
        /// Text description of the current migration
        /// </summary>
        public string Description { get; private set;}
                
        public MigrationVersion(long version)
            : this(version, null) { }

        public MigrationVersion(long version, string description)
        {
            Version = version;
            Description = description;
        }

        public override string ToString()
        {
            return $"[{Version}] {Description}";
        }
    }
}
