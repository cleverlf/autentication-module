create database projetoestoque;
use projetoestoque;

create table nivel(
	id int primary key identity(1,1) not null,
	nome varchar(80) not null
);

insert into nivel values('admin'),('user');

select * from nivel;

update nivel set nome='test1' where nome = 'test';

create table register(
	id int primary key identity(1,1) not null,
	name varchar(50) not null,
	surname varchar(70) not null,
	login varchar(70) not null,
	password varchar(50) not null,
	id_nivel int not null,
	foreign key (id_nivel) references nivel(id)
);

select r.name, r.surname, r.login, r.password, n.nome from register as r
inner join nivel as n
on r.id_nivel = n.id;

insert into nivel values ((select name from register where id = 1));
