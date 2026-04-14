CREATE DATABASE RsIndosiar;
GO

USE RsIndosiar;
GO

ALTER TABLE [User]
ADD role VARCHAR(10) DEFAULT 'user';

UPDATE [User]
SET role = 'user'
WHERE role IS NULL;

SELECT * FROM [User];

SELECT role FROM [User] 
WHERE username = 'user1' AND password = '12345';

INSERT INTO [User] (username, password, role)
VALUES ('admin', 'admin123', 'admin');

INSERT INTO [User] (username, password, role)
VALUES ('user', 'user123', 'user');

CREATE TABLE [User] (
    id_user INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(10) CHECK (role IN ('admin','user')) NOT NULL
);

CREATE TABLE Gejala (
    id_gejala INT IDENTITY(1,1) PRIMARY KEY,
    nama_gejala VARCHAR(100) NOT NULL
);

CREATE TABLE Obat (
    id_obat INT IDENTITY(1,1) PRIMARY KEY,
    nama_obat VARCHAR(100) NOT NULL,
    deskripsi TEXT
);

CREATE TABLE Aturan_Diagnosa (
    id_aturan INT IDENTITY(1,1) PRIMARY KEY,
    id_gejala INT,
    pertanyaan_lanjutan TEXT,
    pilihan_jawaban TEXT,
    id_obat_rekomendasi INT,

    FOREIGN KEY (id_gejala) REFERENCES Gejala(id_gejala),
    FOREIGN KEY (id_obat_rekomendasi) REFERENCES Obat(id_obat)
);

CREATE TABLE Riwayat (
    id_riwayat INT IDENTITY(1,1) PRIMARY KEY,
    id_user INT,
    tanggal DATETIME DEFAULT GETDATE(),
    keluhan TEXT,
    hasil_rekomendasi TEXT,

    FOREIGN KEY (id_user) REFERENCES [User](id_user)
);

