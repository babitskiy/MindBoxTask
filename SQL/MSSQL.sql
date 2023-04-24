use MindBoxTask

--создаём таблицу продуктов
CREATE TABLE Products 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

--создаём таблицу категорий
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

--создаём таблицу для связи многие ко многим
CREATE TABLE ProductCategories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id),
)

--заполняем таблицы
INSERT INTO Products (Title) VALUES ('Яблоко'), ('Груша'), ('Помидор'), ('Картошка'), ('Черешня'), ('Лук'), ('Малина'), ('Ручка'), ('Карандаш'), ('Арбуз')
INSERT INTO Categories (Title) VALUES ('Овощь'), ('Фрукт'), ('Ягода')
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 2), (2, 2), (3, 1), (4, 1), (5, 3), (6, 1), (7, 3), (8, NULL), (9, NULL), (10, 2), (10, 3)

--запрос к БД для вывода всех пар "Имя продукта -  Имя категории"
SELECT product.[Title],
    [Categories].[Title]
FROM [Products] AS product
    INNER JOIN [ProductCategories] ON [ProductCategories].ProductId = product.Id
    LEFT OUTER JOIN [Categories] ON [ProductCategories].CategoryId = [Categories].Id;