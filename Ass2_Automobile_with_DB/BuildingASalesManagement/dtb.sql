USE MySaleBusiness


CREATE TABLE Category (
   CategoryId INT IDENTITY,
   CategoryName VARCHAR(15) NOT NULL,
   [Description] VARCHAR(100) NOT NULL, 
   CONSTRAINT PK_CATEGORY PRIMARY KEY (CategoryId)
)

/*==============================================================*/
/* Index: CategoryName                                          */
/*==============================================================*/
CREATE UNIQUE INDEX CategoryName ON Category (
	CategoryName
)
GO

/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
CREATE UNIQUE INDEX PrimaryKey on Category (
	CategoryId
)
GO

CREATE TABLE Member (
	MemberId INT IDENTITY,
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	[Password] VARCHAR(30) NOT NULL,
	CONSTRAINT PK_MEMBER PRIMARY KEY (MemberId)
)

/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
CREATE UNIQUE INDEX PrimaryKey on [Member] (
	MemberId
)
GO

/*==============================================================*/
/* Index: MemberEmailIdx                                        */
/*==============================================================*/
CREATE UNIQUE INDEX MemberEmailIdx on [Member] (
	Email
)
go

CREATE TABLE [Order] (
	OrderId INT IDENTITY,
	MemberId INT NOT NULL,
	OrderDate DATETIME NOT NULL,
	RequiredDate DATETIME NULL,
	ShippedDate DATETIME NULL,
	Freight MONEY NULL
	CONSTRAINT PK_ORDERS PRIMARY KEY (OrderId)
)

/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
CREATE UNIQUE INDEX PrimaryKey ON [Order] (
	OrderId
)
GO


/*==============================================================*/
/* Index: OrderMemberIdx                                        */
/*==============================================================*/
CREATE INDEX OrderMemberIdx on [Order] (
	MemberId
)
GO 

CREATE TABLE Product (
	ProductId INT IDENTITY,
	CategoryId INT NOT NULL,
	ProductName VARCHAR(40) NOT NULL,
	[Weight] VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitInStock INT NOT NULL,
	CONSTRAINT PK_PRODUCT PRIMARY KEY (ProductId)
)
/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
CREATE UNIQUE INDEX PrimaryKey on Product (
	ProductId
)
GO


/*==============================================================*/
/* Index: CategoriesProducts                                    */
/*==============================================================*/
CREATE INDEX CategoriesProducts on Product (
	CategoryId
)
GO


/*==============================================================*/
/* Index: CategoryID                                            */
/*==============================================================*/
CREATE INDEX CategoryID on Product (
	CategoryId
)
GO


/*==============================================================*/
/* Index: ProductName                                           */
/*==============================================================*/
CREATE INDEX ProductName on Product (
	ProductName
)
GO


CREATE TABLE OrderDetail (
	OrderId INT NOT NULL,
	ProductId INT NOT NULL,
	UnitPrice MONEY NOT NULL,
	Quantity INT NOT NULL,
	Discount FLOAT NOT NULL,
	CONSTRAINT PK_ORDERDETAIL PRIMARY KEY (OrderId, ProductId)
)
/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
CREATE UNIQUE INDEX PrimaryKey ON OrderDetail (
	OrderId,
	ProductId
)
GO


/*==============================================================*/
/* Index: OrderID                                               */
/*==============================================================*/
CREATE INDEX OrderID on OrderDetail (
	OrderId
)
GO

/*==============================================================*/
/* Index: "ProductsOrder Details"                               */
/*==============================================================*/
CREATE INDEX [ProductsOrder Details] on OrderDetail (
	ProductId
)
GO

ALTER TABLE [Order]
	ADD CONSTRAINT FK_ORDER_REFERENCE_MEMBER FOREIGN KEY (MemberId)
	REFERENCES Member (MemberId)
GO

ALTER TABLE OrderDetail
	ADD CONSTRAINT FK_ORDERDET_REFERENCE_ORDER FOREIGN KEY (OrderId)
	REFERENCES [Order] (OrderId)
GO

ALTER TABLE OrderDetail
	ADD CONSTRAINT FK_ORDERDET_REFERENCE_PRODUCT FOREIGN KEY (ProductId)
	REFERENCES Product (ProductId)
GO

ALTER TABLE Product
	ADD CONSTRAINT FK_PRODUCT_REFERENCE_CATEGORY FOREIGN KEY (CategoryId)
	REFERENCES Category (CategoryId)
GO

INSERT INTO Category (CategoryName, [Description])
VALUES
	('Beverages', 'Beverages description'),
	('Condiments', 'Condiments description'),
	('Confections', 'Confections description'),
	('Dairy Products', 'Dairy Prodcuts description'),
	('Grains/Cereals', 'Grains/Cereals description'),
	('Poultry', 'Poultry description'),
	('Produce', 'Produce description'),
	('Seafood', 'Produce description'),
	('Chicken', 'Chicken description')

INSERT INTO Member (Email, CompanyName, City, Country, [Password])
VALUES
	('Mem000001@fstore.com', 'FPT Software', 'Da Nang', 'Viet Nam', '12345'),
	('Mem000002@fstore.com', 'FPT Software', 'Da Nang', 'Viet Nam', '12345'),
	('Mem000003@fstore.com', 'FPT Software', 'Da Nang', 'Viet Nam', '12345'),
	('Mem000004@fstore.com', 'FPT Software', 'Da Nang', 'Viet Nam', '12345'),
	('Mem000005@fstore.com', 'FPT Software', 'Da Nang', 'Viet Nam', '12345')

INSERT INTO [Order] (MemberId, OrderDate, RequiredDate, ShippedDate, Freight)
VALUES
	(1, '2022-03-03', '2022-03-15', '2022-03-10', 30),
	(2, '2022-04-04', '2022-04-15', '2022-04-10', 40),	
	(3, '2022-05-05', '2022-05-15', '2022-05-10', 50),
	(4, '2022-06-06', '2022-06-15', '2022-06-10', 60),
	(5, '2022-07-07', '2022-07-15', '2022-07-10', 70)

INSERT INTO Product (CategoryId, ProductName, [Weight], UnitPrice, UnitInStock)
VALUES
	(1, 'Genen Shouyu', '20lb', 50, 39),
	(1, 'Alice Mutton', '30lb', 30, 17),
	(3, 'Aniseed Syrup', '44lb', 40, 13),
	(2, 'Perth Pasties', '22lb', 22, 53),
	(4, 'Carnarvon Tigers', '80lb', 21.35, 0),
	(2, 'Gula Malacca', '90lb', 25, 120),
	(7, 'Steeleye Stout', '30lb', 30, 15),
	(5, 'Chocolate', '1lb', 40, 6), 
	(6, 'Mishi Kobe Niku', '10lb', 97, 29),
	(8, 'Ikura', '22lb', 31, 31)

INSERT INTO OrderDetail (OrderId, ProductId, UnitPrice, Quantity, Discount)
VALUES
	(1, 1, 50, 10, 0.5),
	(2, 5, 21.35, 20, 0.2),
	(3, 3, 40, 50, 0.8),
	(4, 7, 20, 20, 0.3),
	(5, 6, 30, 15, 0.4)
