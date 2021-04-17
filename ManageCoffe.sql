CREATE DATABASE ManageCoffe
GO
USE ManageCoffe
GO
CREATE TABLE Account(
	UserName varchar(50) primary key not null,
	PassWord varchar(50) not null,
	NameDisplay nvarchar(50) not null,
	TypeAccount int not null
)

GO
CREATE TABLE Beverages(
	BeverID int identity primary key,
	Name nvarchar(50) not null,
	Price int not null
)
GO
CREATE TABLE BillInfor(
	IDBill int identity primary key,
	PaymentDate date default GETDATE() ,
	TotalPrice int,
)
CREATE TABLE OrderBever(
	OrderID int identity primary key,
	IDBill int not null,
	BeverID int not null,
	Amount int not null,
	foreign key (IDBill) references BillInfor(IDBill),
	foreign key (BeverID) references Beverages(BeverID)
)

INSERT Account VALUES ('Admin' ,'admin', N'Admin', 0)
INSERT Account VALUES ('Employee','123456',N'Employee',1)
INSERT Beverages VALUES(N'Bạc sỉu' , 30000)
INSERT Beverages VALUES(N'Cà phê sữa' , 30000)
INSERT Beverages VALUES(N'Cà phê đen' , 30000)
INSERT Beverages VALUES(N'Cà phê đá xay' , 50000)
INSERT Beverages VALUES(N'Cà phê lúa mạch' , 50000)
INSERT Beverages VALUES(N'Cappuccino' , 50000)
INSERT Beverages VALUES(N'Caramel Macchiato' , 50000)
INSERT Beverages VALUES(N'Bạc sỉu' , 30000)
INSERT Beverages VALUES(N'Trà sữa trân châu đường đen' , 50000)
INSERT Beverages VALUES(N'Trà sữa trân châu trắng' , 50000)
INSERT Beverages VALUES(N'Trà sữa khoai môn' , 50000)
INSERT Beverages VALUES(N'Trà sữa Matcha' , 50000)
INSERT Beverages VALUES(N'Trà sữa Matcha đậu đỏ' , 55000)
INSERT Beverages VALUES(N'Trà sữa Oreo Cake Cream' , 55000)
INSERT Beverages VALUES(N'Trà sữa Oreo Chocolate Cream' , 55000)
INSERT Beverages VALUES(N'Trà sữa truyền thống' , 45000)
INSERT Beverages VALUES(N'Trà sữa Caramel' , 55000)
INSERT Beverages VALUES(N'Trà sữa Earl Grey' , 55000)
INSERT Beverages VALUES(N'Cacao nóng' , 45000)
INSERT Beverages VALUES(N'Trà đào cam xả' , 45000)
INSERT Beverages VALUES(N'Trà đào' , 45000)
INSERT Beverages VALUES(N'Trà xoài kem cheese' , 45000)
INSERT Beverages VALUES(N'Sinh tố bơ' , 40000)
INSERT Beverages VALUES(N'Sinh tố dâu' , 40000)
INSERT Beverages VALUES(N'Sinh tố xoài' , 40000)
INSERT Beverages VALUES(N'Nước cam ép' , 30000)
INSERT Beverages VALUES(N'Nước chanh' , 30000)
INSERT Beverages VALUES(N'Nước vải' , 30000)
INSERT Beverages VALUES(N'Nước ép táo' , 30000)
INSERT Beverages VALUES(N'Nước chanh dây' , 30000)

GO
CREATE PROC SP_OrderInfor
AS
BEGIN
	SELECT Name,Price,Amount, (Price * Amount) AS TotalPrice  FROM Beverages , OrderBever WHERE Beverages.BeverID = OrderBever.BeverID AND OrderBever.IDBill = (SELECT MAX(IDBill) FROM OrderBever)
END
GO

SELECT * FROM BillInfor
SELECT * FROM OrderBever
GO
CREATE PROC SP_TotalRevenuePerDay
@Date date
AS
BEGIN
	SELECT b.Name ,b.Price,o.Amount, (Price * Amount) AS TotalPrice FROM Beverages b , OrderBever o, BillInfor bi WHERE b.BeverID = o.BeverID AND bi.IDBill = o.IDBill AND bi.PaymentDate = @Date
END
GO
CREATE PROC SP_TotalRevenuePerMonth
@Month date , @Year date
AS
BEGIN
	SELECT b.Name ,b.Price,o.Amount, (Price * Amount) AS TotalPrice FROM Beverages b , OrderBever o, BillInfor bi WHERE b.BeverID = o.BeverID AND bi.IDBill = o.IDBill AND MONTH(bi.PaymentDate) = MONTH(@Month) AND YEAR(bi.PaymentDate) = YEAR(@Year)
END
GO
CREATE PROC SP_TotalRevenuePerYear
@Year date
AS
BEGIN 
	SELECT b.Name ,b.Price,o.Amount, (Price * Amount) AS TotalPrice FROM Beverages b , OrderBever o, BillInfor bi WHERE b.BeverID = o.BeverID AND bi.IDBill = o.IDBill AND YEAR(bi.PaymentDate) = YEAR(@Year)
END

