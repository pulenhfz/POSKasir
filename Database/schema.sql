-- Buat Database
CREATE DATABASE POSKasirDB;
GO
USE POSKasirDB;
GO

-- Tabel Users
CREATE TABLE Users (
    UserID   INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50)  NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role     NVARCHAR(20)  NOT NULL DEFAULT 'kasir'
);
GO

-- Tabel Products
CREATE TABLE Products (
    ProductID   INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Price       DECIMAL(10,2) NOT NULL,
    Stock       INT           NOT NULL DEFAULT 0,
    Category    NVARCHAR(50)  NOT NULL
);
GO

-- Tabel Transactions
CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID        INT           NOT NULL,
    TransDate     DATETIME      NOT NULL DEFAULT GETDATE(),
    TotalAmount   DECIMAL(10,2) NOT NULL DEFAULT 0,
    CONSTRAINT FK_Trans_User FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- Tabel TransactionDetails
CREATE TABLE TransactionDetails (
    DetailID      INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT           NOT NULL,
    ProductID     INT           NOT NULL,
    Qty           INT           NOT NULL,
    SubTotal      DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Detail_Trans   FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID),
    CONSTRAINT FK_Detail_Product FOREIGN KEY (ProductID)     REFERENCES Products(ProductID)
);
GO

-- Data awal
INSERT INTO Users (Username, Password, Role) VALUES ('admin', 'admin123', 'admin');
INSERT INTO Users (Username, Password, Role) VALUES ('kasir', 'kasir123', 'kasir');
GO

INSERT INTO Products (ProductName, Price, Stock, Category) VALUES ('Nasi Goreng', 15000, 50, 'Makanan');
INSERT INTO Products (ProductName, Price, Stock, Category) VALUES ('Mie Ayam', 12000, 30, 'Makanan');
INSERT INTO Products (ProductName, Price, Stock, Category) VALUES ('Es Teh', 5000, 100, 'Minuman');
INSERT INTO Products (ProductName, Price, Stock, Category) VALUES ('Kopi', 8000, 80, 'Minuman');
INSERT INTO Products (ProductName, Price, Stock, Category) VALUES ('Keripik', 7000, 60, 'Snack');
GO
