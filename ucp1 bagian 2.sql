ALTER TABLE [User]
ADD nama VARCHAR(100),
    email VARCHAR(100);

CREATE PROCEDURE daftarUser
    @nama VARCHAR(100),
    @username VARCHAR(50),
    @email VARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    INSERT INTO [User]
    (nama, username, email, password, role)

    VALUES
    (@nama, @username, @email, @password, 'user')
END


CREATE TABLE Diagnosa (
    id_diagnosa INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50),
    keluhan VARCHAR(255),
    hasil_diagnosa VARCHAR(255),
    obat VARCHAR(100),
    status VARCHAR(50)
);

SELECT * FROM Diagnosa
WHERE status = 'Menunggu'

UPDATE Diagnosa
SET
hasil_diagnosa = @hasil,
obat = @obat,
status = 'Selesai'

WHERE id_diagnosa = @id

CREATE PROCEDURE konfirmasiDiagnosa
    @id INT,
    @hasil VARCHAR(255),
    @obat VARCHAR(100)
AS
BEGIN
    UPDATE Diagnosa
    SET
        hasil_diagnosa = @hasil,
        obat = @obat,
        status = 'Selesai'

    WHERE id_diagnosa = @id
END


SELECT hasil_diagnosa, obat, status
FROM Diagnosa
WHERE username = 'user'

SELECT TOP 1 hasil_diagnosa, obat, status
FROM Diagnosa
WHERE username= 'user'
ORDER BY id_diagnosa DESC

SELECT * FROM Diagnosa

string query = @"
SELECT TOP 1 hasil_diagnosa, obat, status
FROM Diagnosa
WHERE username = @u
ORDER BY id_diagnosa DESC";

ALTER TABLE Diagnosa
ADD id_user INT
FOREIGN KEY REFERENCES [User](id_user);

SELECT * FROM Diagnosa

SELECT * FROM Diagnosa

ALTER TABLE Diagnosa
ADD CONSTRAINT FK_Diagnosa_User
FOREIGN KEY (id_user)
REFERENCES [User](id_user);

WHERE id_diagnosa=@id