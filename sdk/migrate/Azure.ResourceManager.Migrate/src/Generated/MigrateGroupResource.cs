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
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary>
    /// A Class representing a MigrateGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MigrateGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMigrateGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="MigrateAssessmentProjectResource"/> using the GetMigrateGroup method.
    /// </summary>
    public partial class MigrateGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MigrateGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="groupName"> The groupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _migrateGroupGroupsOperationsClientDiagnostics;
        private readonly GroupsRestOperations _migrateGroupGroupsOperationsRestClient;
        private readonly MigrateGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Migrate/assessmentProjects/groups";

        /// <summary> Initializes a new instance of the <see cref="MigrateGroupResource"/> class for mocking. </summary>
        protected MigrateGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrateGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MigrateGroupResource(ArmClient client, MigrateGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MigrateGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MigrateGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrateGroupGroupsOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migrate", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string migrateGroupGroupsOperationsApiVersion);
            _migrateGroupGroupsOperationsRestClient = new GroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrateGroupGroupsOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MigrateGroupData Data
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

        /// <summary> Gets a collection of MigrateAssessmentResources in the MigrateGroup. </summary>
        /// <returns> An object representing collection of MigrateAssessmentResources and their operations over a MigrateAssessmentResource. </returns>
        public virtual MigrateAssessmentCollection GetMigrateAssessments()
        {
            return GetCachedClient(client => new MigrateAssessmentCollection(client, Id));
        }

        /// <summary>
        /// Get a Assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> Machine Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MigrateAssessmentResource>> GetMigrateAssessmentAsync(string assessmentName, CancellationToken cancellationToken = default)
        {
            return await GetMigrateAssessments().GetAsync(assessmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> Machine Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MigrateAssessmentResource> GetMigrateAssessment(string assessmentName, CancellationToken cancellationToken = default)
        {
            return GetMigrateAssessments().Get(assessmentName, cancellationToken);
        }

        /// <summary> Gets a collection of MigrateAvsAssessmentResources in the MigrateGroup. </summary>
        /// <returns> An object representing collection of MigrateAvsAssessmentResources and their operations over a MigrateAvsAssessmentResource. </returns>
        public virtual MigrateAvsAssessmentCollection GetMigrateAvsAssessments()
        {
            return GetCachedClient(client => new MigrateAvsAssessmentCollection(client, Id));
        }

        /// <summary>
        /// Get a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MigrateAvsAssessmentResource>> GetMigrateAvsAssessmentAsync(string assessmentName, CancellationToken cancellationToken = default)
        {
            return await GetMigrateAvsAssessments().GetAsync(assessmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MigrateAvsAssessmentResource> GetMigrateAvsAssessment(string assessmentName, CancellationToken cancellationToken = default)
        {
            return GetMigrateAvsAssessments().Get(assessmentName, cancellationToken);
        }

        /// <summary> Gets a collection of MigrateSqlAssessmentV2Resources in the MigrateGroup. </summary>
        /// <returns> An object representing collection of MigrateSqlAssessmentV2Resources and their operations over a MigrateSqlAssessmentV2Resource. </returns>
        public virtual MigrateSqlAssessmentV2Collection GetMigrateSqlAssessmentV2s()
        {
            return GetCachedClient(client => new MigrateSqlAssessmentV2Collection(client, Id));
        }

        /// <summary>
        /// Get a SqlAssessmentV2
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/sqlAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlAssessmentV2Operations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlAssessmentV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MigrateSqlAssessmentV2Resource>> GetMigrateSqlAssessmentV2Async(string assessmentName, CancellationToken cancellationToken = default)
        {
            return await GetMigrateSqlAssessmentV2s().GetAsync(assessmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a SqlAssessmentV2
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/sqlAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlAssessmentV2Operations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlAssessmentV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MigrateSqlAssessmentV2Resource> GetMigrateSqlAssessmentV2(string assessmentName, CancellationToken cancellationToken = default)
        {
            return GetMigrateSqlAssessmentV2s().Get(assessmentName, cancellationToken);
        }

        /// <summary>
        /// Get a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MigrateGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _migrateGroupGroupsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrateGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrateGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Get");
            scope.Start();
            try
            {
                var response = _migrateGroupGroupsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrateGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _migrateGroupGroupsOperationsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _migrateGroupGroupsOperationsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MigrateArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrateGroupResource>> UpdateAsync(WaitUntil waitUntil, MigrateGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _migrateGroupGroupsOperationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation<MigrateGroupResource>(new MigrateGroupOperationSource(Client), _migrateGroupGroupsOperationsClientDiagnostics, Pipeline, _migrateGroupGroupsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrateGroupResource> Update(WaitUntil waitUntil, MigrateGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.Update");
            scope.Start();
            try
            {
                var response = _migrateGroupGroupsOperationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MigrateArmOperation<MigrateGroupResource>(new MigrateGroupOperationSource(Client), _migrateGroupGroupsOperationsClientDiagnostics, Pipeline, _migrateGroupGroupsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update machines in group by adding or removing machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/updateMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_UpdateMachines</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrateGroupResource>> UpdateMachinesAsync(WaitUntil waitUntil, MigrateGroupUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.UpdateMachines");
            scope.Start();
            try
            {
                var response = await _migrateGroupGroupsOperationsRestClient.UpdateMachinesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation<MigrateGroupResource>(new MigrateGroupOperationSource(Client), _migrateGroupGroupsOperationsClientDiagnostics, Pipeline, _migrateGroupGroupsOperationsRestClient.CreateUpdateMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update machines in group by adding or removing machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/updateMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupsOperations_UpdateMachines</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MigrateGroupResource> UpdateMachines(WaitUntil waitUntil, MigrateGroupUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _migrateGroupGroupsOperationsClientDiagnostics.CreateScope("MigrateGroupResource.UpdateMachines");
            scope.Start();
            try
            {
                var response = _migrateGroupGroupsOperationsRestClient.UpdateMachines(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new MigrateArmOperation<MigrateGroupResource>(new MigrateGroupOperationSource(Client), _migrateGroupGroupsOperationsClientDiagnostics, Pipeline, _migrateGroupGroupsOperationsRestClient.CreateUpdateMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
