USE First
GO
--���������, ��� ������� �������� ������� ��� ��� �������� � �������� ��������� � ������� Student
CREATE PROCEDURE University.Get_scholarship 
AS
BEGIN
UPDATE Student
SET scholarship = University.Scholarship(Student.student_ID , University.Count_scholarship_places())
END

--��������� ���������
EXECUTE University.Get_scholarship
GO
