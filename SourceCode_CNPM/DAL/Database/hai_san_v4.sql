create database haisan
go use haisan
use master
drop database haisan

-- ======
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

Insert Into Employee values ('Emp02', N'Hồ Gia Kiện', '0373436163', 'hogiakien@gmail.com', 'Nam', 'active', 'admin', 'Q7', 'kien.png', '2005-01-01')
insert into Employee values ('Emp01', N'Trần Minh Thuyên', '0373436163', 'tranthuyen@gmail.com', 'Nam', 'active', 'admin', 'Quảng Nam', 'thuyen.png', '2005-02-20')
insert into Employee values ('Emp04', N'Trần Minh Thuyên', '0373336666', 'tmthuyen@gmail.com', 'Nam', 'active', 'sale', 'Quảng Nam', 'thuyen.png', '2005-02-20')
 

 ---=====
Create table Account(
	EmployeeId CHAR(6) Primary key,
	Username CHAR(20) NOT NULL UNIQUE,
	Password Varchar(255) NOT NULL, --hashed
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)	
) 

insert into Account values('Emp01', 'tranthuyen', 'b13341051b70a0a4dc3e18d0d7ca1b65995e76c230d68464d5466b3b5e551c3d')
insert into Account values('Emp04', 'tmthuyen', 'b13341051b70a0a4dc3e18d0d7ca1b65995e76c230d68464d5466b3b5e551c3d')

-- =====
CREATE TABLE Customer (
    CustomerId CHAR(10) PRIMARY KEY,
    CustomerName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) UNIQUE NOT NULL,
    LoyaltyPoint INT NOT NULL --/100 cho hoa don's amount
);  


-- =======
CREATE TABLE Category ( 
    CategoryId CHAR(15) PRIMARY KEY,
    CategoryName NVARCHAR(20) NOT NULL
);
Insert into Category Values
('Fish', N'Cá'),
('Crab', N'Cua')

  INSERT INTO Category VALUES
('Shrimp', N'Tôm'),
('Snail', N'Ốc'),
('Clam', N'Nghêu'),
('Squid', N'Mực'),
('Lobst', N'Tôm hùm');


-- =======
CREATE TABLE Supplier (
    SupplierId CHAR(6) PRIMARY KEY,
    SupplierName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) NOT NULL,
    Email VARCHAR(30) NOT NULL UNIQUE
);
Insert into Supplier Values
('Sup001', 'ALAN', '0377777777', 'alan@gmail.com'),
('Sup002', 'CHARLIE', '0373333333', 'charlie@gmail.com')


-- =====
CREATE TABLE Products (
    ProductId CHAR(20) NOT NULL PRIMARY KEY,
    CategoryId CHAR(15) NOT NULL,
    ProductName NVARCHAR(50) NOT NULL,
    RetailPrice INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    Unit NVARCHAR(10) NOT NULL, 
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);

/*
INSERT INTO Products (ProductId, SupplierId, CategoryId, ProductName, RetailPrice, CreatedAt, Unit) VALUES
('Prod0001', 'Sup001', 'Fish', N'Cá kình', 120000, GETDATE(), 'kg')
('Prod0002', 'Sup001', 'Fish',     N'Cá bống mú', 95000, GETDATE(), N'kg'),
('Prod0003', 'Sup001', 'Crab',     N'Cua biển', 160000, GETDATE(), N'kg'),
('Prod0004', 'Sup002', 'Shrimp',   N'Tôm sú', 190000, GETDATE(), N'kg'),
('Prod0005', 'Sup002', 'Snail',   N'Ốc hương', 100000, GETDATE(), N'kg'),
('Prod0006', 'Sup001', 'Clam',   N'Nghêu trắng', 60000, GETDATE(), N'kg'),
('Prod0007', 'Sup002', 'Squid',   N'Mực ống', 140000, GETDATE(), N'kg'),
('Prod0008', 'Sup001', 'Lobst',   N'Tôm hùm Alaska', 650000, GETDATE(), N'kg');
*/


-- ======
CREATE TABLE Import (
    ImportId CHAR(20) PRIMARY KEY,
    SupplierId CHAR(6) NOT NULL,
    ImportDate DATETIME DEFAULT GETDATE() NOT NULL,
    NumOfProducts INT,--số loại nhập
    FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);



