// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchNodeDeallocationOption enums. </summary>
    public readonly partial struct BatchNodeDeallocationOption : IEquatable<BatchNodeDeallocationOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchNodeDeallocationOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchNodeDeallocationOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequeueValue = "requeue";
        private const string TerminateValue = "terminate";
        private const string TaskCompletionValue = "taskcompletion";
        private const string RetainedDataValue = "retaineddata";

        /// <summary> Terminate running Task processes and requeue the Tasks. The Tasks will run again when a Compute Node is available. Remove Compute Nodes as soon as Tasks have been terminated. </summary>
        public static BatchNodeDeallocationOption Requeue { get; } = new BatchNodeDeallocationOption(RequeueValue);
        /// <summary> Terminate running Tasks. The Tasks will be completed with failureInfo indicating that they were terminated, and will not run again. Remove Compute Nodes as soon as Tasks have been terminated. </summary>
        public static BatchNodeDeallocationOption Terminate { get; } = new BatchNodeDeallocationOption(TerminateValue);
        /// <summary> Allow currently running Tasks to complete. Schedule no new Tasks while waiting. Remove Compute Nodes when all Tasks have completed. </summary>
        public static BatchNodeDeallocationOption TaskCompletion { get; } = new BatchNodeDeallocationOption(TaskCompletionValue);
        /// <summary> Allow currently running Tasks to complete, then wait for all Task data retention periods to expire. Schedule no new Tasks while waiting. Remove Compute Nodes when all Task retention periods have expired. </summary>
        public static BatchNodeDeallocationOption RetainedData { get; } = new BatchNodeDeallocationOption(RetainedDataValue);
        /// <summary> Determines if two <see cref="BatchNodeDeallocationOption"/> values are the same. </summary>
        public static bool operator ==(BatchNodeDeallocationOption left, BatchNodeDeallocationOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchNodeDeallocationOption"/> values are not the same. </summary>
        public static bool operator !=(BatchNodeDeallocationOption left, BatchNodeDeallocationOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BatchNodeDeallocationOption"/>. </summary>
        public static implicit operator BatchNodeDeallocationOption(string value) => new BatchNodeDeallocationOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchNodeDeallocationOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchNodeDeallocationOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
