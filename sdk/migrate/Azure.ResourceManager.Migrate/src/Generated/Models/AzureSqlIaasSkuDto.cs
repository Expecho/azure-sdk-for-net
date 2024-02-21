// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Class representing Azure SQL IAAS SKU. </summary>
    public partial class AzureSqlIaasSkuDto
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

        /// <summary> Initializes a new instance of <see cref="AzureSqlIaasSkuDto"/>. </summary>
        internal AzureSqlIaasSkuDto()
        {
            DataDiskSizes = new ChangeTrackingList<AzureManagedDiskSkuDto>();
            LogDiskSizes = new ChangeTrackingList<AzureManagedDiskSkuDto>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureSqlIaasSkuDto"/>. </summary>
        /// <param name="virtualMachineSize"> Gets the The Azure Compute Virtual Machine. </param>
        /// <param name="dataDiskSizes"> Gets the The list of data disk sizes. </param>
        /// <param name="logDiskSizes"> Gets the The list of log disk sizes. </param>
        /// <param name="azureSqlTargetType"> Gets the target type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureSqlIaasSkuDto(AzureVmSkuDto virtualMachineSize, IReadOnlyList<AzureManagedDiskSkuDto> dataDiskSizes, IReadOnlyList<AzureManagedDiskSkuDto> logDiskSizes, MigrateTargetType? azureSqlTargetType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualMachineSize = virtualMachineSize;
            DataDiskSizes = dataDiskSizes;
            LogDiskSizes = logDiskSizes;
            AzureSqlTargetType = azureSqlTargetType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the The Azure Compute Virtual Machine. </summary>
        public AzureVmSkuDto VirtualMachineSize { get; }
        /// <summary> Gets the The list of data disk sizes. </summary>
        public IReadOnlyList<AzureManagedDiskSkuDto> DataDiskSizes { get; }
        /// <summary> Gets the The list of log disk sizes. </summary>
        public IReadOnlyList<AzureManagedDiskSkuDto> LogDiskSizes { get; }
        /// <summary> Gets the target type. </summary>
        public MigrateTargetType? AzureSqlTargetType { get; }
    }
}
