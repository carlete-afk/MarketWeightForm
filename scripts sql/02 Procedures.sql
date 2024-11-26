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
       IF(CantidadMonedaExiste(ObtenerIdMoneda(xnombre), xcantidad))
       THEN
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

                     INSERT INTO Historial (idUsuario, idMoneda, cantidad, fechaHora, tipoAccion)
                     VALUES (xidusuario, ObtenerIdMoneda(xnombre), xcantidad, NOW(), 'Compra' );
              ELSE
                     SIGNAL SQLSTATE '45000'
                     SET MESSAGE_TEXT = "Saldo Insuficiente!";
              END IF;
       ELSE
              SIGNAL SQLSTATE '45000'
              SET MESSAGE_TEXT = "No hay cantidad de Monedad suficientes!!";
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

              INSERT INTO Historial (idUsuario, idMoneda, cantidad, fechaHora, tipoAccion)
              VALUES (xidusuario, ObtenerIdMoneda(xnombre), (xcantidad * -1), NOW(), 'Venta');
       ELSE
              SIGNAL SQLSTATE '45000'
              SET MESSAGE_TEXT = "Cantidad Insuficiente!";
       END IF;
END $$



DROP PROCEDURE IF EXISTS AltaHistorial $$
CREATE PROCEDURE `AltaHistorial`(xidMoneda INT UNSIGNED, xcantidad DECIMAL(20,10) UNSIGNED, xtipoAccion VARCHAR(45), xidUsuario INT UNSIGNED)
BEGIN
       INSERT INTO `Historial` (idUsuario, idMoneda, cantidad, fechaHora, tipoAccion)
           VALUES( xidUsuario, xidMoneda, xcantidad, NOW(), xcompra, xtipoAccion);
END $$

DROP PROCEDURE IF EXISTS Transferencia $$
CREATE PROCEDURE `Transferencia`(xnombre VARCHAR(45), xCantidad DECIMAL(20,10) UNSIGNED, xidUsuarioTransfiere INT UNSIGNED, xemail VARCHAR(45))
BEGIN
       IF(ExisteUsuario(xemail))
       THEN
              IF (PuedeVender(xidUsuarioTransfiere, xCantidad, ObtenerIdMoneda(xnombre)))
              THEN
                     UPDATE UsuarioMoneda
                     SET cantidad = cantidad - xCantidad
                     WHERE idMoneda = ObtenerIdMoneda(xnombre)
                     AND idUsuario = xidUsuarioTransfiere;

                     INSERT INTO Historial (idUsuario, idMoneda, cantidad, fechaHora, tipoAccion )
                     VALUES (xidUsuarioTransfiere, ObtenerIdMoneda(xnombre), (xCantidad * -1), NOW(), 'Transferencia');
              ELSE
                     SIGNAL SQLSTATE '45000'
                     SET MESSAGE_TEXT = "Cantidad Insuficiente!";
              END IF;

              IF (NOT (EXISTS (
                            SELECT *
                            FROM `UsuarioMoneda`
                            WHERE `idMoneda` = ObtenerIdMoneda(xnombre) AND `idUsuario` = ObtenerIdUsuario(xemail)
                            )))
                            THEN 
                                   INSERT INTO `UsuarioMoneda` (`idUsuario`, `idMoneda`, cantidad)
                                   VALUES(ObtenerIdUsuario(xemail), ObtenerIdMoneda(xnombre), 0);
              END IF;

                     /*usuario a transferir*/
                     UPDATE UsuarioMoneda
                     SET cantidad = cantidad + xCantidad
                     WHERE idMoneda = ObtenerIdMoneda(xnombre)
                     AND idUsuario = ObtenerIdUsuario(xemail);

                     INSERT INTO Historial ( idUsuario, idMoneda, cantidad, fechaHora, tipoAccion)
                     VALUES (ObtenerIdUsuario(xemail), ObtenerIdMoneda(xnombre), xcantidad, NOW(), 'Transferencia');
       ELSE   
              SIGNAL SQLSTATE '45000'
              SET MESSAGE_TEXT = "Usuario/Email NO encontrado!!";
       END IF;
END $$
