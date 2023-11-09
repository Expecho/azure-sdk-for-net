// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ConfidentialLedger;
using Azure.ResourceManager.ConfidentialLedger.Models;

namespace Azure.ResourceManager.ConfidentialLedger.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableConfidentialLedgerSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private ConfidentialLedgerRestOperations _defaultRestClient;
        private ClientDiagnostics _confidentialLedgerLedgerClientDiagnostics;
        private LedgerRestOperations _confidentialLedgerLedgerRestClient;
        private ClientDiagnostics _managedCcfManagedCcfClientDiagnostics;
        private ManagedCCFRestOperations _managedCcfManagedCcfRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableConfidentialLedgerSubscriptionResource"/> class for mocking. </summary>
        protected MockableConfidentialLedgerSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConfidentialLedgerSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConfidentialLedgerSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConfidentialLedger", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ConfidentialLedgerRestOperations DefaultRestClient => _defaultRestClient ??= new ConfidentialLedgerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ConfidentialLedgerLedgerClientDiagnostics => _confidentialLedgerLedgerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConfidentialLedger", ConfidentialLedgerResource.ResourceType.Namespace, Diagnostics);
        private LedgerRestOperations ConfidentialLedgerLedgerRestClient => _confidentialLedgerLedgerRestClient ??= new LedgerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ConfidentialLedgerResource.ResourceType));
        private ClientDiagnostics ManagedCcfManagedCCFClientDiagnostics => _managedCcfManagedCcfClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConfidentialLedger", ManagedCcfResource.ResourceType.Namespace, Diagnostics);
        private ManagedCCFRestOperations ManagedCcfManagedCCFRestClient => _managedCcfManagedCcfRestClient ??= new ManagedCCFRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedCcfResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// To check whether a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Name availability request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ConfidentialLedgerNameAvailabilityResult>> CheckConfidentialLedgerNameAvailabilityAsync(ConfidentialLedgerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableConfidentialLedgerSubscriptionResource.CheckConfidentialLedgerNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// To check whether a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Name availability request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ConfidentialLedgerNameAvailabilityResult> CheckConfidentialLedgerNameAvailability(ConfidentialLedgerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableConfidentialLedgerSubscriptionResource.CheckConfidentialLedgerNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfidentialLedgerResource> GetConfidentialLedgersAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfidentialLedgerLedgerRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfidentialLedgerLedgerRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ConfidentialLedgerResource(Client, ConfidentialLedgerData.DeserializeConfidentialLedgerData(e)), ConfidentialLedgerLedgerClientDiagnostics, Pipeline, "MockableConfidentialLedgerSubscriptionResource.GetConfidentialLedgers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfidentialLedgerResource> GetConfidentialLedgers(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfidentialLedgerLedgerRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfidentialLedgerLedgerRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ConfidentialLedgerResource(Client, ConfidentialLedgerData.DeserializeConfidentialLedgerData(e)), ConfidentialLedgerLedgerClientDiagnostics, Pipeline, "MockableConfidentialLedgerSubscriptionResource.GetConfidentialLedgers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedCcfResource> GetManagedCcfsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedCcfManagedCCFRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedCcfManagedCCFRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedCcfResource(Client, ManagedCcfData.DeserializeManagedCcfData(e)), ManagedCcfManagedCCFClientDiagnostics, Pipeline, "MockableConfidentialLedgerSubscriptionResource.GetManagedCcfs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedCcfResource> GetManagedCcfs(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedCcfManagedCCFRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedCcfManagedCCFRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedCcfResource(Client, ManagedCcfData.DeserializeManagedCcfData(e)), ManagedCcfManagedCCFClientDiagnostics, Pipeline, "MockableConfidentialLedgerSubscriptionResource.GetManagedCcfs", "value", "nextLink", cancellationToken);
        }
    }
}
