USE First;
GO

SELECT *
FROM University.Teacher

INSERT INTO University.Book(book_ID, title, author, price, book_count)
VALUES('1228', 'Мат_статистика', 'Андрій', '41','5')

SELECT *
FROM University.Discipline

INSERT INTO University.Discipline(discipline_ID, name)
VALUES('05', 'Мат_статистика')