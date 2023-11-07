// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure SQL sink. </summary>
    public partial class AzureSqlSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureSqlSink. </summary>
        public AzureSqlSink()
        {
            Type = "AzureSqlSink";
        }

        /// <summary> Initializes a new instance of AzureSqlSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="sqlWriterStoredProcedureName"> SQL writer stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterTableType"> SQL writer table type. Type: string (or Expression with resultType string). </param>
        /// <param name="preCopyScript"> SQL pre-copy script. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> SQL stored procedure parameters. </param>
        /// <param name="storedProcedureTableTypeParameterName"> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </param>
        /// <param name="tableOption"> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </param>
        internal AzureSqlSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object sqlWriterStoredProcedureName, object sqlWriterTableType, object preCopyScript, object storedProcedureParameters, object storedProcedureTableTypeParameterName, object tableOption) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            SqlWriterStoredProcedureName = sqlWriterStoredProcedureName;
            SqlWriterTableType = sqlWriterTableType;
            PreCopyScript = preCopyScript;
            StoredProcedureParameters = storedProcedureParameters;
            StoredProcedureTableTypeParameterName = storedProcedureTableTypeParameterName;
            TableOption = tableOption;
            Type = type ?? "AzureSqlSink";
        }

        /// <summary> SQL writer stored procedure name. Type: string (or Expression with resultType string). </summary>
        public object SqlWriterStoredProcedureName { get; set; }
        /// <summary> SQL writer table type. Type: string (or Expression with resultType string). </summary>
        public object SqlWriterTableType { get; set; }
        /// <summary> SQL pre-copy script. Type: string (or Expression with resultType string). </summary>
        public object PreCopyScript { get; set; }
        /// <summary> SQL stored procedure parameters. </summary>
        public object StoredProcedureParameters { get; set; }
        /// <summary> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </summary>
        public object StoredProcedureTableTypeParameterName { get; set; }
        /// <summary> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </summary>
        public object TableOption { get; set; }
    }
}
