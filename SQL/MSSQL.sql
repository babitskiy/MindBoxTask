use MindBoxTask

--������ ������� ���������
CREATE TABLE Products 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

--������ ������� ���������
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

--������ ������� ��� ����� ������ �� ������
CREATE TABLE ProductCategories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id),
)

--��������� �������
INSERT INTO Products (Title) VALUES ('������'), ('�����'), ('�������'), ('��������'), ('�������'), ('���'), ('������'), ('�����'), ('��������'), ('�����')
INSERT INTO Categories (Title) VALUES ('�����'), ('�����'), ('�����')
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 2), (2, 2), (3, 1), (4, 1), (5, 3), (6, 1), (7, 3), (8, NULL), (9, NULL), (10, 2), (10, 3)

--������ � �� ��� ������ ���� ��� "��� �������� -  ��� ���������"
SELECT product.[Title],
    [Categories].[Title]
FROM [Products] AS product
    INNER JOIN [ProductCategories] ON [ProductCategories].ProductId = product.Id
    LEFT OUTER JOIN [Categories] ON [ProductCategories].CategoryId = [Categories].Id;