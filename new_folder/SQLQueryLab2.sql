USE First
GO

--1)SELECT на основі однієї таблиці з використанням сортування за різними напрямами (ORDER BY), накладенням умов зі зв’язками OR та AND
SELECT * 
FROM [University].[Student] 
WHERE Student.place_in_rating > 10 AND Student.place_in_rating < 15
ORDER BY place_in_rating

--2)SELECT з виводом обчислюваних полів (виразів) в полях результату та з використанням псевдонімів полів
--SELECT з використанням групування даних та групової статистики (GROUP BY)
SELECT Groups.group_ID , COUNT(Student.group_ID) AS students_in_group
FROM University.Groups JOIN [University].[Student] ON Groups.group_ID = Student.group_ID
GROUP BY Student.group_ID, Groups.group_ID

--3)SELECT на основі двох таблиць з використанням поєднання типу INNER JOIN, накладенням умов зі зв’язками OR та AND
SELECT Student.student_ID, Student_grade.dsscipline_ID , Student_grade.grade FROM University.Student
INNER JOIN University.Student_grade ON Student.student_ID = Student_grade.student_ID
WHERE Student_grade.grade = 4 OR Student_grade.grade = 5
ORDER BY Student.student_ID ASC

--4)SELECT на основі кількох таблиць з типами поєднання FULL JOIN
SELECT * 
FROM University.Person 
FULL OUTER JOIN University.Student 
ON Person.passport_ID=Student.passport_ID
ORDER BY name, surname ASC

--5)SELECT з використанням в секції WHERE операторів IS NULL/ IS NOT NULL
SELECT *
FROM University.Student
WHERE Student.scholarship IS NOT NULL

--6)SELECT з використанням статистичних функцій (COUNT, SUM, AVG, MIN, MAX)
SELECT MAX(book_count) AS max_books, Book.book_ID
FROM University.Book
GROUP BY max_books

--7)SELECT з використанням фільтрування груп (HAVING)
SELECT Student_grade.grade, COUNT(Student_grade.grade) AS grades
FROM University.Student_grade 
GROUP BY grade
HAVING COUNT(Student_grade.grade)>15

--8)SELECT з використанням підзапитів в секції SELECT
SELECT Person.surname, (SELECT Student.place_in_rating FROM University.Student WHERE Student.passport_ID=Person.passport_ID) AS rating 
FROM University.Person
ORDER BY surname

--9)SELECT з використанням підзапитів в секції WHERE як операндів операторів IN, EXISTS, SOME, ALL, ANY
SELECT Teacher.name, Teacher.surname, Teacher.passport_ID AS ID 
FROM University.Teacher
WHERE Teacher.passport_ID = ANY (SELECT passport_ID FROM University.Teachers_disciplines)

--10)SELECT з використанням підзапитів в секції HAVING
--11)SELECT з використанням оператора CASE
SELECT student_ID,
      CASE scholarship
         WHEN '1300' THEN 'yes'  
         ELSE 'no'  
      END is_scholarship
FROM  University.Student

--12)SELECT з використанням оператора INTERSECT
SELECT * FROM University.Student  WHERE group_ID = 'ПМ11'      
INTERSECT
SELECT * FROM University.Student  WHERE scholarship IS NOT NULL


--13)SELECT з використанням оператора EXCEPT
SELECT * FROM University.Student  WHERE group_ID = 'ПМ11'      
EXCEPT
SELECT * FROM University.Student  WHERE scholarship IS NOT NULL

--14)SELECT з використанням оператора  UNION
SELECT Person.passport_ID, Person.name, Person.surname
   FROM University.Person
   UNION
   SELECT Teacher.passport_ID, Teacher.name, Teacher.surname
   FROM University.Teacher

--15)SELECT INTO для додавання даних з інших таблиць
SELECT * INTO University.Book_new FROM University.Book

--16)INSERT для додавання записів з явно вказаними значеннями
INSERT INTO University.Teacher(passport_ID, name, surname, scientist_degree) 
VALUES ('002641932 ','Володимир', 'Хоткевич', 'доцент')

--17)UPDATE на базі однієї таблиці
UPDATE University.Student
SET scholarship=1400
WHERE headmaster=1

--18)UPDATE на базі кількох таблиць
UPDATE University.Student
SET scholarship=scholarship-100
FROM University.Student_grade
WHERE Student_grade.grade=5

--19)DELETE для видалення вибраних записів таблиці
DELETE FROM University.Book
WHERE book_count<=5

--20)DELETE для видалення всіх даних з таблиці
DELETE FROM University.Issues_of_books



--індивідуальні завд
--1)список студентів з рейтингом від X до Y   
 SELECT p.name, p.surname, st.place_in_rating
 FROM University.Student st
	JOIN University.Person p ON st.passport_ID=p.passport_ID
	WHERE place_in_rating>=10 AND place_in_rating<=15
 ORDER BY place_in_rating

  --2)список студентів які не повернули книги з минулого року
 SELECT Person.name, Person.surname, COUNT(Issues_of_books.Student_ID) AS Count_of_books, SUM(Book.price) AS SUMA
 FROM University.Issues_of_books
	JOIN University.Student ON Student.student_ID=Issues_of_books.student_ID
	JOIN University.Person ON Student.passport_ID=Person.passport_ID
	JOIN University.Book ON Issues_of_books.book_ID=Book.book_ID
	WHERE University.Issues_of_books.date_of_comeback IS NULL
GROUP BY Issues_of_books.student_ID, Person.name, Person.surname

--3)довідка для студента про його рейтинг та розмір стипендії
 SELECT Person.name, Person.surname, Student.place_in_rating, Student.scholarship
 FROM University.Student
	JOIN University.Person ON Student.passport_ID=Person.passport_ID
	WHERE scholarship NOT LIKE '0%'
	ORDER BY place_in_rating

--4)звіт про успішність кожного студента заданої групи
SELECT Student.student_ID,
	(SELECT COUNT(Student_grade.grade) FROM University.Student_grade 
	WHERE grade = '5' AND Student.student_ID = Student_grade.student_ID ) vidminno,
	(SELECT COUNT(Student_grade.grade) FROM University.Student_grade 
	WHERE grade = '4' AND Student.student_ID = Student_grade.student_ID ) dobre,
	(SELECT COUNT(Student_grade.grade) FROM University.Student_grade 
	WHERE grade = '3' AND Student.student_ID = Student_grade.student_ID ) zadovilno,
	(SELECT COUNT(Student_grade.grade) FROM University.Student_grade 
	WHERE grade = '2' AND Student.student_ID = Student_grade.student_ID ) nezadovilno,
	(SELECT COUNT(Student_grade.grade) FROM University.Student_grade 
	WHERE Student.student_ID = Student_grade.student_ID ) grade_count
FROM University.Student
JOIN University.Student_grade ON Student.student_ID = Student_grade.student_ID
WHERE Student.group_ID = 'ПМ12'
GROUP BY Student.student_ID