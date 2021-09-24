// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for redirecting the call. </summary>
    internal partial class RedirectCallRequest
    {
        /// <summary> Initializes a new instance of RedirectCallRequest. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="targets"> The target identity to redirect the call to. </param>
        /// <param name="callbackUrl"> The callback url. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/>, <paramref name="targets"/>, or <paramref name="callbackUrl"/> is null. </exception>
        public RedirectCallRequest(string incomingCallContext, IEnumerable<CommunicationIdentifierModel> targets, string callbackUrl)
        {
            if (incomingCallContext == null)
            {
                throw new ArgumentNullException(nameof(incomingCallContext));
            }
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }
            if (callbackUrl == null)
            {
                throw new ArgumentNullException(nameof(callbackUrl));
            }

            IncomingCallContext = incomingCallContext;
            Targets = targets.ToList();
            CallbackUrl = callbackUrl;
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The target identity to redirect the call to. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The callback url. </summary>
        public string CallbackUrl { get; }
        /// <summary> The timeout for the redirect in seconds. </summary>
        public int? Timeout { get; set; }
    }
}
