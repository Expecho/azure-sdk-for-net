// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute Synapse notebook activity. </summary>
    public partial class SynapseNotebookActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of SynapseNotebookActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="notebook"> Synapse notebook reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="notebook"/> is null. </exception>
        public SynapseNotebookActivity(string name, SynapseNotebookReference notebook) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (notebook == null)
            {
                throw new ArgumentNullException(nameof(notebook));
            }

            Notebook = notebook;
            Parameters = new ChangeTrackingDictionary<string, object>();
            Type = "SynapseNotebook";
        }

        /// <summary> Initializes a new instance of SynapseNotebookActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="notebook"> Synapse notebook reference. </param>
        /// <param name="parameters"> Notebook parameters. </param>
        internal SynapseNotebookActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, SynapseNotebookReference notebook, IDictionary<string, object> parameters) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Notebook = notebook;
            Parameters = parameters;
            Type = type ?? "SynapseNotebook";
        }

        /// <summary> Synapse notebook reference. </summary>
        public SynapseNotebookReference Notebook { get; set; }
        /// <summary> Notebook parameters. </summary>
        public IDictionary<string, object> Parameters { get; }
    }
}
