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

using System;
using System.Linq;

using Rock.ViewModels.Utility;

namespace Rock.ViewModels.Entities
{
    /// <summary>
    /// SystemCommunication View Model
    /// </summary>
    public partial class SystemCommunicationBag : EntityBagBase
    {
        /// <summary>
        /// Gets or sets the email addresses that should be sent a BCC or blind carbon copy of an email using this template. If there is not a predetermined distribution list; this property 
        /// can remain empty.
        /// </summary>
        /// <value>
        /// A System.String representing a list of email addresses that should be sent a BCC or blind carbon copy of an email that uses this template. If there is not a predetermined
        /// distribution list this property will remain null.
        /// </value>
        public string Bcc { get; set; }

        /// <summary>
        /// Gets or sets the Body template that is used for emails that use this template.
        /// </summary>
        /// <value>
        /// A System.String representing the body template for emails that use this template.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the email addresses that should be sent a CC or carbon copy of an email using this template. If there is not a predetermined distribution list, this property
        /// can remain empty.
        /// </summary>
        /// <value>
        /// A System.String representing a list of email addresses that should be sent a CC or carbon copy of an email that uses this template. If there is not a predetermined
        /// distribution list, this property will be null.
        /// </value>
        public string Cc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CSS styles should be inlined in the message body to ensure compatibility with oldere HTML rendering engines.
        /// </summary>
        /// <value>
        ///   true if CSS style inlining is enabled; otherwise, false.
        /// </value>
        public bool CssInliningEnabled { get; set; }

        /// <summary>
        /// Gets or sets the From email address.
        /// </summary>
        /// <value>
        /// A System.String representing the from email address.
        /// </value>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets from name.
        /// </summary>
        /// <value>
        /// From name.
        /// </value>
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if this item is available for use.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if this item is available for use.
        /// </value>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the email template is part of the Rock core system/framework.
        /// </summary>
        /// <value>
        /// A System.Boolean value that is true if the EmailTemplate is part of the Rock core system/framework otherwise false.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// The internal storage for Rock.Model.CommunicationTemplate.LavaFields
        /// </summary>
        /// <value>
        /// The lava fields json
        /// </value>
        public string LavaFieldsJson { get; set; }

        /// <summary>
        /// Gets or sets the push data.
        /// </summary>
        /// <value>
        /// The push data.
        /// </value>
        public string PushData { get; set; }

        /// <summary>
        /// Gets or sets the push image file identifier.
        /// </summary>
        /// <value>
        /// The push image file identifier.
        /// </value>
        public int? PushImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// A System.String containing the notification text.
        /// </value>
        public string PushMessage { get; set; }

        /// <summary>
        /// Gets or sets the push open action.
        /// </summary>
        /// <value>
        /// The push open action.
        /// </value>
        public int? PushOpenAction { get; set; }

        /// <summary>
        /// Gets or sets the push open message.
        /// </summary>
        /// <value>
        /// The push open message.
        /// </value>
        public string PushOpenMessage { get; set; }

        /// <summary>
        /// Gets or sets the name of the sound alert to use for the notification.
        /// </summary>
        /// <value>
        /// From number.
        /// </value>
        public string PushSound { get; set; }

        /// <summary>
        /// Gets or sets the title of the notification.
        /// </summary>
        /// <value>
        /// A System.String containing the notification title.
        /// </value>
        public string PushTitle { get; set; }

        /// <summary>
        /// Gets or sets the system phone number identifier used for SMS sending.
        /// </summary>
        /// <value>
        /// The system phone number identifier used for SMS sending.
        /// </value>
        public int? SmsFromSystemPhoneNumberId { get; set; }

        /// <summary>
        /// Gets or sets the SMS message content.
        /// </summary>
        /// <value>
        /// A System.String containing the message text.
        /// </value>
        public string SMSMessage { get; set; }

        /// <summary>
        /// Gets or sets the subject of an email that uses this template.
        /// </summary>
        /// <value>
        /// A System.String representing the subject of an email that uses this template.
        /// </value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the Title of the EmailTemplate 
        /// </summary>
        /// <value>
        /// A System.String representing the Title of the EmailTemplate.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the To email addresses that emails using this template should be delivered to.  If there is not a predetermined distribution list, this property can 
        /// remain empty.
        /// </summary>
        /// <value>
        /// A System.String representing a list of email addresses that the message should be delivered to. If there is not a predetermined email list, this property will 
        /// be null.
        /// </value>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the created by person alias identifier.
        /// </summary>
        /// <value>
        /// The created by person alias identifier.
        /// </value>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the modified by person alias identifier.
        /// </summary>
        /// <value>
        /// The modified by person alias identifier.
        /// </value>
        public int? ModifiedByPersonAliasId { get; set; }

    }
}