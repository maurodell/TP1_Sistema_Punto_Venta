SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Asociar_Empleado_NC
	-- Add the parameters for the stored procedure here
    @idEmpleado int,
    @idNC int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO NC_Empleado (idNotaCredito, idEmpleado) 
	VALUES (@idNC, @idEmpleado)
END
GO
