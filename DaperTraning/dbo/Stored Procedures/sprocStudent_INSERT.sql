CREATE PROCEDURE [dbo].[sprocStudent_INSERT]
(
	@Fname		NVARCHAR(32),
	@Lname		NVARCHAR(32),
	@Fathername NVARCHAR(32),
	@Mothername NVARCHAR(32),
	@Mark       NVARCHAR(32)
) AS
	BEGIN
		BEGIN TRY
				INSERT INTO [dbo].[Student]
				(
					FirstName,
					LastName,
					FatherName,
					MotherName,
					Mark
				)
				VALUES
				(
					@Fname,
					@Lname,
					@Fathername,
					@MotherName,
					@Mark
				)
		END TRY
		BEGIN CATCH
			  DECLARE @ErrMsg VARCHAR(MAX)
			  SELECT @ErrMsg = ERROR_MESSAGE()
			  RAISERROR(@ErrMsg,-1,16,2);
			  THROW
		END CATCH
	END;