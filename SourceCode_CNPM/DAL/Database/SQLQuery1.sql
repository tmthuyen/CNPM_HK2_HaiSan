use haisan

create table Category(
	CategoryID char(4) not null primary key,
	CategoryName nvarchar(20) not null
)
Create table Supplier(
	SupplierID char(6) not null primary key,
	Suppliername nvarchar(30) NOT NULL,
	phone varchar(12) not null,
	SupplierAddress nvarchar(50) not null,
	Email varchar(30)
)

create table Import(
	ImportID char(6) NOT NULL primary key,
	SupplierID char(6) not null,
	ImportDate  datetime DEFAULT GETDATE() not null,
	TotalCost money not null,
	FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID) 
)


create table Product(
	ProductID char(4) Not null primary key,
	SupplierID char(6) not null,
	CategoryID char(4) not null,
	ProductName nvarchar(50) not null,
	PurchasePrice money not null,
	RetailPrice money not null,
	CreatedAt datetime DEFAULT GETDATE() not null,
	Remaining Decimal(10,3) not null,
	Expire DATE NOT NULL,
	Unit varchar(10) not null
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID), 
	FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID) 
)
create table ImportDetail(
	ProductID char(4) Not null primary key,
	ImportID char(6) NOT NULL,
	Quantity decimal(10,3) not null,
	PurchasePrice money not null,
	FOREIGN KEY (ImportID) REFERENCES Import(ImportID),
	foreign key (ProductID) REferences Productt(ProductID)
)

create table promotion(
	PromotionID char(10) primary key,
	PromotionName nvarchar(50) NOT NULL,
	ReleaseDate DATE NOT NULL,
	ExpireDate DATE NOT NULL,
	Restriction char(3) NOT NULL,
	DailyTime TIME,
	UsePoints int
)
--children of promotion
create table Voucher(
	PromotionID char(10) not null,
	ApplyAmount Money not null,
	MaxApply money not null,
	DiscountValue DECIMAL(10,2) not null,
	isCash bit not null,
	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID)
)
create table SpecificDiscounts(
	PromotionID char(10) not null primary key,
	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID)
)

create table DiscountDetails(
	PromotionID char(10) not null,
	ProductID char(4) not null,
	DiscountValue DECIMAL(10,2) not null,
	isCash bit not null,
	FOREIGN KEY (PromotionID) REFERENCES SpecificDiscounts(PromotionID),
	Foreign key (ProductID) REFERENCES Productt(ProductID)
)

create table Combo(
	PromotionID char(10) not null primary key,
	ComboAmount money not null
	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID)
)

create table ComboDetails(
	PromotionID char(10) not null primary key,
	ProductID char(4) not null,
	Quantity DECIMAL(5,3) not null,
	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID),
	Foreign key (ProductID) REFERENCES Productt(ProductID)
)

create table BuyGetGroup(
	GroupID char(4) NOT NULL primary key,
	ProductID char(4) not null,
	Quantity decimal(5,3) not null,
	Foreign key (ProductID) REFERENCES Productt(ProductID)
)

create table BuyNGetN(
	PromotionID char(10) NOT NULL primary key,
	BuyGroup char(4) not null,
	GetGroup char(4) not null,
	FOREIGN KEY (BuyGroup) REFERENCES BuyGetGroup(GroupID),
	FOREIGN KEY (GetGroup) REFERENCES BuyGetGroup(GroupID),
	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID),
)
create table ComboForCategory(
	PromotionID char(10) NOT NULL primary key,
	CategoryID char(4) not null,
	Quantity decimal(5,3) not null,
	DiscountValue Money not null,

	FOREIGN KEY (PromotionID) REFERENCES Promotion(PromotionID),
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID), -- Assuming a Category table exists
)

---
create table Employee(
	EmployeeID char(6) not null primary key,
	EmployeeName nvarchar(30) not null,
	Phone varchar(12) not null,
	Gender nvarchar(3) not null,
	EmployeeAddress nvarchar(50) not null,
	EmployeeStatus nvarchar(10) not null,
	Email varchar(20),
	PortraitLink varchar(30),
	DOB DATE NOT NULL,
	EmployeePassword varchar(15) not null
)
create table Customers(
	CustomerID char(12) not null primary key,
	Fullname nvarchar(30) ,
	Phone varchar(12),
	LoyaltyPoint int not null

) -- Replace FK_Productt_Supplier with the actual constraint name
create table Orders(
	OrderId char(12) not null primary key,
	CustomerID char(12) not null,
	EmployeeID char(6) not null,
	CreatedAt datetime default getdate(),
	TotalAmount money not null,
	ReceivedAmount money not null,
	UsedPoint int,
	PaymentMethod varchar(10) not null,
	foreign key (CustomerID) references Customers(CustomerID),
	foreign key (EmployeeID) references Employee(EmployeeID)
)
create table OrderDetail(
	OrderID char(12) not null,
	ProductID char(4) not null,
	Amount decimal(5,2) not null,
	Foreign key (ProductID) REFERENCES Product(ProductID),
	Foreign key (OrderID) REFERENCES Orders(OrderID)
)

