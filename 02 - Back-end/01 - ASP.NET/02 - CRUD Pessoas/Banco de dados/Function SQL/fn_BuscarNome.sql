
CREATE FUNCTION fn_BuscarNome(@Nome Varchar(200))
RETURNS @Tpm TABLE(Codigo   Integer
                  ,Nome     Varchar(200)
				  ,Endereco Varchar(200)
				  ,Email    Varchar(30))
AS
BEGIN 
  INSERT INTO @Tpm (Codigo
                   ,Nome
				   ,Endereco
				   ,Email)
  SELECT Codigo
        ,Nome
		,Endereco
		,Email
  FROM dbo.Pessoas
  WHERE Nome LIKE '%' + @Nome + '%'

  RETURN;                    
END  

