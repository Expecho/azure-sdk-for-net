// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The Age Unit of measurement. </summary>
    public readonly partial struct AgeUnit : IEquatable<AgeUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgeUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgeUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnspecifiedValue = "Unspecified";
        private const string YearValue = "Year";
        private const string MonthValue = "Month";
        private const string WeekValue = "Week";
        private const string DayValue = "Day";

        /// <summary> Unspecified. </summary>
        public static AgeUnit Unspecified { get; } = new AgeUnit(UnspecifiedValue);
        /// <summary> Year. </summary>
        public static AgeUnit Year { get; } = new AgeUnit(YearValue);
        /// <summary> Month. </summary>
        public static AgeUnit Month { get; } = new AgeUnit(MonthValue);
        /// <summary> Week. </summary>
        public static AgeUnit Week { get; } = new AgeUnit(WeekValue);
        /// <summary> Day. </summary>
        public static AgeUnit Day { get; } = new AgeUnit(DayValue);
        /// <summary> Determines if two <see cref="AgeUnit"/> values are the same. </summary>
        public static bool operator ==(AgeUnit left, AgeUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgeUnit"/> values are not the same. </summary>
        public static bool operator !=(AgeUnit left, AgeUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AgeUnit"/>. </summary>
        public static implicit operator AgeUnit(string value) => new AgeUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgeUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgeUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
