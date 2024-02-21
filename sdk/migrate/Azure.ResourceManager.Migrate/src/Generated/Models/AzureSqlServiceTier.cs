// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzureSqlServiceTier. </summary>
    public readonly partial struct AzureSqlServiceTier : IEquatable<AzureSqlServiceTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureSqlServiceTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureSqlServiceTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AutomaticValue = "Automatic";
        private const string GeneralPurposeValue = "GeneralPurpose";
        private const string BusinessCriticalValue = "BusinessCritical";
        private const string HyperScaleValue = "HyperScale";

        /// <summary> Unknown. </summary>
        public static AzureSqlServiceTier Unknown { get; } = new AzureSqlServiceTier(UnknownValue);
        /// <summary> Automatic. </summary>
        public static AzureSqlServiceTier Automatic { get; } = new AzureSqlServiceTier(AutomaticValue);
        /// <summary> GeneralPurpose. </summary>
        public static AzureSqlServiceTier GeneralPurpose { get; } = new AzureSqlServiceTier(GeneralPurposeValue);
        /// <summary> BusinessCritical. </summary>
        public static AzureSqlServiceTier BusinessCritical { get; } = new AzureSqlServiceTier(BusinessCriticalValue);
        /// <summary> HyperScale. </summary>
        public static AzureSqlServiceTier HyperScale { get; } = new AzureSqlServiceTier(HyperScaleValue);
        /// <summary> Determines if two <see cref="AzureSqlServiceTier"/> values are the same. </summary>
        public static bool operator ==(AzureSqlServiceTier left, AzureSqlServiceTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureSqlServiceTier"/> values are not the same. </summary>
        public static bool operator !=(AzureSqlServiceTier left, AzureSqlServiceTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureSqlServiceTier"/>. </summary>
        public static implicit operator AzureSqlServiceTier(string value) => new AzureSqlServiceTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureSqlServiceTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureSqlServiceTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
