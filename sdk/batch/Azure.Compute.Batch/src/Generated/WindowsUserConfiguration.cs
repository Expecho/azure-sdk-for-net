// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Compute.Batch
{
    /// <summary> Properties used to create a user Account on a Windows Compute Node. </summary>
    public partial class WindowsUserConfiguration
    {
        /// <summary> Initializes a new instance of WindowsUserConfiguration. </summary>
        public WindowsUserConfiguration()
        {
        }

        /// <summary> Initializes a new instance of WindowsUserConfiguration. </summary>
        /// <param name="loginMode"> The login mode for the user. The default value for VirtualMachineConfiguration Pools is 'batch' and for CloudServiceConfiguration Pools is 'interactive'. </param>
        internal WindowsUserConfiguration(LoginMode? loginMode)
        {
            LoginMode = loginMode;
        }

        /// <summary> The login mode for the user. The default value for VirtualMachineConfiguration Pools is 'batch' and for CloudServiceConfiguration Pools is 'interactive'. </summary>
        public LoginMode? LoginMode { get; set; }
    }
}
