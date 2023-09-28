// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> OnTaskFailure enums. </summary>
    public readonly partial struct OnTaskFailure : IEquatable<OnTaskFailure>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OnTaskFailure"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OnTaskFailure(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoActionValue = "noaction";
        private const string PerformExitOptionsJobActionValue = "performexitoptionsjobaction";

        /// <summary> Do nothing. The Job remains active unless terminated or disabled by some other means. </summary>
        public static OnTaskFailure NoAction { get; } = new OnTaskFailure(NoActionValue);
        /// <summary> Terminate the Job. The Job's terminateReason is set to 'AllTasksComplete'. </summary>
        public static OnTaskFailure PerformExitOptionsJobAction { get; } = new OnTaskFailure(PerformExitOptionsJobActionValue);
        /// <summary> Determines if two <see cref="OnTaskFailure"/> values are the same. </summary>
        public static bool operator ==(OnTaskFailure left, OnTaskFailure right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OnTaskFailure"/> values are not the same. </summary>
        public static bool operator !=(OnTaskFailure left, OnTaskFailure right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OnTaskFailure"/>. </summary>
        public static implicit operator OnTaskFailure(string value) => new OnTaskFailure(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OnTaskFailure other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OnTaskFailure other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
