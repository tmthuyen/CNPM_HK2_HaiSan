-- Tạo bảng Employee
CREATE TABLE Employee (
    EmployeeId VARCHAR(15) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(15) UNIQUE NOT NULL,
    Avatar NVARCHAR(255),
    Status INT NOT NULL DEFAULT 1, -- 1 la active
    PassWord NVARCHAR(255) NOT NULL,
    RoleName NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10),
    DateOfBirth DATE
);

-- Tạo bảng Customer
CREATE TABLE Customer (
    Phone VARCHAR(15) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    LoyaltyPoint INT DEFAULT 0
);

-- Tạo bảng Order
CREATE TABLE [Order] (
    OrderId VARCHAR(20) PRIMARY KEY,
    CreatedAt DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2) NOT NULL,
    ReceivedAmount DECIMAL(18,2) NOT NULL,
    -- class có getChangeAmount()
    UsedPoint INT DEFAULT 0,
    PaymentMethod NVARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    EmployeeId VARCHAR(15) NOT NULL,
    FOREIGN KEY (Phone) REFERENCES Customer(Phone),
    FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
);

-- Tạo bảng Product
CREATE TABLE Product (
    ProductId VARCHAR(15) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    PurchasePrice DECIMAL(18,2) NOT NULL,
    RetailPrice DECIMAL(18,2) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    Quantity INT DEFAULT 0,
    ExpireDate DATE,
    Status BIT NOT NULL,
    CategoryId VARCHAR(15) NOT NULL,
    SupplierId VARCHAR(15) NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId),
    FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);

-- Tạo bảng OrderDetail
CREATE TABLE OrderDetail (
    OrderId VARCHAR(15),
    ProductId VARCHAR(15),
    QuantitySold INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    DiscountAmount DECIMAL(18,2) DEFAULT 0,
    -- TotalPrice DECIMAL(18,2) NOT NULL,
    -- FinalPrice DECIMAL(18,2) NOT NULL,
    -- class có getTotalPrice, getFinalPrice
    PRIMARY KEY (OrderId, ProductId),
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

-- Tạo bảng Supplier
CREATE TABLE Supplier (
    SupplierId VARCHAR(15) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Address NVARCHAR(255),
    Email NVARCHAR(100),
    Phone VARCHAR(15) UNIQUE
);

-- Tạo bảng Import
CREATE TABLE Import (
    ImportId VARCHAR(15) PRIMARY KEY,
    ImportDate DATETIME DEFAULT GETDATE(),
    SupplierId VARCHAR(15) NOT NULL,
    TotalAmount DECIMAL(18, 2),
    FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);

-- Tạo bảng ImportDetail
CREATE TABLE ImportDetail (
    ImportId VARCHAR(15),
    ProductId VARCHAR(15),
    Quantity INT NOT NULL,
    PurchasePrice DECIMAL(18,2) NOT NULL,
    --TotalPrice DECIMAL(18,2) NOT NULL,
    -- class có getTotalPrice
    PRIMARY KEY (ImportId, ProductId),
    FOREIGN KEY (ImportId) REFERENCES Import(ImportId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

-- Tạo bảng PromotionGroup
CREATE TABLE PromotionGroup (
    GroupId VARCHAR(15) PRIMARY KEY,
    GroupName NVARCHAR(255) NOT NULL
);

-- Tạo bảng Promotion
CREATE TABLE Promotion (
    PromotionId VARCHAR(15) PRIMARY KEY,
    ReleaseDate DATE NOT NULL,
    ExpiredDate DATE NOT NULL,
    DiscountValue DECIMAL(18,2) NOT NULL,
    GroupId INT NOT NULL,
    FOREIGN KEY (GroupId) REFERENCES PromotionGroup(GroupId)
);

-- Tạo bảng OrderPromotion
CREATE TABLE OrderPromotion (
    OrderId VARCHAR(15),
    PromotionId VARCHAR(15),
    PRIMARY KEY (OrderId, PromotionId),
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);

-- Tạo bảng Involves
CREATE TABLE Involves (
    GroupId VARCHAR(15),
    ProductId VARCHAR(15),
    PRIMARY KEY (GroupId, ProductId),
    FOREIGN KEY (GroupId) REFERENCES PromotionGroup(GroupId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

-- Tạo bảng Restriction
CREATE TABLE Restriction (
    PromotionId VARCHAR(15) PRIMARY KEY,
    Type NVARCHAR(50) NOT NULL,
    ApplyCondition NVARCHAR(255) NOT NULL,
    FOREIGN KEY (PromotionId) REFERENCES Promotion(PromotionId)
);
