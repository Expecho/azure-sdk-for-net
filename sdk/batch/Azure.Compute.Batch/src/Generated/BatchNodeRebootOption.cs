// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchNodeRebootOption enums. </summary>
    public readonly partial struct BatchNodeRebootOption : IEquatable<BatchNodeRebootOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchNodeRebootOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchNodeRebootOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequeueValue = "requeue";
        private const string TerminateValue = "terminate";
        private const string TaskCompletionValue = "taskcompletion";
        private const string RetainedDataValue = "retaineddata";

        /// <summary> Terminate running Task processes and requeue the Tasks. The Tasks will run again when a Compute Node is available. Restart the Compute Node as soon as Tasks have been terminated. </summary>
        public static BatchNodeRebootOption Requeue { get; } = new BatchNodeRebootOption(RequeueValue);
        /// <summary> Terminate running Tasks. The Tasks will be completed with failureInfo indicating that they were terminated, and will not run again. Restart the Compute Node as soon as Tasks have been terminated. </summary>
        public static BatchNodeRebootOption Terminate { get; } = new BatchNodeRebootOption(TerminateValue);
        /// <summary> Allow currently running Tasks to complete. Schedule no new Tasks while waiting. Restart the Compute Node when all Tasks have completed. </summary>
        public static BatchNodeRebootOption TaskCompletion { get; } = new BatchNodeRebootOption(TaskCompletionValue);
        /// <summary> Allow currently running Tasks to complete, then wait for all Task data retention periods to expire. Schedule no new Tasks while waiting. Restart the Compute Node when all Task retention periods have expired. </summary>
        public static BatchNodeRebootOption RetainedData { get; } = new BatchNodeRebootOption(RetainedDataValue);
        /// <summary> Determines if two <see cref="BatchNodeRebootOption"/> values are the same. </summary>
        public static bool operator ==(BatchNodeRebootOption left, BatchNodeRebootOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchNodeRebootOption"/> values are not the same. </summary>
        public static bool operator !=(BatchNodeRebootOption left, BatchNodeRebootOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BatchNodeRebootOption"/>. </summary>
        public static implicit operator BatchNodeRebootOption(string value) => new BatchNodeRebootOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchNodeRebootOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchNodeRebootOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
