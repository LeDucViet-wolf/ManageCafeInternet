CREATE DATABASE ManageCafeInternet
GO
USE ManageCafeInternet
GO
CREATE TABLE [food_type]
(
	entity_id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(255) NOT NULL 
)
GO
CREATE TABLE [area]
(
	entity_id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(255) NOT NULL,
	price FLOAT NOT NULL
)
GO
CREATE TABLE [role]
(
	entity_id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(255) NOT NULL
)
GO
CREATE TABLE [food]
(
	entity_id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(255) NOT NULL,
	price FLOAT NOT NULL,
	quantity INT NOT NULL,
	image VARCHAR(255) NOT NULL,
	food_type_id INT NOT NULL,
	FOREIGN KEY (food_type_id) REFERENCES [food_type](entity_id)
)
GO
CREATE TABLE [user]
(
	entity_id INT PRIMARY KEY IDENTITY,
	account VARCHAR(255) NOT NULL,
	password VARCHAR(255) NOT NULL,
	firstName NVARCHAR(255),
	lastName NVARCHAR(255) NOT NULL,
	role_id INT NOT NULL,
	FOREIGN KEY (role_id) REFERENCES [role](entity_id)
)
CREATE TABLE [computer]
(
	entity_id INT PRIMARY KEY IDENTITY,
	name VARCHAR(255) NOT NULL,
	status TINYINT NOT NULL,
	area_id INT NOT NULL,
	FOREIGN KEY (area_id) REFERENCES [area](entity_id)
)
GO
CREATE TABLE [computer_status]
(
	entity_id INT PRIMARY KEY IDENTITY,
	computer_id INT NOT NULL,
	start_time DATETIME NOT NULL,
	end_time DATETIME NOT NULL,
	food_id NVARCHAR(255)
)
GO
CREATE TABLE [order]
(
	entity_id INT PRIMARY KEY IDENTITY,
	computer_status_id INT NOT NULL,
	FOREIGN KEY (computer_status_id) REFERENCES [computer_status](entity_id)
)
GO 
INSERT INTO [role] VALUES
	(N'admin'),
	(N'vendor')
GO
INSERT INTO [user] VALUES
	(N'admin','1',N'Lê Đức',N'Việt',1),
	(N'vendor1','vendor1',N'Vendor',N'A',2)
GO 
INSERT INTO [food_type] VALUES
	(N'Đồ ăn'),
	(N'Đồ uống')
GO
INSERT INTO [food] VALUES
	(N'Mỳ tôm trứng', 20000, 10, '',1),
	(N'Sting đỏ', 15000, 20, '',2)
GO
INSERT INTO [area] VALUES
	(N'Khu hút thuốc',3000),
	(N'Khu bình dân', 5000),
	(N'Khu VIP', 7000),
	(N'Khu máy thi đấu', 10000)
GO
CREATE PROC [getUser]
@account VARCHAR(255), @password VARCHAR(255)
AS
SELECT * FROM [user] WHERE [user].account = @account AND [user].password = @password
GO
CREATE PROC [getAllFoods]
AS 
SELECT	[food].entity_id,
		[food].name AS 'Foods Name', 
		[food].price,
		[food].quantity,
		[food].image,
		[food].food_type_id,
		[food_type].name AS 'Foods Type'
FROM [food] 
LEFT JOIN [food_type] 
ON food.food_type_id = food_type.entity_id 
GO
CREATE PROC [addFood]
@name NVARCHAR(255), @price FLOAT, @quantity INT, @image VARCHAR(255), @foodTypeId INT
AS
INSERT INTO [food](name, price, quantity, image, food_type_id) VALUES (@name, @price, @quantity, @image, @foodTypeId)
GO
INSERT INTO [computer](name,status,area_id) VALUES
	('PC-01',0,1),
	('PC-02',0,1),
	('PC-03',0,2),
	('PC-04',0,2),
	('PC-05',0,3),
	('PC-06',0,3),
	('PC-07',0,4),
	('PC-08',0,4)
