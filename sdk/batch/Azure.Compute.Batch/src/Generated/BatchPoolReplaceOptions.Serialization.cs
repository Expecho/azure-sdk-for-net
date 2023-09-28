// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchPoolReplaceOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                writer.WriteObjectValue(StartTask);
            }
            writer.WritePropertyName("certificateReferences"u8);
            writer.WriteStartArray();
            foreach (var item in CertificateReferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("applicationPackageReferences"u8);
            writer.WriteStartArray();
            foreach (var item in ApplicationPackageReferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("metadata"u8);
            writer.WriteStartArray();
            foreach (var item in Metadata)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
