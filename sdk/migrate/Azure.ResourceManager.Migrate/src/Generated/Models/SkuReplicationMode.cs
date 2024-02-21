// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The SkuReplicationMode. </summary>
    public readonly partial struct SkuReplicationMode : IEquatable<SkuReplicationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuReplicationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuReplicationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotApplicableValue = "NotApplicable";
        private const string ActiveGeoReplicationValue = "ActiveGeoReplication";
        private const string FailoverGroupInstanceValue = "FailoverGroupInstance";

        /// <summary> NotApplicable. </summary>
        public static SkuReplicationMode NotApplicable { get; } = new SkuReplicationMode(NotApplicableValue);
        /// <summary> ActiveGeoReplication. </summary>
        public static SkuReplicationMode ActiveGeoReplication { get; } = new SkuReplicationMode(ActiveGeoReplicationValue);
        /// <summary> FailoverGroupInstance. </summary>
        public static SkuReplicationMode FailoverGroupInstance { get; } = new SkuReplicationMode(FailoverGroupInstanceValue);
        /// <summary> Determines if two <see cref="SkuReplicationMode"/> values are the same. </summary>
        public static bool operator ==(SkuReplicationMode left, SkuReplicationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuReplicationMode"/> values are not the same. </summary>
        public static bool operator !=(SkuReplicationMode left, SkuReplicationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuReplicationMode"/>. </summary>
        public static implicit operator SkuReplicationMode(string value) => new SkuReplicationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuReplicationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuReplicationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
