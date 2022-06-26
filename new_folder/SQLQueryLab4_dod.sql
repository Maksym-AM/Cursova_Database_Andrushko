ALTER TABLE University.Issues_of_books
ADD UCR VARCHAR(50) DEFAULT NULL,
	DCR DATETIME DEFAULT NULL,
	ULC VARCHAR(50) DEFAULT NULL,
	DLC DATETIME DEFAULT NULL
GO

CREATE OR ALTER TRIGGER Book_Insert ON University.Issues_of_books AFTER INSERT AS
BEGIN
	UPDATE University.Issues_of_books 
	SET UCR = SUSER_NAME(), DCR = GETDATE() 
	WHERE Issues_of_books.student_ID = (SELECT inserted.student_ID FROM inserted)
END
GO

CREATE OR ALTER TRIGGER Book_Update ON University.Issues_of_books AFTER UPDATE AS
BEGIN
	UPDATE University.Issues_of_books 
	SET ULC = SUSER_NAME(), DLC = GETDATE() 
	WHERE Issues_of_books.student_ID = (SELECT inserted.student_ID FROM inserted)
END
GO
DROP TRIGGER University.Book_Insert
DROP TRIGGER University.Book_Update