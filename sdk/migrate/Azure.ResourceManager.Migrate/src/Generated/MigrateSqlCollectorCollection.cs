// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Migrate
{
    /// <summary>
    /// A class representing a collection of <see cref="MigrateSqlCollectorResource"/> and their operations.
    /// Each <see cref="MigrateSqlCollectorResource"/> in the collection will belong to the same instance of <see cref="MigrateAssessmentProjectResource"/>.
    /// To get a <see cref="MigrateSqlCollectorCollection"/> instance call the GetMigrateSqlCollectors method from an instance of <see cref="MigrateAssessmentProjectResource"/>.
    /// </summary>
    public partial class MigrateSqlCollectorCollection : ArmCollection, IEnumerable<MigrateSqlCollectorResource>, IAsyncEnumerable<MigrateSqlCollectorResource>
    {
        private readonly ClientDiagnostics _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics;
        private readonly SqlCollectorRestOperations _migrateSqlCollectorSqlCollectorOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrateSqlCollectorCollection"/> class for mocking. </summary>
        protected MigrateSqlCollectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrateSqlCollectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrateSqlCollectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migrate", MigrateSqlCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrateSqlCollectorResource.ResourceType, out string migrateSqlCollectorSqlCollectorOperationsApiVersion);
            _migrateSqlCollectorSqlCollectorOperationsRestClient = new SqlCollectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrateSqlCollectorSqlCollectorOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MigrateAssessmentProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MigrateAssessmentProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a SqlCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrateSqlCollectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string collectorName, MigrateSqlCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation<MigrateSqlCollectorResource>(new MigrateSqlCollectorOperationSource(Client), _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics, Pipeline, _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a SqlCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrateSqlCollectorResource> CreateOrUpdate(WaitUntil waitUntil, string collectorName, MigrateSqlCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrateSqlCollectorSqlCollectorOperationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, data, cancellationToken);
                var operation = new MigrateArmOperation<MigrateSqlCollectorResource>(new MigrateSqlCollectorOperationSource(Client), _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics, Pipeline, _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a SqlCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual async Task<Response<MigrateSqlCollectorResource>> GetAsync(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrateSqlCollectorSqlCollectorOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrateSqlCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SqlCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual Response<MigrateSqlCollectorResource> Get(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = _migrateSqlCollectorSqlCollectorOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrateSqlCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List SqlCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrateSqlCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrateSqlCollectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrateSqlCollectorResource(Client, MigrateSqlCollectorData.DeserializeMigrateSqlCollectorData(e)), _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics, Pipeline, "MigrateSqlCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List SqlCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrateSqlCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrateSqlCollectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrateSqlCollectorSqlCollectorOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrateSqlCollectorResource(Client, MigrateSqlCollectorData.DeserializeMigrateSqlCollectorData(e)), _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics, Pipeline, "MigrateSqlCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrateSqlCollectorSqlCollectorOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrateSqlCollectorSqlCollectorOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrateSqlCollectorResource>> GetIfExistsAsync(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrateSqlCollectorSqlCollectorOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrateSqlCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrateSqlCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/sqlcollectors/{collectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlCollectorOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateSqlCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="collectorName"> Sql collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectorName"/> is null. </exception>
        public virtual NullableResponse<MigrateSqlCollectorResource> GetIfExists(string collectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectorName, nameof(collectorName));

            using var scope = _migrateSqlCollectorSqlCollectorOperationsClientDiagnostics.CreateScope("MigrateSqlCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrateSqlCollectorSqlCollectorOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, collectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrateSqlCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrateSqlCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrateSqlCollectorResource> IEnumerable<MigrateSqlCollectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrateSqlCollectorResource> IAsyncEnumerable<MigrateSqlCollectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
