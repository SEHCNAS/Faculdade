/* 1 - criação da tabela */
create table cadastro(
	nome varchar2(30),
    sobrenome varchar2(30),
    salario number(10,2),
    endereco varchar2(30),
    dt_cadastro date  
);

/* 1 - insert dos registros */
insert into cadastro values ('Marcelo', 'Diniz', 1000,'Piracema 100', sysdate);
insert into cadastro values ('Fernando', 'Romero', 2000,'Correia 100', sysdate);
insert into cadastro values ('Carlos', 'Martins', 2500,'Siria 100', sysdate);
insert into cadastro values ('Miguel', 'Carmim', 4000,'Piaiu 100', sysdate);
insert into cadastro values ('Camila', 'Pacheco', 8000,'Sao Jorge 84', sysdate);
insert into cadastro values ('Marina', 'Augusto', 1400,'Nova Tatuape 100', sysdate);
insert into cadastro values ('Roberto', 'Eduardo', 800,'Jurubatuba 505', sysdate);
insert into cadastro values ('Eduardo', 'Gomes', 1000,'Estrela 14', sysdate);
insert into cadastro values ('Mario', 'Temer', 3500, 'Moreira 10', sysdate);
insert into cadastro values ('Marcelo', 'Juracyr', 7350, 'Santa Elvira 100', sysdate);

/* 2 -  Selecionar todos os registros da tabela cadastro.*/
select * from cadastro;

/*3-) Retornar todos os registros da tabela somente com as colunas nome e sobrenome*/
select nome, sobrenome from cadastro;

/*4-) Retornar todos os registros da tabela cadastro, referentes aos funcionários Marina e
Eduardo.*/
select * from cadastro where nome in ('Marina', 'Eduardo');

/*5-) Retornar todos os registros da tabela com um cálculo de quanto os funcionários ganham
em um ano de trabalho. Criar um apelido para a coluna de “ANUAL”.*/
select nome, sobrenome, salario * 12 as ANUAL, endereco, dt_cadastro from cadastro;

/*6-) Selecionar as colunas nome e sobrenome da tabela cadastro e simular um aumento no
salário de 10%, colocando um apelido na coluna com o nome de "AUMENTO"*/
select nome, sobrenome, salario * 1.1 as AUMENTO from cadastro;

/*7-) Selecionar todos os funcionários que ganham entre 4000 e 5000.*/
select * from cadastro WHERE SALARIO BETWEEN 4000 AND 5000;

/*8-) Selecionar todos os funcionários que possuem o salário maior e igual a 4000.*/
select * from cadastro WHERE SALARIO >= 4000;

/*9-) Retornar os salários iguais a 4000 e 8000.*/
select * from cadastro WHERE SALARIO IN (4000,8000);

/*10-) Selecionar todos os funcionários que possuem a letra “a” no nome.*/
select * from cadastro WHERE upper(NOME) LIKE upper('%a%');

/*11-) Selecionar todos os funcionários que comecem com a letra “M”.*/
select * from cadastro WHERE upper(NOME) LIKE upper('m%');

/*12-) Retornar todos os funcionários que tenham o nome Marcelo.*/
select * from cadastro WHERE upper(NOME) = upper('marcelo');

/*13-) Retornar todos os registros das colunas nome e sobrenome com exceção dos funcionários
Carlos e Fernando.*/
select * from cadastro WHERE upper(nome) not IN (upper('Carlos'),upper('Fernando'));

/*14-) Selecionar todos os registros onde o salário seja diferente de 1000*/
select * from cadastro WHERE not SALARIO = 1000;