// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzureSqlDataBaseType. </summary>
    public readonly partial struct AzureSqlDataBaseType : IEquatable<AzureSqlDataBaseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureSqlDataBaseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureSqlDataBaseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AutomaticValue = "Automatic";
        private const string SingleDatabaseValue = "SingleDatabase";
        private const string ElasticPoolValue = "ElasticPool";

        /// <summary> Unknown. </summary>
        public static AzureSqlDataBaseType Unknown { get; } = new AzureSqlDataBaseType(UnknownValue);
        /// <summary> Automatic. </summary>
        public static AzureSqlDataBaseType Automatic { get; } = new AzureSqlDataBaseType(AutomaticValue);
        /// <summary> SingleDatabase. </summary>
        public static AzureSqlDataBaseType SingleDatabase { get; } = new AzureSqlDataBaseType(SingleDatabaseValue);
        /// <summary> ElasticPool. </summary>
        public static AzureSqlDataBaseType ElasticPool { get; } = new AzureSqlDataBaseType(ElasticPoolValue);
        /// <summary> Determines if two <see cref="AzureSqlDataBaseType"/> values are the same. </summary>
        public static bool operator ==(AzureSqlDataBaseType left, AzureSqlDataBaseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureSqlDataBaseType"/> values are not the same. </summary>
        public static bool operator !=(AzureSqlDataBaseType left, AzureSqlDataBaseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureSqlDataBaseType"/>. </summary>
        public static implicit operator AzureSqlDataBaseType(string value) => new AzureSqlDataBaseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureSqlDataBaseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureSqlDataBaseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
