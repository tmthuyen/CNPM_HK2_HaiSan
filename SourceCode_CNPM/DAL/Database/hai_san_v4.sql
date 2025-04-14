create database haisan
go use haisan
use master
drop database haisan

CREATE TABLE Employee (
    EmployeeId CHAR(6) PRIMARY KEY,
    EmployeeName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) NOT NULL,
    Email VARCHAR(30) UNIQUE,
    Gender NVARCHAR(3) NOT NULL CHECK (Gender = N'Nam' OR Gender = N'Nữ') DEFAULT N'Nam',
    Status NVARCHAR(10) NOT NULL CHECK (Status = 'active' OR Status = 'inactive') DEFAULT 'active',
    RoleName VARCHAR(6) NOT NULL CHECK (RoleName = 'admin' OR RoleName = 'sale'),
    Address NVARCHAR(50) NOT NULL,
    Avatar VARCHAR(30),
    DateOfBirth DATE NOT NULL
);

Insert Into Employee values
('Emp01', N'Trần Minh Thuyên', '0373436163', 'tranthuyen2222@gmail.com', 'Nam', 'active', 'admin', 'Q7', 'thuyen.png', '2005-02-20'),
('Emp02', N'Hồ Gia Kiện', '0373436163', 'hogiakien@gmail.com', 'Nam', 'active', 'admin', 'Q7', 'kien.png', '2005-01-01')

--('Emp03', N'Trần Minh Thuyên', '0373436163', 'tranthuyen2222@gmail.com', 'Nam', 'active', 'admin', 'Q7', 'thuyen.png', '2005-02-20'),

Create table Account(
	EmployeeId CHAR(6) Primary key,
	Username CHAR(20) NOT NULL UNIQUE,
	Password Varchar(50) NOT NULL, --hashed
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)	
)

ALTER TABLE Account
ALTER COLUMN Password VARCHAR(100);

Select * from Employee
select * from Account
select * from Category
select * from Customer
select * from Products
select * from Supplier
Insert into Account Values
('Emp01', 'tranthuyen', 'thuyen123'),
('Emp02', 'giakien', 'kien123')


CREATE TABLE Customer (
    CustomerId CHAR(10) PRIMARY KEY,
    CustomerName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) UNIQUE NOT NULL,
    LoyaltyPoint INT NOT NULL --/100 cho hoa don's amount
); 

insert into Customer values
('cus00001', N'Thuyên', '0373436163', 0)

CREATE TABLE Category (
    CategoryId CHAR(6) PRIMARY KEY,
    CategoryName NVARCHAR(20) NOT NULL
);
Insert into Category Values
('Fish', 'Cá'),
('Crab', 'Cua')



CREATE TABLE Supplier (
    SupplierId CHAR(6) PRIMARY KEY,
    SupplierName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) NOT NULL,
    Email VARCHAR(30) NOT NULL UNIQUE
);
Insert into Supplier Values
('Sup001', 'ALAN', '0377777777', 'alan@gmail.com'),
('Sup002', 'CHARLIE', '0373333333', 'charlie@gmail.com')


CREATE TABLE Products (
    ProductId CHAR(10) NOT NULL PRIMARY KEY,
    SupplierId CHAR(6) NOT NULL,
    CategoryId CHAR(6) NOT NULL,
    ProductName NVARCHAR(50) NOT NULL,
    PurchasePrice INT NOT NULL,
    RetailPrice INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    Unit NVARCHAR(10) NOT NULL, 
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId),
    FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);

Insert Into Products Values
('Prod0001', 'Sup001', 'Fish', N'Cá kình', 50000000, 100000000, GETDATE(), 'kg')

ALTER TABLE Products
ALTER COLUMN ProductId CHAR(20);
ALTER TABLE Category
ALTER COLUMN CategoryId Char(15)

CREATE TABLE Import (
    ImportId CHAR(6) PRIMARY KEY,
    ImportDate DATETIME DEFAULT GETDATE() NOT NULL,
	NumOfProducts INT,--số loại nhập
);


CREATE TABLE ExpireProduct (--neu ma het thi bo qua ban nay
    ExpireProductId CHAR(10) NOT NULL PRIMARY KEY,
    ProductId CHAR(10) NOT NULL,
    Quantity DECIMAL(10, 3) NOT NULL,--so luong mat
    TotalLoss INT NOT NULL,--tien mat
    ExpiredDate DATE NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

CREATE TABLE ImportDetail ( --day la lo hang chu ko phai chi tiet nhap hang
    ProductId CHAR(10) NOT NULL,
    ImportId CHAR(6) NOT NULL,
    Quantity DECIMAL(10, 3) NOT NULL,--so luong nhap
    Remaining DECIMAL(10, 3) NOT NULL,--so luong con lai
    Expire DATE NOT NULL,
    PurchasePrice INT NOT NULL,
    PRIMARY KEY (ProductId, ImportId),
    FOREIGN KEY (ImportId) REFERENCES Import(ImportId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

CREATE TABLE Voucher (
    VoucherId CHAR(10) PRIMARY KEY,
    VoucherName NVARCHAR(50) NOT NULL,
    ReleaseDate DATE NOT NULL, --bat dau ap dung tu
    Expire DATE NOT NULL,
    ApplyAmount INT NOT NULL, --ap dung cho don tu 
    MaxApply INT NOT NULL,   --giam gia toi da bao nhieu vnd
    DiscountValue INT NOT NULL, -- giam bao nhieu
    IsCash BIT NOT NULL -- giam tien hay %
);

CREATE TABLE Orders (   
    OrderId CHAR(12) NOT NULL PRIMARY KEY,
    CustomerId CHAR(10) NOT NULL,
    EmployeeId CHAR(6) NOT NULL,
    VoucherId CHAR(10),	--so tien khuyen mai
    CreatedAt DATETIME DEFAULT GETDATE(),
    TotalAmount INT NOT NULL,--tong tien suy diễn
    ReceivedAmount INT NOT NULL,--tien nhan
    UsedPoint INT,--khach hang su dung bao nhieu
    PaymentMethod NVARCHAR(10) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
	FOREIGN KEY (VoucherId) REFERENCES Voucher(VoucherId)
);

CREATE TABLE OrderDetail (
    OrderId CHAR(12) NOT NULL,
    ProductId CHAR(10) NOT NULL,
    RetailPrice INT NOT NULL,
    Amount DECIMAL(10, 3) NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);