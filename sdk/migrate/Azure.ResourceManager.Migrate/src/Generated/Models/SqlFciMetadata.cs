// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Sql fci meta data. </summary>
    public partial class SqlFciMetadata
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

        /// <summary> Initializes a new instance of <see cref="SqlFciMetadata"/>. </summary>
        internal SqlFciMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlFciMetadata"/>. </summary>
        /// <param name="state"> Gets the Sql fci meta data state. </param>
        /// <param name="isMultiSubnet"> Gets whether fci is multi subnet. </param>
        /// <param name="fciSharedDiskCount"> Gets the fci shared disk count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlFciMetadata(SqlFciMetadataState? state, bool? isMultiSubnet, int? fciSharedDiskCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            IsMultiSubnet = isMultiSubnet;
            FciSharedDiskCount = fciSharedDiskCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the Sql fci meta data state. </summary>
        public SqlFciMetadataState? State { get; }
        /// <summary> Gets whether fci is multi subnet. </summary>
        public bool? IsMultiSubnet { get; }
        /// <summary> Gets the fci shared disk count. </summary>
        public int? FciSharedDiskCount { get; }
    }
}
