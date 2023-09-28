// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Compute.Batch
{
    /// <summary> Contains information about the container which a Task is executing. </summary>
    public partial class TaskContainerExecutionInformation
    {
        /// <summary> Initializes a new instance of TaskContainerExecutionInformation. </summary>
        public TaskContainerExecutionInformation()
        {
        }

        /// <summary> Initializes a new instance of TaskContainerExecutionInformation. </summary>
        /// <param name="containerId"> The ID of the container. </param>
        /// <param name="state"> The state of the container. This is the state of the container according to the Docker service. It is equivalent to the status field returned by "docker inspect". </param>
        /// <param name="error"> Detailed error information about the container. This is the detailed error string from the Docker service, if available. It is equivalent to the error field returned by "docker inspect". </param>
        internal TaskContainerExecutionInformation(string containerId, string state, string error)
        {
            ContainerId = containerId;
            State = state;
            Error = error;
        }

        /// <summary> The ID of the container. </summary>
        public string ContainerId { get; set; }
        /// <summary> The state of the container. This is the state of the container according to the Docker service. It is equivalent to the status field returned by "docker inspect". </summary>
        public string State { get; set; }
        /// <summary> Detailed error information about the container. This is the detailed error string from the Docker service, if available. It is equivalent to the error field returned by "docker inspect". </summary>
        public string Error { get; set; }
    }
}
