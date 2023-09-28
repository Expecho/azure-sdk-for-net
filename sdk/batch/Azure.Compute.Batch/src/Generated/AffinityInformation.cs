// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// A locality hint that can be used by the Batch service to select a Compute Node
    /// on which to start a Task.
    /// </summary>
    public partial class AffinityInformation
    {
        /// <summary> Initializes a new instance of AffinityInformation. </summary>
        /// <param name="affinityId"> An opaque string representing the location of a Compute Node or a Task that has run previously. You can pass the affinityId of a Node to indicate that this Task needs to run on that Compute Node. Note that this is just a soft affinity. If the target Compute Node is busy or unavailable at the time the Task is scheduled, then the Task will be scheduled elsewhere. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="affinityId"/> is null. </exception>
        public AffinityInformation(string affinityId)
        {
            Argument.AssertNotNull(affinityId, nameof(affinityId));

            AffinityId = affinityId;
        }

        /// <summary> An opaque string representing the location of a Compute Node or a Task that has run previously. You can pass the affinityId of a Node to indicate that this Task needs to run on that Compute Node. Note that this is just a soft affinity. If the target Compute Node is busy or unavailable at the time the Task is scheduled, then the Task will be scheduled elsewhere. </summary>
        public string AffinityId { get; set; }
    }
}
