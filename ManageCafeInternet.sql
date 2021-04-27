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
	price FLOAT NOT NULL,
	price_turn_on FLOAT NOT NULL
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
	start_time DATETIME,
	end_time DATETIME
)
GO
CREATE TABLE [order]
(
	entity_id INT PRIMARY KEY IDENTITY,
	computer_status_id INT NOT NULL,
	FOREIGN KEY (computer_status_id) REFERENCES [computer_status](entity_id)
)
GO 
CREATE TABLE [foods_ordered]
(
	computer_id INT NOT NULL,
	food_id INT NOT NULL,
	qty INT NOT NULL,
	computer_status_id INT NOT NULL,
	FOREIGN KEY (food_id) REFERENCES [food](entity_id)
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
	(N'Mỳ tôm trứng', 20000, 10,1),
	(N'Sting đỏ', 15000, 20,2)
GO
INSERT INTO [area] VALUES
	(N'Khu hút thuốc',3000,1000),
	(N'Khu bình dân', 5000,2000),
	(N'Khu VIP', 7000,3000),
	(N'Khu máy thi đấu', 10000,4000)
GO
CREATE PROC [getUser]
@account VARCHAR(255), @password VARCHAR(255)
AS
SELECT * FROM [user] WHERE [user].account = @account AND [user].password = @password
GO
CREATE PROC [getAllFoods]
AS 
SELECT	[food].entity_id,
		[food].name, 
		[food].price,
		[food].quantity,
		[food].food_type_id,
		[food_type].name AS 'type'
FROM [food] 
LEFT JOIN [food_type] 
ON food.food_type_id = food_type.entity_id 
GO
CREATE PROC [addFood]
@name NVARCHAR(255), @price FLOAT, @quantity INT, @foodTypeId INT
AS
INSERT INTO [food](name, price, quantity, food_type_id) VALUES (@name, @price, @quantity, @foodTypeId)
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
@entity_id INT, @name NVARCHAR(255), @price FLOAT, @quantity INT, @foodTypeId INT
AS
UPDATE [food] 
SET	name = @name, 
	price = @price,
	quantity = @quantity,
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
SELECT	[computer].entity_id, 
		[computer].name, 
		[area].price, 
		[area].price_turn_on, 
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
SELECT	[computer].entity_id, 
		[computer].name, 
		[area].price, 
		[area].price_turn_on, 
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
CREATE PROC [updateComputerStatus]
@computer_id INT
AS
UPDATE [computer] SET status = 1
WHERE entity_id = @computer_id
GO
CREATE PROC [updateComputerStartTime]
@computer_id INT, @start_time DATETIME
AS
INSERT INTO [computer_status](computer_id, start_time) VALUES (@computer_id, @start_time)
GO
CREATE PROC [updateFoodQuantity]
@foodId INT, @quanity INT
AS
UPDATE [food]
SET quantity = @quanity
WHERE entity_id = @foodId
GO
CREATE PROC [getComputerStatusId]
@computerId INT
AS
SELECT [computer_status].entity_id
FROM [computer_status]
WHERE [computer_status].computer_id = @computerId
AND [computer_status].end_time IS NULL
GO
CREATE PROC [getSelectedFoodsByComputerId]
@computerId INT, @computerStatusId INT
AS
SELECT	[foods_ordered].food_id,
		[food].name,
		[foods_ordered].qty,
		[food].price,
		([foods_ordered].qty * [food].price) AS 'total_row'
FROM [foods_ordered]
JOIN [food]
ON [foods_ordered].food_id = [food].entity_id
WHERE [foods_ordered].computer_id = @computerId AND [foods_ordered].computer_status_id = @computerStatusId
GO
CREATE PROC [addSelectedFoods]
@foodId INT, @qty INT, @computerId INT, @computerStatusId INT
AS
IF EXISTS (SELECT * FROM [foods_ordered] WHERE [foods_ordered].food_id = @foodId AND [foods_ordered].computer_status_id = @computerStatusId AND [foods_ordered].computer_id = @computerId)
BEGIN
	UPDATE [foods_ordered] SET qty += @qty WHERE food_id = @foodId
END 
ELSE 
BEGIN
	INSERT INTO [foods_ordered] (food_id,qty,computer_id,computer_status_id) VALUES (@foodId, @qty, @computerId, @computerStatusId)
END
GO
CREATE PROC [getComputerToCheckout]
@computerId INT
AS
SELECT TOP(1) [computer_status].entity_id FROM [computer_status] WHERE [computer_status].end_time IS NULL AND [computer_status].computer_id = @computerId ORDER BY [computer_status].start_time DESC
GO
CREATE PROC [checkoutComputer]
@endTime DATETIME, @computerId INT
AS
BEGIN
UPDATE [computer_status] 
SET [computer_status].end_time = @endTime
WHERE [computer_status].entity_id = (SELECT TOP(1) [computer_status].entity_id FROM [computer_status] WHERE [computer_status].end_time IS NULL AND [computer_status].computer_id = @computerId ORDER BY [computer_status].start_time DESC)
END
GO
CREATE PROC [updateComputerStatusTurnOff]
@computerId INT
AS 
UPDATE [computer]
SET status = 0
WHERE entity_id = @computerId
GO
CREATE PROC [selectedFoodsToOrder]
(@computerId INT, @computerStatusId INT)
AS
DECLARE @foodsPrice FLOAT
IF EXISTS (SELECT [foods_ordered].food_id,[food].name,[foods_ordered].qty,[food].price FROM [foods_ordered] JOIN [food] ON [foods_ordered].food_id = [food].entity_id WHERE [foods_ordered].computer_id = @computerId AND [foods_ordered].computer_status_id = @computerStatusId)
BEGIN
	SET @foodsPrice = (SELECT SUM([foods_ordered].qty * [food].price) FROM [foods_ordered] JOIN [food] ON [foods_ordered].food_id = [food].entity_id WHERE [foods_ordered].computer_id = @computerId AND [foods_ordered].computer_status_id = @computerStatusId)
END
ELSE
BEGIN
	SET @foodsPrice = 0
END
RETURN @foodsPrice
GO
CREATE PROC [useTimeToOrder]
@computerId INT
AS
DECLARE @timeUse INT, @useTimePrice FLOAT;
SET @timeUse = (SELECT DATEDIFF(MINUTE,[computer_status].start_time,[computer_status].end_time) FROM [computer_status] WHERE [computer_status].entity_id = (SELECT TOP(1) [computer_status].entity_id FROM [computer_status] WHERE [computer_status].computer_id = @computerId AND [computer_status].end_time IS NOT NULL ORDER BY [computer_status].entity_id DESC));
IF @timeUse < 15
BEGIN
	SET @useTimePrice =		(SELECT [area].price_turn_on 
							FROM [computer_status] JOIN [computer] ON [computer].entity_id = [computer_status].computer_id 
							JOIN [area] ON [area].entity_id = [computer].area_id
							WHERE [computer_status].entity_id =		(
																	SELECT TOP(1) [computer_status].entity_id 
																	FROM [computer_status] 
																	WHERE [computer_status].computer_id = @computerId 
																	AND [computer_status].end_time IS NOT NULL 
																	ORDER BY [computer_status].entity_id DESC)
																	)
END 
ELSE 
BEGIN
	SET @useTimePrice =		(SELECT ROUND([area].price * @timeUse/60, 0) 
							FROM [computer_status] JOIN [computer] ON [computer].entity_id = [computer_status].computer_id 
							JOIN [area] ON [area].entity_id = [computer].area_id
							WHERE [computer_status].entity_id =		(
																	SELECT TOP(1) [computer_status].entity_id 
																	FROM [computer_status] 
																	WHERE [computer_status].computer_id = @computerId 
																	AND [computer_status].end_time IS NOT NULL 
																	ORDER BY [computer_status].entity_id DESC)
																	)
END
RETURN @useTimePrice
GO
CREATE PROC [useTime]
@computerId INT
AS
SELECT [computer_status].start_time,[computer_status].end_time, [area].price, [area].price_turn_on 
FROM [computer_status] 
JOIN [computer] ON [computer_status].computer_id = [computer].entity_id
JOIN [area] ON [computer].area_id = [area].entity_id
WHERE [computer_status].entity_id =		(
																	SELECT TOP(1) [computer_status].entity_id 
																	FROM [computer_status] 
																	WHERE [computer_status].computer_id = @computerId 
																	AND [computer_status].end_time IS NOT NULL 
																	ORDER BY [computer_status].entity_id DESC)
GO
CREATE PROC [searchComputerName]
@name VARCHAR(255), @areaId INT
AS
SELECT	[computer].entity_id, 
		[computer].name, 
		[area].price, 
		[area].price_turn_on, 
		CASE WHEN [computer].status = 0 THEN 'Not using'
			 WHEN [computer].status = 1 THEN 'Using'
		END AS 'Computer Status'
FROM [computer] 
JOIN [area] ON [computer].area_id = [area].entity_id
WHERE [computer].name LIKE '%' + @name + '%' AND [computer].area_id = @areaId
GO
CREATE PROC [getAllAreasAdmin]
AS
SELECT * FROM [area]
GO
CREATE PROC [addArea]
@name NVARCHAR(255), @price FLOAT, @price_turn_on FLOAT
AS
INSERT INTO [area] VALUES (@name, @price, @price_turn_on)
GO
CREATE PROC [updateArea]
@areaId INT, @name NVARCHAR(255), @price FLOAT, @price_turn_on FLOAT
AS
UPDATE [area]
SET	name = @name, price = @price, price_turn_on = @price_turn_on
WHERE entity_id = @areaId
GO
CREATE PROC [deleteArea]
@areaId INT
AS
DELETE [area] WHERE entity_id = @areaId
GO
CREATE PROC [deleteComputerByArea]
@areaId INT
AS
DELETE [computer] WHERE [computer].area_id = @areaId
GO
CREATE PROC [saveToOrder]
@computerStatusId INT
AS
INSERT INTO [order] VALUES (@computerStatusId)