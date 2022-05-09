select 
	Products.[Name] as ProductName,
	Categories.[Name] as CategoryName
from Products
	left join ProductCategories on Products.Id = ProductCategories.ProductId
	left join Categories on Categories.Id = ProductCategories.CategoryId