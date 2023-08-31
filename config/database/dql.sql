-- Tabel Transaksi Keuangan
CREATE TABLE FinancialTransactions (
    TransactionID INT PRIMARY KEY,
    Date DATE,
    Amount DECIMAL(18, 2),
    Category NVARCHAR(50)
    -- Kolom lain yang diperlukan
);

-- Tabel Stok Barang
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Description NVARCHAR(255),
    InitialStock INT
    -- Kolom lain yang diperlukan
);

-- Tabel Pemberitahuan
CREATE TABLE Notifications (
    NotificationID INT PRIMARY KEY,
    Deadline DATE,
    Description NVARCHAR(255),
    Type NVARCHAR(50)
    -- Kolom lain yang diperlukan
);

-- Tabel Harga Produk
CREATE TABLE ProductPrices (
    PriceID INT PRIMARY KEY,
    ProductID INT,
    Price DECIMAL(18, 2),
    StartDate DATE,
    EndDate DATE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
    -- Kolom lain yang diperlukan
);
