USE Store;
GO

drop table if exists Products;
drop table if exists Categories;
drop table if exists ProductCategories;

create table Products(
	Id int identity,
	Desciption nvarchar(50),
	constraint PK_Products_Id primary key clustered (Id)
);

create table Categories(
	Id int identity,
	Desciption nvarchar(50),
	constraint PK_Categories_Id primary key clustered (Id)
);

create table ProductCategories(
	Id int identity,
	ProductId int,
	CategoryId int,
	constraint PK_ProductCategories_Id primary key clustered (Id),
	constraint FK_ProductCategories_Products_Id foreign key (ProductId) references Products (Id),
	constraint FK_ProductCategories_Categories_Id foreign key (CategoryId) references Categories (Id)
);