// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Result of run notebook. </summary>
    public partial class RunNotebookResult
    {
        /// <summary> Initializes a new instance of RunNotebookResult. </summary>
        internal RunNotebookResult()
        {
        }

        /// <summary> Initializes a new instance of RunNotebookResult. </summary>
        /// <param name="runId"> Run id. </param>
        /// <param name="runStatus"> Status of the run notebook. </param>
        /// <param name="lastCheckedOn"> Timestamp of last update. </param>
        /// <param name="sessionId"> Livy session id. </param>
        /// <param name="sparkPool"> SparkPool name. </param>
        /// <param name="sessionDetail"> Run notebook session details. </param>
        /// <param name="exitValue"> Output of exit command. </param>
        /// <param name="error"> Run notebook error. </param>
        internal RunNotebookResult(string runId, string runStatus, string lastCheckedOn, string sessionId, string sparkPool, object sessionDetail, string exitValue, RunNotebookError error)
        {
            RunId = runId;
            RunStatus = runStatus;
            LastCheckedOn = lastCheckedOn;
            SessionId = sessionId;
            SparkPool = sparkPool;
            SessionDetail = sessionDetail;
            ExitValue = exitValue;
            Error = error;
        }

        /// <summary> Run id. </summary>
        public string RunId { get; }
        /// <summary> Status of the run notebook. </summary>
        public string RunStatus { get; }
        /// <summary> Timestamp of last update. </summary>
        public string LastCheckedOn { get; }
        /// <summary> Livy session id. </summary>
        public string SessionId { get; }
        /// <summary> SparkPool name. </summary>
        public string SparkPool { get; }
        /// <summary> Run notebook session details. </summary>
        public object SessionDetail { get; }
        /// <summary> Output of exit command. </summary>
        public string ExitValue { get; }
        /// <summary> Run notebook error. </summary>
        public RunNotebookError Error { get; }
    }
}
