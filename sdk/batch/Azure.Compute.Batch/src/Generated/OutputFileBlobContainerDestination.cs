// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> Specifies a file upload destination within an Azure blob storage container. </summary>
    public partial class OutputFileBlobContainerDestination
    {
        /// <summary> Initializes a new instance of OutputFileBlobContainerDestination. </summary>
        /// <param name="containerUrl"> The URL of the container within Azure Blob Storage to which to upload the file(s). If not using a managed identity, the URL must include a Shared Access Signature (SAS) granting write permissions to the container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUrl"/> is null. </exception>
        public OutputFileBlobContainerDestination(string containerUrl)
        {
            Argument.AssertNotNull(containerUrl, nameof(containerUrl));

            ContainerUrl = containerUrl;
            UploadHeaders = new ChangeTrackingList<HttpHeader>();
        }

        /// <summary> Initializes a new instance of OutputFileBlobContainerDestination. </summary>
        /// <param name="path"> The destination blob or virtual directory within the Azure Storage container. If filePattern refers to a specific file (i.e. contains no wildcards), then path is the name of the blob to which to upload that file. If filePattern contains one or more wildcards (and therefore may match multiple files), then path is the name of the blob virtual directory (which is prepended to each blob name) to which to upload the file(s). If omitted, file(s) are uploaded to the root of the container with a blob name matching their file name. </param>
        /// <param name="containerUrl"> The URL of the container within Azure Blob Storage to which to upload the file(s). If not using a managed identity, the URL must include a Shared Access Signature (SAS) granting write permissions to the container. </param>
        /// <param name="identityReference"> The reference to the user assigned identity to use to access Azure Blob Storage specified by containerUrl. The identity must have write access to the Azure Blob Storage container. </param>
        /// <param name="uploadHeaders"> A list of name-value pairs for headers to be used in uploading output files. These headers will be specified when uploading files to Azure Storage. Official document on allowed headers when uploading blobs: https://docs.microsoft.com/en-us/rest/api/storageservices/put-blob#request-headers-all-blob-types. </param>
        internal OutputFileBlobContainerDestination(string path, string containerUrl, BatchNodeIdentityReference identityReference, IList<HttpHeader> uploadHeaders)
        {
            Path = path;
            ContainerUrl = containerUrl;
            IdentityReference = identityReference;
            UploadHeaders = uploadHeaders;
        }

        /// <summary> The destination blob or virtual directory within the Azure Storage container. If filePattern refers to a specific file (i.e. contains no wildcards), then path is the name of the blob to which to upload that file. If filePattern contains one or more wildcards (and therefore may match multiple files), then path is the name of the blob virtual directory (which is prepended to each blob name) to which to upload the file(s). If omitted, file(s) are uploaded to the root of the container with a blob name matching their file name. </summary>
        public string Path { get; set; }
        /// <summary> The URL of the container within Azure Blob Storage to which to upload the file(s). If not using a managed identity, the URL must include a Shared Access Signature (SAS) granting write permissions to the container. </summary>
        public string ContainerUrl { get; set; }
        /// <summary> The reference to the user assigned identity to use to access Azure Blob Storage specified by containerUrl. The identity must have write access to the Azure Blob Storage container. </summary>
        public BatchNodeIdentityReference IdentityReference { get; set; }
        /// <summary> A list of name-value pairs for headers to be used in uploading output files. These headers will be specified when uploading files to Azure Storage. Official document on allowed headers when uploading blobs: https://docs.microsoft.com/en-us/rest/api/storageservices/put-blob#request-headers-all-blob-types. </summary>
        public IList<HttpHeader> UploadHeaders { get; }
    }
}
