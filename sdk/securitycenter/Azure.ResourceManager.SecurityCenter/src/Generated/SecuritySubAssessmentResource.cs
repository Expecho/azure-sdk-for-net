// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecuritySubAssessment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecuritySubAssessmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecuritySubAssessmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="SecurityAssessmentResource" /> using the GetSecuritySubAssessment method.
    /// </summary>
    public partial class SecuritySubAssessmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecuritySubAssessmentResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="assessmentName"> The assessmentName. </param>
        /// <param name="subAssessmentName"> The subAssessmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string assessmentName, string subAssessmentName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securitySubAssessmentSubAssessmentsClientDiagnostics;
        private readonly SubAssessmentsRestOperations _securitySubAssessmentSubAssessmentsRestClient;
        private readonly SecuritySubAssessmentData _data;

        /// <summary> Initializes a new instance of the <see cref="SecuritySubAssessmentResource"/> class for mocking. </summary>
        protected SecuritySubAssessmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecuritySubAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecuritySubAssessmentResource(ArmClient client, SecuritySubAssessmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecuritySubAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecuritySubAssessmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securitySubAssessmentSubAssessmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securitySubAssessmentSubAssessmentsApiVersion);
            _securitySubAssessmentSubAssessmentsRestClient = new SubAssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securitySubAssessmentSubAssessmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/assessments/subAssessments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecuritySubAssessmentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecuritySubAssessmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = await _securitySubAssessmentSubAssessmentsRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecuritySubAssessmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = _securitySubAssessmentSubAssessmentsRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
