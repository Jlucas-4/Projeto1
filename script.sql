-- Criando Banco de Dados
create DATABASE bdExemplo;
use bdExemplo;

create TABLE Usuarios(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null
);

select * from Usuarios;