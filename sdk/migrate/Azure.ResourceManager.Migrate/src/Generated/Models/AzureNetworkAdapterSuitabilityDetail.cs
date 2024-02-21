// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzureNetworkAdapterSuitabilityDetail. </summary>
    public readonly partial struct AzureNetworkAdapterSuitabilityDetail : IEquatable<AzureNetworkAdapterSuitabilityDetail>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureNetworkAdapterSuitabilityDetail"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureNetworkAdapterSuitabilityDetail(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MegabytesOfDataTransmittedMissingValue = "MegabytesOfDataTransmittedMissing";
        private const string MegabytesOfDataTransmittedOutOfRangeValue = "MegabytesOfDataTransmittedOutOfRange";
        private const string MegabytesOfDataRecievedMissingValue = "MegabytesOfDataRecievedMissing";
        private const string MegabytesOfDataRecievedOutOfRangeValue = "MegabytesOfDataRecievedOutOfRange";

        /// <summary> None. </summary>
        public static AzureNetworkAdapterSuitabilityDetail None { get; } = new AzureNetworkAdapterSuitabilityDetail(NoneValue);
        /// <summary> MegabytesOfDataTransmittedMissing. </summary>
        public static AzureNetworkAdapterSuitabilityDetail MegabytesOfDataTransmittedMissing { get; } = new AzureNetworkAdapterSuitabilityDetail(MegabytesOfDataTransmittedMissingValue);
        /// <summary> MegabytesOfDataTransmittedOutOfRange. </summary>
        public static AzureNetworkAdapterSuitabilityDetail MegabytesOfDataTransmittedOutOfRange { get; } = new AzureNetworkAdapterSuitabilityDetail(MegabytesOfDataTransmittedOutOfRangeValue);
        /// <summary> MegabytesOfDataRecievedMissing. </summary>
        public static AzureNetworkAdapterSuitabilityDetail MegabytesOfDataRecievedMissing { get; } = new AzureNetworkAdapterSuitabilityDetail(MegabytesOfDataRecievedMissingValue);
        /// <summary> MegabytesOfDataRecievedOutOfRange. </summary>
        public static AzureNetworkAdapterSuitabilityDetail MegabytesOfDataRecievedOutOfRange { get; } = new AzureNetworkAdapterSuitabilityDetail(MegabytesOfDataRecievedOutOfRangeValue);
        /// <summary> Determines if two <see cref="AzureNetworkAdapterSuitabilityDetail"/> values are the same. </summary>
        public static bool operator ==(AzureNetworkAdapterSuitabilityDetail left, AzureNetworkAdapterSuitabilityDetail right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureNetworkAdapterSuitabilityDetail"/> values are not the same. </summary>
        public static bool operator !=(AzureNetworkAdapterSuitabilityDetail left, AzureNetworkAdapterSuitabilityDetail right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureNetworkAdapterSuitabilityDetail"/>. </summary>
        public static implicit operator AzureNetworkAdapterSuitabilityDetail(string value) => new AzureNetworkAdapterSuitabilityDetail(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureNetworkAdapterSuitabilityDetail other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureNetworkAdapterSuitabilityDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
