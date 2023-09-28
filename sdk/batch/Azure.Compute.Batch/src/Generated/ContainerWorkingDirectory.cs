// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> ContainerWorkingDirectory enums. </summary>
    public readonly partial struct ContainerWorkingDirectory : IEquatable<ContainerWorkingDirectory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerWorkingDirectory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerWorkingDirectory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TaskWorkingDirectoryValue = "taskWorkingDirectory";
        private const string ContainerImageDefaultValue = "containerImageDefault";

        /// <summary> Use the standard Batch service Task working directory, which will contain the Task Resource Files populated by Batch. </summary>
        public static ContainerWorkingDirectory TaskWorkingDirectory { get; } = new ContainerWorkingDirectory(TaskWorkingDirectoryValue);
        /// <summary> Use the working directory defined in the container Image. Beware that this directory will not contain the Resource Files downloaded by Batch. </summary>
        public static ContainerWorkingDirectory ContainerImageDefault { get; } = new ContainerWorkingDirectory(ContainerImageDefaultValue);
        /// <summary> Determines if two <see cref="ContainerWorkingDirectory"/> values are the same. </summary>
        public static bool operator ==(ContainerWorkingDirectory left, ContainerWorkingDirectory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerWorkingDirectory"/> values are not the same. </summary>
        public static bool operator !=(ContainerWorkingDirectory left, ContainerWorkingDirectory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerWorkingDirectory"/>. </summary>
        public static implicit operator ContainerWorkingDirectory(string value) => new ContainerWorkingDirectory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerWorkingDirectory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerWorkingDirectory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
