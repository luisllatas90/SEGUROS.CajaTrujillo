USE BDSeguros
GO
--INSERT PERSONA
INSERT INTO FIN_Persona (nombres_per, apellidoPaterno_per, apellidoMaterno_per, documentoIdentidad_per)
VALUES('LUIS','LLATAS','YOVERA','46277166')
     ,('MARIA','VEGA','JIMENEZ','76217166')
	 ,('JUAN', 'PEREZ','RODRIGUEZ','12257161')
     ,('IRIS', 'ESPINOZA','MEJIA','75161289')

--INSERT SEGUROS
INSERT INTO FIN_Seguro(companiaAseguradora_seg, tipoSeguro_seg,factorImpuesto_seg,porcentajeComision_seg,montoPrima_seg,moneda_seg,edadMaxPermitida_seg,fechaVigencia_seg,estado_seg,importeMensual_seg,cobertura_seg)
VALUES('PACIFICO','SEPELIO',4.00,20.00,100.00,'S',65,'31/12/2025','A',20.00,'Muerte por accidentes o de forma natural')
     ,('PACIFICO','ONCOLOGICO',5.00,30.00,200.00,'S',67,'31/12/2025','A',20.00,'Tratamientos de quimioterapia y otros procedimientos médicos')
    