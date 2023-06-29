USE BDSeguros
GO

/* Usuario Crea: LUIS.LLATAS
 Fecha:  29/06/2023  
 Descripción: Registrar afiliación
   
 Historial de Cambios  
 CODIGO  FECHA    DESARROLLADOR  DESCRIPCIÓN 
*/ 
CREATE PROCEDURE dbo.[FIN_RegistrarAfiliacion]
      @codigo_seg INT = 0 -- codigo de seguro
    , @codigo_per INT = 0 -- codigo de persona
AS  
BEGIN  
    DECLARE @trancount BIT = 0  
    DECLARE @codigo_afi INT = 0
    
    BEGIN TRY  
        IF @@TRANCOUNT = 0  
            BEGIN  
                BEGIN TRANSACTION  
                    SET @trancount = 1  
            END
            
           INSERT INTO FIN_Afiliacion (codigo_seg, codigo_per)
		     VALUES (@codigo_seg, @codigo_per)
           SET @codigo_afi = @@IDENTITY

        IF @trancount = 1  
            COMMIT  
            SELECT 'Registrado correctamente' AS rpta, @codigo_afi AS 'codigo_afi' 
            
  
    END TRY  
    BEGIN CATCH  
        IF @trancount = 1  
            ROLLBACK  
         SELECT 'error' AS rpta, -100 AS 'codigo_afi'
       
    END CATCH  
END  
