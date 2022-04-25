// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The Pagination. </summary>
    internal partial class Pagination
    {
        /// <summary> Initializes a new instance of Pagination. </summary>
        internal Pagination()
        {
        }

        /// <summary> Initializes a new instance of Pagination. </summary>
        /// <param name="nextLink"></param>
        internal Pagination(string nextLink)
        {
            NextLink = nextLink;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
