USE 5to_MarketWeight;

DELIMITER $$
DROP PROCEDURE IF EXISTS AltaCriptoMoneda $$
CREATE PROCEDURE `AltaCriptoMoneda`(xprecio DECIMAL(20,10), xcantidad DECIMAL(20,10), xnombre VARCHAR(45))
BEGIN
   INSERT INTO `Moneda` (precio, cantidad, nombre)
           VALUES(xprecio, xcantidad, xnombre);
END $$

DROP PROCEDURE IF EXISTS AltaUsuario $$
CREATE PROCEDURE `AltaUsuario`(xnombre VARCHAR(45), xapellido  VARCHAR(45), xemail  VARCHAR(45), xpass CHAR(64) )
BEGIN
       INSERT INTO `Usuario` (nombre, apellido, email, pass, saldo)
           VALUES(xnombre, xapellido, xemail, xpass, 0.0);
END $$

DROP PROCEDURE IF EXISTS ComprarMoneda $$
CREATE PROCEDURE `ComprarMoneda`(xidusuario INT UNSIGNED, xcantidad DECIMAL(20,10), xnombre VARCHAR(45))
BEGIN

       IF (PuedeComprar(xidUsuario, xcantidad, ObtenerIdMoneda(xnombre)))
       THEN 
              IF (NOT (EXISTS (
                     SELECT *
                     FROM `UsuarioMoneda`
                     WHERE `idMoneda` = ObtenerIdMoneda(xnombre) AND `idUsuario` = xidusuario
                     )))
                     THEN 
                            INSERT INTO `UsuarioMoneda` (`idUsuario`, `idMoneda`, cantidad)
                            VALUES(xidusuario, ObtenerIdMoneda(xnombre), 0);
              END IF;

              UPDATE UsuarioMoneda
              SET cantidad = cantidad + xcantidad
              WHERE idMoneda = ObtenerIdMoneda(xnombre)
              AND idUsuario = xidusuario;

              INSERT INTO Historial (idMoneda, cantidad, fechaHora, compra, idUsuario)
              VALUES (ObtenerIdMoneda(xnombre), xcantidad, NOW(), TRUE, xidusuario);
       ELSE
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = "Saldo Insuficiente!";
       END IF;
END $$

DROP PROCEDURE IF EXISTS IngresarDinero $$
CREATE PROCEDURE `IngresarDinero`(xidUsuario INT UNSIGNED, xsaldo DECIMAL(20,10))
BEGIN 
    UPDATE Usuario 
    SET saldo = saldo + xsaldo
    WHERE `idUsuario` = xidUsuario;
END $$

DROP PROCEDURE IF EXISTS VenderMoneda $$
CREATE PROCEDURE `VenderMoneda`(xidusuario INT UNSIGNED, xcantidad DECIMAL(20,10), xnombre VARCHAR(45))
BEGIN
       SELECT cantidad INTO @xcantidad
       FROM `UsuarioMoneda`
       WHERE `idMoneda` = ObtenerIdMoneda(xnombre) AND `idUsuario` = xidusuario;


       IF(@xcantidad >= xcantidad)
       THEN
              UPDATE UsuarioMoneda
              SET cantidad = cantidad - xcantidad
              WHERE idMoneda = ObtenerIdMoneda(xnombre)
              AND idUsuario = xidusuario;

              INSERT INTO Historial (idMoneda, cantidad, fechaHora, compra, idUsuario)
              VALUES (ObtenerIdMoneda(xnombre), (xcantidad * -1), NOW(), FALSE, xidusuario);
       ELSE
              SIGNAL SQLSTATE '45000'
              SET MESSAGE_TEXT = "Cantidad Insuficiente!";
       END IF;
END $$



DROP PROCEDURE IF EXISTS AltaHistorial $$
CREATE PROCEDURE `AltaHistorial`(xidMoneda INT UNSIGNED, xcantidad DECIMAL(20,10) UNSIGNED, xcompra TINYINT UNSIGNED, xidUsuario INT UNSIGNED)
BEGIN
       INSERT INTO `Historial` (idMoneda, cantidad, fechaHora, compra, idUsuario)
           VALUES(xidMoneda, xcantidad, NOW(), xcompra, xidUsuario);
END $$

DROP PROCEDURE IF EXISTS Transferencia $$
CREATE PROCEDURE `Transferencia`(xnombre VARCHAR(45), xCantidad DECIMAL(20,10) UNSIGNED, xidUsuarioTransfiere INT UNSIGNED, xidUsuarioTransferido INT UNSIGNED)
BEGIN
       START TRANSACTION;
       IF (PuedeVender(xidUsuarioTransfiere, xCantidad, ObtenerIdMoneda(xnombre)))
       THEN
              UPDATE UsuarioMoneda
              SET cantidad = cantidad - xCantidad
              WHERE idMoneda = ObtenerIdMoneda(xnombre)
              AND idUsuario = xidUsuarioTransfiere;

              INSERT INTO Historial (idMoneda, cantidad, fechaHora, compra, idUsuario)
              VALUES (ObtenerIdMoneda(xnombre), (xCantidad * -1), NOW(), NULL, xidUsuarioTransfiere);
       ELSE
              SIGNAL SQLSTATE '45000'
              SET MESSAGE_TEXT = "Cantidad Insuficiente!";
       END IF;

       IF (NOT (EXISTS (
                     SELECT *
                     FROM `UsuarioMoneda`
                     WHERE `idMoneda` = ObtenerIdMoneda(xnombre) AND `idUsuario` = xidUsuarioTransferido
                     )))
                     THEN 
                            INSERT INTO `UsuarioMoneda` (`idUsuario`, `idMoneda`, cantidad)
                            VALUES(xidUsuarioTransferido, ObtenerIdMoneda(xnombre), 0);
       END IF;


              UPDATE UsuarioMoneda
              SET cantidad = cantidad + xCantidad
              WHERE idMoneda = ObtenerIdMoneda(xnombre)
              AND idUsuario = xidUsuarioTransferido;

              INSERT INTO Historial (idMoneda, cantidad, fechaHora, compra, idUsuario)
              VALUES (ObtenerIdMoneda(xnombre), xcantidad, NOW(), NULL, xidUsuarioTransferido);
       COMMIT;
END $$
