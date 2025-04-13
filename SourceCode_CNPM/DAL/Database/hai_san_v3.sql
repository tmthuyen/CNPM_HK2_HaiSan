USE Haisan;


CREATE TABLE Employee (
    EmployeeId CHAR(6) NOT NULL PRIMARY KEY,
    EmployeeName NVARCHAR(30) NOT NULL,
    Password VARCHAR(30) NOT NULL,
    Phone VARCHAR(12) NOT NULL UNIQUE,
    Email VARCHAR(40) NOT NULL UNIQUE,
    Gender NVARCHAR(3) NOT NULL CHECK(Gender = N'Nam' OR Gender = N'Nữ') DEFAULT N'Nam', 
    Status VARCHAR(10) NOT NULL CHECK(Status = 'active' OR Status = 'inactive') DEFAULT 'active',
    RoleName VARCHAR(6) NOT NULL CHECK(RoleName = N'admin' OR RoleName = N'sale'),
    Avatar VARCHAR(30),
    DateOfBirth DATE NOT NULL
);

CREATE TABLE Customer (
    CustomerId CHAR(10) NOT NULL PRIMARY KEY,
    CustomerName NVARCHAR(50) NOT NULL,
    Phone VARCHAR(12) UNIQUE NOT NULL,
    LoyaltyPoint INT NOT NULL
);

CREATE TABLE Category (
    CategoryId CHAR(6) PRIMARY KEY,
    CategoryName NVARCHAR(20) NOT NULL
);

CREATE TABLE Supplier (
    SupplierId CHAR(6) PRIMARY KEY,
    SupplierName NVARCHAR(30) NOT NULL,
    Phone VARCHAR(12) NOT NULL UNIQUE,
    Email VARCHAR(30) NOT NULL UNIQUE,
    Address NVARCHAR(50) NOT NULL
);

CREATE TABLE Product (
    ProductId CHAR(10) NOT NULL PRIMARY KEY,
    ProductName NVARCHAR(50) NOT NULL,
    PurchasePrice INT NOT NULL,
    RetailPrice INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    Remaining DECIMAL(10, 3) NOT NULL,
    ShelfLife INT NOT NULL,  -- hạn sử dụng (số ngày có thể dùng tính từ ngày nhập)
    Unit VARCHAR(10) NOT NULL, 
    SupplierId CHAR(6) NOT NULL,
    CategoryId CHAR(6) NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId),
    FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);

CREATE TABLE Import (
    ImportId CHAR(6) PRIMARY KEY, 
    ImportDate DATETIME DEFAULT GETDATE() NOT NULL,
    TotalCost INT NOT NULL,  
); 

CREATE TABLE ImportDetail (
    ProductId CHAR(10) NOT NULL,
    ImportId CHAR(6) NOT NULL,
    Quantity DECIMAL(10, 3) NOT NULL,
    Remaining  DECIMAL(10, 3) NOT NULL DEFAULT Quantity, -- sô luong con lai cua lo -> ban hangf va bao cáo
    ExpireDate DATE NOT NULL, -- han su dung cua lo hang, chi ban khi remaining > 0 and now < expriredate
    PurchasePrice INT NOT NULL,
    PRIMARY KEY (ProductId, ImportId),
    FOREIGN KEY (ImportId) REFERENCES Import(ImportId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

CREATE TABLE Promotion (
    PromotionId CHAR(10) PRIMARY KEY,
    PromotionName NVARCHAR(50) NOT NULL,
    ReleaseDate DATE NOT NULL,
    ExpireDate DATE NOT NULL,
    Restriction CHAR(3) NOT NULL,
    DailyTime TIME,
    UsePoints INT
);

CREATE TABLE Voucher (
    PromotionId CHAR(10) NOT NULL,
    ApplyAmount INT NOT NULL,
    MaxApply INT NOT NULL,
    DiscountValue INT NOT NULL,
    IsCash BIT NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);

CREATE TABLE SpecificDiscounts (
    PromotionId CHAR(10) NOT NULL PRIMARY KEY,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);

CREATE TABLE DiscountDetails (
    PromotionId CHAR(10) NOT NULL,
    ProductId CHAR(10) NOT NULL,
    DiscountValue INT NOT NULL,
    IsCash BIT NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES SpecificDiscounts(PromotionId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

CREATE TABLE Combo (
    PromotionId CHAR(10) NOT NULL PRIMARY KEY,
    ComboAmount INT NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);

CREATE TABLE ComboDetails (
    PromotionId CHAR(10) NOT NULL PRIMARY KEY,
    ProductId CHAR(10) NOT NULL,
    Quantity DECIMAL(5, 3) NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

CREATE TABLE BuyGetGroup (
    GroupId CHAR(4) NOT NULL PRIMARY KEY,
    ProductId CHAR(10) NOT NULL,
    Quantity DECIMAL(5, 3) NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

CREATE TABLE BuyNGetN (
    PromotionId CHAR(10) NOT NULL PRIMARY KEY,
    BuyGroup CHAR(4) NOT NULL,
    GetGroup CHAR(4) NOT NULL,
    FOREIGN KEY (BuyGroup) REFERENCES BuyGetGroup(GroupId),
    FOREIGN KEY (GetGroup) REFERENCES BuyGetGroup(GroupId),
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);

CREATE TABLE ComboForCategory (
    PromotionId CHAR(10) NOT NULL PRIMARY KEY,
    CategoryId CHAR(6) NOT NULL,
    Quantity DECIMAL(5, 3) NOT NULL,
    DiscountValue INT NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId),
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);




CREATE TABLE Orders (
    OrderId CHAR(12) NOT NULL PRIMARY KEY,
    CustomerId CHAR(10) NOT NULL,
    EmployeeId CHAR(6) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    TotalAmount INT NOT NULL,
    ReceivedAmount INT NOT NULL,
    UsedPoint INT,
    PaymentMethod VARCHAR(10) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);

CREATE TABLE OrderDetail (
    OrderId CHAR(12) NOT NULL,
    ProductId CHAR(4) NOT NULL,
    RetailPrice INT NOT NULL, -- de tinh tong tien cua ctdh 
    Amount DECIMAL(5, 2) NOT NULL, -- AMOUNT LA GÌ SỐ LƯỢNG HAY GIÁ
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);
