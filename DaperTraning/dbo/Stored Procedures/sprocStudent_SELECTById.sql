CREATE PROCEDURE [dbo].[sprocStudent_SELECTById]
(
	@ID			INT
) AS
	BEGIN
		IF(NOT(EXISTS(SELECT * FROM [dbo].[Student] WHERE Id = @ID)))
		 BEGIN
			RAISERROR('The Student Is Not Exists, Please Refresh Your Data',0,3);
			RETURN
		 END
		BEGIN TRY
				SELECT * FROM [dbo].[Student]
				WHERE Id = @ID
		END TRY
		BEGIN CATCH
			  DECLARE @ErrMsg VARCHAR(MAX)
			  SELECT @ErrMsg = ERROR_MESSAGE()
			  RAISERROR(@ErrMsg,0,3);
			  THROW
		END CATCH
	END;