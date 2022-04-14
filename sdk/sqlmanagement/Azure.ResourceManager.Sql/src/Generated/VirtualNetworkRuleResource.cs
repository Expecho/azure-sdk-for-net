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
    /// A Class representing a VirtualNetworkRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="VirtualNetworkRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetVirtualNetworkRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource" /> using the GetVirtualNetworkRule method.
    /// </summary>
    public partial class VirtualNetworkRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualNetworkRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string virtualNetworkRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualNetworkRuleClientDiagnostics;
        private readonly VirtualNetworkRulesRestOperations _virtualNetworkRuleRestClient;
        private readonly VirtualNetworkRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkRuleResource"/> class for mocking. </summary>
        protected VirtualNetworkRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualNetworkRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualNetworkRuleResource(ArmClient client, VirtualNetworkRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualNetworkRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string virtualNetworkRuleApiVersion);
            _virtualNetworkRuleRestClient = new VirtualNetworkRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/virtualNetworkRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualNetworkRuleData Data
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
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualNetworkRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualNetworkRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleResource.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the virtual network rule with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRuleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_virtualNetworkRuleClientDiagnostics, Pipeline, _virtualNetworkRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the virtual network rule with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _virtualNetworkRuleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_virtualNetworkRuleClientDiagnostics, Pipeline, _virtualNetworkRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
