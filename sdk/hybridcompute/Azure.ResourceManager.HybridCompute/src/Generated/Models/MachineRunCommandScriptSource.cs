// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the script sources for run command. Use only one of script, scriptUri, commandId. </summary>
    public partial class MachineRunCommandScriptSource
    {
        /// <summary> Initializes a new instance of <see cref="MachineRunCommandScriptSource"/>. </summary>
        public MachineRunCommandScriptSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineRunCommandScriptSource"/>. </summary>
        /// <param name="script"> Specifies the script content to be executed on the machine. </param>
        /// <param name="scriptUri"> Specifies the script download location. It can be either SAS URI of an Azure storage blob with read access or public URI. </param>
        /// <param name="commandId"> Specifies the commandId of predefined built-in script. </param>
        /// <param name="scriptUriManagedIdentity"> User-assigned managed identity that has access to scriptUri in case of Azure storage blob. Use an empty object in case of system-assigned identity. Make sure the Azure storage blob exists, and managed identity has been given access to blob's container with 'Storage Blob Data Reader' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </param>
        internal MachineRunCommandScriptSource(string script, Uri scriptUri, string commandId, HybridComputeRunCommandManagedIdentity scriptUriManagedIdentity)
        {
            Script = script;
            ScriptUri = scriptUri;
            CommandId = commandId;
            ScriptUriManagedIdentity = scriptUriManagedIdentity;
        }

        /// <summary> Specifies the script content to be executed on the machine. </summary>
        public string Script { get; set; }
        /// <summary> Specifies the script download location. It can be either SAS URI of an Azure storage blob with read access or public URI. </summary>
        public Uri ScriptUri { get; set; }
        /// <summary> Specifies the commandId of predefined built-in script. </summary>
        public string CommandId { get; set; }
        /// <summary> User-assigned managed identity that has access to scriptUri in case of Azure storage blob. Use an empty object in case of system-assigned identity. Make sure the Azure storage blob exists, and managed identity has been given access to blob's container with 'Storage Blob Data Reader' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
        public HybridComputeRunCommandManagedIdentity ScriptUriManagedIdentity { get; set; }
    }
}
