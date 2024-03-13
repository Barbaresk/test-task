select p.[name] as N'Имя продукта', ISNULL(c.[name], N'-') as N'Имя категории' from [test_strelets].[products] as p 
	left join [test_strelets].[product_categories] as pc on p.[id] = pc.[product_id]
	left join [test_strelets].[categories] as c on pc.[category_id] = c.[id]