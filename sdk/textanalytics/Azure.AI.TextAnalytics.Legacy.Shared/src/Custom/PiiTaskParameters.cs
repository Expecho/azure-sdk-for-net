﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary>
    /// PiiTaskParameters class.
    /// </summary>
    [CodeGenModel("PiiTaskParameters")]
    internal partial class PiiTaskParameters
    {
        /// <summary> (Optional) describes the PII categories to return. </summary>
        public IList<PiiEntityCategory> PiiCategories { get; set; }
    }
}
