// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzureManagedDiskSkuDtoDiskType. </summary>
    public readonly partial struct AzureManagedDiskSkuDtoDiskType : IEquatable<AzureManagedDiskSkuDtoDiskType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureManagedDiskSkuDtoDiskType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureManagedDiskSkuDtoDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string StandardValue = "Standard";
        private const string StandardSsdValue = "StandardSSD";
        private const string PremiumValue = "Premium";
        private const string StandardOrPremiumValue = "StandardOrPremium";
        private const string UltraValue = "Ultra";
        private const string PremiumV2Value = "PremiumV2";

        /// <summary> Unknown. </summary>
        public static AzureManagedDiskSkuDtoDiskType Unknown { get; } = new AzureManagedDiskSkuDtoDiskType(UnknownValue);
        /// <summary> Standard. </summary>
        public static AzureManagedDiskSkuDtoDiskType Standard { get; } = new AzureManagedDiskSkuDtoDiskType(StandardValue);
        /// <summary> StandardSSD. </summary>
        public static AzureManagedDiskSkuDtoDiskType StandardSsd { get; } = new AzureManagedDiskSkuDtoDiskType(StandardSsdValue);
        /// <summary> Premium. </summary>
        public static AzureManagedDiskSkuDtoDiskType Premium { get; } = new AzureManagedDiskSkuDtoDiskType(PremiumValue);
        /// <summary> StandardOrPremium. </summary>
        public static AzureManagedDiskSkuDtoDiskType StandardOrPremium { get; } = new AzureManagedDiskSkuDtoDiskType(StandardOrPremiumValue);
        /// <summary> Ultra. </summary>
        public static AzureManagedDiskSkuDtoDiskType Ultra { get; } = new AzureManagedDiskSkuDtoDiskType(UltraValue);
        /// <summary> PremiumV2. </summary>
        public static AzureManagedDiskSkuDtoDiskType PremiumV2 { get; } = new AzureManagedDiskSkuDtoDiskType(PremiumV2Value);
        /// <summary> Determines if two <see cref="AzureManagedDiskSkuDtoDiskType"/> values are the same. </summary>
        public static bool operator ==(AzureManagedDiskSkuDtoDiskType left, AzureManagedDiskSkuDtoDiskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureManagedDiskSkuDtoDiskType"/> values are not the same. </summary>
        public static bool operator !=(AzureManagedDiskSkuDtoDiskType left, AzureManagedDiskSkuDtoDiskType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureManagedDiskSkuDtoDiskType"/>. </summary>
        public static implicit operator AzureManagedDiskSkuDtoDiskType(string value) => new AzureManagedDiskSkuDtoDiskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureManagedDiskSkuDtoDiskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureManagedDiskSkuDtoDiskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
