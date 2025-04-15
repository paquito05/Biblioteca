CREATE OR ALTER TRIGGER trg_SancionarUsuarios
ON Prestamos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
        UPDATE p
        SET Estado = 'Atrasado'
        FROM Prestamos p
        INNER JOIN inserted i ON p.PrestamoID = i.PrestamoID
        INNER JOIN deleted d ON i.PrestamoID = d.PrestamoID
        WHERE 
            d.FechaDevolucion IS NULL
            AND i.FechaDevolucion IS NOT NULL
            AND DATEDIFF(MINUTE, i.FechaPrestamo, i.FechaDevolucion) > 1440;
END