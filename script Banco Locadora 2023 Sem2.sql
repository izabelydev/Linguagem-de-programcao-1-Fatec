Use master 
GO
if exists (select * from sysdatabases where name = 'Locadora')
      drop database Locadora
      
go      
  SET DATEFORMAT dmy
      
  GO




  CREATE DATABASE Locadora
  go

use Locadora
  go 
CREATE TABLE Categorias (
      Codcategoria	int				not null		identity (1,1)		primary key ,
      Categoria		nvarchar (15)	not null,
      Descricao		nvarchar (150)  null,
      valor			money			not null   
 )
       
insert into Categorias (valor,Categoria,Descricao)			  
	   values (200.50,'Simples','Carro comum 1.3')
      
insert into Categorias (Categoria,Descricao,valor)
       values ('Esportes','Carros esportivos geralmente com motor 1.3','250')
      
insert into Categorias (Categoria,Descricao,valor)
       Values ('PlayBoy', 'Possui direção hidraulica e ar condicionado','300')
       
insert into Categorias (Categoria,Descricao,valor)
        Values ('Minivan','Carros com mais de 7 Lugares ','400')
        
 select * from categorias       
        
   CREATE TABLE Funcionarios (
        Codfuncionario int identity (1,1) primary key,
        NomeFunc nvarchar (50)not null,
        Endereco nvarchar (50) not null,
        Bairro   nvarchar (50) not null,
        Cidade   nvarchar (50) not null,
        Cargo    nvarchar (50) not null,
        Usuario  nvarchar (50) not null,
        senha    nvarchar (50) not null,
        Nivel    int not null
   )
        
        insert into Funcionarios (NomeFunc, Endereco,Bairro,Cidade,Cargo,Usuario,senha,Nivel)
         values ('Ana Maria','R. das Flores','Orquideas','flores','Auxiliar','ana','123',1)
        
        insert into Funcionarios (NomeFunc, Endereco,Bairro,Cidade,Cargo,usuario,senha,Nivel)
         values ('Eva Silva', 'R. das Uvas','Frutas','Floresta','Ass.Adm.','eva','456',2)
         
         insert into Funcionarios (NomeFunc, Endereco,Bairro,Cidade,Cargo,usuario,senha,Nivel)
         values ('Rui','R. das Amoras','Frutas','Floresta','Gerente','rui','789',3)
         
 select * from Funcionarios
   --select distinct modelo from veiculos 
 
create table veiculos(
        Codveiculo int identity (1,1) primary key,
        Marca    nvarchar (30)not null,
        Modelo   nvarchar (50) not null,
        Cor      nvarchar (20) not null,
        Placa    nvarchar (9) not null  ,
        Ano      int           not null,
        Imagem   nvarchar(200),
        CodCategoria int,        
        constraint FKcatveic foreign key  (Codcategoria) references 
                             categorias(codcategoria)                                   
)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Gm','Vectra','Prata','xxe-3456',2010,'vectra.jpg',3)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Gm','Astra','Preto','eev-3996',2015,'astra.jpg',3)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Gm','Corsa','Branco','ddj-3421',2014,'corsa.jpg',1)
         
         
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Fiat','Uno','Branco','wjw-4387',2014,'uno.jpg',1)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Fiat','Siena','Vermelho','qqj-7777',2015,'siena.jpg',2)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('VW','Fox','Prata','ssj-3333',2015,'fox.jpg',2)
         
         
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Gm','Meriva','Prata','qjq-7888',2014,'meriva.jpg',4)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Crhysler','Country Town','Verde','rrr-9999',2014,'Country Town.jpg',4)



insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('VW','Fox','Prata','nnn-8888',2010,'fox.jpg',3)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Fiat','Uno','Preto','sas-3456',2015,'uno.jpg',3)
                  
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Fiat','Uno','Branco','wfw-4377',2014,'uno.jpg',1)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('GM','Corsa','Vermelho','dfg-6767',2015,'corsa.jpg',2)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('VW','Fox','Prata','sts-3933',2015,'fox.jpg',2)
         
         
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('Fiat','Uno','Prata','qqq-4444',2014,'uno.jpg',4)
insert into Veiculos (Marca, Modelo,Cor,Placa,Ano,Imagem,CodCategoria)
         values ('VW','Fox','Verde','rrr-9999',2014,'fox.jpg',4)



select * from veiculos

 
create table clientes(
        Codcliente int identity (1,1) primary key,
        Cliente    nvarchar (50)not null,
        endereco   nvarchar (50) not null,
        bairro     nvarchar (50) not null,
        cidade     nvarchar (50) not null ,
        Estado     nvarchar (2) not null,
        pais       nvarchar (50) not null ,
        dataNasc   date     not  null,
        cnh		   nvarchar (20) not null  unique
)


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Ana Maria','R. Pera','Frutas',
                   'São Bernardo do Campo','Brasil','SP','01/01/1976','12345678912')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Eva Silva','R. Maçã','Frutas',
                   'São Bernardo do Campo','Brasil','SP','15/10/1986','19541268912')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Maria Madalena','R. Amoras','Frutas',
                   'Buenos Aires','Argentina','SP','07/02/1987','12345632156')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Mario Augusto Lopez','R. Orquidesas','Flores',
                   'Santa Rosa','Argentina','SP','09/02/1995','12348521479')

insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Adriano Ricco','R. Bromélias','Flores',
                   'São Bernardo do Campo','Brasil','SP','21/08/1965','18448523698')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Rafael Bastos','R. Estonia','Parque das Nações',
                   'Santo andré','Brasil','SP','12/08/1982','129712348813')



insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Rodrigo Dantas','R. Polonia','Parque das Nações',
                   'Aguas Calientes','Peru','SP','04/04/1953','1298745893')



insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Danilo Alves','R. Estonia','Parque das Nações',
                   'Santo andré','Brasil','SP','01/01/1982','129787458913')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Rafael Bastos','R. Dom Pedro II','Jardins',
                   'Santo andré','Brasil','SP','01/09/1982','12987123913')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Amanda Bastos','R. Protogenes','Jardins',
                   'Santo andré','Brasil','SP','01/09/1982','12787123976')


insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Rosana Braga','R. da garça','Assunção',
                   'Santo andré','Brasil','SP','01/09/1992','12787185697')

insert into clientes (Cliente,endereco,bairro,cidade,pais,Estado,dataNasc ,cnh)
         values ('Rita Moreira','R. das Laranjeiras','Assunção',
                   'Santo andré','Brasil','SP','15/07/1981','12321456852')



 select * from clientes








create table locacoes(
	codlocacao		int identity(1,1) primary key,
	dataLocacao		date ,	--data em que a pessoa pede a locacao
	Codcliente		int ,
	codVeiculo		int,
	dataRetirada	date,	--data que a pessoa retira o veiculo
	dataEntrega		date,	--data provavel para entrega do veiculo
	codFuncionario	int,
	formaPagamento	nvarchar(20),	
	dataDevolucao	date,	--data que a pessoa devolve o veiculo
	Valorlocacao    money default 0,
	multa           money default 0 
)	

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('10/08/2015',1,1,'20/08/2015','23/08/2015',1,'Dinheiro','23/08/2015')
   
insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('10/08/2015',2,2,'10/08/2015','13/08/2015',2,'Débito','23/08/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('10/08/2015',3,3,'12/08/2015','16/08/2015',3,'Dinheiro','16/08/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('11/08/2015',4,4,'15/08/2015','18/08/2015',2,'Crédito','19/08/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('11/09/2015',5,5,'17/09/2015','23/09/2015',2,'Débito','24/09/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('11/09/2015',6,6,'20/09/2015','24/09/2015',1,'Dinheiro','24/09/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('11/09/2015',7,7,'12/09/2015','23/09/2015',1,'Crédito','23/09/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('12/09/2015',8,8,'13/09/2015','14/09/2015',3,'Dinheiro','14/09/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('12/09/2015',9,1,'12/05/2015','15/05/2015',1,'Débito','16/09/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('13/10/2015',1,2,'14/10/2015','15/10/2015',3,'Crédito','17/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('13/10/2015',2,3,'15/10/2015','17/10/2015',2,'Dinheiro','17/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('13/10/2015',3,4,'13/10/2015','18/10/2015',3,'Débito','18/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('14/10/2015',4,5,'14/10/2015','16/10/2015',1,'Débito','16/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('15/10/2015',5,6,'15/10/2015','16/10/2015',1,'Crédito','16/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('16/10/2015',6,7,'16/10/2015','19/10/2015',2,'Dinheiro','19/10/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('16/11/2015',7,8,'20/11/2015','23/11/2015',1,'Crédito','23/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('17/11/2015',3,1,'21/11/2015','23/11/2015',3,'Crédito','23/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('17/11/2015',4,3,'22/11/2015','24/11/2015',2,'Dinheiro','24/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('18/11/2015',5,4,'20/11/2015','21/11/2015',1,'Crédito','21/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('18/11/2015',6,5,'20/11/2015','21/11/2015',2,'Dinheiro','21/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('18/11/2015',7,6,'20/11/2015','23/11/2015',2,'Débito','23/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('19/11/2015',8,8,'19/11/2015','20/11/2015',3,'Dinheiro','20/11/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('19/12/2015',9,4,'19/12/2015','20/12/2015',2,'Crédito','20/12/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('21/12/2015',1,3,'24/12/2015','26/12/2015',2,'Dinheiro','29/12/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('21/12/2015',1,7,'24/12/2015','27/12/2015',1,'Débito','27/12/2015')   

insert into locacoes (dataLocacao,Codcliente,codVeiculo,dataRetirada,dataEntrega,codFuncionario,formaPagamento,dataDevolucao) values('21/05/2015',1,8,'25/05/2015','28/05/2015',1,'Crédito','28/05/2015')   

update locacoes set dataLocacao= dateadd (mm,96,datalocacao),
						dataretirada= dateadd (mm,96,dataretirada),
						dataentrega= dateadd (mm,96,dataentrega) ,
					datadevolucao= dateadd (mm,96,datadevolucao)

select * from locacoes





