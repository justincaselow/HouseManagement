SET QUOTED_IDENTIFIER OFF;
GO

USE [HouseManagement];
GO

/*
	People
*/

IF NOT EXISTS (SELECT 1 FROM People WHERE Name = 'Justin Low')
	INSERT INTO People (Name) VALUES ('Justin Low')

IF NOT EXISTS (SELECT 1 FROM People WHERE Name = 'Jack Low')
	INSERT INTO People (Name) VALUES ('Jack Low')

IF NOT EXISTS (SELECT 1 FROM People WHERE Name = 'Erica Lacey')
	INSERT INTO People (Name) VALUES ('Erica Lacey')

/*
	Item Types
*/
IF NOT EXISTS (SELECT 1 FROM ItemTypes WHERE Description = 'Cleaning')
	INSERT INTO ItemTypes (Description) VALUES ('Cleaning')

IF NOT EXISTS (SELECT 1 FROM ItemTypes WHERE Description = 'Electrical')
	INSERT INTO ItemTypes (Description) VALUES ('Electrical')

IF NOT EXISTS (SELECT 1 FROM ItemTypes WHERE Description = 'Maintenance')
	INSERT INTO ItemTypes (Description) VALUES ('Maintenance')

IF NOT EXISTS (SELECT 1 FROM ItemTypes WHERE Description = 'Security')
	INSERT INTO ItemTypes (Description) VALUES ('Security')