GO
CREATE PROC [getAllFoodTypes]
AS
SELECT	[food_type].entity_id AS 'food_type_id',
		[food_type].name	AS 'food_type_name'
FROM [food_type]
GO
CREATE PROC [updateFood]
@entity_id INT, @name NVARCHAR(255), @price FLOAT, @quantity INT, @image VARCHAR(255), @foodTypeId INT
AS
UPDATE [food] 
SET	name = @name, 
	price = @price,
	quantity = @quantity,
	image = @image,
	food_type_id = @foodTypeId
WHERE entity_id = @entity_id
GO					
CREATE PROC [deleteFood]
@entity_id INT
AS
DELETE [food] WHERE entity_id = @entity_id
GO
CREATE PROC [getAllAreas]
AS
SELECT	[area].entity_id AS 'area_id',
		[area].name	AS 'area_name'
FROM [area]
GO
CREATE PROC [getAllComputersFromArea]
@area_id INT 
AS
SELECT	[computer].entity_id AS 'Computer Id',
		[computer].name AS 'Computer Name',
		[area].name AS 'Area',
		[area].price,
		CASE WHEN [computer].status = 0 THEN 'Not using'
			 WHEN [computer].status = 1 THEN 'Using'
		END AS 'Computer Status'
FROM computer
JOIN area 
ON computer.area_id = area.entity_id
WHERE area.entity_id = @area_id
GO
CREATE PROC [getAllComputers]
AS
SELECT	[computer].entity_id AS 'Computer Id',
		[computer].name AS 'Computer Name',
		[area].name AS 'Area',
		[area].price,
		CASE WHEN [computer].status = 0 THEN 'Not using'
			 WHEN [computer].status = 1 THEN 'Using'
		END AS 'Computer Status'
FROM computer
JOIN area 
ON computer.area_id = area.entity_id
GO
CREATE PROC [addComputer]
@computer_name VARCHAR(255), @area_id INT
AS
INSERT INTO [computer](name,status,area_id) VALUES (@computer_name,0, @area_id)
GO
CREATE PROC [updateComputer]
@entity_id INT, @computer_name VARCHAR(255), @area_id INT
AS
UPDATE [computer] 
SET	name = @computer_name, 
	status = 0,
	area_id = @area_id
WHERE entity_id = @entity_id
GO		
CREATE PROC [deleteComputer]
@entity_id INT
AS
DELETE [computer] WHERE entity_id = @entity_id
GO
CREATE PROC [getAllRoles]
AS
SELECT	[role].entity_id AS 'role_id',
		[role].name AS 'role_name'
FROM [role]
GO
CREATE PROC [getUserFromRole]
@roleId INT
AS
SELECT	[role].entity_id AS 'role_id',
		[role].name AS 'role_name'
FROM [role]
WHERE [role].entity_id = @roleId
GO
CREATE PROC [addUser]
@account VARCHAR(255), @password VARCHAR(255), @firstName NVARCHAR(255), @lastName NVARCHAR(255), @roleId INT
AS
INSERT INTO [user](account,password,firstName,lastName,role_id) VALUES (@account,@password,@firstName,@password,@roleId)
GO
CREATE PROC [updateUser]
@userId INT, @account VARCHAR(255), @password VARCHAR(255), @firstName NVARCHAR(255), @lastName NVARCHAR(255), @roleId INT
AS
UPDATE [user] 
SET	account = @account,
	password = @password,
	firstName = @firstName,
	lastName = @lastName,
	role_id = @roleId
WHERE entity_id = @userId
GO
CREATE PROC [deleteUser]
@userId INT
AS 
DELETE [user] WHERE entity_id = @userId
GO
CREATE PROC [getAllUsersFromRole]
@role_id INT 
AS
SELECT	[user].entity_id,
		[user].account,
		[user].password,
		[user].firstName,
		[user].lastName,
		CASE WHEN [role].entity_id = 1 THEN 'Admin'
			 WHEN [role].entity_id = 2 THEN 'Vendor'
		END AS 'Role'
FROM [user]
JOIN [role] 
ON [user].role_id = [role].entity_id
WHERE [role].entity_id = @role_id
GO