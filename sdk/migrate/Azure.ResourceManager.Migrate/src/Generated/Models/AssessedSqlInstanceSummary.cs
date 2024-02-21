// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Assessed Sql Instance Summary. </summary>
    public partial class AssessedSqlInstanceSummary
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

        /// <summary> Initializes a new instance of <see cref="AssessedSqlInstanceSummary"/>. </summary>
        internal AssessedSqlInstanceSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AssessedSqlInstanceSummary"/>. </summary>
        /// <param name="instanceId"> Gets the instance id. </param>
        /// <param name="instanceName"> Gets the instance name. </param>
        /// <param name="sqlInstanceSdsArmId"> Gets the instance arm id. </param>
        /// <param name="sqlInstanceEntityId"> Gets the instance entity id. </param>
        /// <param name="sqlEdition"> Gets the Sql edition. </param>
        /// <param name="sqlVersion"> Gets the Sql version. </param>
        /// <param name="isClustered"> Gets whether Sql is clustered. </param>
        /// <param name="isHighAvailabilityEnabled"> Gets whether Sql is highly available. </param>
        /// <param name="sqlFciState"> Gets the Sql Fci state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssessedSqlInstanceSummary(string instanceId, string instanceName, ResourceIdentifier sqlInstanceSdsArmId, string sqlInstanceEntityId, string sqlEdition, string sqlVersion, bool? isClustered, bool? isHighAvailabilityEnabled, SqlFciState? sqlFciState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceId = instanceId;
            InstanceName = instanceName;
            SqlInstanceSdsArmId = sqlInstanceSdsArmId;
            SqlInstanceEntityId = sqlInstanceEntityId;
            SqlEdition = sqlEdition;
            SqlVersion = sqlVersion;
            IsClustered = isClustered;
            IsHighAvailabilityEnabled = isHighAvailabilityEnabled;
            SqlFciState = sqlFciState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the instance id. </summary>
        public string InstanceId { get; }
        /// <summary> Gets the instance name. </summary>
        public string InstanceName { get; }
        /// <summary> Gets the instance arm id. </summary>
        public ResourceIdentifier SqlInstanceSdsArmId { get; }
        /// <summary> Gets the instance entity id. </summary>
        public string SqlInstanceEntityId { get; }
        /// <summary> Gets the Sql edition. </summary>
        public string SqlEdition { get; }
        /// <summary> Gets the Sql version. </summary>
        public string SqlVersion { get; }
        /// <summary> Gets whether Sql is clustered. </summary>
        public bool? IsClustered { get; }
        /// <summary> Gets whether Sql is highly available. </summary>
        public bool? IsHighAvailabilityEnabled { get; }
        /// <summary> Gets the Sql Fci state. </summary>
        public SqlFciState? SqlFciState { get; }
    }
}
