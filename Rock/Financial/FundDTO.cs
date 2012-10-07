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
	/// Data Transfer Object for Fund object
	/// </summary>
	public partial class FundDto : IDto
	{

#pragma warning disable 1591
		public string Name { get; set; }
		public string PublicName { get; set; }
		public string Description { get; set; }
		public int? ParentFundId { get; set; }
		public bool IsTaxDeductible { get; set; }
		public int Order { get; set; }
		public bool IsActive { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public bool IsPledgable { get; set; }
		public string GlCode { get; set; }
		public int? FundTypeId { get; set; }
		public string Entity { get; set; }
		public int? EntityId { get; set; }
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
		public FundDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the entity
		/// </summary>
		/// <param name="fund"></param>
		public FundDto ( Fund fund )
		{
			CopyFromModel( fund );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyFromModel( IEntity model )
		{
			if ( model is Fund )
			{
				var fund = (Fund)model;
				this.Name = fund.Name;
				this.PublicName = fund.PublicName;
				this.Description = fund.Description;
				this.ParentFundId = fund.ParentFundId;
				this.IsTaxDeductible = fund.IsTaxDeductible;
				this.Order = fund.Order;
				this.IsActive = fund.IsActive;
				this.StartDate = fund.StartDate;
				this.EndDate = fund.EndDate;
				this.IsPledgable = fund.IsPledgable;
				this.GlCode = fund.GlCode;
				this.FundTypeId = fund.FundTypeId;
				this.Entity = fund.Entity;
				this.EntityId = fund.EntityId;
				this.ModifiedDateTime = fund.ModifiedDateTime;
				this.CreatedDateTime = fund.CreatedDateTime;
				this.CreatedByPersonId = fund.CreatedByPersonId;
				this.ModifiedByPersonId = fund.ModifiedByPersonId;
				this.Id = fund.Id;
				this.Guid = fund.Guid;
			}
		}

		/// <summary>
		/// Copies the DTO property values to the entity properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyToModel ( IEntity model )
		{
			if ( model is Fund )
			{
				var fund = (Fund)model;
				fund.Name = this.Name;
				fund.PublicName = this.PublicName;
				fund.Description = this.Description;
				fund.ParentFundId = this.ParentFundId;
				fund.IsTaxDeductible = this.IsTaxDeductible;
				fund.Order = this.Order;
				fund.IsActive = this.IsActive;
				fund.StartDate = this.StartDate;
				fund.EndDate = this.EndDate;
				fund.IsPledgable = this.IsPledgable;
				fund.GlCode = this.GlCode;
				fund.FundTypeId = this.FundTypeId;
				fund.Entity = this.Entity;
				fund.EntityId = this.EntityId;
				fund.ModifiedDateTime = this.ModifiedDateTime;
				fund.CreatedDateTime = this.CreatedDateTime;
				fund.CreatedByPersonId = this.CreatedByPersonId;
				fund.ModifiedByPersonId = this.ModifiedByPersonId;
				fund.Id = this.Id;
				fund.Guid = this.Guid;
			}
		}
	}
}
