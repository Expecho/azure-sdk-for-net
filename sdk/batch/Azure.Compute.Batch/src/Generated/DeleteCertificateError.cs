// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> An error encountered by the Batch service when deleting a Certificate. </summary>
    public partial class DeleteCertificateError
    {
        /// <summary> Initializes a new instance of DeleteCertificateError. </summary>
        public DeleteCertificateError()
        {
            Values = new ChangeTrackingList<NameValuePair>();
        }

        /// <summary> Initializes a new instance of DeleteCertificateError. </summary>
        /// <param name="code"> An identifier for the Certificate deletion error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the Certificate deletion error, intended to be suitable for display in a user interface. </param>
        /// <param name="values"> A list of additional error details related to the Certificate deletion error. This list includes details such as the active Pools and Compute Nodes referencing this Certificate. However, if a large number of resources reference the Certificate, the list contains only about the first hundred. </param>
        internal DeleteCertificateError(string code, string message, IList<NameValuePair> values)
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary> An identifier for the Certificate deletion error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; set; }
        /// <summary> A message describing the Certificate deletion error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; set; }
        /// <summary> A list of additional error details related to the Certificate deletion error. This list includes details such as the active Pools and Compute Nodes referencing this Certificate. However, if a large number of resources reference the Certificate, the list contains only about the first hundred. </summary>
        public IList<NameValuePair> Values { get; }
    }
}
