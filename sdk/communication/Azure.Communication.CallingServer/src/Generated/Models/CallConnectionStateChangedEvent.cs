// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The call connection state changed event. </summary>
    public partial class CallConnectionStateChangedEvent
    {
        /// <summary> Initializes a new instance of CallConnectionStateChangedEvent. </summary>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        internal CallConnectionStateChangedEvent(CallConnectionState callConnectionState)
        {
            CallConnectionState = callConnectionState;
        }

        /// <summary> Initializes a new instance of CallConnectionStateChangedEvent. </summary>
        /// <param name="serverCallId"> The server call.id. </param>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        internal CallConnectionStateChangedEvent(string serverCallId, string callConnectionId, CallConnectionState callConnectionState)
        {
            ServerCallId = serverCallId;
            CallConnectionId = callConnectionId;
            CallConnectionState = callConnectionState;
        }

        /// <summary> The server call.id. </summary>
        public string ServerCallId { get; }
        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState CallConnectionState { get; }
    }
}
