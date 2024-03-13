create schema [test_strelets]
go

--делаем некоторые предположения об ограничениях в длине названия и орписания товара
create table [test_strelets].[products](
	[id] INT PRIMARY KEY,
	[name] NVARCHAR(200) NOT NULL,
	[description] NVARCHAR(1000)
)

--такие же предположения о категории
create table [test_strelets].[categories](
	[id] INT PRIMARY KEY,
	[name] NVARCHAR(200) NOT NULL,
	[description] NVARCHAR(500)
)

--делаем составной первичный ключ из двух внешних ключей,
--предполагая, что нам не нужно по каким-то причинам
--дважды иметь один и тот же товар в одной и той же категории
create table [test_strelets].[product_categories](
	[product_id] INT REFERENCES [test_strelets].[products],
	[category_id] INT REFERENCES [test_strelets].[categories],
	PRIMARY KEY([product_id], [category_id])
)

insert into [test_strelets].[products] values 
	(1, N'Кока-кола 0.5л', null),
	(2, N'Чупа-чупс', null),
	(3, N'Чипсы Lays 100g', null),
	(4, N'Фруто-няня, 250г', null)

insert into [test_strelets].[categories] values
	(1, N'Газировка', 'разная шипучка'),
	(2, N'Не полезное питание', 'всякое вкусное'),
	(3, N'Снеки', null),
	(4, N'Соки', null)

insert into [test_strelets].[product_categories] values
	(1, 1), (1, 2),  --кола в 1 и 2 кат
	(2, 2),          --чупс в 2 кат
	(3, 2), (3, 3)   --лэйс в 2 и 3 кат
