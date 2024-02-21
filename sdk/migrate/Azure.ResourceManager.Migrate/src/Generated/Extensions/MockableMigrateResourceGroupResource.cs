// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMigrateResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMigrateResourceGroupResource"/> class for mocking. </summary>
        protected MockableMigrateResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMigrateResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMigrateResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MigrateAssessmentProjectResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MigrateAssessmentProjectResources and their operations over a MigrateAssessmentProjectResource. </returns>
        public virtual MigrateAssessmentProjectCollection GetMigrateAssessmentProjects()
        {
            return GetCachedClient(client => new MigrateAssessmentProjectCollection(client, Id));
        }

        /// <summary>
        /// Get a AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAssessmentProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MigrateAssessmentProjectResource>> GetMigrateAssessmentProjectAsync(string projectName, CancellationToken cancellationToken = default)
        {
            return await GetMigrateAssessmentProjects().GetAsync(projectName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrateAssessmentProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MigrateAssessmentProjectResource> GetMigrateAssessmentProject(string projectName, CancellationToken cancellationToken = default)
        {
            return GetMigrateAssessmentProjects().Get(projectName, cancellationToken);
        }
    }
}
