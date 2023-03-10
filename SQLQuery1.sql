USE [p2666656]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCusID]
		@CustomerID = 3834864

SELECT	@return_value as 'Return Value'

GO
