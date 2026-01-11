create table tbl_Atendente(
	cd_Atendente int primary key identity,
	ds_Login varchar(20) not null,
	ds_Senha char(8) not null,
	nm_Atendente varchar(60) not null
)

use db_livraria

insert into tbl_Atendente(
	ds_Login,
	ds_Senha,
	nm_Atendente) 
VALUES
	('Felipe', '123lol', 'Felipe Santos')

	select * from tbl_Atendente

create table tbl_Cliente(
	cd_Cliente int primary key Identity,
	nm_Cliente varchar(60) not null,
	ds_Email varchar(60) not null,
	no_CPF char(11) null,
	no_CNPJ char(14) null,
	nm_Logradouro varchar(60) not null,
	no_Logradouro varchar(5) not null,
	ds_Complemento varchar(20) null,
	nm_Bairro varchar(20) not null,
	nm_Cidade varchar(20) not null,
	sg_UF char(2) not null,
	no_CEP char(8)
)

create table tbl_Telefone (
	cd_Cliente int,
	no_Telefone char(11)
	primary key (cd_Cliente,no_Telefone)
	foreign key (cd_Cliente) references tbl_Cliente(cd_Cliente)
)

select * from tbl_Telefone