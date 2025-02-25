-- criar banco
create database loja; 
go

use loja;
go

create table Categoria 
(
	Id			int not null identity primary key,
	Nome		varchar(50) not null unique,
	Foto		varchar(200),
	ExibirHome  bit
);

create table Produto
(
	Id			int not null identity primary key,
	Nome		varchar(100) not null,
	Descricao	varchar(1000),
	CategoriaId	int not null,
	ValorCusto	numeric(10,2),
	ValorVenda	numeric(10,2) not null,
	QtdeEstoque int not null default 0,
	Destaque	bit default 0,
	Foreign key	(CategoriaId) references Categoria(Id)

);

create table ProdutoFoto
(
	Id			int not null identity primary key,
	ProdutoId	int not null,
	Foto		varchar(200) not null,
	Descricao	varchar(100)
	foreign key (ProdutoId) references Produto(Id)

);
