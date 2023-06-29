USE BDSeguros
GO

/* Usuario Crea: LUIS.LLATAS
 Fecha:  29/06/2023  
 Descripción: Buscar cliente
   
 Historial de Cambios  
 CODIGO  FECHA    DESARROLLADOR  DESCRIPCIÓN 
*/  
 CREATE PROCEDURE [dbo].[FIN_Buscar_Cliente] 
 @busqueda VARCHAR(200) = ''
AS  
BEGIN   

 SELECT codigo_per, apellidoPaterno_per +' '+apellidoMaterno_per+', '+nombres_per persona FROM FIN_Persona WITH(NOLOCK)
   WHERE ( documentoIdentidad_per = @busqueda OR apellidoPaterno_per + ' ' +apellidoMaterno_per LIKE @busqueda )
   AND Eliminado_AUD = 0
     
END 

