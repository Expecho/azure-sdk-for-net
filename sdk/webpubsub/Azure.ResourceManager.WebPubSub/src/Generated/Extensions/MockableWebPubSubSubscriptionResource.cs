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
using Azure.ResourceManager.WebPubSub;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableWebPubSubSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _webPubSubClientDiagnostics;
        private WebPubSubRestOperations _webPubSubRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableWebPubSubSubscriptionResource"/> class for mocking. </summary>
        protected MockableWebPubSubSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWebPubSubSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWebPubSubSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics WebPubSubClientDiagnostics => _webPubSubClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.WebPubSub", WebPubSubResource.ResourceType.Namespace, Diagnostics);
        private WebPubSubRestOperations WebPubSubRestClient => _webPubSubRestClient ??= new WebPubSubRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(WebPubSubResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.WebPubSub", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<WebPubSubNameAvailability>> CheckWebPubSubNameAvailabilityAsync(AzureLocation location, WebPubSubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = WebPubSubClientDiagnostics.CreateScope("MockableWebPubSubSubscriptionResource.CheckWebPubSubNameAvailability");
            scope.Start();
            try
            {
                var response = await WebPubSubRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<WebPubSubNameAvailability> CheckWebPubSubNameAvailability(AzureLocation location, WebPubSubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = WebPubSubClientDiagnostics.CreateScope("MockableWebPubSubSubscriptionResource.CheckWebPubSubNameAvailability");
            scope.Start();
            try
            {
                var response = WebPubSubRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/webPubSub</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebPubSubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebPubSubResource> GetWebPubSubsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => WebPubSubRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => WebPubSubRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebPubSubResource(Client, WebPubSubData.DeserializeWebPubSubData(e)), WebPubSubClientDiagnostics, Pipeline, "MockableWebPubSubSubscriptionResource.GetWebPubSubs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/webPubSub</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSub_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebPubSubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebPubSubResource> GetWebPubSubs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => WebPubSubRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => WebPubSubRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebPubSubResource(Client, WebPubSubData.DeserializeWebPubSubData(e)), WebPubSubClientDiagnostics, Pipeline, "MockableWebPubSubSubscriptionResource.GetWebPubSubs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRServiceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRServiceUsage> GetUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SignalRServiceUsage.DeserializeSignalRServiceUsage, UsagesClientDiagnostics, Pipeline, "MockableWebPubSubSubscriptionResource.GetUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRServiceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRServiceUsage> GetUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SignalRServiceUsage.DeserializeSignalRServiceUsage, UsagesClientDiagnostics, Pipeline, "MockableWebPubSubSubscriptionResource.GetUsages", "value", "nextLink", cancellationToken);
        }
    }
}
