USE BDSeguros
GO

/* Usuario Crea: LUIS.LLATAS
 Fecha:  29/06/2023  
 Descripción: Buscar seguro
   
 Historial de Cambios  
 CODIGO  FECHA    DESARROLLADOR  DESCRIPCIÓN 
*/  
 CREATE PROCEDURE [dbo].[FIN_Buscar_Seguro] 
 @codigo_seg INT = 0
AS  
BEGIN   

 SELECT codigo_seg, companiaAseguradora_seg, tipoSeguro_seg
       ,montoPrima_seg, moneda_seg, edadMaxPermitida_seg
	   ,fechaVigencia_seg, estado_seg, importeMensual_seg
	   ,cobertura_seg
	  FROM FIN_Seguro WITH(NOLOCK)
   WHERE ( codigo_seg = @codigo_seg OR @codigo_seg = 0 )
   AND Eliminado_AUD = 0
     
END 


