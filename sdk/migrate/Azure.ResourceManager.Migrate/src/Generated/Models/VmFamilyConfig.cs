// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// VM family name, the list of targeted azure locations and the category of the
    /// family.
    /// </summary>
    public partial class VmFamilyConfig
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

        /// <summary> Initializes a new instance of <see cref="VmFamilyConfig"/>. </summary>
        internal VmFamilyConfig()
        {
            TargetLocations = new ChangeTrackingList<string>();
            Category = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VmFamilyConfig"/>. </summary>
        /// <param name="familyName"> Name of the VM family. </param>
        /// <param name="targetLocations"> List of Azure regions. </param>
        /// <param name="category"> Category of the VM family. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VmFamilyConfig(string familyName, IReadOnlyList<string> targetLocations, IReadOnlyList<string> category, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FamilyName = familyName;
            TargetLocations = targetLocations;
            Category = category;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the VM family. </summary>
        public string FamilyName { get; }
        /// <summary> List of Azure regions. </summary>
        public IReadOnlyList<string> TargetLocations { get; }
        /// <summary> Category of the VM family. </summary>
        public IReadOnlyList<string> Category { get; }
    }
}
