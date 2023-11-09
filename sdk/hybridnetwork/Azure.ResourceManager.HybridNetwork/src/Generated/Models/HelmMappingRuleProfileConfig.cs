// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The helm deployment options. </summary>
    public partial class HelmMappingRuleProfileConfig
    {
        /// <summary> Initializes a new instance of HelmMappingRuleProfileConfig. </summary>
        public HelmMappingRuleProfileConfig()
        {
        }

        /// <summary> Initializes a new instance of HelmMappingRuleProfileConfig. </summary>
        /// <param name="installOptions"> The helm deployment install options. </param>
        /// <param name="upgradeOptions"> The helm deployment upgrade options. </param>
        internal HelmMappingRuleProfileConfig(HelmInstallConfig installOptions, HelmUpgradeConfig upgradeOptions)
        {
            InstallOptions = installOptions;
            UpgradeOptions = upgradeOptions;
        }

        /// <summary> The helm deployment install options. </summary>
        public HelmInstallConfig InstallOptions { get; set; }
        /// <summary> The helm deployment upgrade options. </summary>
        public HelmUpgradeConfig UpgradeOptions { get; set; }
    }
}
