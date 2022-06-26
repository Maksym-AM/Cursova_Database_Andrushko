USE First
GO

ALTER TABLE [University].[Book]
WITH CHECK ADD CHECK (price >= 0 AND price <= 100)
GO

ALTER TABLE [University].[Issues_of_books]
WITH CHECK ADD CHECK (date_of_issues <= GETDATE())
GO

ALTER TABLE [University].[Person]
ADD CONSTRAINT marital_status_def 
DEFAULT ('No') FOR marital_status
GO

ALTER TABLE [University].[Student]
ADD UNIQUE ( place_in_rating ASC )
GO