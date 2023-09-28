// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// The result of listing the status of the Job Preparation and Job Release Tasks
    /// for a Job.
    /// </summary>
    public partial class BatchJobListPreparationAndReleaseTaskStatusResult
    {
        /// <summary> Initializes a new instance of BatchJobListPreparationAndReleaseTaskStatusResult. </summary>
        internal BatchJobListPreparationAndReleaseTaskStatusResult()
        {
            Value = new ChangeTrackingList<JobPreparationAndReleaseTaskExecutionInformation>();
        }

        /// <summary> Initializes a new instance of BatchJobListPreparationAndReleaseTaskStatusResult. </summary>
        /// <param name="value"> A list of Job Preparation and Job Release Task execution information. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal BatchJobListPreparationAndReleaseTaskStatusResult(IReadOnlyList<JobPreparationAndReleaseTaskExecutionInformation> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A list of Job Preparation and Job Release Task execution information. </summary>
        public IReadOnlyList<JobPreparationAndReleaseTaskExecutionInformation> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
