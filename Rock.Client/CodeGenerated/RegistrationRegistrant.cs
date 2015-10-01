//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for RegistrationRegistrant that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class RegistrationRegistrantEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public decimal Cost { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public int? GroupMemberId { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId and ModifiedDateTime properties are being set manually and should not be overwritten with current time/user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public int? PersonAliasId { get; set; }

        /// <summary />
        public int RegistrationId { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source RegistrationRegistrant object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( RegistrationRegistrant source )
        {
            this.Id = source.Id;
            this.Cost = source.Cost;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GroupMemberId = source.GroupMemberId;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.PersonAliasId = source.PersonAliasId;
            this.RegistrationId = source.RegistrationId;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for RegistrationRegistrant that includes all the fields that are available for GETs. Use this for GETs (use RegistrationRegistrantEntity for POST/PUTs)
    /// </summary>
    public partial class RegistrationRegistrant : RegistrationRegistrantEntity
    {
        /// <summary />
        public ICollection<RegistrationRegistrantFee> Fees { get; set; }

        /// <summary />
        public PersonAlias PersonAlias { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
