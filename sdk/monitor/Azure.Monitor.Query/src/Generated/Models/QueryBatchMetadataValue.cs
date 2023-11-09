// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitor.Query.Models
{
    /// <summary> Represents a metric metadata value. </summary>
    public partial class QueryBatchMetadataValue
    {
        /// <summary> Initializes a new instance of QueryBatchMetadataValue. </summary>
        internal QueryBatchMetadataValue()
        {
        }

        /// <summary> Initializes a new instance of QueryBatchMetadataValue. </summary>
        /// <param name="name"> The name of the metadata. </param>
        /// <param name="value"> The value of the metadata. </param>
        internal QueryBatchMetadataValue(QueryBatchLocalizableString name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the metadata. </summary>
        public QueryBatchLocalizableString Name { get; }
        /// <summary> The value of the metadata. </summary>
        public string Value { get; }
    }
}
