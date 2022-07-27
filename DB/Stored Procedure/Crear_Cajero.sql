SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Crear_Cajero
	@Nom varchar(100),
	@Ape varchar(150),
	@DNI int,
	@Puesto varchar(50),
	@idS int,
	@Email varchar(150),
	@Pass varchar(200),
	@Delete tinyint, 
	@NumC int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert Empleado
	INSERT INTO Empleado
	(Nombre, Apellido, DNI, Puesto, idSuc, Email, Pass, Soft_Delete, NumCaja)
	VALUES
	(@Nom, @Ape, @DNI, @Puesto, @idS, @Email, @Pass, @Delete, @NumC)
END
GO
