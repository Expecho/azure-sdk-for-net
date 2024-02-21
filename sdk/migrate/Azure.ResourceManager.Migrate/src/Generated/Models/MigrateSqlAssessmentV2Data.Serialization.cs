// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Migrate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migrate
{
    public partial class MigrateSqlAssessmentV2Data : IUtf8JsonSerializable, IJsonModel<MigrateSqlAssessmentV2Data>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlAssessmentV2Data>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlAssessmentV2Data>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlAssessmentV2Data>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlAssessmentV2Data)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OSLicense))
            {
                writer.WritePropertyName("osLicense"u8);
                writer.WriteStringValue(OSLicense.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentType))
            {
                writer.WritePropertyName("environmentType"u8);
                writer.WriteStringValue(EnvironmentType.Value.ToString());
            }
            if (Optional.IsDefined(EntityUptime))
            {
                writer.WritePropertyName("entityUptime"u8);
                writer.WriteObjectValue(EntityUptime);
            }
            if (Optional.IsDefined(OptimizationLogic))
            {
                writer.WritePropertyName("optimizationLogic"u8);
                writer.WriteStringValue(OptimizationLogic.Value.ToString());
            }
            if (Optional.IsDefined(ReservedInstanceForVm))
            {
                writer.WritePropertyName("reservedInstanceForVm"u8);
                writer.WriteStringValue(ReservedInstanceForVm.Value.ToString());
            }
            if (Optional.IsDefined(AzureOfferCodeForVm))
            {
                writer.WritePropertyName("azureOfferCodeForVm"u8);
                writer.WriteStringValue(AzureOfferCodeForVm.Value.ToString());
            }
            if (Optional.IsDefined(EASubscriptionId))
            {
                writer.WritePropertyName("eaSubscriptionId"u8);
                writer.WriteStringValue(EASubscriptionId);
            }
            if (Optional.IsDefined(AzureSqlManagedInstanceSettings))
            {
                writer.WritePropertyName("azureSqlManagedInstanceSettings"u8);
                writer.WriteObjectValue(AzureSqlManagedInstanceSettings);
            }
            if (Optional.IsDefined(AzureSqlDatabaseSettings))
            {
                writer.WritePropertyName("azureSqlDatabaseSettings"u8);
                writer.WriteObjectValue(AzureSqlDatabaseSettings);
            }
            if (Optional.IsDefined(AzureSqlVmSettings))
            {
                writer.WritePropertyName("azureSqlVmSettings"u8);
                writer.WriteObjectValue(AzureSqlVmSettings);
            }
            if (Optional.IsDefined(MultiSubnetIntent))
            {
                writer.WritePropertyName("multiSubnetIntent"u8);
                writer.WriteStringValue(MultiSubnetIntent.Value.ToString());
            }
            if (Optional.IsDefined(AsyncCommitModeIntent))
            {
                writer.WritePropertyName("asyncCommitModeIntent"u8);
                writer.WriteStringValue(AsyncCommitModeIntent.Value.ToString());
            }
            if (Optional.IsDefined(IsInternetAccessAvailable))
            {
                writer.WritePropertyName("isInternetAccessAvailable"u8);
                writer.WriteBooleanValue(IsInternetAccessAvailable.Value);
            }
            if (Optional.IsDefined(DisasterRecoveryLocation))
            {
                writer.WritePropertyName("disasterRecoveryLocation"u8);
                writer.WriteStringValue(DisasterRecoveryLocation.Value);
            }
            if (Optional.IsDefined(EnableHadrAssessment))
            {
                writer.WritePropertyName("enableHadrAssessment"u8);
                writer.WriteBooleanValue(EnableHadrAssessment.Value);
            }
            if (Optional.IsDefined(AzureSecurityOfferingType))
            {
                writer.WritePropertyName("azureSecurityOfferingType"u8);
                writer.WriteStringValue(AzureSecurityOfferingType.Value.ToString());
            }
            if (Optional.IsDefined(ReservedInstance))
            {
                writer.WritePropertyName("reservedInstance"u8);
                writer.WriteStringValue(ReservedInstance.Value.ToString());
            }
            if (Optional.IsDefined(SqlServerLicense))
            {
                writer.WritePropertyName("sqlServerLicense"u8);
                writer.WriteStringValue(SqlServerLicense.Value.ToString());
            }
            if (Optional.IsDefined(GroupType))
            {
                writer.WritePropertyName("groupType"u8);
                writer.WriteStringValue(GroupType.Value.ToString());
            }
            if (Optional.IsDefined(AssessmentType))
            {
                writer.WritePropertyName("assessmentType"u8);
                writer.WriteStringValue(AssessmentType.Value.ToString());
            }
            if (Optional.IsDefined(AzureLocation))
            {
                writer.WritePropertyName("azureLocation"u8);
                writer.WriteStringValue(AzureLocation.Value);
            }
            if (Optional.IsDefined(AzureOfferCode))
            {
                writer.WritePropertyName("azureOfferCode"u8);
                writer.WriteStringValue(AzureOfferCode.Value.ToString());
            }
            if (Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency.Value.ToString());
            }
            if (Optional.IsDefined(ScalingFactor))
            {
                writer.WritePropertyName("scalingFactor"u8);
                writer.WriteNumberValue(ScalingFactor.Value);
            }
            if (Optional.IsDefined(Percentile))
            {
                writer.WritePropertyName("percentile"u8);
                writer.WriteStringValue(Percentile.Value.ToString());
            }
            if (Optional.IsDefined(TimeRange))
            {
                writer.WritePropertyName("timeRange"u8);
                writer.WriteStringValue(TimeRange.Value.ToString());
            }
            if (Optional.IsDefined(PerfDataStartOn))
            {
                writer.WritePropertyName("perfDataStartTime"u8);
                writer.WriteStringValue(PerfDataStartOn.Value, "O");
            }
            if (Optional.IsDefined(PerfDataEndOn))
            {
                writer.WritePropertyName("perfDataEndTime"u8);
                writer.WriteStringValue(PerfDataEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Stage))
            {
                writer.WritePropertyName("stage"u8);
                writer.WriteStringValue(Stage.Value.ToString());
            }
            if (Optional.IsDefined(DiscountPercentage))
            {
                writer.WritePropertyName("discountPercentage"u8);
                writer.WriteNumberValue(DiscountPercentage.Value);
            }
            if (Optional.IsDefined(SizingCriterion))
            {
                writer.WritePropertyName("sizingCriterion"u8);
                writer.WriteStringValue(SizingCriterion.Value.ToString());
            }
            if (Optional.IsDefined(ConfidenceRatingInPercentage))
            {
                writer.WritePropertyName("confidenceRatingInPercentage"u8);
                writer.WriteNumberValue(ConfidenceRatingInPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PricesQueriedOn))
            {
                writer.WritePropertyName("pricesTimestamp"u8);
                writer.WriteStringValue(PricesQueriedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTimestamp"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedTimestamp"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteStringValue(SchemaVersion);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MigrateSqlAssessmentV2Data IJsonModel<MigrateSqlAssessmentV2Data>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlAssessmentV2Data>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlAssessmentV2Data)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlAssessmentV2Data(document.RootElement, options);
        }

        internal static MigrateSqlAssessmentV2Data DeserializeMigrateSqlAssessmentV2Data(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MigrateProvisioningState> provisioningState = default;
            Optional<MigrateOSLicense> osLicense = default;
            Optional<AssessmentEnvironmentType> environmentType = default;
            Optional<EntityUptime> entityUptime = default;
            Optional<SqlOptimizationLogic> optimizationLogic = default;
            Optional<AzureReservedInstance> reservedInstanceForVm = default;
            Optional<AzureOfferCode> azureOfferCodeForVm = default;
            Optional<string> eaSubscriptionId = default;
            Optional<SqlMISettings> azureSqlManagedInstanceSettings = default;
            Optional<SqlDBSettings> azureSqlDatabaseSettings = default;
            Optional<SqlVmSettings> azureSqlVmSettings = default;
            Optional<MultiSubnetIntent> multiSubnetIntent = default;
            Optional<AsyncCommitModeIntent> asyncCommitModeIntent = default;
            Optional<bool> isInternetAccessAvailable = default;
            Optional<AzureLocation> disasterRecoveryLocation = default;
            Optional<bool> enableHadrAssessment = default;
            Optional<AzureSecurityOfferingType> azureSecurityOfferingType = default;
            Optional<AzureReservedInstance> reservedInstance = default;
            Optional<SqlServerLicense> sqlServerLicense = default;
            Optional<MigrateGroupType> groupType = default;
            Optional<AssessmentType> assessmentType = default;
            Optional<AzureLocation> azureLocation = default;
            Optional<AzureOfferCode> azureOfferCode = default;
            Optional<AzureCurrency> currency = default;
            Optional<double> scalingFactor = default;
            Optional<PercentileOfUtilization> percentile = default;
            Optional<AssessmentTimeRange> timeRange = default;
            Optional<DateTimeOffset> perfDataStartTime = default;
            Optional<DateTimeOffset> perfDataEndTime = default;
            Optional<AssessmentStage> stage = default;
            Optional<double> discountPercentage = default;
            Optional<AssessmentSizingCriterion> sizingCriterion = default;
            Optional<double> confidenceRatingInPercentage = default;
            Optional<DateTimeOffset> pricesTimestamp = default;
            Optional<DateTimeOffset> createdTimestamp = default;
            Optional<DateTimeOffset> updatedTimestamp = default;
            Optional<AssessmentStatus> status = default;
            Optional<string> schemaVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MigrateProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osLicense"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osLicense = new MigrateOSLicense(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("environmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentType = new AssessmentEnvironmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("entityUptime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            entityUptime = EntityUptime.DeserializeEntityUptime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("optimizationLogic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizationLogic = new SqlOptimizationLogic(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reservedInstanceForVm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedInstanceForVm = new AzureReservedInstance(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureOfferCodeForVm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureOfferCodeForVm = new AzureOfferCode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eaSubscriptionId"u8))
                        {
                            eaSubscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureSqlManagedInstanceSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureSqlManagedInstanceSettings = SqlMISettings.DeserializeSqlMISettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureSqlDatabaseSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureSqlDatabaseSettings = SqlDBSettings.DeserializeSqlDBSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureSqlVmSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureSqlVmSettings = SqlVmSettings.DeserializeSqlVmSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("multiSubnetIntent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multiSubnetIntent = new MultiSubnetIntent(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("asyncCommitModeIntent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asyncCommitModeIntent = new AsyncCommitModeIntent(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isInternetAccessAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isInternetAccessAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disasterRecoveryLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disasterRecoveryLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableHadrAssessment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHadrAssessment = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("azureSecurityOfferingType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureSecurityOfferingType = new AzureSecurityOfferingType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reservedInstance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedInstance = new AzureReservedInstance(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sqlServerLicense"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sqlServerLicense = new SqlServerLicense(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("groupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            groupType = new MigrateGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("assessmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentType = new AssessmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureOfferCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureOfferCode = new AzureOfferCode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currency = new AzureCurrency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scalingFactor"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scalingFactor = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("percentile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentile = new PercentileOfUtilization(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeRange"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeRange = new AssessmentTimeRange(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perfDataStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perfDataStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("perfDataEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perfDataEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("stage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stage = new AssessmentStage(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("discountPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            discountPercentage = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("sizingCriterion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sizingCriterion = new AssessmentSizingCriterion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("confidenceRatingInPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceRatingInPercentage = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("pricesTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pricesTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new AssessmentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schemaVersion"u8))
                        {
                            schemaVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlAssessmentV2Data(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(osLicense), Optional.ToNullable(environmentType), entityUptime.Value, Optional.ToNullable(optimizationLogic), Optional.ToNullable(reservedInstanceForVm), Optional.ToNullable(azureOfferCodeForVm), eaSubscriptionId.Value, azureSqlManagedInstanceSettings.Value, azureSqlDatabaseSettings.Value, azureSqlVmSettings.Value, Optional.ToNullable(multiSubnetIntent), Optional.ToNullable(asyncCommitModeIntent), Optional.ToNullable(isInternetAccessAvailable), Optional.ToNullable(disasterRecoveryLocation), Optional.ToNullable(enableHadrAssessment), Optional.ToNullable(azureSecurityOfferingType), Optional.ToNullable(reservedInstance), Optional.ToNullable(sqlServerLicense), Optional.ToNullable(groupType), Optional.ToNullable(assessmentType), Optional.ToNullable(azureLocation), Optional.ToNullable(azureOfferCode), Optional.ToNullable(currency), Optional.ToNullable(scalingFactor), Optional.ToNullable(percentile), Optional.ToNullable(timeRange), Optional.ToNullable(perfDataStartTime), Optional.ToNullable(perfDataEndTime), Optional.ToNullable(stage), Optional.ToNullable(discountPercentage), Optional.ToNullable(sizingCriterion), Optional.ToNullable(confidenceRatingInPercentage), Optional.ToNullable(pricesTimestamp), Optional.ToNullable(createdTimestamp), Optional.ToNullable(updatedTimestamp), Optional.ToNullable(status), schemaVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateSqlAssessmentV2Data>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlAssessmentV2Data>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlAssessmentV2Data)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlAssessmentV2Data IPersistableModel<MigrateSqlAssessmentV2Data>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlAssessmentV2Data>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlAssessmentV2Data(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlAssessmentV2Data)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlAssessmentV2Data>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
