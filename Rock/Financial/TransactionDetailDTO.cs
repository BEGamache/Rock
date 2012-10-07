//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

using Rock.Data;

namespace Rock.Financial
{
	/// <summary>
	/// Data Transfer Object for TransactionDetail object
	/// </summary>
	public partial class TransactionDetailDto : IDto
	{

#pragma warning disable 1591
		public int? TransactionId { get; set; }
		public string Entity { get; set; }
		public string EntityId { get; set; }
		public decimal Amount { get; set; }
		public string Summary { get; set; }
		public DateTime? ModifiedDateTime { get; set; }
		public DateTime? CreatedDateTime { get; set; }
		public int? CreatedByPersonId { get; set; }
		public int? ModifiedByPersonId { get; set; }
		public int Id { get; set; }
		public Guid Guid { get; set; }
#pragma warning restore 1591

		/// <summary>
		/// Instantiates a new DTO object
		/// </summary>
		public TransactionDetailDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the entity
		/// </summary>
		/// <param name="transactionDetail"></param>
		public TransactionDetailDto ( TransactionDetail transactionDetail )
		{
			CopyFromModel( transactionDetail );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyFromModel( IEntity model )
		{
			if ( model is TransactionDetail )
			{
				var transactionDetail = (TransactionDetail)model;
				this.TransactionId = transactionDetail.TransactionId;
				this.Entity = transactionDetail.Entity;
				this.EntityId = transactionDetail.EntityId;
				this.Amount = transactionDetail.Amount;
				this.Summary = transactionDetail.Summary;
				this.ModifiedDateTime = transactionDetail.ModifiedDateTime;
				this.CreatedDateTime = transactionDetail.CreatedDateTime;
				this.CreatedByPersonId = transactionDetail.CreatedByPersonId;
				this.ModifiedByPersonId = transactionDetail.ModifiedByPersonId;
				this.Id = transactionDetail.Id;
				this.Guid = transactionDetail.Guid;
			}
		}

		/// <summary>
		/// Copies the DTO property values to the entity properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyToModel ( IEntity model )
		{
			if ( model is TransactionDetail )
			{
				var transactionDetail = (TransactionDetail)model;
				transactionDetail.TransactionId = this.TransactionId;
				transactionDetail.Entity = this.Entity;
				transactionDetail.EntityId = this.EntityId;
				transactionDetail.Amount = this.Amount;
				transactionDetail.Summary = this.Summary;
				transactionDetail.ModifiedDateTime = this.ModifiedDateTime;
				transactionDetail.CreatedDateTime = this.CreatedDateTime;
				transactionDetail.CreatedByPersonId = this.CreatedByPersonId;
				transactionDetail.ModifiedByPersonId = this.ModifiedByPersonId;
				transactionDetail.Id = this.Id;
				transactionDetail.Guid = this.Guid;
			}
		}
	}
}
