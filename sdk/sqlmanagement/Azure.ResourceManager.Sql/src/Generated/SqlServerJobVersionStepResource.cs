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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerJobVersionStep along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerJobVersionStepResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerJobVersionStepResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerJobVersionResource" /> using the GetSqlServerJobVersionStep method.
    /// </summary>
    public partial class SqlServerJobVersionStepResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerJobVersionStepResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="jobAgentName"> The jobAgentName. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="jobVersion"> The jobVersion. </param>
        /// <param name="stepName"> The stepName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion, string stepName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerJobVersionStepJobStepsClientDiagnostics;
        private readonly JobStepsRestOperations _sqlServerJobVersionStepJobStepsRestClient;
        private readonly SqlServerJobStepData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionStepResource"/> class for mocking. </summary>
        protected SqlServerJobVersionStepResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerJobVersionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerJobVersionStepResource(ArmClient client, SqlServerJobStepData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerJobVersionStepResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobVersionStepJobStepsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobVersionStepJobStepsApiVersion);
            _sqlServerJobVersionStepJobStepsRestClient = new JobStepsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobVersionStepJobStepsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/versions/steps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerJobStepData Data
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
        /// Gets the specified version of a job step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerJobVersionStepResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionStepJobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, int.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified version of a job step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerJobVersionStepResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionStepJobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, int.Parse(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
