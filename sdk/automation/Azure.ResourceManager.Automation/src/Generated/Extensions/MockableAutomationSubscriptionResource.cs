// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAutomationSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _automationAccountClientDiagnostics;
        private AutomationAccountRestOperations _automationAccountRestClient;
        private ClientDiagnostics _deletedAutomationAccountsClientDiagnostics;
        private DeletedAutomationAccountsRestOperations _deletedAutomationAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAutomationSubscriptionResource"/> class for mocking. </summary>
        protected MockableAutomationSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAutomationSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAutomationSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AutomationAccountClientDiagnostics => _automationAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountResource.ResourceType.Namespace, Diagnostics);
        private AutomationAccountRestOperations AutomationAccountRestClient => _automationAccountRestClient ??= new AutomationAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AutomationAccountResource.ResourceType));
        private ClientDiagnostics deletedAutomationAccountsClientDiagnostics => _deletedAutomationAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automation", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DeletedAutomationAccountsRestOperations deletedAutomationAccountsRestClient => _deletedAutomationAccountsRestClient ??= new DeletedAutomationAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountResource> GetAutomationAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomationAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AutomationAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), AutomationAccountClientDiagnostics, Pipeline, "MockableAutomationSubscriptionResource.GetAutomationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountResource> GetAutomationAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomationAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AutomationAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), AutomationAccountClientDiagnostics, Pipeline, "MockableAutomationSubscriptionResource.GetAutomationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>deletedAutomationAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => deletedAutomationAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, DeletedAutomationAccount.DeserializeDeletedAutomationAccount, deletedAutomationAccountsClientDiagnostics, Pipeline, "MockableAutomationSubscriptionResource.GetDeletedAutomationAccountsBySubscription", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>deletedAutomationAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscription(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => deletedAutomationAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, DeletedAutomationAccount.DeserializeDeletedAutomationAccount, deletedAutomationAccountsClientDiagnostics, Pipeline, "MockableAutomationSubscriptionResource.GetDeletedAutomationAccountsBySubscription", "value", null, cancellationToken);
        }
    }
}
