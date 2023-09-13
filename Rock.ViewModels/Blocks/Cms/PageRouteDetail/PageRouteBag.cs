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

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Blocks.Cms.PageRouteDetail
{
    /// <summary>
    /// 
    /// </summary>
    public class PageRouteBag : EntityBagBase
    {
        /// <summary>
        /// If true then the route will be accessible from all sites regardless if EnableExclusiveRoutes is set on the site
        /// </summary>
        public bool IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the PageRoute is part of the Rock core system/framework. This property is required.
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the Rock.Model.Page associated with the RoutePath.
        /// </summary>
        public ListItemBag Page { get; set; }

        /// <summary>
        /// Gets or sets the format of the route path. Route examples include: Page NewAccount or Checkin/Welcome. 
        /// A specific group Group/{GroupId} (i.e. Group/16). A person's history Person/{PersonId}/History (i.e. Person/12/History).
        /// This property is required.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Gets or sets the site.
        /// </summary>
        /// <value>
        /// The site.
        /// </value>
        public string Site { get; set; }
    }
}