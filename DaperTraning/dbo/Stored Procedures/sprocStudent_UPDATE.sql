CREATE PROCEDURE [dbo].[sprocStudent_UPDATE]
(
	@ID			INT,
	@Fname		NVARCHAR(32),
	@Lname		NVARCHAR(32),
	@Fathername NVARCHAR(32),
	@Mothername NVARCHAR(32),
	@Mark       NVARCHAR(32)
) AS
	BEGIN
		IF(NOT(EXISTS(SELECT * FROM [dbo].[Student] WHERE Id = @ID)))
		 BEGIN
			RAISERROR('The Student Is Not Exists, Please Refresh Your Data',0,1);
			RETURN
		 END
		BEGIN TRY
				UPDATE [dbo].[Student]
				SET 
					FirstName = @Fname,
					LastName = @Lname,
					FatherName = @Fathername,
					Mothername = @Mothername,
					Mark = @Mark
				WHERE Id = @ID
				
		END TRY
		BEGIN CATCH
			  DECLARE @ErrMsg VARCHAR(MAX)
			  SELECT @ErrMsg = ERROR_MESSAGE()
			  RAISERROR(@ErrMsg,0,1);
			  THROW
		END CATCH
	END;