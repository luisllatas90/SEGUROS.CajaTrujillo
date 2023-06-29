USE BDSeguros
GO

/* Usuario Crea: LUIS.LLATAS
 Fecha:  29/06/2023  
 Descripción: Registrar pago
   
 Historial de Cambios  
 CODIGO  FECHA    DESARROLLADOR  DESCRIPCIÓN 
*/ 
CREATE PROCEDURE dbo.[FIN_RegistrarPago]
      @codigo_seg INT = 0 -- codigo de seguro
    , @montoPagar DECIMAL(10,2) = 0.00 -- monto a pagar
	, @mesPago INT = 0 -- mes de pago
	, @anioPago INT = 0 -- anio de pago
AS
BEGIN  
    DECLARE @trancount BIT = 0  
    DECLARE @codigo_pag INT = 0
    
    BEGIN TRY  
        IF @@TRANCOUNT = 0  
            BEGIN  
                BEGIN TRANSACTION  
                    SET @trancount = 1  
            END
            
           INSERT INTO FIN_Pago(codigo_seg, montoPagar_pag, mesPago_pag, anioPago_pag)
		     VALUES (@codigo_seg, @montoPagar, @mesPago, @anioPago)
           SET @codigo_pag = @@IDENTITY

        IF @trancount = 1  
            COMMIT  
            SELECT 'Registrado correctamente' AS rpta, @codigo_pag AS 'codigo_pag' 
            
 
    END TRY  
    BEGIN CATCH  
        IF @trancount = 1  
            ROLLBACK  
         SELECT 'error' AS rpta, -100 AS 'codigo_pag'
       
    END CATCH  
END  
