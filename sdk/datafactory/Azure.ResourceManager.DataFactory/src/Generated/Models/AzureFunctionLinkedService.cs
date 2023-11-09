// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Function linked service. </summary>
    public partial class AzureFunctionLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureFunctionLinkedService. </summary>
        /// <param name="functionAppUri"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUri"/> is null. </exception>
        public AzureFunctionLinkedService(BinaryData functionAppUri)
        {
            Argument.AssertNotNull(functionAppUri, nameof(functionAppUri));

            FunctionAppUri = functionAppUri;
            LinkedServiceType = "AzureFunction";
        }

        /// <summary> Initializes a new instance of AzureFunctionLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="functionAppUri"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. </param>
        /// <param name="functionKey"> Function or Host key for Azure Function App. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="resourceId"> Allowed token audiences for azure function. </param>
        /// <param name="authentication"> Type of authentication (Required to specify MSI) used to connect to AzureFunction. Type: string (or Expression with resultType string). </param>
        internal AzureFunctionLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData functionAppUri, DataFactorySecretBaseDefinition functionKey, string encryptedCredential, DataFactoryCredentialReference credential, BinaryData resourceId, DataFactoryElement<string> authentication) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            FunctionAppUri = functionAppUri;
            FunctionKey = functionKey;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            ResourceId = resourceId;
            Authentication = authentication;
            LinkedServiceType = linkedServiceType ?? "AzureFunction";
        }

        /// <summary>
        /// The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData FunctionAppUri { get; set; }
        /// <summary> Function or Host key for Azure Function App. </summary>
        public DataFactorySecretBaseDefinition FunctionKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary>
        /// Allowed token audiences for azure function.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData ResourceId { get; set; }
        /// <summary> Type of authentication (Required to specify MSI) used to connect to AzureFunction. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Authentication { get; set; }
    }
}
