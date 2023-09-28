// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> VerificationType enums. </summary>
    public readonly partial struct VerificationType : IEquatable<VerificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VerificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VerificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VerifiedValue = "verified";
        private const string UnverifiedValue = "unverified";

        /// <summary> The Image is guaranteed to be compatible with the associated Compute Node agent SKU and all Batch features have been confirmed to work as expected. </summary>
        public static VerificationType Verified { get; } = new VerificationType(VerifiedValue);
        /// <summary> The associated Compute Node agent SKU should have binary compatibility with the Image, but specific functionality has not been verified. </summary>
        public static VerificationType Unverified { get; } = new VerificationType(UnverifiedValue);
        /// <summary> Determines if two <see cref="VerificationType"/> values are the same. </summary>
        public static bool operator ==(VerificationType left, VerificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VerificationType"/> values are not the same. </summary>
        public static bool operator !=(VerificationType left, VerificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VerificationType"/>. </summary>
        public static implicit operator VerificationType(string value) => new VerificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VerificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VerificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
