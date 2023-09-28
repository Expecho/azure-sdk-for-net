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
    /// Batch will retry Tasks when a recovery operation is triggered on a Node.
    /// Examples of recovery operations include (but are not limited to) when an
    /// unhealthy Node is rebooted or a Compute Node disappeared due to host failure.
    /// Retries due to recovery operations are independent of and are not counted
    /// against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal
    /// retry due to a recovery operation may occur. Because of this, all Tasks should
    /// be idempotent. This means Tasks need to tolerate being interrupted and
    /// restarted without causing any corruption or duplicate data. The best practice
    /// for long running Tasks is to use some form of checkpointing.
    /// </summary>
    public partial class BatchTask
    {
        /// <summary> Initializes a new instance of BatchTask. </summary>
        public BatchTask()
        {
            ResourceFiles = new ChangeTrackingList<ResourceFile>();
            OutputFiles = new ChangeTrackingList<OutputFile>();
            EnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
            ApplicationPackageReferences = new ChangeTrackingList<ApplicationPackageReference>();
        }

        /// <summary> Initializes a new instance of BatchTask. </summary>
        /// <param name="id"> A string that uniquely identifies the Task within the Job. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. </param>
        /// <param name="displayName"> A display name for the Task. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="url"> The URL of the Task. </param>
        /// <param name="eTag"> The ETag of the Task. This is an opaque string. You can use it to detect whether the Task has changed between requests. In particular, you can be pass the ETag when updating a Task to specify that your changes should take effect only if nobody else has modified the Task in the meantime. </param>
        /// <param name="lastModified"> The last modified time of the Task. </param>
        /// <param name="creationTime"> The creation time of the Task. </param>
        /// <param name="exitConditions"> How the Batch service should respond when the Task completes. </param>
        /// <param name="state"> The current state of the Task. </param>
        /// <param name="stateTransitionTime"> The time at which the Task entered its current state. </param>
        /// <param name="previousState"> The previous state of the Task. This property is not set if the Task is in its initial Active state. </param>
        /// <param name="previousStateTransitionTime"> The time at which the Task entered its previous state. This property is not set if the Task is in its initial Active state. </param>
        /// <param name="commandLine"> The command line of the Task. For multi-instance Tasks, the command line is executed as the primary Task, after the primary Task and all subtasks have finished executing the coordination command line. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <param name="containerSettings"> The settings for the container under which the Task runs. If the Pool that will run this Task has containerConfiguration set, this must be set as well. If the Pool that will run this Task doesn't have containerConfiguration set, this must not be set. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </param>
        /// <param name="resourceFiles"> A list of files that the Batch service will download to the Compute Node before running the command line. For multi-instance Tasks, the resource files will only be downloaded to the Compute Node on which the primary Task is executed. There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. </param>
        /// <param name="outputFiles"> A list of files that the Batch service will upload from the Compute Node after running the command line. For multi-instance Tasks, the files will only be uploaded from the Compute Node on which the primary Task is executed. </param>
        /// <param name="environmentSettings"> A list of environment variable settings for the Task. </param>
        /// <param name="affinityInfo"> A locality hint that can be used by the Batch service to select a Compute Node on which to start the new Task. </param>
        /// <param name="constraints"> The execution constraints that apply to this Task. </param>
        /// <param name="requiredSlots"> The number of scheduling slots that the Task requires to run. The default is 1. A Task can only be scheduled to run on a compute node if the node has enough free scheduling slots available. For multi-instance Tasks, this must be 1. </param>
        /// <param name="userIdentity"> The user identity under which the Task runs. If omitted, the Task runs as a non-administrative user unique to the Task. </param>
        /// <param name="executionInfo"> Information about the execution of the Task. </param>
        /// <param name="nodeInfo"> Information about the Compute Node on which the Task ran. </param>
        /// <param name="multiInstanceSettings"> An object that indicates that the Task is a multi-instance Task, and contains information about how to run the multi-instance Task. </param>
        /// <param name="stats"> Resource usage statistics for the Task. </param>
        /// <param name="dependsOn"> The Tasks that this Task depends on. This Task will not be scheduled until all Tasks that it depends on have completed successfully. If any of those Tasks fail and exhaust their retry counts, this Task will never be scheduled. </param>
        /// <param name="applicationPackageReferences"> A list of Packages that the Batch service will deploy to the Compute Node before running the command line. Application packages are downloaded and deployed to a shared directory, not the Task working directory. Therefore, if a referenced package is already on the Node, and is up to date, then it is not re-downloaded; the existing copy on the Compute Node is used. If a referenced Package cannot be installed, for example because the package has been deleted or because download failed, the Task fails. </param>
        /// <param name="authenticationTokenSettings"> The settings for an authentication token that the Task can use to perform Batch service operations. If this property is set, the Batch service provides the Task with an authentication token which can be used to authenticate Batch service operations without requiring an Account access key. The token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment variable. The operations that the Task can carry out using the token depend on the settings. For example, a Task can request Job permissions in order to add other Tasks to the Job, or check the status of the Job or of other Tasks under the Job. </param>
        internal BatchTask(string id, string displayName, string url, string eTag, DateTimeOffset? lastModified, DateTimeOffset? creationTime, ExitConditions exitConditions, TaskState? state, DateTimeOffset? stateTransitionTime, TaskState? previousState, DateTimeOffset? previousStateTransitionTime, string commandLine, TaskContainerSettings containerSettings, IReadOnlyList<ResourceFile> resourceFiles, IReadOnlyList<OutputFile> outputFiles, IReadOnlyList<EnvironmentSetting> environmentSettings, AffinityInformation affinityInfo, TaskConstraints constraints, int? requiredSlots, UserIdentity userIdentity, TaskExecutionInformation executionInfo, BatchNodeInformation nodeInfo, MultiInstanceSettings multiInstanceSettings, TaskStatistics stats, TaskDependencies dependsOn, IReadOnlyList<ApplicationPackageReference> applicationPackageReferences, AuthenticationTokenSettings authenticationTokenSettings)
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            ExitConditions = exitConditions;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            OutputFiles = outputFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            RequiredSlots = requiredSlots;
            UserIdentity = userIdentity;
            ExecutionInfo = executionInfo;
            NodeInfo = nodeInfo;
            MultiInstanceSettings = multiInstanceSettings;
            Stats = stats;
            DependsOn = dependsOn;
            ApplicationPackageReferences = applicationPackageReferences;
            AuthenticationTokenSettings = authenticationTokenSettings;
        }

        /// <summary> A string that uniquely identifies the Task within the Job. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. </summary>
        public string Id { get; }
        /// <summary> A display name for the Task. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; }
        /// <summary> The URL of the Task. </summary>
        public string Url { get; }
        /// <summary> The ETag of the Task. This is an opaque string. You can use it to detect whether the Task has changed between requests. In particular, you can be pass the ETag when updating a Task to specify that your changes should take effect only if nobody else has modified the Task in the meantime. </summary>
        public string ETag { get; }
        /// <summary> The last modified time of the Task. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> The creation time of the Task. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> How the Batch service should respond when the Task completes. </summary>
        public ExitConditions ExitConditions { get; }
        /// <summary> The current state of the Task. </summary>
        public TaskState? State { get; }
        /// <summary> The time at which the Task entered its current state. </summary>
        public DateTimeOffset? StateTransitionTime { get; }
        /// <summary> The previous state of the Task. This property is not set if the Task is in its initial Active state. </summary>
        public TaskState? PreviousState { get; }
        /// <summary> The time at which the Task entered its previous state. This property is not set if the Task is in its initial Active state. </summary>
        public DateTimeOffset? PreviousStateTransitionTime { get; }
        /// <summary> The command line of the Task. For multi-instance Tasks, the command line is executed as the primary Task, after the primary Task and all subtasks have finished executing the coordination command line. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </summary>
        public string CommandLine { get; }
        /// <summary> The settings for the container under which the Task runs. If the Pool that will run this Task has containerConfiguration set, this must be set as well. If the Pool that will run this Task doesn't have containerConfiguration set, this must not be set. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </summary>
        public TaskContainerSettings ContainerSettings { get; }
        /// <summary> A list of files that the Batch service will download to the Compute Node before running the command line. For multi-instance Tasks, the resource files will only be downloaded to the Compute Node on which the primary Task is executed. There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. </summary>
        public IReadOnlyList<ResourceFile> ResourceFiles { get; }
        /// <summary> A list of files that the Batch service will upload from the Compute Node after running the command line. For multi-instance Tasks, the files will only be uploaded from the Compute Node on which the primary Task is executed. </summary>
        public IReadOnlyList<OutputFile> OutputFiles { get; }
        /// <summary> A list of environment variable settings for the Task. </summary>
        public IReadOnlyList<EnvironmentSetting> EnvironmentSettings { get; }
        /// <summary> A locality hint that can be used by the Batch service to select a Compute Node on which to start the new Task. </summary>
        public AffinityInformation AffinityInfo { get; }
        /// <summary> The execution constraints that apply to this Task. </summary>
        public TaskConstraints Constraints { get; set; }
        /// <summary> The number of scheduling slots that the Task requires to run. The default is 1. A Task can only be scheduled to run on a compute node if the node has enough free scheduling slots available. For multi-instance Tasks, this must be 1. </summary>
        public int? RequiredSlots { get; }
        /// <summary> The user identity under which the Task runs. If omitted, the Task runs as a non-administrative user unique to the Task. </summary>
        public UserIdentity UserIdentity { get; }
        /// <summary> Information about the execution of the Task. </summary>
        public TaskExecutionInformation ExecutionInfo { get; }
        /// <summary> Information about the Compute Node on which the Task ran. </summary>
        public BatchNodeInformation NodeInfo { get; }
        /// <summary> An object that indicates that the Task is a multi-instance Task, and contains information about how to run the multi-instance Task. </summary>
        public MultiInstanceSettings MultiInstanceSettings { get; }
        /// <summary> Resource usage statistics for the Task. </summary>
        public TaskStatistics Stats { get; }
        /// <summary> The Tasks that this Task depends on. This Task will not be scheduled until all Tasks that it depends on have completed successfully. If any of those Tasks fail and exhaust their retry counts, this Task will never be scheduled. </summary>
        public TaskDependencies DependsOn { get; }
        /// <summary> A list of Packages that the Batch service will deploy to the Compute Node before running the command line. Application packages are downloaded and deployed to a shared directory, not the Task working directory. Therefore, if a referenced package is already on the Node, and is up to date, then it is not re-downloaded; the existing copy on the Compute Node is used. If a referenced Package cannot be installed, for example because the package has been deleted or because download failed, the Task fails. </summary>
        public IReadOnlyList<ApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> The settings for an authentication token that the Task can use to perform Batch service operations. If this property is set, the Batch service provides the Task with an authentication token which can be used to authenticate Batch service operations without requiring an Account access key. The token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment variable. The operations that the Task can carry out using the token depend on the settings. For example, a Task can request Job permissions in order to add other Tasks to the Job, or check the status of the Job or of other Tasks under the Job. </summary>
        public AuthenticationTokenSettings AuthenticationTokenSettings { get; }
    }
}
