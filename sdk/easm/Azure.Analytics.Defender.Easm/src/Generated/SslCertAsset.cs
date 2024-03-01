// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The SslCertAsset. </summary>
    public partial class SslCertAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of <see cref="SslCertAsset"/>. </summary>
        internal SslCertAsset()
        {
            SubjectCommonNames = new ChangeTrackingList<string>();
            Organizations = new ChangeTrackingList<string>();
            OrganizationalUnits = new ChangeTrackingList<string>();
            IssuerCommonNames = new ChangeTrackingList<string>();
            SubjectAlternativeNames = new ChangeTrackingList<string>();
            IssuerAlternativeNames = new ChangeTrackingList<string>();
            Sources = new ChangeTrackingList<SourceDetails>();
            SubjectLocality = new ChangeTrackingList<string>();
            SubjectState = new ChangeTrackingList<string>();
            SubjectCountry = new ChangeTrackingList<string>();
            IssuerLocality = new ChangeTrackingList<string>();
            IssuerState = new ChangeTrackingList<string>();
            IssuerCountry = new ChangeTrackingList<string>();
            SubjectOrganizations = new ChangeTrackingList<string>();
            SubjectOrganizationalUnits = new ChangeTrackingList<string>();
            IssuerOrganizations = new ChangeTrackingList<string>();
            IssuerOrganizationalUnits = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SslCertAsset"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sha1"></param>
        /// <param name="subjectCommonNames"></param>
        /// <param name="organizations"></param>
        /// <param name="organizationalUnits"></param>
        /// <param name="issuerCommonNames"></param>
        /// <param name="sigAlgName"></param>
        /// <param name="invalidAfter"></param>
        /// <param name="serialNumber"></param>
        /// <param name="subjectAlternativeNames"></param>
        /// <param name="issuerAlternativeNames"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="invalidBefore"></param>
        /// <param name="keySize"></param>
        /// <param name="keyAlgorithm"></param>
        /// <param name="subjectLocality"></param>
        /// <param name="subjectState"></param>
        /// <param name="subjectCountry"></param>
        /// <param name="issuerLocality"></param>
        /// <param name="issuerState"></param>
        /// <param name="issuerCountry"></param>
        /// <param name="subjectOrganizations"></param>
        /// <param name="subjectOrganizationalUnits"></param>
        /// <param name="issuerOrganizations"></param>
        /// <param name="issuerOrganizationalUnits"></param>
        /// <param name="version"></param>
        /// <param name="certificateAuthority"></param>
        /// <param name="selfSigned"></param>
        /// <param name="sigAlgOid"></param>
        /// <param name="recent"></param>
        /// <param name="validationType"></param>
        internal SslCertAsset(IDictionary<string, BinaryData> serializedAdditionalRawData, string sha1, IReadOnlyList<string> subjectCommonNames, IReadOnlyList<string> organizations, IReadOnlyList<string> organizationalUnits, IReadOnlyList<string> issuerCommonNames, string sigAlgName, DateTimeOffset? invalidAfter, string serialNumber, IReadOnlyList<string> subjectAlternativeNames, IReadOnlyList<string> issuerAlternativeNames, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, DateTimeOffset? invalidBefore, int? keySize, string keyAlgorithm, IReadOnlyList<string> subjectLocality, IReadOnlyList<string> subjectState, IReadOnlyList<string> subjectCountry, IReadOnlyList<string> issuerLocality, IReadOnlyList<string> issuerState, IReadOnlyList<string> issuerCountry, IReadOnlyList<string> subjectOrganizations, IReadOnlyList<string> subjectOrganizationalUnits, IReadOnlyList<string> issuerOrganizations, IReadOnlyList<string> issuerOrganizationalUnits, int? version, bool? certificateAuthority, bool? selfSigned, string sigAlgOid, bool? recent, SslCertAssetValidationType? validationType) : base(serializedAdditionalRawData)
        {
            Sha1 = sha1;
            SubjectCommonNames = subjectCommonNames;
            Organizations = organizations;
            OrganizationalUnits = organizationalUnits;
            IssuerCommonNames = issuerCommonNames;
            SigAlgName = sigAlgName;
            InvalidAfter = invalidAfter;
            SerialNumber = serialNumber;
            SubjectAlternativeNames = subjectAlternativeNames;
            IssuerAlternativeNames = issuerAlternativeNames;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            InvalidBefore = invalidBefore;
            KeySize = keySize;
            KeyAlgorithm = keyAlgorithm;
            SubjectLocality = subjectLocality;
            SubjectState = subjectState;
            SubjectCountry = subjectCountry;
            IssuerLocality = issuerLocality;
            IssuerState = issuerState;
            IssuerCountry = issuerCountry;
            SubjectOrganizations = subjectOrganizations;
            SubjectOrganizationalUnits = subjectOrganizationalUnits;
            IssuerOrganizations = issuerOrganizations;
            IssuerOrganizationalUnits = issuerOrganizationalUnits;
            Version = version;
            CertificateAuthority = certificateAuthority;
            SelfSigned = selfSigned;
            SigAlgOid = sigAlgOid;
            Recent = recent;
            ValidationType = validationType;
        }

        /// <summary> Gets the sha 1. </summary>
        public string Sha1 { get; }
        /// <summary> Gets the subject common names. </summary>
        public IReadOnlyList<string> SubjectCommonNames { get; }
        /// <summary> Gets the organizations. </summary>
        public IReadOnlyList<string> Organizations { get; }
        /// <summary> Gets the organizational units. </summary>
        public IReadOnlyList<string> OrganizationalUnits { get; }
        /// <summary> Gets the issuer common names. </summary>
        public IReadOnlyList<string> IssuerCommonNames { get; }
        /// <summary> Gets the sig alg name. </summary>
        public string SigAlgName { get; }
        /// <summary> Gets the invalid after. </summary>
        public DateTimeOffset? InvalidAfter { get; }
        /// <summary> Gets the serial number. </summary>
        public string SerialNumber { get; }
        /// <summary> Gets the subject alternative names. </summary>
        public IReadOnlyList<string> SubjectAlternativeNames { get; }
        /// <summary> Gets the issuer alternative names. </summary>
        public IReadOnlyList<string> IssuerAlternativeNames { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the invalid before. </summary>
        public DateTimeOffset? InvalidBefore { get; }
        /// <summary> Gets the key size. </summary>
        public int? KeySize { get; }
        /// <summary> Gets the key algorithm. </summary>
        public string KeyAlgorithm { get; }
        /// <summary> Gets the subject locality. </summary>
        public IReadOnlyList<string> SubjectLocality { get; }
        /// <summary> Gets the subject state. </summary>
        public IReadOnlyList<string> SubjectState { get; }
        /// <summary> Gets the subject country. </summary>
        public IReadOnlyList<string> SubjectCountry { get; }
        /// <summary> Gets the issuer locality. </summary>
        public IReadOnlyList<string> IssuerLocality { get; }
        /// <summary> Gets the issuer state. </summary>
        public IReadOnlyList<string> IssuerState { get; }
        /// <summary> Gets the issuer country. </summary>
        public IReadOnlyList<string> IssuerCountry { get; }
        /// <summary> Gets the subject organizations. </summary>
        public IReadOnlyList<string> SubjectOrganizations { get; }
        /// <summary> Gets the subject organizational units. </summary>
        public IReadOnlyList<string> SubjectOrganizationalUnits { get; }
        /// <summary> Gets the issuer organizations. </summary>
        public IReadOnlyList<string> IssuerOrganizations { get; }
        /// <summary> Gets the issuer organizational units. </summary>
        public IReadOnlyList<string> IssuerOrganizationalUnits { get; }
        /// <summary> Gets the version. </summary>
        public int? Version { get; }
        /// <summary> Gets the certificate authority. </summary>
        public bool? CertificateAuthority { get; }
        /// <summary> Gets the self signed. </summary>
        public bool? SelfSigned { get; }
        /// <summary> Gets the sig alg oid. </summary>
        public string SigAlgOid { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
        /// <summary> Gets the validation type. </summary>
        public SslCertAssetValidationType? ValidationType { get; }
    }
}
