// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Class representing Azure SQL IAAS suitability details. </summary>
    public partial class SqlAssessmentV2IaasSuitabilityDetails
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

        /// <summary> Initializes a new instance of <see cref="SqlAssessmentV2IaasSuitabilityDetails"/>. </summary>
        internal SqlAssessmentV2IaasSuitabilityDetails()
        {
            ReplicaAzureSqlSku = new ChangeTrackingList<AzureSqlIaasSkuDto>();
            CostComponents = new ChangeTrackingList<CostComponent>();
            MigrationGuidelines = new ChangeTrackingList<SqlMigrationGuideline>();
            RecommendationReasonings = new ChangeTrackingList<SqlRecommendationReasoning>();
            MigrationIssues = new ChangeTrackingList<SqlAssessmentMigrationIssue>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlAssessmentV2IaasSuitabilityDetails"/>. </summary>
        /// <param name="azureSqlSku"> Gets the azure SQL IAAS SKU. </param>
        /// <param name="replicaAzureSqlSku"> Gets the replica azure SQL IAAS SKU. </param>
        /// <param name="sharedResources"> Gets the shared resources. </param>
        /// <param name="monthlyComputeCost"> Gets the monthly compute cost. </param>
        /// <param name="monthlyStorageCost"> Gets the monthly storage cost. </param>
        /// <param name="costComponents"> Gets the collection of cost components. </param>
        /// <param name="securitySuitability"> Gets the suitability for Microsoft cloud defender. </param>
        /// <param name="shouldProvisionReplicas"> Gets a value indicating whether replicas should be provisioned. </param>
        /// <param name="skuReplicationMode"> Gets the replication mode. </param>
        /// <param name="migrationGuidelines"> Gets the list of migration guidelines applicable to this target. </param>
        /// <param name="recommendationReasonings"> Gets the list of SQL recommendation Reasoning. </param>
        /// <param name="migrationTargetPlatform"> Gets the migration target platform. </param>
        /// <param name="suitability"> Gets the azure suitability. </param>
        /// <param name="migrationIssues"> Gets the list of migrations issues. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlAssessmentV2IaasSuitabilityDetails(AzureSqlIaasSkuDto azureSqlSku, IReadOnlyList<AzureSqlIaasSkuDto> replicaAzureSqlSku, SharedResourcesDto sharedResources, double? monthlyComputeCost, double? monthlyStorageCost, IReadOnlyList<CostComponent> costComponents, MigrateCloudSuitability? securitySuitability, bool? shouldProvisionReplicas, SkuReplicationMode? skuReplicationMode, IReadOnlyList<SqlMigrationGuideline> migrationGuidelines, IReadOnlyList<SqlRecommendationReasoning> recommendationReasonings, MigrateTargetType? migrationTargetPlatform, MigrateCloudSuitability? suitability, IReadOnlyList<SqlAssessmentMigrationIssue> migrationIssues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureSqlSku = azureSqlSku;
            ReplicaAzureSqlSku = replicaAzureSqlSku;
            SharedResources = sharedResources;
            MonthlyComputeCost = monthlyComputeCost;
            MonthlyStorageCost = monthlyStorageCost;
            CostComponents = costComponents;
            SecuritySuitability = securitySuitability;
            ShouldProvisionReplicas = shouldProvisionReplicas;
            SkuReplicationMode = skuReplicationMode;
            MigrationGuidelines = migrationGuidelines;
            RecommendationReasonings = recommendationReasonings;
            MigrationTargetPlatform = migrationTargetPlatform;
            Suitability = suitability;
            MigrationIssues = migrationIssues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the azure SQL IAAS SKU. </summary>
        public AzureSqlIaasSkuDto AzureSqlSku { get; }
        /// <summary> Gets the replica azure SQL IAAS SKU. </summary>
        public IReadOnlyList<AzureSqlIaasSkuDto> ReplicaAzureSqlSku { get; }
        /// <summary> Gets the shared resources. </summary>
        public SharedResourcesDto SharedResources { get; }
        /// <summary> Gets the monthly compute cost. </summary>
        public double? MonthlyComputeCost { get; }
        /// <summary> Gets the monthly storage cost. </summary>
        public double? MonthlyStorageCost { get; }
        /// <summary> Gets the collection of cost components. </summary>
        public IReadOnlyList<CostComponent> CostComponents { get; }
        /// <summary> Gets the suitability for Microsoft cloud defender. </summary>
        public MigrateCloudSuitability? SecuritySuitability { get; }
        /// <summary> Gets a value indicating whether replicas should be provisioned. </summary>
        public bool? ShouldProvisionReplicas { get; }
        /// <summary> Gets the replication mode. </summary>
        public SkuReplicationMode? SkuReplicationMode { get; }
        /// <summary> Gets the list of migration guidelines applicable to this target. </summary>
        public IReadOnlyList<SqlMigrationGuideline> MigrationGuidelines { get; }
        /// <summary> Gets the list of SQL recommendation Reasoning. </summary>
        public IReadOnlyList<SqlRecommendationReasoning> RecommendationReasonings { get; }
        /// <summary> Gets the migration target platform. </summary>
        public MigrateTargetType? MigrationTargetPlatform { get; }
        /// <summary> Gets the azure suitability. </summary>
        public MigrateCloudSuitability? Suitability { get; }
        /// <summary> Gets the list of migrations issues. </summary>
        public IReadOnlyList<SqlAssessmentMigrationIssue> MigrationIssues { get; }
    }
}
