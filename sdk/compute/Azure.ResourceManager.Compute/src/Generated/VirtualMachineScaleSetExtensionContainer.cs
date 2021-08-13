// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineScaleSetExtension and their operations over a VirtualMachineScaleSet. </summary>
    public partial class VirtualMachineScaleSetExtensionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineScaleSetExtensionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetExtensionContainer"/> class for mocking. </summary>
        protected VirtualMachineScaleSetExtensionContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetExtensionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineScaleSetExtensionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualMachineScaleSetExtensionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualMachineScaleSet.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetExtension> CreateOrUpdate(string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(vmssExtensionName, extensionParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetExtension>> CreateOrUpdateAsync(string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(vmssExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual VirtualMachineScaleSetExtensionCreateOrUpdateOperation StartCreateOrUpdate(string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters, cancellationToken);
                return new VirtualMachineScaleSetExtensionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public async virtual Task<VirtualMachineScaleSetExtensionCreateOrUpdateOperation> StartCreateOrUpdateAsync(string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetExtensionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualMachineScaleSetExtension> Get(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.Get");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualMachineScaleSetExtension>> GetAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.Get");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSetExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualMachineScaleSetExtension> GetIfExists(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineScaleSetExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineScaleSetExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualMachineScaleSetExtension>> GetIfExistsAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineScaleSetExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineScaleSetExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = GetIfExists(vmssExtensionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vmssExtensionName == null)
                {
                    throw new ArgumentNullException(nameof(vmssExtensionName));
                }

                var response = await GetIfExistsAsync(vmssExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetExtension" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualMachineScaleSetExtension> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetExtension" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualMachineScaleSetExtension> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualMachineScaleSetExtension" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSetExtension.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineScaleSetExtension" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSetExtension.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualMachineScaleSetExtension, VirtualMachineScaleSetExtensionData> Construct() { }
    }
}
