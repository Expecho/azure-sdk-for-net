// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockablePurviewResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePurviewResourceGroupResource"/> class for mocking. </summary>
        protected MockablePurviewResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePurviewResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePurviewResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PurviewAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PurviewAccountResources and their operations over a PurviewAccountResource. </returns>
        public virtual PurviewAccountCollection GetPurviewAccounts()
        {
            return GetCachedClient(client => new PurviewAccountCollection(client, Id));
        }

        /// <summary>
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PurviewAccountResource>> GetPurviewAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetPurviewAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PurviewAccountResource> GetPurviewAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetPurviewAccounts().Get(accountName, cancellationToken);
        }
    }
}
