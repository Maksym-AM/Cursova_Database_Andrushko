USE First;
GO

--функція нарахування стипендії
CREATE FUNCTION University.Scholarship(@student_ID NCHAR(10) , @places INT)
RETURNS MONEY   
BEGIN
	DECLARE @stipend MONEY
	SELECT @stipend = 1300
	FROM University.Student
	WHERE Student.place_in_rating <= @places*0.45 AND Student.student_ID = @student_ID
RETURN @stipend
END