CREATE TABLE ImportDetail ( --day la lo hang chu ko phai chi tiet nhap hang
    ImportId CHAR(20) NOT NULL,
    ProductId CHAR(20) NOT NULL,
    Quantity DECIMAL(10, 3) NOT NULL,--so luong nhap
    Remaining DECIMAL(10, 3) NOT NULL,--so luong con lai
    Expire DATE NOT NULL,  -- ngay het han cua san pham
    PurchasePrice INT NOT NULL,  --  gias goc khi nhap hang
    PRIMARY KEY (ProductId, ImportId),
    FOREIGN KEY (ImportId) REFERENCES Import(ImportId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
-- Kiểm tra trong bảng Import
EXEC sp_help 'Import';

-- Kiểm tra trong bảng ImportDetail
EXEC sp_help 'ImportDetail';


-- =====
CREATE TABLE ExpireProduct (--neu ma het thi bo qua ban nay
    ExpireProductId CHAR(10) NOT NULL PRIMARY KEY,
    ProductId CHAR(20) NOT NULL,
    ImportId CHAR(20) NOT NULL,
    Quantity DECIMAL(10, 3) NOT NULL,--so luong mat
    TotalLoss INT NOT NULL,--tien mat
    ExpiredDate DATE NOT NULL,  --  ngay loai bo san phamar
    FOREIGN KEY (ProductId,ImportId) REFERENCES ImportDetail(ProductId,ImportId)
);



/*
-- Bảng Import (phiếu nhập)
INSERT INTO Import (ImportId, ImportDate, NumOfProducts) VALUES
('IMP00001', GETDATE(), 3),
('IMP00002', GETDATE(), 3),
('IMP00003', GETDATE(), 1);

-- Bảng ImportDetail (lô hàng nhập)
INSERT INTO ImportDetail (ProductId, ImportId, Quantity, Remaining, Expire, PurchasePrice) VALUES
('Prod0001', 'IMP00001', 30, 30, '2025-05-10', 100000),
('Prod0002', 'IMP00001', 30, 30, '2025-05-10', 70000),
('Prod0003', 'IMP00001', 20, 20, '2025-05-12', 120000),

('Prod0004', 'IMP00002', 25, 25, '2025-05-08', 150000),
('Prod0005', 'IMP00002', 40, 40, '2025-06-01', 80000),
('Prod0006', 'IMP00002', 50, 50, '2025-05-25', 40000),

('Prod0007', 'IMP00003', 15, 15, '2025-04-30', 110000);
*/


-- =====
CREATE TABLE Voucher (
    VoucherId CHAR(10) PRIMARY KEY, 
    VoucherName NVARCHAR(50) NOT NULL,
    ReleaseDate DATE NOT NULL,        -- bắt đầu áp dụng từ
    Expire DATE NOT NULL,
    ApplyAmount INT NOT NULL,         -- áp dụng cho đơn từ
    MaxApply INT NOT NULL,            -- giảm giá tối đa bao nhiêu VND
    DiscountValue INT NOT NULL,       -- giảm bao nhiêu
    IsCash BIT NOT NULL,              -- giảm tiền hay %
    IsDebuted BIT default 0,          -- voucher này ra mắt chưa
	IsDeactivated BIT default 0,	  -- voucher này có bị bô hiệu hóa bởi ng dùng hay ko
    IsActive AS (
        CASE 
            WHEN IsDebuted = 1 AND IsDeactivated = 0 AND GETDATE() >= ReleaseDate AND GETDATE() <= Expire THEN 1 
            ELSE 0 
        END
    ) -- này check coi có trong ngày ko lun với ra mắt chưa để bik coi nó đang hoạt động ko
);

-- =======
CREATE TABLE Orders (   
    OrderId CHAR(12) NOT NULL PRIMARY KEY,
    CustomerId CHAR(10) NOT NULL,
    EmployeeId CHAR(6) NOT NULL,
    VoucherId CHAR(10),	--so tien khuyen mai
    CreatedAt DATETIME DEFAULT GETDATE(),
    TotalAmount INT NOT NULL,--tong tien suy diễn
    ReceivedAmount INT NOT NULL,--tien nhan
    UsedPoint INT,--khach hang su dung bao nhieu
    PaymentMethod NVARCHAR(11) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    FOREIGN KEY (VoucherId) REFERENCES Voucher(VoucherId)
);


-- =====
CREATE TABLE OrderDetail (
    OrderId CHAR(12) NOT NULL,
    ProductId CHAR(20) NOT NULL,
	ImportId CHAR(20) NOT NULL,
    RetailPrice INT NOT NULL,
    Amount DECIMAL(10, 3) NOT NULL,
    FOREIGN KEY (ProductId,ImportId) REFERENCES ImportDetail(ProductId,ImportId),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
	PRIMARY KEY(ProductId, ImportId, OrderId)
);


INSERT INTO Voucher (VoucherId, VoucherName, ReleaseDate, Expire, ApplyAmount, MaxApply, DiscountValue, IsCash, IsDebuted, IsDeactivated)
VALUES 
-- Đã ra mắt, đang hoạt động
('V250401C01', N'Giảm tiền mùa hè', '2025-04-01', '2025-05-01', 500000, 100000, 50000, 1, 1, 0),
('V250401P01', N'Giảm 10% cho đơn lớn', '2025-04-01', '2025-06-01', 300000, 80000, 10, 0, 1, 0),

-- Chưa ra mắt (trong tương lai)
('V250501C01', N'Ưu đãi ngày Quốc tế Lao động', '2025-05-01', '2025-06-01', 400000, 90000, 40000, 1, 0, 0),
('V250515P01', N'Giảm giá tháng 5', '2025-05-15', '2025-06-15', 200000, 70000, 15, 0, 0, 0),

-- Đã ra mắt, đang hoạt động
('V250410C01', N'Ưu đãi đầu tháng 4', '2025-04-10', '2025-05-10', 250000, 50000, 30000, 1, 1, 0),
('V250410P02', N'Giảm 5% cho đơn ăn trưa', '2025-04-10', '2025-05-10', 150000, 40000, 5, 0, 1, 0);


insert into import values ('1',getdate(),1)
insert into ImportDetail values ('Prod0001','1',50,50,'2025-05-01',50000)
insert into ImportDetail values ('Prod0002','1',50,50,'2025-05-01',30000)
insert into ImportDetail values ('Prod0003','1',50,50,'2025-05-01',75000)
