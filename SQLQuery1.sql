ALTER PROC PridetiVartotoja
@vartotojoVardas nchar(20),
@slaptazodis nchar(35)
AS
	INSERT INTO Vartotojai(vartotojoVardas, slaptazodis)
	VALUES (@vartotojoVardas, @slaptazodis)