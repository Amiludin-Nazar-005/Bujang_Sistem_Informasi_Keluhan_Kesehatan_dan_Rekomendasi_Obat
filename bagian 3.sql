CREATE PROCEDURE spTambahObat
    @nama VARCHAR(100),
    @deskripsi VARCHAR(255)
AS
BEGIN
    INSERT INTO Obat(nama_obat, deskripsi)
    VALUES(@nama, @deskripsi)
END

CREATE VIEW vwDiagnosa
AS
SELECT
    id_diagnosa,
    username,
    keluhan,
    hasil_diagnosa,
    obat,
    status
FROM Diagnosa


CREATE PROCEDURE spLogin
    @username VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    SELECT role
    FROM [User]
    WHERE username = @username
    AND password = @password
END

CREATE VIEW vwObat
AS
SELECT
    id_obat,
    nama_obat,
    deskripsi
FROM Obat

CREATE PROCEDURE spTambahObat
    @nama VARCHAR(100),
    @deskripsi VARCHAR(255)
AS
BEGIN
    INSERT INTO Obat(nama_obat, deskripsi)
    VALUES(@nama, @deskripsi)
END

CREATE VIEW vwRiwayat
AS
SELECT
    id_diagnosa,
    username,
    keluhan,
    hasil_diagnosa,
    obat,
    status,
    tanggal
FROM Diagnosa

ALTER TABLE Diagnosa
ADD tanggal DATETIME DEFAULT GETDATE()


ALTER PROCEDURE spKonfirmasiDiagnosa
    @id INT,
    @hasil VARCHAR(255),
    @obat VARCHAR(255)
AS
BEGIN
    UPDATE Diagnosa
    SET
        hasil_diagnosa = @hasil,
        obat = @obat,
        status = 'Selesai',
        tanggal = GETDATE()
    WHERE id_diagnosa = @id
END

ALTER VIEW vwRiwayat
AS
SELECT
    id_diagnosa,
    username,
    keluhan,
    hasil_diagnosa,
    obat,
    status,
    tanggal
FROM Diagnosa

ALTER TABLE Diagnosa
ADD tanggal DATETIME

CREATE PROCEDURE spKonfirmasiDiagnosa
    @id INT,
    @hasil VARCHAR(255),
    @obat VARCHAR(255)
AS
BEGIN
    UPDATE Diagnosa
    SET
        hasil_diagnosa = @hasil,
        obat = @obat,
        status = 'Selesai',
        tanggal = GETDATE()
    WHERE id_diagnosa = @id
END

SELECT * FROM Diagnosa

CREATE PROCEDURE spUpdateObat
    @id INT,
    @nama VARCHAR(100),
    @deskripsi VARCHAR(255)
AS
BEGIN
    UPDATE Obat
    SET
        nama_obat = @nama,
        deskripsi = @deskripsi
    WHERE id_obat = @id
END

CREATE PROCEDURE spDeleteObat
    @id INT
AS
BEGIN
    DELETE FROM Obat
    WHERE id_obat = @id
END

ALTER PROCEDURE spUpdateObat
    @id INT,
    @nama VARCHAR(100),
    @deskripsi VARCHAR(255)
AS
BEGIN
    UPDATE Obat
    SET
        nama_obat = @nama,
        deskripsi = @deskripsi
    WHERE id_obat = @id
END

ALTER PROCEDURE spKonfirmasiDiagnosa
    @id INT,
    @hasil VARCHAR(255),
    @obat VARCHAR(255)
AS
BEGIN
    UPDATE Diagnosa
    SET
        hasil_diagnosa = @hasil,
        obat = @obat,
        status = 'Selesai',
        tanggal = GETDATE()
    WHERE id_diagnosa = @id
END

SELECT * FROM Obat

CREATE PROCEDURE spUpdateObat
    @id INT,
    @nama VARCHAR(100),
    @deskripsi VARCHAR(255)
AS
BEGIN
    UPDATE Obat
    SET
        nama_obat = @nama,
        deskripsi = @deskripsi
    WHERE id_obat = @id
END


ALTER VIEW vwDiagnosa
AS
SELECT
    id_diagnosa,
    username,
    keluhan,
    hasil_diagnosa,
    obat,
    status,
    tanggal
FROM Diagnosa

ALTER VIEW vwDiagnosa
AS
SELECT
    id_diagnosa,
    username,
    keluhan,
    hasil_diagnosa,
    obat,
    status,
    tanggal
FROM Diagnosa

SELECT * FROM vwDiagnosa

string query = @"
SELECT TOP 1
keluhan,
hasil_diagnosa,
obat,
status,
tanggal
FROM Diagnosa
WHERE username=@u
ORDER BY id_diagnosa DESC";


SELECT
hasil_diagnosa
FROM Diagnosa

SELECT * FROM Diagnosa
WHERE username = ''
OR '1'='1'