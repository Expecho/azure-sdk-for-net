// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzurePricingTier. </summary>
    public readonly partial struct AzurePricingTier : IEquatable<AzurePricingTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzurePricingTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzurePricingTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string BasicValue = "Basic";

        /// <summary> Standard. </summary>
        public static AzurePricingTier Standard { get; } = new AzurePricingTier(StandardValue);
        /// <summary> Basic. </summary>
        public static AzurePricingTier Basic { get; } = new AzurePricingTier(BasicValue);
        /// <summary> Determines if two <see cref="AzurePricingTier"/> values are the same. </summary>
        public static bool operator ==(AzurePricingTier left, AzurePricingTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzurePricingTier"/> values are not the same. </summary>
        public static bool operator !=(AzurePricingTier left, AzurePricingTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzurePricingTier"/>. </summary>
        public static implicit operator AzurePricingTier(string value) => new AzurePricingTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzurePricingTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzurePricingTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
