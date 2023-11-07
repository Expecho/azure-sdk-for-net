// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The resources of the network function component. </summary>
    public partial class ComponentKubernetesResources
    {
        /// <summary> Initializes a new instance of ComponentKubernetesResources. </summary>
        internal ComponentKubernetesResources()
        {
            Deployments = new ChangeTrackingList<KubernetesDeployment>();
            Pods = new ChangeTrackingList<KubernetesPod>();
            ReplicaSets = new ChangeTrackingList<KubernetesReplicaSet>();
            StatefulSets = new ChangeTrackingList<KubernetesStatefulSet>();
            DaemonSets = new ChangeTrackingList<KubernetesDaemonSet>();
        }

        /// <summary> Initializes a new instance of ComponentKubernetesResources. </summary>
        /// <param name="deployments"> Deployments that are related to component resource. </param>
        /// <param name="pods"> Pods related to component resource. </param>
        /// <param name="replicaSets"> Replica sets related to component resource. </param>
        /// <param name="statefulSets"> Stateful sets related to component resource. </param>
        /// <param name="daemonSets"> Daemonsets related to component resource. </param>
        internal ComponentKubernetesResources(IReadOnlyList<KubernetesDeployment> deployments, IReadOnlyList<KubernetesPod> pods, IReadOnlyList<KubernetesReplicaSet> replicaSets, IReadOnlyList<KubernetesStatefulSet> statefulSets, IReadOnlyList<KubernetesDaemonSet> daemonSets)
        {
            Deployments = deployments;
            Pods = pods;
            ReplicaSets = replicaSets;
            StatefulSets = statefulSets;
            DaemonSets = daemonSets;
        }

        /// <summary> Deployments that are related to component resource. </summary>
        public IReadOnlyList<KubernetesDeployment> Deployments { get; }
        /// <summary> Pods related to component resource. </summary>
        public IReadOnlyList<KubernetesPod> Pods { get; }
        /// <summary> Replica sets related to component resource. </summary>
        public IReadOnlyList<KubernetesReplicaSet> ReplicaSets { get; }
        /// <summary> Stateful sets related to component resource. </summary>
        public IReadOnlyList<KubernetesStatefulSet> StatefulSets { get; }
        /// <summary> Daemonsets related to component resource. </summary>
        public IReadOnlyList<KubernetesDaemonSet> DaemonSets { get; }
    }
}
