// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> PoolIdentityType enums. </summary>
    public readonly partial struct PoolIdentityType : IEquatable<PoolIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PoolIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PoolIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserAssignedValue = "UserAssigned";
        private const string NoneValue = "None";

        /// <summary> Batch pool has user assigned identities with it. </summary>
        public static PoolIdentityType UserAssigned { get; } = new PoolIdentityType(UserAssignedValue);
        /// <summary> Batch pool has no identity associated with it. Setting `None` in update pool will remove existing identities. </summary>
        public static PoolIdentityType None { get; } = new PoolIdentityType(NoneValue);
        /// <summary> Determines if two <see cref="PoolIdentityType"/> values are the same. </summary>
        public static bool operator ==(PoolIdentityType left, PoolIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PoolIdentityType"/> values are not the same. </summary>
        public static bool operator !=(PoolIdentityType left, PoolIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PoolIdentityType"/>. </summary>
        public static implicit operator PoolIdentityType(string value) => new PoolIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PoolIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PoolIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
