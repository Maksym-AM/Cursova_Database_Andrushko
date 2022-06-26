USE First;
GO

SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER prise_of_books
ON [University].[Issues_of_books]
AFTER INSERT , UPDATE
AS
IF ( 
	SELECT SUM(Book.price) 
	FROM Issues_of_books JOIN Book ON Issues_of_books.book_ID = Book.book_ID

	WHERE Issues_of_books.date_of_comeback IS NULL 
	AND Issues_of_books.student_ID = (SELECT inserted.student_ID FROM inserted))>200
	ROLLBACK TRAN
