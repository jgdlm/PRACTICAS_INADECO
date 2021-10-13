CREATE PROCEDURE cargarGridTodosDatos
AS
SELECT * FROM CURSOS
INNER JOIN ALUMNOS
ON CURSOS.DNI_ALUMNO = ALUMNOS.DNI_ALUMNO
INNER JOIN PROFESORES
ON CURSOS.DNI_PROFESOR = PROFESORES.DNI_PROFESOR
INNER JOIN AULAS
ON CURSOS.ID_AULA = AULAS.ID_AULA
EXEC cargarGridTodosDatos