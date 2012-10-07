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

namespace Rock.Core
{
	/// <summary>
	/// Data Transfer Object for FieldType object
	/// </summary>
	public partial class FieldTypeDto : IDto
	{

#pragma warning disable 1591
		public bool IsSystem { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Assembly { get; set; }
		public string Class { get; set; }
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
		public FieldTypeDto ()
		{
		}

		/// <summary>
		/// Instantiates a new DTO object from the entity
		/// </summary>
		/// <param name="fieldType"></param>
		public FieldTypeDto ( FieldType fieldType )
		{
			CopyFromModel( fieldType );
		}

		/// <summary>
		/// Copies the model property values to the DTO properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyFromModel( IEntity model )
		{
			if ( model is FieldType )
			{
				var fieldType = (FieldType)model;
				this.IsSystem = fieldType.IsSystem;
				this.Name = fieldType.Name;
				this.Description = fieldType.Description;
				this.Assembly = fieldType.Assembly;
				this.Class = fieldType.Class;
				this.CreatedDateTime = fieldType.CreatedDateTime;
				this.ModifiedDateTime = fieldType.ModifiedDateTime;
				this.CreatedByPersonId = fieldType.CreatedByPersonId;
				this.ModifiedByPersonId = fieldType.ModifiedByPersonId;
				this.Id = fieldType.Id;
				this.Guid = fieldType.Guid;
			}
		}

		/// <summary>
		/// Copies the DTO property values to the entity properties
		/// </summary>
		/// <param name="model">The model</param>
		public void CopyToModel ( IEntity model )
		{
			if ( model is FieldType )
			{
				var fieldType = (FieldType)model;
				fieldType.IsSystem = this.IsSystem;
				fieldType.Name = this.Name;
				fieldType.Description = this.Description;
				fieldType.Assembly = this.Assembly;
				fieldType.Class = this.Class;
				fieldType.CreatedDateTime = this.CreatedDateTime;
				fieldType.ModifiedDateTime = this.ModifiedDateTime;
				fieldType.CreatedByPersonId = this.CreatedByPersonId;
				fieldType.ModifiedByPersonId = this.ModifiedByPersonId;
				fieldType.Id = this.Id;
				fieldType.Guid = this.Guid;
			}
		}
	}
}
