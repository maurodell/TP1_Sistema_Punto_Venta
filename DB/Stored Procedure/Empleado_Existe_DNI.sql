SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Empleado_Existe_DNI
	@DNI int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- SELECT COUNT(idCard) FROM Cliente WHERE idCard = " + pObjeto.Codigo + ""
	SELECT COUNT(idEmpleado)
	FROM Empleado
	WHERE idEmpleado = @DNI
END
GO
