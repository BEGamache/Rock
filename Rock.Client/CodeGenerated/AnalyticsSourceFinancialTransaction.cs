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
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for AnalyticsSourceFinancialTransaction that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AnalyticsSourceFinancialTransactionEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? AccountId { get; set; }

        /// <summary />
        public decimal Amount { get; set; }

        /// <summary />
        public int? AuthorizedCurrentPersonKey { get; set; }

        /// <summary />
        public int? AuthorizedFamilyId { get; set; }

        /// <summary />
        public int? AuthorizedPersonAliasId { get; set; }

        /// <summary />
        public int? AuthorizedPersonKey { get; set; }

        /// <summary />
        public int? BatchId { get; set; }

        /// <summary />
        public int Count { get; set; }

        /// <summary />
        public int? CreditCardTypeValueId { get; set; }

        /// <summary />
        public int? CurrencyTypeValueId { get; set; }

        /// <summary />
        public int? DaysSinceLastTransactionOfType { get; set; }

        /// <summary />
        public int? EntityId { get; set; }

        /// <summary />
        public int? EntityTypeId { get; set; }

        /// <summary />
        public int? FinancialGatewayId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public int? GivingGroupId { get; set; }

        /// <summary />
        public string GivingId { get; set; }

        /// <summary />
        public bool IsFirstTransactionOfType { get; set; }

        /// <summary />
        public bool IsScheduled { get; set; }

        /// <summary />
        public int? ProcessedByPersonAliasId { get; set; }

        /// <summary />
        public DateTime? ProcessedDateTime { get; set; }

        /// <summary />
        public int? SourceTypeValueId { get; set; }

        /// <summary />
        public string Summary { get; set; }

        /// <summary />
        public string TransactionCode { get; set; }

        /// <summary />
        public int TransactionDateKey { get; set; }

        /// <summary />
        public DateTime TransactionDateTime { get; set; }

        /// <summary />
        public int TransactionDetailId { get; set; }

        /// <summary />
        public string TransactionFrequency { get; set; }

        /// <summary />
        public int TransactionId { get; set; }

        /// <summary />
        public string TransactionKey { get; set; }

        /// <summary />
        public int TransactionTypeValueId { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source AnalyticsSourceFinancialTransaction object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AnalyticsSourceFinancialTransaction source )
        {
            this.Id = source.Id;
            this.AccountId = source.AccountId;
            this.Amount = source.Amount;
            this.AuthorizedCurrentPersonKey = source.AuthorizedCurrentPersonKey;
            this.AuthorizedFamilyId = source.AuthorizedFamilyId;
            this.AuthorizedPersonAliasId = source.AuthorizedPersonAliasId;
            this.AuthorizedPersonKey = source.AuthorizedPersonKey;
            this.BatchId = source.BatchId;
            this.Count = source.Count;
            this.CreditCardTypeValueId = source.CreditCardTypeValueId;
            this.CurrencyTypeValueId = source.CurrencyTypeValueId;
            this.DaysSinceLastTransactionOfType = source.DaysSinceLastTransactionOfType;
            this.EntityId = source.EntityId;
            this.EntityTypeId = source.EntityTypeId;
            this.FinancialGatewayId = source.FinancialGatewayId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GivingGroupId = source.GivingGroupId;
            this.GivingId = source.GivingId;
            this.IsFirstTransactionOfType = source.IsFirstTransactionOfType;
            this.IsScheduled = source.IsScheduled;
            this.ProcessedByPersonAliasId = source.ProcessedByPersonAliasId;
            this.ProcessedDateTime = source.ProcessedDateTime;
            this.SourceTypeValueId = source.SourceTypeValueId;
            this.Summary = source.Summary;
            this.TransactionCode = source.TransactionCode;
            this.TransactionDateKey = source.TransactionDateKey;
            this.TransactionDateTime = source.TransactionDateTime;
            this.TransactionDetailId = source.TransactionDetailId;
            this.TransactionFrequency = source.TransactionFrequency;
            this.TransactionId = source.TransactionId;
            this.TransactionKey = source.TransactionKey;
            this.TransactionTypeValueId = source.TransactionTypeValueId;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for AnalyticsSourceFinancialTransaction that includes all the fields that are available for GETs. Use this for GETs (use AnalyticsSourceFinancialTransactionEntity for POST/PUTs)
    /// </summary>
    public partial class AnalyticsSourceFinancialTransaction : AnalyticsSourceFinancialTransactionEntity
    {
        /// <summary />
        public AnalyticsDimFinancialAccount Account { get; set; }

        /// <summary />
        public AnalyticsDimFinancialBatch Batch { get; set; }

        /// <summary />
        public AnalyticsSourceDate TransactionDate { get; set; }

    }
}
