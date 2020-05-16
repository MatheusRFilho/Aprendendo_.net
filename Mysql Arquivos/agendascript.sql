CREATE DATABASE agendaScript;
use agendaScript;

create table tipotelefone(
tte_codigo int primary key auto_increment,
tte_descricao varchar(180) not null
)engine = innoDB;

create table tipoendereco(
ten_codigo int primary key auto_increment,
ten_descricao varchar(180) not null
)engine=innoDB;

create table perfil(
per_codigo int primary key auto_increment,
per_descricao varchar(180) not null
)engine=innoDB;

create table usuario(
usu_codigo int primary key auto_increment,
usu_nome varchar(180) not null,
usu_email varchar(180) not null,
usu_senha text not null,
usu_datacadastro date,
per_codigo int,

foreign key (per_codigo) references perfil(per_codigo)
)engine=innoDB;

create table telefone(
tel_codigo int primary key auto_increment,
tel_ddd varchar(3) not null,
tel_numero varchar(11) not null,
usu_codigo int ,
tte_codigo int,

foreign key(usu_codigo) references usuario(usu_codigo),
foreign key(tte_codigo) references tipotelefone(tte_codigo)
)engine=innoDB;

create table endereco(
end_codigo int primary key auto_increment,
end_rua varchar(180),
end_numero varchar(45),
end_bairro varchar(180),
end_cidade varchar(180),
end_estado char(2),
end_cep varchar(11),
usu_codigo int,
ten_codigo int,

foreign key(usu_codigo) references usuario(usu_codigo),
foreign key(ten_codigo) references tipoendereco(ten_codigo)
)engine=innoDB;