USE [DBTp2]
GO
/****** Object:  StoredProcedure [dbo].[Listar_X_Apellido]    Script Date: 12/06/2022 21:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Listar_X_Apellido] 
	@Apellido varchar(150)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Empleado.idEmpleado, Empleado.Nombre, Empleado.Apellido, Empleado.DNI, Empleado.NumCaja, Empleado.Puesto, Empleado.Email, Empleado.Pass, Empleado.Soft_Delete, Sucursal.idSuc, Sucursal.Telefono, Sucursal.Direccion 
	FROM Empleado, Sucursal
	WHERE Empleado.idSuc = Sucursal.idSuc AND Empleado.Apellido = @Apellido AND Empleado.Soft_Delete = 1
END
