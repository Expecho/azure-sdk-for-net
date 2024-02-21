// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The SqlMigrationGuidelineCategory. </summary>
    public readonly partial struct SqlMigrationGuidelineCategory : IEquatable<SqlMigrationGuidelineCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlMigrationGuidelineCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlMigrationGuidelineCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string GeneralValue = "General";
        private const string FailoverClusterInstanceGuideLineValue = "FailoverCluterInstanceGuideLine";
        private const string AvailabilityGroupGuidelineValue = "AvailabilityGroupGuideline";

        /// <summary> Unknown. </summary>
        public static SqlMigrationGuidelineCategory Unknown { get; } = new SqlMigrationGuidelineCategory(UnknownValue);
        /// <summary> General. </summary>
        public static SqlMigrationGuidelineCategory General { get; } = new SqlMigrationGuidelineCategory(GeneralValue);
        /// <summary> FailoverCluterInstanceGuideLine. </summary>
        public static SqlMigrationGuidelineCategory FailoverClusterInstanceGuideLine { get; } = new SqlMigrationGuidelineCategory(FailoverClusterInstanceGuideLineValue);
        /// <summary> AvailabilityGroupGuideline. </summary>
        public static SqlMigrationGuidelineCategory AvailabilityGroupGuideline { get; } = new SqlMigrationGuidelineCategory(AvailabilityGroupGuidelineValue);
        /// <summary> Determines if two <see cref="SqlMigrationGuidelineCategory"/> values are the same. </summary>
        public static bool operator ==(SqlMigrationGuidelineCategory left, SqlMigrationGuidelineCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlMigrationGuidelineCategory"/> values are not the same. </summary>
        public static bool operator !=(SqlMigrationGuidelineCategory left, SqlMigrationGuidelineCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlMigrationGuidelineCategory"/>. </summary>
        public static implicit operator SqlMigrationGuidelineCategory(string value) => new SqlMigrationGuidelineCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlMigrationGuidelineCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlMigrationGuidelineCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
