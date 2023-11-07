// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class LibraryRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of LibraryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public LibraryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Library. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<LibraryListResponse>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists Library. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LibraryListResponse> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateFlushRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendPath("/flush", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Flush Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response> FlushAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateFlushRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Flush Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response Flush(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateFlushRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOperationResultRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraryOperationResults/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Operation result for Library. </summary>
        /// <param name="operationId"> operation id for which status is requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<Response<object>> GetOperationResultAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationResultRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                case 202:
                    {
                        OperationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationResult.DeserializeOperationResult(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Operation result for Library. </summary>
        /// <param name="operationId"> operation id for which status is requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public Response<object> GetOperationResult(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationResultRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                case 202:
                    {
                        OperationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationResult.DeserializeOperationResult(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateDeleteRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 409:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response Delete(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateDeleteRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 409:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response<LibraryResource>> GetAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateGetRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((LibraryResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response<LibraryResource> Get(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateGetRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((LibraryResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Creates a library with the library name. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response> CreateAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateCreateRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a library with the library name. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response Create(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateCreateRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAppendRequest(string libraryName, Stream content, long? blobConditionAppendPosition)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("comp", "appendblock", true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            if (blobConditionAppendPosition != null)
            {
                request.Headers.Add("x-ms-blob-condition-appendpos", blobConditionAppendPosition.Value);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/octet-stream");
            request.Content = RequestContent.Create(content);
            return message;
        }

        /// <summary> Append the content to the library resource created using the create operation. The maximum content size is 4MiB. Content larger than 4MiB must be appended in 4MiB chunks. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="content"> Library file chunk. </param>
        /// <param name="blobConditionAppendPosition"> Set this header to a byte offset at which the block is expected to be appended. The request succeeds only if the current offset matches this value. Otherwise, the request fails with the AppendPositionConditionNotMet error (HTTP status code 412 – Precondition Failed). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> or <paramref name="content"/> is null. </exception>
        public async Task<Response> AppendAsync(string libraryName, Stream content, long? blobConditionAppendPosition = null, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateAppendRequest(libraryName, content, blobConditionAppendPosition);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Append the content to the library resource created using the create operation. The maximum content size is 4MiB. Content larger than 4MiB must be appended in 4MiB chunks. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="content"> Library file chunk. </param>
        /// <param name="blobConditionAppendPosition"> Set this header to a byte offset at which the block is expected to be appended. The request succeeds only if the current offset matches this value. Otherwise, the request fails with the AppendPositionConditionNotMet error (HTTP status code 412 – Precondition Failed). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> or <paramref name="content"/> is null. </exception>
        public Response Append(string libraryName, Stream content, long? blobConditionAppendPosition = null, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateAppendRequest(libraryName, content, blobConditionAppendPosition);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Library. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<LibraryListResponse>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists Library. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<LibraryListResponse> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
