CREATE PROCEDURE sproc_tblOrders_FilterByOrderNo
@OrderID int
AS
select * from tblOrderProcessing where OrderID = @OrderID
RETURN 0