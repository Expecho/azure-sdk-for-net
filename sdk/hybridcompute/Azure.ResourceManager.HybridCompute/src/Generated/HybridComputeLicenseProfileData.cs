// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the HybridComputeLicenseProfile data model.
    /// Describes a license profile in a hybrid machine.
    /// </summary>
    public partial class HybridComputeLicenseProfileData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputeLicenseProfileData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridComputeLicenseProfileData(AzureLocation location) : base(location)
        {
            ProductFeatures = new ChangeTrackingList<HybridComputeProductFeature>();
            EsuKeys = new ChangeTrackingList<EsuKey>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeLicenseProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="subscriptionStatus"> Indicates the subscription status of the product. </param>
        /// <param name="productType"> Indicates the product type of the license. </param>
        /// <param name="billingStartOn"> The timestamp in UTC when the billing starts. </param>
        /// <param name="enrollmentOn"> The timestamp in UTC when the user enrolls the feature. </param>
        /// <param name="disenrollmentOn"> The timestamp in UTC when the user disenrolled the feature. </param>
        /// <param name="productFeatures"> The list of product features. </param>
        /// <param name="assignedLicenseImmutableId"> The guid id of the license. </param>
        /// <param name="esuKeys"> The list of ESU keys. </param>
        /// <param name="serverType"> The type of the Esu servers. </param>
        /// <param name="esuEligibility"> Indicates the eligibility state of Esu. </param>
        /// <param name="esuKeyState"> Indicates whether there is an ESU Key currently active for the machine. </param>
        /// <param name="assignedLicense"> The resource id of the license. </param>
        /// <param name="softwareAssuranceCustomer"> Specifies if this machine is licensed as part of a Software Assurance agreement. </param>
        internal HybridComputeLicenseProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HybridComputeProvisioningState? provisioningState, LicenseProfileSubscriptionStatus? subscriptionStatus, LicenseProfileProductType? productType, DateTimeOffset? billingStartOn, DateTimeOffset? enrollmentOn, DateTimeOffset? disenrollmentOn, IList<HybridComputeProductFeature> productFeatures, Guid? assignedLicenseImmutableId, IReadOnlyList<EsuKey> esuKeys, EsuServerType? serverType, EsuEligibility? esuEligibility, EsuKeyState? esuKeyState, string assignedLicense, bool? softwareAssuranceCustomer) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            SubscriptionStatus = subscriptionStatus;
            ProductType = productType;
            BillingStartOn = billingStartOn;
            EnrollmentOn = enrollmentOn;
            DisenrollmentOn = disenrollmentOn;
            ProductFeatures = productFeatures;
            AssignedLicenseImmutableId = assignedLicenseImmutableId;
            EsuKeys = esuKeys;
            ServerType = serverType;
            EsuEligibility = esuEligibility;
            EsuKeyState = esuKeyState;
            AssignedLicense = assignedLicense;
            SoftwareAssuranceCustomer = softwareAssuranceCustomer;
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public HybridComputeProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates the subscription status of the product. </summary>
        public LicenseProfileSubscriptionStatus? SubscriptionStatus { get; set; }
        /// <summary> Indicates the product type of the license. </summary>
        public LicenseProfileProductType? ProductType { get; set; }
        /// <summary> The timestamp in UTC when the billing starts. </summary>
        public DateTimeOffset? BillingStartOn { get; }
        /// <summary> The timestamp in UTC when the user enrolls the feature. </summary>
        public DateTimeOffset? EnrollmentOn { get; }
        /// <summary> The timestamp in UTC when the user disenrolled the feature. </summary>
        public DateTimeOffset? DisenrollmentOn { get; }
        /// <summary> The list of product features. </summary>
        public IList<HybridComputeProductFeature> ProductFeatures { get; }
        /// <summary> The guid id of the license. </summary>
        public Guid? AssignedLicenseImmutableId { get; }
        /// <summary> The list of ESU keys. </summary>
        public IReadOnlyList<EsuKey> EsuKeys { get; }
        /// <summary> The type of the Esu servers. </summary>
        public EsuServerType? ServerType { get; }
        /// <summary> Indicates the eligibility state of Esu. </summary>
        public EsuEligibility? EsuEligibility { get; }
        /// <summary> Indicates whether there is an ESU Key currently active for the machine. </summary>
        public EsuKeyState? EsuKeyState { get; }
        /// <summary> The resource id of the license. </summary>
        public string AssignedLicense { get; set; }
        /// <summary> Specifies if this machine is licensed as part of a Software Assurance agreement. </summary>
        public bool? SoftwareAssuranceCustomer { get; set; }
    }
}
