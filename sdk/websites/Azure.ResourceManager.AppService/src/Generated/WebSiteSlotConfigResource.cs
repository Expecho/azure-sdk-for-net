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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteSlotConfig along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSlotConfigResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSlotConfigResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetWebSiteSlotConfig method.
    /// </summary>
    public partial class WebSiteSlotConfigResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotConfigResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotConfigWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotConfigWebAppsRestClient;
        private readonly ClientDiagnostics _siteSlotConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotConfigSnapshotWebAppsRestClient;
        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotConfigResource"/> class for mocking. </summary>
        protected WebSiteSlotConfigResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSlotConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotConfigResource(ArmClient client, SiteConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotConfigResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotConfigWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotConfigWebAppsApiVersion);
            _webSiteSlotConfigWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotConfigWebAppsApiVersion);
            _siteSlotConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotConfigSnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotConfigSnapshotResource.ResourceType, out string siteSlotConfigSnapshotWebAppsApiVersion);
            _siteSlotConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/config";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
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

        /// <summary> Gets a collection of SiteSlotConfigSnapshotResources in the WebSiteSlotConfig. </summary>
        /// <returns> An object representing collection of SiteSlotConfigSnapshotResources and their operations over a SiteSlotConfigSnapshotResource. </returns>
        public virtual SiteSlotConfigSnapshotCollection GetSiteSlotConfigSnapshots()
        {
            return GetCachedClient(Client => new SiteSlotConfigSnapshotCollection(Client, Id));
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteSlotConfigSnapshotResource>> GetSiteSlotConfigSnapshotAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotConfigSnapshots().GetAsync(snapshotId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteSlotConfigSnapshotResource> GetSiteSlotConfigSnapshot(string snapshotId, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotConfigSnapshots().Get(snapshotId, cancellationToken);
        }

        /// <summary>
        /// Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_GetConfigurationSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteSlotConfigResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotConfigWebAppsRestClient.GetConfigurationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_GetConfigurationSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteSlotConfigResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotConfigWebAppsRestClient.GetConfigurationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_UpdateConfigurationSlot
        /// </summary>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotConfigResource>> UpdateAsync(SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.Update");
            scope.Start();
            try
            {
                var response = await _webSiteSlotConfigWebAppsRestClient.UpdateConfigurationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WebSiteSlotConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_UpdateConfigurationSlot
        /// </summary>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<WebSiteSlotConfigResource> Update(SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.Update");
            scope.Start();
            try
            {
                var response = _webSiteSlotConfigWebAppsRestClient.UpdateConfigurationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new WebSiteSlotConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_CreateOrUpdateConfigurationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteSlotConfigResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteSlotConfigWebAppsRestClient.CreateOrUpdateConfigurationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteSlotConfigResource>(Response.FromValue(new WebSiteSlotConfigResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates the configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// Operation Id: WebApps_CreateOrUpdateConfigurationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteSlotConfigResource> CreateOrUpdate(WaitUntil waitUntil, SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotConfigWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteSlotConfigWebAppsRestClient.CreateOrUpdateConfigurationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteSlotConfigResource>(Response.FromValue(new WebSiteSlotConfigResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots
        /// Operation Id: WebApps_ListConfigurationSnapshotInfoSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoSlotAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteConfigurationSnapshotInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.GetConfigurationSnapshotInfoSlot");
                scope.Start();
                try
                {
                    var response = await _siteSlotConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteConfigurationSnapshotInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.GetConfigurationSnapshotInfoSlot");
                scope.Start();
                try
                {
                    var response = await _siteSlotConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots
        /// Operation Id: WebApps_ListConfigurationSnapshotInfoSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoSlot(CancellationToken cancellationToken = default)
        {
            Page<SiteConfigurationSnapshotInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.GetConfigurationSnapshotInfoSlot");
                scope.Start();
                try
                {
                    var response = _siteSlotConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteConfigurationSnapshotInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigResource.GetConfigurationSnapshotInfoSlot");
                scope.Start();
                try
                {
                    var response = _siteSlotConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
