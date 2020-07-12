CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
begin
	Set nocount on;

	select FirstName, LastName, EmailAddress,DateCreated
	from [dbo].[User]
	where Id =@Id;
end

