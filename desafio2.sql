create table clientes
(
	cpf varchar(11) primary key,
	Nome varchar(40),
	Telefone varchar(40),
	Email varchar(40)
);

insert into clientes
values ('215806556', 'Ciclado da Silva', '5584598520', 'cliclaninhu33@gmail.com');
insert into clientes
values ('684645684', '', null, 'rogerius18ao@pop.com.br');
insert into clientes
values ('5684341635', 'Alvares Junior', '558897456', 'alvares.junior@email.com');
insert into clientes
values ('564654688', 'Atilla Dulo', null, 'atilla_d@hunos.com');
insert into clientes
values ('0191954785',	NULL,	NULL,	NULL);


create table produtos
(
	CodEAN varchar(18) primary key,
	Nome varchar(40),
	preco float,
	estoque integer
);


insert into produtos
values ('215806556', 'massa de modelar', 0.55, 133);
insert into produtos
values ('1435346515413', '', 554, 8);
insert into produtos
values ('321423151', 'caixas de sapato', 1.77, 0);
insert into produtos
values ('3451134', 'porta pregos', 0.15, 55);
insert into produtos
values ('21433435654', 'pen drive', 66, 4);
insert into produtos
values ('569456526423', 'micro sd', 66, null);