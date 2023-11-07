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
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableCognitiveServicesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCognitiveServicesResourceGroupResource"/> class for mocking. </summary>
        protected MockableCognitiveServicesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCognitiveServicesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCognitiveServicesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CognitiveServicesAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CognitiveServicesAccountResources and their operations over a CognitiveServicesAccountResource. </returns>
        public virtual CognitiveServicesAccountCollection GetCognitiveServicesAccounts()
        {
            return GetCachedClient(client => new CognitiveServicesAccountCollection(client, Id));
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CognitiveServicesAccountResource>> GetCognitiveServicesAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetCognitiveServicesAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CognitiveServicesAccountResource> GetCognitiveServicesAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetCognitiveServicesAccounts().Get(accountName, cancellationToken);
        }

        /// <summary> Gets a collection of CognitiveServicesCommitmentPlanResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CognitiveServicesCommitmentPlanResources and their operations over a CognitiveServicesCommitmentPlanResource. </returns>
        public virtual CognitiveServicesCommitmentPlanCollection GetCognitiveServicesCommitmentPlans()
        {
            return GetCachedClient(client => new CognitiveServicesCommitmentPlanCollection(client, Id));
        }

        /// <summary>
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> GetCognitiveServicesCommitmentPlanAsync(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            return await GetCognitiveServicesCommitmentPlans().GetAsync(commitmentPlanName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanName"> The name of the commitmentPlan associated with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CognitiveServicesCommitmentPlanResource> GetCognitiveServicesCommitmentPlan(string commitmentPlanName, CancellationToken cancellationToken = default)
        {
            return GetCognitiveServicesCommitmentPlans().Get(commitmentPlanName, cancellationToken);
        }
    }
}
