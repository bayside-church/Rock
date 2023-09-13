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

/** Communication View Model */
export type CommunicationBag = {
    /** Gets or sets a JSON string containing any additional merge fields for the Communication. */
    additionalMergeFieldsJson?: string | null;

    /** Gets or sets the attributes. */
    attributes?: Record<string, PublicAttributeBag> | null;

    /** Gets or sets the attribute values. */
    attributeValues?: Record<string, string> | null;

    /** Gets or sets a comma separated list of BCC'ed email addresses. */
    bCCEmails?: string | null;

    /** Gets or sets a comma separated list of CC'ed email addresses. */
    cCEmails?: string | null;

    /** Gets or sets the Rock.Model.CommunicationTemplate that was used to compose this communication */
    communicationTemplateId?: number | null;

    /** Gets or sets the communication type value identifier. */
    communicationType: number;

    /** Gets or sets the created by person alias identifier. */
    createdByPersonAliasId?: number | null;

    /** Gets or sets the created date time. */
    createdDateTime?: string | null;

    /** Gets or sets a comma-delimited list of enabled LavaCommands */
    enabledLavaCommands?: string | null;

    /**
     * Option to prevent communications from being sent to people with the same email/SMS addresses.
     * This will mean two people who share an address will not receive a personalized communication, only one of them will.
     */
    excludeDuplicateRecipientAddress: boolean;

    /** Gets or sets from email address. */
    fromEmail?: string | null;

    /** Gets or sets from name. */
    fromName?: string | null;

    /**
     * Gets or sets the future send date for the communication. This allows a user to schedule when a communication is sent 
     * and the communication will not be sent until that date and time.
     */
    futureSendDateTime?: string | null;

    /** Gets or sets the identifier key of this entity. */
    idKey?: string | null;

    /** Gets or sets the is bulk communication. */
    isBulkCommunication: boolean;

    /** Gets or sets the list that email is being sent to. */
    listGroupId?: number | null;

    /** Gets or sets the message. */
    message?: string | null;

    /** Gets or sets the message meta data. */
    messageMetaData?: string | null;

    /** Gets or sets the modified by person alias identifier. */
    modifiedByPersonAliasId?: number | null;

    /** Gets or sets the modified date time. */
    modifiedDateTime?: string | null;

    /** Gets or sets the name of the Communication */
    name?: string | null;

    /** Gets or sets the push data. */
    pushData?: string | null;

    /** Gets or sets the push image file identifier. */
    pushImageBinaryFileId?: number | null;

    /** Gets or sets the message. */
    pushMessage?: string | null;

    /** Gets or sets the push open action. */
    pushOpenAction?: number | null;

    /** Gets or sets the push open message. */
    pushOpenMessage?: string | null;

    /** Gets or sets push sound. */
    pushSound?: string | null;

    /** Gets or sets the push notification title. */
    pushTitle?: string | null;

    /** Gets or sets the reply to email address. */
    replyToEmail?: string | null;

    /** Gets or sets the date and time stamp of when the Communication was reviewed. */
    reviewedDateTime?: string | null;

    /** Gets or sets the note that was entered by the reviewer. */
    reviewerNote?: string | null;

    /** Gets or sets the reviewer person alias identifier. */
    reviewerPersonAliasId?: number | null;

    /** Gets or sets if communication is targeted to people in all selected segments or any selected segments. */
    segmentCriteria: number;

    /** Gets or sets the segments that list is being filtered to (comma-delimited list of dataview guids). */
    segments?: string | null;

    /** Gets or sets the datetime that communication was sent. This also indicates that communication shouldn't attempt to send again. */
    sendDateTime?: string | null;

    /** Gets or sets the sender Rock.Model.PersonAlias identifier. */
    senderPersonAliasId?: number | null;

    /** Gets or sets the system phone number identifier used for SMS sending. */
    smsFromSystemPhoneNumberId?: number | null;

    /** Gets or sets the message. */
    sMSMessage?: string | null;

    /** Gets or sets the status of the Communication. */
    status: number;

    /** Gets or sets the name of the Communication */
    subject?: string | null;

    /** Gets or sets the Rock.Model.Communication.SystemCommunication that this communication is associated with. */
    systemCommunicationId?: number | null;

    /** Gets or sets the URL from where this communication was created (grid) */
    urlReferrer?: string | null;
};