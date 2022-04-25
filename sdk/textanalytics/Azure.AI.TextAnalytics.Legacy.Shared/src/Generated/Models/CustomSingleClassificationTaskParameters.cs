// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The CustomSingleClassificationTaskParameters. </summary>
    internal partial class CustomSingleClassificationTaskParameters
    {
        /// <summary> Initializes a new instance of CustomSingleClassificationTaskParameters. </summary>
        /// <param name="projectName"></param>
        /// <param name="deploymentName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomSingleClassificationTaskParameters(string projectName, string deploymentName)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Gets the project name. </summary>
        public string ProjectName { get; }
        /// <summary> Gets the deployment name. </summary>
        public string DeploymentName { get; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
    }
}
