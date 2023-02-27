create database dbformindbox;
create table Products(
Id int primary key,
Name nvarchar(255)
);
insert into Products values('bread'),('iphone x'),('samsunga52');
create table Category(
Id int primary key,
Name nvarchar(255)
);
insert into Category values('Food'),('Smartphone');
create table ProdCat(
ProductsId int,
CategoryId int,
foreign key(ProductsId) references Products(id) on delete cascade,
foreign key(CategoryId) references Category(id) on delete cascade
);
create unique index prod_cat on ProdCat(ProductsId, CategoryId);
insert into ProdCat values(1, 1), (2, 2), (3, 2);
select p.Name, c.Name
from Products as p
left join ProdCat pc
	on p.Id = pc.ProductsId
left join Category c
	on pc.CategoryId = c.Id;