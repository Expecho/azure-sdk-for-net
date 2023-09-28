// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> An error response received from the Azure Batch service. </summary>
    public partial class BatchError
    {
        /// <summary> Initializes a new instance of BatchError. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal BatchError(string code)
        {
            Argument.AssertNotNull(code, nameof(code));

            Code = code;
            Values = new ChangeTrackingList<BatchErrorDetail>();
        }

        /// <summary> Initializes a new instance of BatchError. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the error, intended to be suitable for display in a user interface. </param>
        /// <param name="values"> A collection of key-value pairs containing additional details about the error. </param>
        internal BatchError(string code, ErrorMessage message, IReadOnlyList<BatchErrorDetail> values)
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the error, intended to be suitable for display in a user interface. </summary>
        public ErrorMessage Message { get; }
        /// <summary> A collection of key-value pairs containing additional details about the error. </summary>
        public IReadOnlyList<BatchErrorDetail> Values { get; }
    }
}
