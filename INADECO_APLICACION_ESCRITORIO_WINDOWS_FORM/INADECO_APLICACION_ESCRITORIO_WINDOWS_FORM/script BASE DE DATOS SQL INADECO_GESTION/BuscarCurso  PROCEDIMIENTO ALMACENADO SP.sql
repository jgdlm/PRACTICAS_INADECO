CREATE PROCEDURE BuscarCurso
@ID_CURSO nvarchar(50)
AS
SELECT *
FROM CURSOS
WHERE ID_CURSO LIKE '%' +@ID_CURSO+'%'

EXEC BuscarCurso '2021/1234'