USE 5to_MarketWeight $$
DELIMITER $$
DROP FUNCTION IF EXISTS PrecioCompra $$
CREATE DEFINER=`root`@`localhost` FUNCTION `PrecioCompra`(xcantidad DECIMAL(20,10), xidmoneda INT UNSIGNED) RETURNS DECIMAL(20,10)
    READS SQL DATA
BEGIN
    SELECT precio INTO @xprecio
    FROM `Moneda`
    WHERE `idMoneda` = xidmoneda;
    IF(@xprecio is not null)
    THEN
        RETURN @xprecio * xcantidad;
    END IF;
    RETURN NULL;
END $$

DROP FUNCTION IF EXISTS PuedeComprar $$
CREATE DEFINER=`root`@`localhost` FUNCTION `PuedeComprar`(xidusuario INT, xcantidad DECIMAL(20,10), xidmoneda INT UNSIGNED) RETURNS TINYINT
READS SQL DATA
BEGIN
    SELECT saldo INTO @saldo
    FROM Usuario
    WHERE `idUsuario` = xidusuario;

    SET @precio = PrecioCompra(xcantidad, xidmoneda);

    IF (@saldo >= @precio)
    THEN
        RETURN TRUE;
    ELSE
        RETURN FALSE;
    END IF;
END $$

DROP FUNCTION IF EXISTS ObtenerIdUsuario $$
CREATE FUNCTION `ObtenerIdUsuario`(xemail varchar(45), xpass varchar(45)) RETURNS INT
READS SQL DATA
BEGIN
    SELECT idUsuario INTO @xidusuario
    FROM Usuario
    WHERE `email` = xemail AND `pass` = xpass;
    
    RETURN @xidusuario;
END $$

DROP FUNCTION IF EXISTS ObtenerIdMoneda $$
CREATE FUNCTION `ObtenerIdMoneda`(xnombre varchar(45)) RETURNS INT
READS SQL DATA
BEGIN
    SELECT idMoneda INTO @xidmoneda
    FROM Moneda
    WHERE `nombre` = xnombre;
    
    RETURN @xidmoneda;
END $$
