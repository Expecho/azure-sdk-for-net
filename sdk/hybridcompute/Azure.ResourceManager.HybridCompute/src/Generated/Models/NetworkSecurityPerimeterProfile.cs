// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Network Security Perimeter profile. </summary>
    public partial class NetworkSecurityPerimeterProfile
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfile"/>. </summary>
        internal NetworkSecurityPerimeterProfile()
        {
            AccessRules = new ChangeTrackingList<HybridComputeAccessRule>();
            EnabledLogCategories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfile"/>. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="accessRulesVersion"> Access rules version number. </param>
        /// <param name="accessRules"> Collection of access rules for the profile. </param>
        /// <param name="diagnosticSettingsVersion"> Diagnostic settings version number. </param>
        /// <param name="enabledLogCategories"> Collection of enabled log categories for the profile. </param>
        internal NetworkSecurityPerimeterProfile(string name, string accessRulesVersion, IReadOnlyList<HybridComputeAccessRule> accessRules, string diagnosticSettingsVersion, IReadOnlyList<string> enabledLogCategories)
        {
            Name = name;
            AccessRulesVersion = accessRulesVersion;
            AccessRules = accessRules;
            DiagnosticSettingsVersion = diagnosticSettingsVersion;
            EnabledLogCategories = enabledLogCategories;
        }

        /// <summary> Name of the resource. </summary>
        public string Name { get; }
        /// <summary> Access rules version number. </summary>
        public string AccessRulesVersion { get; }
        /// <summary> Collection of access rules for the profile. </summary>
        public IReadOnlyList<HybridComputeAccessRule> AccessRules { get; }
        /// <summary> Diagnostic settings version number. </summary>
        public string DiagnosticSettingsVersion { get; }
        /// <summary> Collection of enabled log categories for the profile. </summary>
        public IReadOnlyList<string> EnabledLogCategories { get; }
    }
}
