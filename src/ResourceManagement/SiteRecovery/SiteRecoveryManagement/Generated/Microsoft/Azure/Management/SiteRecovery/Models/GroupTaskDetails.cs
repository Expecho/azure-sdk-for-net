// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of group task details object.
    /// </summary>
    public partial class GroupTaskDetails
    {
        private IList<AsrTaskBase> _childTasks;
        
        /// <summary>
        /// Required. List of child tasks.
        /// </summary>
        public IList<AsrTaskBase> ChildTasks
        {
            get { return this._childTasks; }
            set { this._childTasks = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The task type. Overriden in derived classes.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GroupTaskDetails class.
        /// </summary>
        public GroupTaskDetails()
        {
            this.ChildTasks = new LazyList<AsrTaskBase>();
        }
        
        /// <summary>
        /// Initializes a new instance of the GroupTaskDetails class with
        /// required arguments.
        /// </summary>
        public GroupTaskDetails(string type, List<AsrTaskBase> childTasks)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (childTasks == null)
            {
                throw new ArgumentNullException("childTasks");
            }
            this.Type = type;
            this.ChildTasks = childTasks;
        }
    }
}
