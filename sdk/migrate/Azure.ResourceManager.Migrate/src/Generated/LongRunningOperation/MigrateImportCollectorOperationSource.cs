// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Migrate
{
    internal class MigrateImportCollectorOperationSource : IOperationSource<MigrateImportCollectorResource>
    {
        private readonly ArmClient _client;

        internal MigrateImportCollectorOperationSource(ArmClient client)
        {
            _client = client;
        }

        MigrateImportCollectorResource IOperationSource<MigrateImportCollectorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MigrateImportCollectorData.DeserializeMigrateImportCollectorData(document.RootElement);
            return new MigrateImportCollectorResource(_client, data);
        }

        async ValueTask<MigrateImportCollectorResource> IOperationSource<MigrateImportCollectorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MigrateImportCollectorData.DeserializeMigrateImportCollectorData(document.RootElement);
            return new MigrateImportCollectorResource(_client, data);
        }
    }
}
