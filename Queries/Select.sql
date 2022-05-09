select 
	Products.*,
	Categories.*
from ProductCategories 
	full join Products on Products.Id = ProductCategories.ProductId
	full join Categories on Categories.Id = ProductCategories.CategoryId