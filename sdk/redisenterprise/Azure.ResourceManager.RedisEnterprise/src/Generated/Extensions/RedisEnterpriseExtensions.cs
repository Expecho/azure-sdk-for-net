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
using Azure.ResourceManager.RedisEnterprise.Mocking;
using Azure.ResourceManager.RedisEnterprise.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.RedisEnterprise. </summary>
    public static partial class RedisEnterpriseExtensions
    {
        private static MockableRedisEnterpriseArmClient GetMockableRedisEnterpriseArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableRedisEnterpriseArmClient(client0));
        }

        private static MockableRedisEnterpriseResourceGroupResource GetMockableRedisEnterpriseResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRedisEnterpriseResourceGroupResource(client, resource.Id));
        }

        private static MockableRedisEnterpriseSubscriptionResource GetMockableRedisEnterpriseSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRedisEnterpriseSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisEnterpriseClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisEnterpriseClusterResource.CreateResourceIdentifier" /> to create a <see cref="RedisEnterpriseClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseArmClient.GetRedisEnterpriseClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisEnterpriseClusterResource" /> object. </returns>
        public static RedisEnterpriseClusterResource GetRedisEnterpriseClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableRedisEnterpriseArmClient(client).GetRedisEnterpriseClusterResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisEnterpriseDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisEnterpriseDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="RedisEnterpriseDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseArmClient.GetRedisEnterpriseDatabaseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisEnterpriseDatabaseResource" /> object. </returns>
        public static RedisEnterpriseDatabaseResource GetRedisEnterpriseDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableRedisEnterpriseArmClient(client).GetRedisEnterpriseDatabaseResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisEnterprisePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisEnterprisePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RedisEnterprisePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseArmClient.GetRedisEnterprisePrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisEnterprisePrivateEndpointConnectionResource" /> object. </returns>
        public static RedisEnterprisePrivateEndpointConnectionResource GetRedisEnterprisePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableRedisEnterpriseArmClient(client).GetRedisEnterprisePrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of RedisEnterpriseClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseResourceGroupResource.GetRedisEnterpriseClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RedisEnterpriseClusterResources and their operations over a RedisEnterpriseClusterResource. </returns>
        public static RedisEnterpriseClusterCollection GetRedisEnterpriseClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableRedisEnterpriseResourceGroupResource(resourceGroupResource).GetRedisEnterpriseClusters();
        }

        /// <summary>
        /// Gets information about a RedisEnterprise cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseResourceGroupResource.GetRedisEnterpriseClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RedisEnterpriseClusterResource>> GetRedisEnterpriseClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetMockableRedisEnterpriseResourceGroupResource(resourceGroupResource).GetRedisEnterpriseClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a RedisEnterprise cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseResourceGroupResource.GetRedisEnterpriseCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<RedisEnterpriseClusterResource> GetRedisEnterpriseCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseResourceGroupResource(resourceGroupResource).GetRedisEnterpriseCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// Gets the status of operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/operationsStatus/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsStatus_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseOperationsStatus(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<RedisEnterpriseOperationStatus>> GetRedisEnterpriseOperationsStatusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            return await GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseOperationsStatusAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the status of operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/operationsStatus/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsStatus_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseOperationsStatus(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response<RedisEnterpriseOperationStatus> GetRedisEnterpriseOperationsStatus(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseOperationsStatus(location, operationId, cancellationToken);
        }

        /// <summary>
        /// Gets all RedisEnterprise clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisEnterpriseClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RedisEnterpriseClusterResource> GetRedisEnterpriseClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all RedisEnterprise clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisEnterpriseClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RedisEnterpriseClusterResource> GetRedisEnterpriseClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseClusters(cancellationToken);
        }

        /// <summary>
        /// Gets information about skus in specified location for the given subscription id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseSkus(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisEnterpriseRegionSkuDetail" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RedisEnterpriseRegionSkuDetail> GetRedisEnterpriseSkusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseSkusAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets information about skus in specified location for the given subscription id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisEnterpriseSubscriptionResource.GetRedisEnterpriseSkus(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisEnterpriseRegionSkuDetail" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RedisEnterpriseRegionSkuDetail> GetRedisEnterpriseSkus(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableRedisEnterpriseSubscriptionResource(subscriptionResource).GetRedisEnterpriseSkus(location, cancellationToken);
        }
    }
}
