SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Listar_NC_X_Empleado
	-- Add the parameters for the stored procedure here
	@idEmpleado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT NotaCredito.idNC, NotaCredito.NumeroDoc, NotaCredito.Fecha, NotaCredito.Monto 
	FROM NotaCredito, NC_Empleado 
	WHERE NotaCredito.idNC = NC_Empleado.idNotaCredito and NC_Empleado.idEmpleado = @idEmpleado;
END
GO