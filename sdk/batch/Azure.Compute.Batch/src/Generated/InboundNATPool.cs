// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// A inbound NAT Pool that can be used to address specific ports on Compute Nodes
    /// in a Batch Pool externally.
    /// </summary>
    public partial class InboundNATPool
    {
        /// <summary> Initializes a new instance of InboundNATPool. </summary>
        /// <param name="name"> The name of the endpoint. The name must be unique within a Batch Pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="backendPort"> The port number on the Compute Node. This must be unique within a Batch Pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeStart"> The first port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeEnd"> The last port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public InboundNATPool(string name, InboundEndpointProtocol protocol, int backendPort, int frontendPortRangeStart, int frontendPortRangeEnd)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Protocol = protocol;
            BackendPort = backendPort;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            NetworkSecurityGroupRules = new ChangeTrackingList<NetworkSecurityGroupRule>();
        }

        /// <summary> Initializes a new instance of InboundNATPool. </summary>
        /// <param name="name"> The name of the endpoint. The name must be unique within a Batch Pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="backendPort"> The port number on the Compute Node. This must be unique within a Batch Pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeStart"> The first port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeEnd"> The last port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="networkSecurityGroupRules"> A list of network security group rules that will be applied to the endpoint. The maximum number of rules that can be specified across all the endpoints on a Batch Pool is 25. If no network security group rules are specified, a default rule will be created to allow inbound access to the specified backendPort. If the maximum number of network security group rules is exceeded the request fails with HTTP status code 400. </param>
        internal InboundNATPool(string name, InboundEndpointProtocol protocol, int backendPort, int frontendPortRangeStart, int frontendPortRangeEnd, IList<NetworkSecurityGroupRule> networkSecurityGroupRules)
        {
            Name = name;
            Protocol = protocol;
            BackendPort = backendPort;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            NetworkSecurityGroupRules = networkSecurityGroupRules;
        }

        /// <summary> The name of the endpoint. The name must be unique within a Batch Pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </summary>
        public string Name { get; set; }
        /// <summary> The protocol of the endpoint. </summary>
        public InboundEndpointProtocol Protocol { get; set; }
        /// <summary> The port number on the Compute Node. This must be unique within a Batch Pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </summary>
        public int BackendPort { get; set; }
        /// <summary> The first port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </summary>
        public int FrontendPortRangeStart { get; set; }
        /// <summary> The last port number in the range of external ports that will be used to provide inbound access to the backendPort on individual Compute Nodes. Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a Pool must be distinct and cannot overlap. Each range must contain at least 40 ports. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </summary>
        public int FrontendPortRangeEnd { get; set; }
        /// <summary> A list of network security group rules that will be applied to the endpoint. The maximum number of rules that can be specified across all the endpoints on a Batch Pool is 25. If no network security group rules are specified, a default rule will be created to allow inbound access to the specified backendPort. If the maximum number of network security group rules is exceeded the request fails with HTTP status code 400. </summary>
        public IList<NetworkSecurityGroupRule> NetworkSecurityGroupRules { get; }
    }
}
