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
    internal class MigrateAssessmentOperationSource : IOperationSource<MigrateAssessmentResource>
    {
        private readonly ArmClient _client;

        internal MigrateAssessmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        MigrateAssessmentResource IOperationSource<MigrateAssessmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MigrateAssessmentData.DeserializeMigrateAssessmentData(document.RootElement);
            return new MigrateAssessmentResource(_client, data);
        }

        async ValueTask<MigrateAssessmentResource> IOperationSource<MigrateAssessmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MigrateAssessmentData.DeserializeMigrateAssessmentData(document.RootElement);
            return new MigrateAssessmentResource(_client, data);
        }
    }
}
