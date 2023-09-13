//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
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

import { PublicAttributeBag } from "@Obsidian/ViewModels/Utility/publicAttributeBag";

/** WorkflowActionFormAttribute View Model */
export type WorkflowActionFormAttributeBag = {
    /** Gets or sets the action form section identifier. */
    actionFormSectionId?: number | null;

    /** Gets or sets the attribute identifier. */
    attributeId: number;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets the size of the column. */
    columnSize?: number | null;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets the field visibility rules json. */
    fieldVisibilityRulesJSON?: string | null;

    /** Gets or sets a value indicating whether [hide label]. */
    hideLabel: boolean;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets a value indicating whether [is read only]. */
    isReadOnly: boolean;

    /** Gets or sets a value indicating whether [is required]. */
    isRequired: boolean;

    /** Gets or sets a value indicating whether [is visible]. */
    isVisible: boolean;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the order. */
    order: number;

    /** Gets or sets the post HTML. */
    postHtml?: string | null;

    /** Gets or sets the PreHTML. */
    preHtml?: string | null;

    /** Gets or sets the header. */
    workflowActionFormId: number;
};