// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The call recording state change event. </summary>
    public partial class CallRecordingStateChangeEvent
    {
        /// <summary> Initializes a new instance of CallRecordingStateChangeEvent. </summary>
        /// <param name="state"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        internal CallRecordingStateChangeEvent(CallRecordingState state, DateTimeOffset startDateTime)
        {
            State = state;
            StartDateTime = startDateTime;
        }

        /// <summary> Initializes a new instance of CallRecordingStateChangeEvent. </summary>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="state"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        /// <param name="callLocator"> The locator used for joining or taking action on a call. </param>
        internal CallRecordingStateChangeEvent(string recordingId, CallRecordingState state, DateTimeOffset startDateTime, CallLocatorModel callLocator)
        {
            RecordingId = recordingId;
            State = state;
            StartDateTime = startDateTime;
            CallLocator = callLocator;
        }

        /// <summary> The call recording id. </summary>
        public string RecordingId { get; }
        /// <summary> The state of the recording. </summary>
        public CallRecordingState State { get; }
        /// <summary> The time of the recording started. </summary>
        public DateTimeOffset StartDateTime { get; }
        /// <summary> The locator used for joining or taking action on a call. </summary>
        public CallLocatorModel CallLocator { get; }
    }
}
