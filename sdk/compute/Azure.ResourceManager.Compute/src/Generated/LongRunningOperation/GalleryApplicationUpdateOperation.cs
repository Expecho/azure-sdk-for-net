// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Update a gallery Application Definition. </summary>
    public partial class GalleryApplicationUpdateOperation : Operation<GalleryApplication>, IOperationSource<GalleryApplication>
    {
        private readonly OperationInternals<GalleryApplication> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of GalleryApplicationUpdateOperation for mocking. </summary>
        protected GalleryApplicationUpdateOperation()
        {
        }

        internal GalleryApplicationUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<GalleryApplication>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "GalleryApplicationUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override GalleryApplication Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GalleryApplication>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GalleryApplication>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        GalleryApplication IOperationSource<GalleryApplication>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new GalleryApplication(_operationBase, GalleryApplicationData.DeserializeGalleryApplicationData(document.RootElement));
        }

        async ValueTask<GalleryApplication> IOperationSource<GalleryApplication>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new GalleryApplication(_operationBase, GalleryApplicationData.DeserializeGalleryApplicationData(document.RootElement));
        }
    }
}
