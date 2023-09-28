// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> The container settings for a Task. </summary>
    public partial class TaskContainerSettings
    {
        /// <summary> Initializes a new instance of TaskContainerSettings. </summary>
        /// <param name="imageName"> The Image to use to create the container in which the Task will run. This is the full Image reference, as would be specified to "docker pull". If no tag is provided as part of the Image name, the tag ":latest" is used as a default. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public TaskContainerSettings(string imageName)
        {
            Argument.AssertNotNull(imageName, nameof(imageName));

            ImageName = imageName;
        }

        /// <summary> Initializes a new instance of TaskContainerSettings. </summary>
        /// <param name="containerRunOptions"> Additional options to the container create command. These additional options are supplied as arguments to the "docker create" command, in addition to those controlled by the Batch Service. </param>
        /// <param name="imageName"> The Image to use to create the container in which the Task will run. This is the full Image reference, as would be specified to "docker pull". If no tag is provided as part of the Image name, the tag ":latest" is used as a default. </param>
        /// <param name="registry"> The private registry which contains the container Image. This setting can be omitted if was already provided at Pool creation. </param>
        /// <param name="workingDirectory"> The location of the container Task working directory. The default is 'taskWorkingDirectory'. </param>
        internal TaskContainerSettings(string containerRunOptions, string imageName, ContainerRegistry registry, ContainerWorkingDirectory? workingDirectory)
        {
            ContainerRunOptions = containerRunOptions;
            ImageName = imageName;
            Registry = registry;
            WorkingDirectory = workingDirectory;
        }

        /// <summary> Additional options to the container create command. These additional options are supplied as arguments to the "docker create" command, in addition to those controlled by the Batch Service. </summary>
        public string ContainerRunOptions { get; set; }
        /// <summary> The Image to use to create the container in which the Task will run. This is the full Image reference, as would be specified to "docker pull". If no tag is provided as part of the Image name, the tag ":latest" is used as a default. </summary>
        public string ImageName { get; set; }
        /// <summary> The private registry which contains the container Image. This setting can be omitted if was already provided at Pool creation. </summary>
        public ContainerRegistry Registry { get; set; }
        /// <summary> The location of the container Task working directory. The default is 'taskWorkingDirectory'. </summary>
        public ContainerWorkingDirectory? WorkingDirectory { get; set; }
    }
}
