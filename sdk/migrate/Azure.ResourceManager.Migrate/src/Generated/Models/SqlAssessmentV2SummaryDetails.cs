// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> SQL Assessment V2 summary data. </summary>
    public partial class SqlAssessmentV2SummaryDetails
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

        /// <summary> Initializes a new instance of <see cref="SqlAssessmentV2SummaryDetails"/>. </summary>
        internal SqlAssessmentV2SummaryDetails()
        {
            SuitabilitySummary = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlAssessmentV2SummaryDetails"/>. </summary>
        /// <param name="suitabilitySummary"> Sql assessment summary data. </param>
        /// <param name="monthlyComputeCost"> Monthly compute cost. </param>
        /// <param name="monthlyStorageCost"> Monthly storage cost. </param>
        /// <param name="monthlyLicenseCost"> Monthly license cost. </param>
        /// <param name="confidenceScore"> Confidence Rating. </param>
        /// <param name="monthlySecurityCost"> Monthly security cost. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlAssessmentV2SummaryDetails(IReadOnlyDictionary<string, int> suitabilitySummary, double? monthlyComputeCost, double? monthlyStorageCost, double? monthlyLicenseCost, double? confidenceScore, double? monthlySecurityCost, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SuitabilitySummary = suitabilitySummary;
            MonthlyComputeCost = monthlyComputeCost;
            MonthlyStorageCost = monthlyStorageCost;
            MonthlyLicenseCost = monthlyLicenseCost;
            ConfidenceScore = confidenceScore;
            MonthlySecurityCost = monthlySecurityCost;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sql assessment summary data. </summary>
        public IReadOnlyDictionary<string, int> SuitabilitySummary { get; }
        /// <summary> Monthly compute cost. </summary>
        public double? MonthlyComputeCost { get; }
        /// <summary> Monthly storage cost. </summary>
        public double? MonthlyStorageCost { get; }
        /// <summary> Monthly license cost. </summary>
        public double? MonthlyLicenseCost { get; }
        /// <summary> Confidence Rating. </summary>
        public double? ConfidenceScore { get; }
        /// <summary> Monthly security cost. </summary>
        public double? MonthlySecurityCost { get; }
    }
}
