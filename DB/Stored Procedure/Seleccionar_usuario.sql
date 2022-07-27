SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Seleccionar_Usuario 
	-- Add the parameters for the stored procedure here
	@Email varchar(150)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Empleado.idEmpleado, Empleado.Nombre, Empleado.Apellido, Empleado.DNI, Empleado.NumCaja, Empleado.Puesto, Empleado.Email, Empleado.Pass, Empleado.Soft_Delete 
	FROM Empleado
	WHERE Empleado.Email = @Email AND Empleado.Soft_Delete = 1
END
GO
