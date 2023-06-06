use MindBoxTask

-- creating a Products table
CREATE TABLE Products 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

-- creating a Categories table
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

-- creating a ProductCategories table to implement the many-to-many connection
CREATE TABLE ProductCategories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id),
)

-- filling tables with values
INSERT INTO Products (Title) VALUES ('Product1'), ('Product2'), ('Product3'), ('Product4'), ('×Product5'), ('Product6'), ('Product7'), ('Product8'), ('Product9'), ('Product10')
INSERT INTO Categories (Title) VALUES ('Category1'), ('Category2'), ('Category3')
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 2), (2, 2), (3, 1), (4, 1), (5, 3), (6, 1), (7, 3), (8, NULL), (9, NULL), (10, 2), (10, 3)

-- selection of all pairs product name - category name
SELECT product.[Title],
    [Categories].[Title]
FROM [Products] AS product
    INNER JOIN [ProductCategories] ON [ProductCategories].ProductId = product.Id
    LEFT OUTER JOIN [Categories] ON [ProductCategories].CategoryId = [Categories].Id;
