// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Compute.Batch
{
    /// <summary> Options for evaluating an automatic scaling formula on an Azure Batch Pool. </summary>
    public partial class BatchPoolEvaluateAutoScaleOptions
    {
        /// <summary> Initializes a new instance of BatchPoolEvaluateAutoScaleOptions. </summary>
        /// <param name="autoScaleFormula"> The formula for the desired number of Compute Nodes in the Pool. The formula is validated and its results calculated, but it is not applied to the Pool. To apply the formula to the Pool, 'Enable automatic scaling on a Pool'. For more information about specifying this formula, see Automatically scale Compute Nodes in an Azure Batch Pool (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoScaleFormula"/> is null. </exception>
        public BatchPoolEvaluateAutoScaleOptions(string autoScaleFormula)
        {
            Argument.AssertNotNull(autoScaleFormula, nameof(autoScaleFormula));

            AutoScaleFormula = autoScaleFormula;
        }

        /// <summary> The formula for the desired number of Compute Nodes in the Pool. The formula is validated and its results calculated, but it is not applied to the Pool. To apply the formula to the Pool, 'Enable automatic scaling on a Pool'. For more information about specifying this formula, see Automatically scale Compute Nodes in an Azure Batch Pool (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling). </summary>
        public string AutoScaleFormula { get; }
    }
}
