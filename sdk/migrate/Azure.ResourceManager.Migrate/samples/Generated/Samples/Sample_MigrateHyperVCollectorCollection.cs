// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Migrate;
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate.Samples
{
    public partial class Sample_MigrateHyperVCollectorCollection
    {
        // HypervCollectorsOperations_ListByAssessmentProject_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_HypervCollectorsOperationsListByAssessmentProjectMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/HypervCollectorsOperations_ListByAssessmentProject_MaximumSet_Gen.json
            // this example is just showing the usage of "HypervCollectorsOperations_ListByAssessmentProject" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrateAssessmentProjectResource created on azure
            // for more information of creating MigrateAssessmentProjectResource, please refer to the document of MigrateAssessmentProjectResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            ResourceIdentifier migrateAssessmentProjectResourceId = MigrateAssessmentProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            MigrateAssessmentProjectResource migrateAssessmentProject = client.GetMigrateAssessmentProjectResource(migrateAssessmentProjectResourceId);

            // get the collection of this MigrateHyperVCollectorResource
            MigrateHyperVCollectorCollection collection = migrateAssessmentProject.GetMigrateHyperVCollectors();

            // invoke the operation and iterate over the result
            await foreach (MigrateHyperVCollectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrateHyperVCollectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // HypervCollectorsOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HypervCollectorsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/HypervCollectorsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "HypervCollectorsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrateAssessmentProjectResource created on azure
            // for more information of creating MigrateAssessmentProjectResource, please refer to the document of MigrateAssessmentProjectResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            ResourceIdentifier migrateAssessmentProjectResourceId = MigrateAssessmentProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            MigrateAssessmentProjectResource migrateAssessmentProject = client.GetMigrateAssessmentProjectResource(migrateAssessmentProjectResourceId);

            // get the collection of this MigrateHyperVCollectorResource
            MigrateHyperVCollectorCollection collection = migrateAssessmentProject.GetMigrateHyperVCollectors();

            // invoke the operation
            string hyperVCollectorName = "test-697cecollector";
            MigrateHyperVCollectorResource result = await collection.GetAsync(hyperVCollectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrateHyperVCollectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HypervCollectorsOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_HypervCollectorsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/HypervCollectorsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "HypervCollectorsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrateAssessmentProjectResource created on azure
            // for more information of creating MigrateAssessmentProjectResource, please refer to the document of MigrateAssessmentProjectResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            ResourceIdentifier migrateAssessmentProjectResourceId = MigrateAssessmentProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            MigrateAssessmentProjectResource migrateAssessmentProject = client.GetMigrateAssessmentProjectResource(migrateAssessmentProjectResourceId);

            // get the collection of this MigrateHyperVCollectorResource
            MigrateHyperVCollectorCollection collection = migrateAssessmentProject.GetMigrateHyperVCollectors();

            // invoke the operation
            string hyperVCollectorName = "test-697cecollector";
            bool result = await collection.ExistsAsync(hyperVCollectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // HypervCollectorsOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_HypervCollectorsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/HypervCollectorsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "HypervCollectorsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrateAssessmentProjectResource created on azure
            // for more information of creating MigrateAssessmentProjectResource, please refer to the document of MigrateAssessmentProjectResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            ResourceIdentifier migrateAssessmentProjectResourceId = MigrateAssessmentProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            MigrateAssessmentProjectResource migrateAssessmentProject = client.GetMigrateAssessmentProjectResource(migrateAssessmentProjectResourceId);

            // get the collection of this MigrateHyperVCollectorResource
            MigrateHyperVCollectorCollection collection = migrateAssessmentProject.GetMigrateHyperVCollectors();

            // invoke the operation
            string hyperVCollectorName = "test-697cecollector";
            NullableResponse<MigrateHyperVCollectorResource> response = await collection.GetIfExistsAsync(hyperVCollectorName);
            MigrateHyperVCollectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrateHyperVCollectorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // HypervCollectorsOperations_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HypervCollectorsOperationsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/HypervCollectorsOperations_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "HypervCollectorsOperations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrateAssessmentProjectResource created on azure
            // for more information of creating MigrateAssessmentProjectResource, please refer to the document of MigrateAssessmentProjectResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            ResourceIdentifier migrateAssessmentProjectResourceId = MigrateAssessmentProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            MigrateAssessmentProjectResource migrateAssessmentProject = client.GetMigrateAssessmentProjectResource(migrateAssessmentProjectResourceId);

            // get the collection of this MigrateHyperVCollectorResource
            MigrateHyperVCollectorCollection collection = migrateAssessmentProject.GetMigrateHyperVCollectors();

            // invoke the operation
            string hyperVCollectorName = "test-697cecollector";
            MigrateHyperVCollectorData data = new MigrateHyperVCollectorData()
            {
                ProvisioningState = MigrateProvisioningState.Succeeded,
                AgentProperties = new CollectorAgentPropertiesBase()
                {
                    Id = "12f1d90f-b3fa-4926-8893-e56803a09af0",
                    Version = "2.0.1993.19",
                    LastHeartbeatOn = DateTimeOffset.Parse("2022-07-07T14:25:35.708325Z"),
                    SpnDetails = new CollectorAgentSpnPropertiesBase()
                    {
                        Authority = "https://login.windows.net/72f988bf-86f1-41af-91ab-2d7cd011db47",
                        ApplicationId = "e3bd6eaa-980b-40ae-a30e-2a5069ba097c",
                        Audience = "e3bd6eaa-980b-40ae-a30e-2a5069ba097c",
                        ObjectId = "01b9f9e2-2d82-414c-adaa-09ce259b6b44",
                        TenantId = Guid.Parse("72f988bf-86f1-41af-91ab-2d7cd011db47"),
                    },
                },
                DiscoverySiteId = "/subscriptions/4bd2aa0f-2bd2-4d67-91a8-5a4533d58600/resourceGroups/ayagrawRG/providers/Microsoft.OffAzure/HyperVSites/test-60527site",
            };
            ArmOperation<MigrateHyperVCollectorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hyperVCollectorName, data);
            MigrateHyperVCollectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrateHyperVCollectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
