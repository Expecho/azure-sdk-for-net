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
    /// A class representing the MigrateMachine data model.
    /// Machine resource.
    /// </summary>
    public partial class MigrateMachineData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MigrateMachineData"/>. </summary>
        public MigrateMachineData()
        {
            Errors = new ChangeTrackingList<MigrateError>();
            Disks = new ChangeTrackingDictionary<string, MigrateDisk>();
            Groups = new ChangeTrackingList<string>();
            NetworkAdapters = new ChangeTrackingDictionary<string, MigrateNetworkAdapter>();
            SqlInstances = new ChangeTrackingList<string>();
            WebApplications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="workloadSummary"> Gets or sets workload summary. </param>
        /// <param name="errors"> List of errors for this machine. </param>
        /// <param name="hostProcessor"> Gets Processor details of the host. </param>
        /// <param name="productSupportStatus"> Gets the product support status related details. </param>
        /// <param name="discoveryMachineArmId"> Site id of machine discovered in private data center. </param>
        /// <param name="datacenterManagementServerArmId"> The data center management server ARM Id for the machine. </param>
        /// <param name="datacenterManagementServerName"> The data center management server name for the machine. </param>
        /// <param name="bootType"> Boot type of machine discovered in private data center. </param>
        /// <param name="displayName"> Display Name of the Machine. </param>
        /// <param name="megabytesOfMemory"> Megabytes of memory found allocated for the machine in private data center. </param>
        /// <param name="numberOfCores"> Number of CPU cores found on the machine. </param>
        /// <param name="operatingSystemType"> Operating system as reported by datacenter management solution. </param>
        /// <param name="operatingSystemName"> Operating system as reported by datacenter management solution. </param>
        /// <param name="operatingSystemVersion"> Operating system version as reported by datacenter management solution. </param>
        /// <param name="description"> Description for the machine. </param>
        /// <param name="createdOn"> When was machine first created. </param>
        /// <param name="disks"> Disks attached to the machine discovered in private data center. </param>
        /// <param name="groups"> Gets the References to the groups that this machine is member of. </param>
        /// <param name="networkAdapters"> Network adapters attached to the machine discovered in private data center. </param>
        /// <param name="sqlInstances"> SQL instances discovered on the machine. </param>
        /// <param name="webApplications"> Web applications discovered on the machine. </param>
        /// <param name="updatedOn"> When was machine last updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WorkloadSummary workloadSummary, IReadOnlyList<MigrateError> errors, ProcessorInfo hostProcessor, ProductSupportStatus productSupportStatus, ResourceIdentifier discoveryMachineArmId, ResourceIdentifier datacenterManagementServerArmId, string datacenterManagementServerName, MachineBootType? bootType, string displayName, double? megabytesOfMemory, int? numberOfCores, string operatingSystemType, string operatingSystemName, string operatingSystemVersion, string description, DateTimeOffset? createdOn, IReadOnlyDictionary<string, MigrateDisk> disks, IReadOnlyList<string> groups, IReadOnlyDictionary<string, MigrateNetworkAdapter> networkAdapters, IReadOnlyList<string> sqlInstances, IReadOnlyList<string> webApplications, DateTimeOffset? updatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WorkloadSummary = workloadSummary;
            Errors = errors;
            HostProcessor = hostProcessor;
            ProductSupportStatus = productSupportStatus;
            DiscoveryMachineArmId = discoveryMachineArmId;
            DatacenterManagementServerArmId = datacenterManagementServerArmId;
            DatacenterManagementServerName = datacenterManagementServerName;
            BootType = bootType;
            DisplayName = displayName;
            MegabytesOfMemory = megabytesOfMemory;
            NumberOfCores = numberOfCores;
            OperatingSystemType = operatingSystemType;
            OperatingSystemName = operatingSystemName;
            OperatingSystemVersion = operatingSystemVersion;
            Description = description;
            CreatedOn = createdOn;
            Disks = disks;
            Groups = groups;
            NetworkAdapters = networkAdapters;
            SqlInstances = sqlInstances;
            WebApplications = webApplications;
            UpdatedOn = updatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets workload summary. </summary>
        public WorkloadSummary WorkloadSummary { get; }
        /// <summary> List of errors for this machine. </summary>
        public IReadOnlyList<MigrateError> Errors { get; }
        /// <summary> Gets Processor details of the host. </summary>
        public ProcessorInfo HostProcessor { get; }
        /// <summary> Gets the product support status related details. </summary>
        public ProductSupportStatus ProductSupportStatus { get; }
        /// <summary> Site id of machine discovered in private data center. </summary>
        public ResourceIdentifier DiscoveryMachineArmId { get; }
        /// <summary> The data center management server ARM Id for the machine. </summary>
        public ResourceIdentifier DatacenterManagementServerArmId { get; }
        /// <summary> The data center management server name for the machine. </summary>
        public string DatacenterManagementServerName { get; }
        /// <summary> Boot type of machine discovered in private data center. </summary>
        public MachineBootType? BootType { get; }
        /// <summary> Display Name of the Machine. </summary>
        public string DisplayName { get; }
        /// <summary> Megabytes of memory found allocated for the machine in private data center. </summary>
        public double? MegabytesOfMemory { get; }
        /// <summary> Number of CPU cores found on the machine. </summary>
        public int? NumberOfCores { get; }
        /// <summary> Operating system as reported by datacenter management solution. </summary>
        public string OperatingSystemType { get; }
        /// <summary> Operating system as reported by datacenter management solution. </summary>
        public string OperatingSystemName { get; }
        /// <summary> Operating system version as reported by datacenter management solution. </summary>
        public string OperatingSystemVersion { get; }
        /// <summary> Description for the machine. </summary>
        public string Description { get; }
        /// <summary> When was machine first created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Disks attached to the machine discovered in private data center. </summary>
        public IReadOnlyDictionary<string, MigrateDisk> Disks { get; }
        /// <summary> Gets the References to the groups that this machine is member of. </summary>
        public IReadOnlyList<string> Groups { get; }
        /// <summary> Network adapters attached to the machine discovered in private data center. </summary>
        public IReadOnlyDictionary<string, MigrateNetworkAdapter> NetworkAdapters { get; }
        /// <summary> SQL instances discovered on the machine. </summary>
        public IReadOnlyList<string> SqlInstances { get; }
        /// <summary> Web applications discovered on the machine. </summary>
        public IReadOnlyList<string> WebApplications { get; }
        /// <summary> When was machine last updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
