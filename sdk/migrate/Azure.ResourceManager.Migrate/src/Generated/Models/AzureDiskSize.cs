// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The AzureDiskSize. </summary>
    public readonly partial struct AzureDiskSize : IEquatable<AzureDiskSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureDiskSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureDiskSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string StandardS4Value = "Standard_S4";
        private const string StandardS6Value = "Standard_S6";
        private const string StandardS10Value = "Standard_S10";
        private const string StandardS15Value = "Standard_S15";
        private const string StandardS20Value = "Standard_S20";
        private const string StandardS30Value = "Standard_S30";
        private const string StandardS40Value = "Standard_S40";
        private const string StandardS50Value = "Standard_S50";
        private const string StandardS60Value = "Standard_S60";
        private const string StandardS70Value = "Standard_S70";
        private const string StandardS80Value = "Standard_S80";
        private const string PremiumP4Value = "Premium_P4";
        private const string PremiumP6Value = "Premium_P6";
        private const string PremiumP10Value = "Premium_P10";
        private const string PremiumP15Value = "Premium_P15";
        private const string PremiumP20Value = "Premium_P20";
        private const string PremiumP30Value = "Premium_P30";
        private const string PremiumP40Value = "Premium_P40";
        private const string PremiumP50Value = "Premium_P50";
        private const string PremiumP60Value = "Premium_P60";
        private const string PremiumP70Value = "Premium_P70";
        private const string PremiumP80Value = "Premium_P80";
        private const string StandardSsde10Value = "StandardSSD_E10";
        private const string StandardSsde15Value = "StandardSSD_E15";
        private const string StandardSsde20Value = "StandardSSD_E20";
        private const string StandardSsde30Value = "StandardSSD_E30";
        private const string StandardSsde40Value = "StandardSSD_E40";
        private const string StandardSsde50Value = "StandardSSD_E50";
        private const string StandardSsde60Value = "StandardSSD_E60";
        private const string StandardSsde70Value = "StandardSSD_E70";
        private const string StandardSsde80Value = "StandardSSD_E80";
        private const string StandardSsde4Value = "StandardSSD_E4";
        private const string StandardSsde6Value = "StandardSSD_E6";
        private const string StandardSsde1Value = "StandardSSD_E1";
        private const string StandardSsde2Value = "StandardSSD_E2";
        private const string StandardSsde3Value = "StandardSSD_E3";
        private const string PremiumP1Value = "Premium_P1";
        private const string PremiumP2Value = "Premium_P2";
        private const string PremiumP3Value = "Premium_P3";
        private const string UltraValue = "Ultra";
        private const string PremiumV2Value = "PremiumV2";

        /// <summary> Unknown. </summary>
        public static AzureDiskSize Unknown { get; } = new AzureDiskSize(UnknownValue);
        /// <summary> Standard_S4. </summary>
        public static AzureDiskSize StandardS4 { get; } = new AzureDiskSize(StandardS4Value);
        /// <summary> Standard_S6. </summary>
        public static AzureDiskSize StandardS6 { get; } = new AzureDiskSize(StandardS6Value);
        /// <summary> Standard_S10. </summary>
        public static AzureDiskSize StandardS10 { get; } = new AzureDiskSize(StandardS10Value);
        /// <summary> Standard_S15. </summary>
        public static AzureDiskSize StandardS15 { get; } = new AzureDiskSize(StandardS15Value);
        /// <summary> Standard_S20. </summary>
        public static AzureDiskSize StandardS20 { get; } = new AzureDiskSize(StandardS20Value);
        /// <summary> Standard_S30. </summary>
        public static AzureDiskSize StandardS30 { get; } = new AzureDiskSize(StandardS30Value);
        /// <summary> Standard_S40. </summary>
        public static AzureDiskSize StandardS40 { get; } = new AzureDiskSize(StandardS40Value);
        /// <summary> Standard_S50. </summary>
        public static AzureDiskSize StandardS50 { get; } = new AzureDiskSize(StandardS50Value);
        /// <summary> Standard_S60. </summary>
        public static AzureDiskSize StandardS60 { get; } = new AzureDiskSize(StandardS60Value);
        /// <summary> Standard_S70. </summary>
        public static AzureDiskSize StandardS70 { get; } = new AzureDiskSize(StandardS70Value);
        /// <summary> Standard_S80. </summary>
        public static AzureDiskSize StandardS80 { get; } = new AzureDiskSize(StandardS80Value);
        /// <summary> Premium_P4. </summary>
        public static AzureDiskSize PremiumP4 { get; } = new AzureDiskSize(PremiumP4Value);
        /// <summary> Premium_P6. </summary>
        public static AzureDiskSize PremiumP6 { get; } = new AzureDiskSize(PremiumP6Value);
        /// <summary> Premium_P10. </summary>
        public static AzureDiskSize PremiumP10 { get; } = new AzureDiskSize(PremiumP10Value);
        /// <summary> Premium_P15. </summary>
        public static AzureDiskSize PremiumP15 { get; } = new AzureDiskSize(PremiumP15Value);
        /// <summary> Premium_P20. </summary>
        public static AzureDiskSize PremiumP20 { get; } = new AzureDiskSize(PremiumP20Value);
        /// <summary> Premium_P30. </summary>
        public static AzureDiskSize PremiumP30 { get; } = new AzureDiskSize(PremiumP30Value);
        /// <summary> Premium_P40. </summary>
        public static AzureDiskSize PremiumP40 { get; } = new AzureDiskSize(PremiumP40Value);
        /// <summary> Premium_P50. </summary>
        public static AzureDiskSize PremiumP50 { get; } = new AzureDiskSize(PremiumP50Value);
        /// <summary> Premium_P60. </summary>
        public static AzureDiskSize PremiumP60 { get; } = new AzureDiskSize(PremiumP60Value);
        /// <summary> Premium_P70. </summary>
        public static AzureDiskSize PremiumP70 { get; } = new AzureDiskSize(PremiumP70Value);
        /// <summary> Premium_P80. </summary>
        public static AzureDiskSize PremiumP80 { get; } = new AzureDiskSize(PremiumP80Value);
        /// <summary> StandardSSD_E10. </summary>
        public static AzureDiskSize StandardSsde10 { get; } = new AzureDiskSize(StandardSsde10Value);
        /// <summary> StandardSSD_E15. </summary>
        public static AzureDiskSize StandardSsde15 { get; } = new AzureDiskSize(StandardSsde15Value);
        /// <summary> StandardSSD_E20. </summary>
        public static AzureDiskSize StandardSsde20 { get; } = new AzureDiskSize(StandardSsde20Value);
        /// <summary> StandardSSD_E30. </summary>
        public static AzureDiskSize StandardSsde30 { get; } = new AzureDiskSize(StandardSsde30Value);
        /// <summary> StandardSSD_E40. </summary>
        public static AzureDiskSize StandardSsde40 { get; } = new AzureDiskSize(StandardSsde40Value);
        /// <summary> StandardSSD_E50. </summary>
        public static AzureDiskSize StandardSsde50 { get; } = new AzureDiskSize(StandardSsde50Value);
        /// <summary> StandardSSD_E60. </summary>
        public static AzureDiskSize StandardSsde60 { get; } = new AzureDiskSize(StandardSsde60Value);
        /// <summary> StandardSSD_E70. </summary>
        public static AzureDiskSize StandardSsde70 { get; } = new AzureDiskSize(StandardSsde70Value);
        /// <summary> StandardSSD_E80. </summary>
        public static AzureDiskSize StandardSsde80 { get; } = new AzureDiskSize(StandardSsde80Value);
        /// <summary> StandardSSD_E4. </summary>
        public static AzureDiskSize StandardSsde4 { get; } = new AzureDiskSize(StandardSsde4Value);
        /// <summary> StandardSSD_E6. </summary>
        public static AzureDiskSize StandardSsde6 { get; } = new AzureDiskSize(StandardSsde6Value);
        /// <summary> StandardSSD_E1. </summary>
        public static AzureDiskSize StandardSsde1 { get; } = new AzureDiskSize(StandardSsde1Value);
        /// <summary> StandardSSD_E2. </summary>
        public static AzureDiskSize StandardSsde2 { get; } = new AzureDiskSize(StandardSsde2Value);
        /// <summary> StandardSSD_E3. </summary>
        public static AzureDiskSize StandardSsde3 { get; } = new AzureDiskSize(StandardSsde3Value);
        /// <summary> Premium_P1. </summary>
        public static AzureDiskSize PremiumP1 { get; } = new AzureDiskSize(PremiumP1Value);
        /// <summary> Premium_P2. </summary>
        public static AzureDiskSize PremiumP2 { get; } = new AzureDiskSize(PremiumP2Value);
        /// <summary> Premium_P3. </summary>
        public static AzureDiskSize PremiumP3 { get; } = new AzureDiskSize(PremiumP3Value);
        /// <summary> Ultra. </summary>
        public static AzureDiskSize Ultra { get; } = new AzureDiskSize(UltraValue);
        /// <summary> PremiumV2. </summary>
        public static AzureDiskSize PremiumV2 { get; } = new AzureDiskSize(PremiumV2Value);
        /// <summary> Determines if two <see cref="AzureDiskSize"/> values are the same. </summary>
        public static bool operator ==(AzureDiskSize left, AzureDiskSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureDiskSize"/> values are not the same. </summary>
        public static bool operator !=(AzureDiskSize left, AzureDiskSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureDiskSize"/>. </summary>
        public static implicit operator AzureDiskSize(string value) => new AzureDiskSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureDiskSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureDiskSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
