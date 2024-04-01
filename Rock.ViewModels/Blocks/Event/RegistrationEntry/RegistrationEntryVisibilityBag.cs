﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

using System;
using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Blocks.Event.RegistrationEntry
{
    /// <summary>
    /// RegistrationEntryBlockVisibilityViewModel
    /// </summary>
    public sealed class RegistrationEntryVisibilityBag
    {
        /// <summary>
        /// Gets or sets the compared to registration template form field unique identifier.
        /// </summary>
        /// <value>
        /// The compared to registration template form field unique identifier.
        /// </value>
        public Guid ComparedToRegistrationTemplateFormFieldGuid { get; set; }

        /// <summary>
        /// Gets or sets the comparison value for this field.
        /// </summary>
        /// <value>The comparison value for this field.</value>
        public PublicComparisonValueBag ComparisonValue { get; set; }
    }
}