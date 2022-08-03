create database projetoestoque;
use projetoestoque;

create table nivel(
	id int primary key identity(1,1) not null,
	nome varchar(80) not null
);

insert into nivel values('admin'),('user');

select * from nivel;

update nivel set nome='test1' where nome = 'test';
	