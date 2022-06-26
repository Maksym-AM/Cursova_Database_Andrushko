USE First;
GO

SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER room
ON University.Student
AFTER INSERT , UPDATE
AS
IF ( 
	SELECT COUNT(Student.student_ID) 
	FROM Student 
	WHERE Student.dorm_room = (SELECT inserted.dorm_room FROM inserted))>3
	ROLLBACK TRAN

