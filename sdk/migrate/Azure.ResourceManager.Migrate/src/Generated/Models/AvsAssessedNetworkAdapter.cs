// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Second level object returned as part of AVS AssessedMachine REST resource. </summary>
    public partial class AvsAssessedNetworkAdapter
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvsAssessedNetworkAdapter"/>. </summary>
        internal AvsAssessedNetworkAdapter()
        {
            IPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsAssessedNetworkAdapter"/>. </summary>
        /// <param name="macAddress"> Mac address of the NIC. </param>
        /// <param name="ipAddresses"> IP V4 addresses for the machine. </param>
        /// <param name="displayName"> Gets the display name of the network adapter. </param>
        /// <param name="megabytesPerSecondReceived">
        /// Gets the Received data for Network Adapter in MB/s.
        ///             This value is
        /// the percentile of historical data based on options selected in Assessment.
        /// </param>
        /// <param name="megabytesPerSecondTransmitted">
        /// Gets the Transmitted data for Network Adapter in MB/s.
        ///             This value
        /// is the percentile of historical data based on options selected in Assessment.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsAssessedNetworkAdapter(string macAddress, IReadOnlyList<string> ipAddresses, string displayName, double? megabytesPerSecondReceived, double? megabytesPerSecondTransmitted, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MacAddress = macAddress;
            IPAddresses = ipAddresses;
            DisplayName = displayName;
            MegabytesPerSecondReceived = megabytesPerSecondReceived;
            MegabytesPerSecondTransmitted = megabytesPerSecondTransmitted;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Mac address of the NIC. </summary>
        public string MacAddress { get; }
        /// <summary> IP V4 addresses for the machine. </summary>
        public IReadOnlyList<string> IPAddresses { get; }
        /// <summary> Gets the display name of the network adapter. </summary>
        public string DisplayName { get; }
        /// <summary>
        /// Gets the Received data for Network Adapter in MB/s.
        ///             This value is
        /// the percentile of historical data based on options selected in Assessment.
        /// </summary>
        public double? MegabytesPerSecondReceived { get; }
        /// <summary>
        /// Gets the Transmitted data for Network Adapter in MB/s.
        ///             This value
        /// is the percentile of historical data based on options selected in Assessment.
        /// </summary>
        public double? MegabytesPerSecondTransmitted { get; }
    }
}
