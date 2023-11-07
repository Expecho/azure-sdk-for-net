// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockablePrivateDnsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsArmClient"/> class for mocking. </summary>
        protected MockablePrivateDnsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePrivateDnsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockablePrivateDnsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsZoneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsZoneResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsZoneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsZoneResource" /> object. </returns>
        public virtual PrivateDnsZoneResource GetPrivateDnsZoneResource(ResourceIdentifier id)
        {
            PrivateDnsZoneResource.ValidateResourceId(id);
            return new PrivateDnsZoneResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualNetworkLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualNetworkLinkResource.CreateResourceIdentifier" /> to create a <see cref="VirtualNetworkLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkLinkResource" /> object. </returns>
        public virtual VirtualNetworkLinkResource GetVirtualNetworkLinkResource(ResourceIdentifier id)
        {
            VirtualNetworkLinkResource.ValidateResourceId(id);
            return new VirtualNetworkLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsARecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsARecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsARecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsARecordResource" /> object. </returns>
        public virtual PrivateDnsARecordResource GetPrivateDnsARecordResource(ResourceIdentifier id)
        {
            PrivateDnsARecordResource.ValidateResourceId(id);
            return new PrivateDnsARecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsAaaaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsAaaaRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsAaaaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsAaaaRecordResource" /> object. </returns>
        public virtual PrivateDnsAaaaRecordResource GetPrivateDnsAaaaRecordResource(ResourceIdentifier id)
        {
            PrivateDnsAaaaRecordResource.ValidateResourceId(id);
            return new PrivateDnsAaaaRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsCnameRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsCnameRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsCnameRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsCnameRecordResource" /> object. </returns>
        public virtual PrivateDnsCnameRecordResource GetPrivateDnsCnameRecordResource(ResourceIdentifier id)
        {
            PrivateDnsCnameRecordResource.ValidateResourceId(id);
            return new PrivateDnsCnameRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsMXRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsMXRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsMXRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsMXRecordResource" /> object. </returns>
        public virtual PrivateDnsMXRecordResource GetPrivateDnsMXRecordResource(ResourceIdentifier id)
        {
            PrivateDnsMXRecordResource.ValidateResourceId(id);
            return new PrivateDnsMXRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsPtrRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsPtrRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsPtrRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsPtrRecordResource" /> object. </returns>
        public virtual PrivateDnsPtrRecordResource GetPrivateDnsPtrRecordResource(ResourceIdentifier id)
        {
            PrivateDnsPtrRecordResource.ValidateResourceId(id);
            return new PrivateDnsPtrRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsSoaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsSoaRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsSoaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsSoaRecordResource" /> object. </returns>
        public virtual PrivateDnsSoaRecordResource GetPrivateDnsSoaRecordResource(ResourceIdentifier id)
        {
            PrivateDnsSoaRecordResource.ValidateResourceId(id);
            return new PrivateDnsSoaRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsSrvRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsSrvRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsSrvRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsSrvRecordResource" /> object. </returns>
        public virtual PrivateDnsSrvRecordResource GetPrivateDnsSrvRecordResource(ResourceIdentifier id)
        {
            PrivateDnsSrvRecordResource.ValidateResourceId(id);
            return new PrivateDnsSrvRecordResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsTxtRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsTxtRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsTxtRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsTxtRecordResource" /> object. </returns>
        public virtual PrivateDnsTxtRecordResource GetPrivateDnsTxtRecordResource(ResourceIdentifier id)
        {
            PrivateDnsTxtRecordResource.ValidateResourceId(id);
            return new PrivateDnsTxtRecordResource(Client, id);
        }
    }
}
