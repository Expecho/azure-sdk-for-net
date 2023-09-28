// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> SubtaskState enums. </summary>
    public readonly partial struct SubtaskState : IEquatable<SubtaskState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SubtaskState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubtaskState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreparingValue = "preparing";
        private const string RunningValue = "running";
        private const string CompletedValue = "completed";

        /// <summary> The Task has been assigned to a Compute Node, but is waiting for a required Job Preparation Task to complete on the Compute Node. If the Job Preparation Task succeeds, the Task will move to running. If the Job Preparation Task fails, the Task will return to active and will be eligible to be assigned to a different Compute Node. </summary>
        public static SubtaskState Preparing { get; } = new SubtaskState(PreparingValue);
        /// <summary> The Task is running on a Compute Node. This includes task-level preparation such as downloading resource files or deploying Packages specified on the Task - it does not necessarily mean that the Task command line has started executing. </summary>
        public static SubtaskState Running { get; } = new SubtaskState(RunningValue);
        /// <summary> The Task is no longer eligible to run, usually because the Task has finished successfully, or the Task has finished unsuccessfully and has exhausted its retry limit. A Task is also marked as completed if an error occurred launching the Task, or when the Task has been terminated. </summary>
        public static SubtaskState Completed { get; } = new SubtaskState(CompletedValue);
        /// <summary> Determines if two <see cref="SubtaskState"/> values are the same. </summary>
        public static bool operator ==(SubtaskState left, SubtaskState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubtaskState"/> values are not the same. </summary>
        public static bool operator !=(SubtaskState left, SubtaskState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SubtaskState"/>. </summary>
        public static implicit operator SubtaskState(string value) => new SubtaskState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubtaskState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubtaskState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
