// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> Specifies details of the Jobs to be created on a schedule. </summary>
    public partial class JobSpecification
    {
        /// <summary> Initializes a new instance of JobSpecification. </summary>
        /// <param name="poolInfo"> The Pool on which the Batch service runs the Tasks of Jobs created under this schedule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolInfo"/> is null. </exception>
        public JobSpecification(PoolInformation poolInfo)
        {
            Argument.AssertNotNull(poolInfo, nameof(poolInfo));

            CommonEnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
            PoolInfo = poolInfo;
            Metadata = new ChangeTrackingList<MetadataItem>();
        }

        /// <summary> Initializes a new instance of JobSpecification. </summary>
        /// <param name="priority"> The priority of Jobs created under this schedule. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0. This priority is used as the default for all Jobs under the Job Schedule. You can update a Job's priority after it has been created using by using the update Job API. </param>
        /// <param name="allowTaskPreemption"> Whether Tasks in this job can be preempted by other high priority jobs. If the value is set to True, other high priority jobs submitted to the system will take precedence and will be able requeue tasks from this job. You can update a job's allowTaskPreemption after it has been created using the update job API. </param>
        /// <param name="maxParallelTasks"> The maximum number of tasks that can be executed in parallel for the job. The value of maxParallelTasks must be -1 or greater than 0 if specified. If not specified, the default value is -1, which means there's no limit to the number of tasks that can be run at once. You can update a job's maxParallelTasks after it has been created using the update job API. </param>
        /// <param name="displayName"> The display name for Jobs created under this schedule. The name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="usesTaskDependencies"> Whether Tasks in the Job can define dependencies on each other. The default is false. </param>
        /// <param name="onAllTasksComplete"> The action the Batch service should take when all Tasks in a Job created under this schedule are in the completed state. Note that if a Job contains no Tasks, then all Tasks are considered complete. This option is therefore most commonly used with a Job Manager task; if you want to use automatic Job termination without a Job Manager, you should initially set onAllTasksComplete to noaction and update the Job properties to set onAllTasksComplete to terminatejob once you have finished adding Tasks. The default is noaction. </param>
        /// <param name="onTaskFailure"> The action the Batch service should take when any Task fails in a Job created under this schedule. A Task is considered to have failed if it have failed if has a failureInfo. A failureInfo is set if the Task completes with a non-zero exit code after exhausting its retry count, or if there was an error starting the Task, for example due to a resource file download error. The default is noaction. </param>
        /// <param name="networkConfiguration"> The network configuration for the Job. </param>
        /// <param name="constraints"> The execution constraints for Jobs created under this schedule. </param>
        /// <param name="jobManagerTask"> The details of a Job Manager Task to be launched when a Job is started under this schedule. If the Job does not specify a Job Manager Task, the user must explicitly add Tasks to the Job using the Task API. If the Job does specify a Job Manager Task, the Batch service creates the Job Manager Task when the Job is created, and will try to schedule the Job Manager Task before scheduling other Tasks in the Job. </param>
        /// <param name="jobPreparationTask"> The Job Preparation Task for Jobs created under this schedule. If a Job has a Job Preparation Task, the Batch service will run the Job Preparation Task on a Node before starting any Tasks of that Job on that Compute Node. </param>
        /// <param name="jobReleaseTask"> The Job Release Task for Jobs created under this schedule. The primary purpose of the Job Release Task is to undo changes to Nodes made by the Job Preparation Task. Example activities include deleting local files, or shutting down services that were started as part of Job preparation. A Job Release Task cannot be specified without also specifying a Job Preparation Task for the Job. The Batch service runs the Job Release Task on the Compute Nodes that have run the Job Preparation Task. </param>
        /// <param name="commonEnvironmentSettings"> A list of common environment variable settings. These environment variables are set for all Tasks in Jobs created under this schedule (including the Job Manager, Job Preparation and Job Release Tasks). Individual Tasks can override an environment setting specified here by specifying the same setting name with a different value. </param>
        /// <param name="poolInfo"> The Pool on which the Batch service runs the Tasks of Jobs created under this schedule. </param>
        /// <param name="metadata"> A list of name-value pairs associated with each Job created under this schedule as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </param>
        internal JobSpecification(int? priority, bool? allowTaskPreemption, int? maxParallelTasks, string displayName, bool? usesTaskDependencies, OnAllTasksComplete? onAllTasksComplete, OnTaskFailure? onTaskFailure, JobNetworkConfiguration networkConfiguration, JobConstraints constraints, JobManagerTask jobManagerTask, JobPreparationTask jobPreparationTask, JobReleaseTask jobReleaseTask, IList<EnvironmentSetting> commonEnvironmentSettings, PoolInformation poolInfo, IList<MetadataItem> metadata)
        {
            Priority = priority;
            AllowTaskPreemption = allowTaskPreemption;
            MaxParallelTasks = maxParallelTasks;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            NetworkConfiguration = networkConfiguration;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            Metadata = metadata;
        }

        /// <summary> The priority of Jobs created under this schedule. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0. This priority is used as the default for all Jobs under the Job Schedule. You can update a Job's priority after it has been created using by using the update Job API. </summary>
        public int? Priority { get; set; }
        /// <summary> Whether Tasks in this job can be preempted by other high priority jobs. If the value is set to True, other high priority jobs submitted to the system will take precedence and will be able requeue tasks from this job. You can update a job's allowTaskPreemption after it has been created using the update job API. </summary>
        public bool? AllowTaskPreemption { get; set; }
        /// <summary> The maximum number of tasks that can be executed in parallel for the job. The value of maxParallelTasks must be -1 or greater than 0 if specified. If not specified, the default value is -1, which means there's no limit to the number of tasks that can be run at once. You can update a job's maxParallelTasks after it has been created using the update job API. </summary>
        public int? MaxParallelTasks { get; set; }
        /// <summary> The display name for Jobs created under this schedule. The name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; set; }
        /// <summary> Whether Tasks in the Job can define dependencies on each other. The default is false. </summary>
        public bool? UsesTaskDependencies { get; set; }
        /// <summary> The action the Batch service should take when all Tasks in a Job created under this schedule are in the completed state. Note that if a Job contains no Tasks, then all Tasks are considered complete. This option is therefore most commonly used with a Job Manager task; if you want to use automatic Job termination without a Job Manager, you should initially set onAllTasksComplete to noaction and update the Job properties to set onAllTasksComplete to terminatejob once you have finished adding Tasks. The default is noaction. </summary>
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }
        /// <summary> The action the Batch service should take when any Task fails in a Job created under this schedule. A Task is considered to have failed if it have failed if has a failureInfo. A failureInfo is set if the Task completes with a non-zero exit code after exhausting its retry count, or if there was an error starting the Task, for example due to a resource file download error. The default is noaction. </summary>
        public OnTaskFailure? OnTaskFailure { get; set; }
        /// <summary> The network configuration for the Job. </summary>
        public JobNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> The execution constraints for Jobs created under this schedule. </summary>
        public JobConstraints Constraints { get; set; }
        /// <summary> The details of a Job Manager Task to be launched when a Job is started under this schedule. If the Job does not specify a Job Manager Task, the user must explicitly add Tasks to the Job using the Task API. If the Job does specify a Job Manager Task, the Batch service creates the Job Manager Task when the Job is created, and will try to schedule the Job Manager Task before scheduling other Tasks in the Job. </summary>
        public JobManagerTask JobManagerTask { get; set; }
        /// <summary> The Job Preparation Task for Jobs created under this schedule. If a Job has a Job Preparation Task, the Batch service will run the Job Preparation Task on a Node before starting any Tasks of that Job on that Compute Node. </summary>
        public JobPreparationTask JobPreparationTask { get; set; }
        /// <summary> The Job Release Task for Jobs created under this schedule. The primary purpose of the Job Release Task is to undo changes to Nodes made by the Job Preparation Task. Example activities include deleting local files, or shutting down services that were started as part of Job preparation. A Job Release Task cannot be specified without also specifying a Job Preparation Task for the Job. The Batch service runs the Job Release Task on the Compute Nodes that have run the Job Preparation Task. </summary>
        public JobReleaseTask JobReleaseTask { get; set; }
        /// <summary> A list of common environment variable settings. These environment variables are set for all Tasks in Jobs created under this schedule (including the Job Manager, Job Preparation and Job Release Tasks). Individual Tasks can override an environment setting specified here by specifying the same setting name with a different value. </summary>
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; }
        /// <summary> The Pool on which the Batch service runs the Tasks of Jobs created under this schedule. </summary>
        public PoolInformation PoolInfo { get; set; }
        /// <summary> A list of name-value pairs associated with each Job created under this schedule as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </summary>
        public IList<MetadataItem> Metadata { get; }
    }
}
