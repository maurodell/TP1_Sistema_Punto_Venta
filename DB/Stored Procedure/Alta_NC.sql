SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Alta_NC 
	-- Add the parameters for the stored procedure here
	@Numero_doc int,
    @Fecha date,
    @Monto decimal
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO NotaCredito
	(NumeroDoc, Fecha, Monto)
	VALUES
	(@Numero_doc, @Fecha, @Monto)
END
GO
