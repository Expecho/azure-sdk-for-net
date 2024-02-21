// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Migrate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary>
    /// A class representing the MigrateAssessmentProject data model.
    /// An Assessment project site resource.
    /// </summary>
    public partial class MigrateAssessmentProjectData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="MigrateAssessmentProjectData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MigrateAssessmentProjectData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<MigratePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateAssessmentProjectData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="createOn"> Time when this project was created. Date-Time represented in ISO-8601 format. </param>
        /// <param name="updatedOn">
        /// Time when this project was last updated. Date-Time represented in ISO-8601
        /// format.
        /// </param>
        /// <param name="serviceEndpoint"> Endpoint at which the collector agent can call agent REST API. </param>
        /// <param name="assessmentSolutionId"> Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects. </param>
        /// <param name="projectStatus"> Assessment project status. </param>
        /// <param name="customerWorkspaceId"> The ARM id of service map workspace created by customer. </param>
        /// <param name="customerWorkspaceLocation"> Location of service map workspace created by customer. </param>
        /// <param name="publicNetworkAccess">
        /// This value can be set to 'enabled' to avoid breaking changes on existing
        /// customer resources and templates. If set to 'disabled', traffic over public
        /// interface is not allowed, and private endpoint connections would be the
        /// exclusive access method.
        /// </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the project. </param>
        /// <param name="customerStorageAccountArmId">
        /// The ARM id of the storage account used for interactions when public access is
        /// disabled.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateAssessmentProjectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MigrateProvisioningState? provisioningState, DateTimeOffset? createOn, DateTimeOffset? updatedOn, string serviceEndpoint, string assessmentSolutionId, AssessmentProjectStatus? projectStatus, string customerWorkspaceId, string customerWorkspaceLocation, string publicNetworkAccess, IReadOnlyList<MigratePrivateEndpointConnectionData> privateEndpointConnections, ResourceIdentifier customerStorageAccountArmId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            CreateOn = createOn;
            UpdatedOn = updatedOn;
            ServiceEndpoint = serviceEndpoint;
            AssessmentSolutionId = assessmentSolutionId;
            ProjectStatus = projectStatus;
            CustomerWorkspaceId = customerWorkspaceId;
            CustomerWorkspaceLocation = customerWorkspaceLocation;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomerStorageAccountArmId = customerStorageAccountArmId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateAssessmentProjectData"/> for deserialization. </summary>
        internal MigrateAssessmentProjectData()
        {
        }

        /// <summary> The status of the last operation. </summary>
        public MigrateProvisioningState? ProvisioningState { get; set; }
        /// <summary> Time when this project was created. Date-Time represented in ISO-8601 format. </summary>
        public DateTimeOffset? CreateOn { get; }
        /// <summary>
        /// Time when this project was last updated. Date-Time represented in ISO-8601
        /// format.
        /// </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint at which the collector agent can call agent REST API. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects. </summary>
        public string AssessmentSolutionId { get; set; }
        /// <summary> Assessment project status. </summary>
        public AssessmentProjectStatus? ProjectStatus { get; set; }
        /// <summary> The ARM id of service map workspace created by customer. </summary>
        public string CustomerWorkspaceId { get; set; }
        /// <summary> Location of service map workspace created by customer. </summary>
        public string CustomerWorkspaceLocation { get; set; }
        /// <summary>
        /// This value can be set to 'enabled' to avoid breaking changes on existing
        /// customer resources and templates. If set to 'disabled', traffic over public
        /// interface is not allowed, and private endpoint connections would be the
        /// exclusive access method.
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary> The list of private endpoint connections to the project. </summary>
        public IReadOnlyList<MigratePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary>
        /// The ARM id of the storage account used for interactions when public access is
        /// disabled.
        /// </summary>
        public ResourceIdentifier CustomerStorageAccountArmId { get; set; }
    }
}
