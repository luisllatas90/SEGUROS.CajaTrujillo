USE BDSeguros
GO

/* Usuario Crea: LUIS.LLATAS
 Fecha:  29/06/2023  
 Descripción: Buscar afiliación
   
 Historial de Cambios  
 CODIGO  FECHA    DESARROLLADOR  DESCRIPCIÓN 
*/  
 CREATE PROCEDURE [dbo].[FIN_Buscar_Afiliacion] 
 @busqueda VARCHAR(200) = ''
AS  
BEGIN   

 SELECT  
      af.codigo_afi, pe.codigo_per, pe.apellidoPaterno_per + ' ' + pe.apellidoMaterno_per + ', '+ pe.nombres_per persona
	 ,se.codigo_seg, se.companiaAseguradora_seg, se.tipoSeguro_seg
	 ,se.importeMensual_seg
	 ,se.moneda_seg
	 ,se.montoPrima_seg
	  FROM FIN_Afiliacion af WITH(NOLOCK)
	   INNER JOIN FIN_Persona pe WITH(NOLOCK) ON pe.codigo_per = af.codigo_per
	   INNER JOIN FIN_Seguro se WITH(NOLOCK) ON se.codigo_seg = af.codigo_seg
   WHERE ( pe.documentoIdentidad_per = @busqueda OR apellidoPaterno_per + ' ' +apellidoMaterno_per LIKE @busqueda )
     AND af.Eliminado_AUD = 0 AND pe.Eliminado_AUD = 0
	 AND se.Eliminado_AUD = 0

END 


