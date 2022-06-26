USE First
GO
--процедура, яка викликає створену функцію для всіх студентів і вставляє результат в таблицю Student
CREATE PROCEDURE University.Get_scholarship 
AS
BEGIN
UPDATE Student
SET scholarship = University.Scholarship(Student.student_ID , University.Count_scholarship_places())
END

--виконання процедури
EXECUTE University.Get_scholarship
GO
