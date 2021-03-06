USE [DBTp2]
GO
/****** Object:  StoredProcedure [dbo].[Listar_Empleado_Todos]    Script Date: 11/06/2022 14:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Listar_Empleado_Todos]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Empleado.idEmpleado, Empleado.Nombre, Empleado.Apellido, Empleado.DNI, Empleado.NumCaja, Empleado.Puesto, Empleado.Email, Empleado.Pass, Empleado.Soft_Delete, Sucursal.idSuc, Sucursal.Telefono, Sucursal.Direccion 
	FROM Empleado, Sucursal
	WHERE Empleado.idSuc = Sucursal.idSuc
END
