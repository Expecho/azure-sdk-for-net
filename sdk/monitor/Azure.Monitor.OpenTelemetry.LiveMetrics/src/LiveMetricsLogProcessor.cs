﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Monitor.OpenTelemetry.LiveMetrics.Internals;
using Azure.Monitor.OpenTelemetry.LiveMetrics.Internals.DataCollection;
using OpenTelemetry;
using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics
{
    internal class LiveMetricsLogProcessor : BaseProcessor<LogRecord>
    {
        private bool _disposed;
        private LiveMetricsResource? _resource;
        private readonly Manager _manager;

        internal LiveMetricsResource? LiveMetricsResource => _resource ??= ParentProvider?.GetResource().CreateAzureMonitorResource();

        public LiveMetricsLogProcessor(Manager manager)
        {
            _manager = manager;
        }

        public override void OnEnd(LogRecord data)
        {
            // Check if live metrics is enabled.
            if (!_manager.ShouldCollect())
            {
                return;
            }

            // Resource is not available at initialization and must be set later.
            if (_manager.LiveMetricsResource == null && LiveMetricsResource != null)
            {
                _manager.LiveMetricsResource = LiveMetricsResource;
            }

            if (data.Exception is null)
            {
                AddLogDocument(data);
            }
            else
            {
                AddExceptionDocument(data.Exception);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    try
                    {
                        _manager.Dispose();
                    }
                    catch (System.Exception)
                    {
                    }
                }

                _disposed = true;
            }

            base.Dispose(disposing);
        }

        private void AddLogDocument(LogRecord logRecord)
        {
            var logDocument = DocumentHelper.ConvertToTrace(logRecord);
            _manager._documentBuffer.WriteDocument(logDocument);
        }

        private void AddExceptionDocument(Exception exception)
        {
            var exceptionDocument = DocumentHelper.CreateException(exceptionType: exception.GetType().Name, exceptionMessage: exception.Message);
            _manager._documentBuffer.WriteDocument(exceptionDocument);
        }
    }
}
