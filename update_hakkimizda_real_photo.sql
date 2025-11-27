-- Hakkımızda tablosundaki fotoğraf URL'sini gerçek fotoğraf ile güncelle
-- Bu scripti SQL Server Management Studio'da çalıştırın

USE TravelDb;
GO

-- Gerçek fotoğraf ile güncelle
UPDATE Hakkimizdas 
SET FotoUrl = 'https://i.hizliresim.com/eu1smd4.jpg' 
WHERE ID = 1;

-- Sonucu kontrol et
SELECT * FROM Hakkimizdas WHERE ID = 1;
GO
