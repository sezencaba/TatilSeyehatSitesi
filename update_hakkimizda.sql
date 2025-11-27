-- Hakkımızda tablosundaki fotoğraf URL'sini güncelle
-- Bu scripti SQL Server Management Studio'da çalıştırın

USE TravelDb;
GO

-- Test fotoğrafı ile güncelle
UPDATE Hakkimizdas 
SET FotoUrl = 'https://via.placeholder.com/400x300/0066cc/ffffff?text=Hakkımızda' 
WHERE ID = 1;

-- Sonucu kontrol et
SELECT * FROM Hakkimizdas WHERE ID = 1;
GO
