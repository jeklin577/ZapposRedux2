CREATE PROCEDURE sproc_tblOrders_FilterByOrderNo
@OrderNo int
AS
select * from tblOrderProcessing where OrderID = @OrderNo
RETURN 0