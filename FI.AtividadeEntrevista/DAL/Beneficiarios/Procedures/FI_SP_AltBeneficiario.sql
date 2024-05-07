CREATE PROC FI_SP_AltBeneficiario
	@Id            BIGINT,
    @NOME          VARCHAR (50) ,
    @CPF           VARCHAR (11)
AS
BEGIN
	UPDATE BENEFICIARIOS
	SET 
		NOME = @NOME, 
		CPF = @CPF
	WHERE Id = @Id
END