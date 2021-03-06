/* Code Generate 'AddEntityAttribute(...)' for migrations. 
This will list all of the attributes order by entity type and order 
Just pick the top few that you need for your migration depending
*/

begin

declare
@crlf varchar(2) = char(13) + char(10),
@entityTypeNameSearch nvarchar(max) = '%Business%'; -- < Change this 


SELECT 
        '            RockMigrationHelper.AddEntityAttribute("'+    
		[e].name + '","' +
        CONVERT(nvarchar(50), ft.Guid)+ '","' + 
		a.EntityTypeQualifierColumn + '","' +
		a.EntityTypeQualifierValue + '","' +
		a.Name + '","","' +
		a.Description + '",' +
		CONVERT(varchar(5), a.[order]) + ',"' +
		a.DefaultValue + '","' +
        CONVERT(nvarchar(50), a.Guid)+ '");' + @crlf
  FROM [Attribute] [a]
  inner join [EntityType] [e] on [e].Id = [a].EntityTypeId
  inner join [FieldType] [ft] on [ft].Id = [a].FieldTypeId
  where e.Name like @entityTypeNameSearch
order by [e].[name], [a].[Order] 


    -- attributes values
	--    public void AddAttributeValue( string attributeGuid, int entityId, string value, string guid )

    SELECT 
        '            RockMigrationHelper.AddAttributeValue("'+     
        CONVERT(nvarchar(50), a.Guid)+
		'",0,@"'+ 
        ISNULL(av.Value,'') + '","'+ 
        CONVERT(nvarchar(50), a.Guid)+ '"); // '+ a.[Name] + 
        @crlf
    from [AttributeValue] [av]
    join Attribute a on a.id = av.AttributeId
	inner join [EntityType] [e] on [e].Id = [a].EntityTypeId
	inner join [FieldType] [ft] on [ft].Id = [a].FieldTypeId
    where e.[Name] like @entityTypeNameSearch
    order by [e].[name], [a].[Order] 

SELECT 
        '            RockMigrationHelper.DeleteAttribute("' +    
        CONVERT(nvarchar(50), a.Guid)+ '");    // ' + 
		[e].name + ': ' +
		a.Name + @crlf
  FROM [Attribute] [a]
  inner join [EntityType] [e] on [e].Id = [a].EntityTypeId
  inner join [FieldType] [ft] on [ft].Id = [a].FieldTypeId
  where e.Name like @entityTypeNameSearch
order by [e].[name], [a].[Order] 



end