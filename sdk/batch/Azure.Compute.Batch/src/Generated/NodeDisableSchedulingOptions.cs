// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Compute.Batch
{
    /// <summary> Options for disabling scheduling on an Azure Batch Compute Node. </summary>
    public partial class NodeDisableSchedulingOptions
    {
        /// <summary> Initializes a new instance of NodeDisableSchedulingOptions. </summary>
        public NodeDisableSchedulingOptions()
        {
        }

        /// <summary> Initializes a new instance of NodeDisableSchedulingOptions. </summary>
        /// <param name="nodeDisableSchedulingOption"> What to do with currently running Tasks when disabling Task scheduling on the Compute Node. The default value is requeue. </param>
        internal NodeDisableSchedulingOptions(DisableBatchNodeSchedulingOption? nodeDisableSchedulingOption)
        {
            NodeDisableSchedulingOption = nodeDisableSchedulingOption;
        }

        /// <summary> What to do with currently running Tasks when disabling Task scheduling on the Compute Node. The default value is requeue. </summary>
        public DisableBatchNodeSchedulingOption? NodeDisableSchedulingOption { get; set; }
    }
}
