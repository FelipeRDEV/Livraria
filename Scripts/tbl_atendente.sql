create table tbl_Atendente(
	cd_Atendente int primary key identity,
	ds_Login varchar(20) not null,
	ds_Senha char(8) not null,
	nm_Atendente varchar(60) not null
)

drop table tbl_Atendente