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

namespace Rock.Crm
{
	/// <summary>
	/// Data Transfer Object for EmailTemplate object
	/// </summary>
	public partial class EmailTemplateDto : IDto
	{

#pragma warning disable 1591
		public bool IsSystem { get; set; }
		public int? PersonId { get; set; }
		public string Category { get; set; }
		public string Title { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public string Cc { get; set; }
		public string Bcc { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime? CreatedDateTime { get; set; }
		public DateTime? ModifiedDateTime { get; set; }
		public int? CreatedByPersonId { get; set; }
		public int? ModifiedByPersonId { get; set; }
		public int Id { get; set; }
		public Guid Guid { get; set; }
#pragma warning restore 1591

		/// <summary>
		/// Instantiates a new DTO object
		/// </summary>
		public EmailTemplateDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the entity
		/// </summary>
		/// <param name="emailTemplate"></param>
		public EmailTemplateDto ( EmailTemplate emailTemplate )
		{
			CopyFromModel( emailTemplate );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyFromModel( IEntity model )
		{
			if ( model is EmailTemplate )
			{
				var emailTemplate = (EmailTemplate)model;
				this.IsSystem = emailTemplate.IsSystem;
				this.PersonId = emailTemplate.PersonId;
				this.Category = emailTemplate.Category;
				this.Title = emailTemplate.Title;
				this.From = emailTemplate.From;
				this.To = emailTemplate.To;
				this.Cc = emailTemplate.Cc;
				this.Bcc = emailTemplate.Bcc;
				this.Subject = emailTemplate.Subject;
				this.Body = emailTemplate.Body;
				this.CreatedDateTime = emailTemplate.CreatedDateTime;
				this.ModifiedDateTime = emailTemplate.ModifiedDateTime;
				this.CreatedByPersonId = emailTemplate.CreatedByPersonId;
				this.ModifiedByPersonId = emailTemplate.ModifiedByPersonId;
				this.Id = emailTemplate.Id;
				this.Guid = emailTemplate.Guid;
			}
		}

		/// <summary>
		/// Copies the DTO property values to the entity properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyToModel ( IEntity model )
		{
			if ( model is EmailTemplate )
			{
				var emailTemplate = (EmailTemplate)model;
				emailTemplate.IsSystem = this.IsSystem;
				emailTemplate.PersonId = this.PersonId;
				emailTemplate.Category = this.Category;
				emailTemplate.Title = this.Title;
				emailTemplate.From = this.From;
				emailTemplate.To = this.To;
				emailTemplate.Cc = this.Cc;
				emailTemplate.Bcc = this.Bcc;
				emailTemplate.Subject = this.Subject;
				emailTemplate.Body = this.Body;
				emailTemplate.CreatedDateTime = this.CreatedDateTime;
				emailTemplate.ModifiedDateTime = this.ModifiedDateTime;
				emailTemplate.CreatedByPersonId = this.CreatedByPersonId;
				emailTemplate.ModifiedByPersonId = this.ModifiedByPersonId;
				emailTemplate.Id = this.Id;
				emailTemplate.Guid = this.Guid;
			}
		}
	}
}
