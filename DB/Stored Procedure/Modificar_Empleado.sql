SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Cajero_Modificar
	@idEmpleado int,
	@Nom varchar(100),
	@Ape varchar(150),
	@DNI int,
	@Puesto varchar(50),
	@idS int,
	@Email varchar(150),
	@Pass varchar(200),
	@NumC int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Actualizar Empleado
	UPDATE Empleado SET
					Nombre = @Nom,
					Apellido = @Ape,
					DNI = @DNI, 
					Puesto = @Puesto, 
					idSuc = @idS, 
					Email = @Email, 
					Pass = @Pass, 
					NumCaja = @NumC
	WHERE idEmpleado = @idEmpleado

END
GO
