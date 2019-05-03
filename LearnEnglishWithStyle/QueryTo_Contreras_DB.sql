create database Contreras_DB 
go 
use Contreras_DB

create table IrregularVerbs ( 
IDIrregular int identity (1,1) primary key ,
English varchar (50) not null ,
Spanish varchar (50) not null )

insert into IrregularVerbs values 
('BUY','COMPRAR'),
('CATCH','ATRAPAR'),
('BRING','TRAER/LLEVAR'),
('BEAT','GOLPEAR'),
('DREAM','SOÑAR'),
('FIND','ENCONTRAR'),
('FREEZE','CONGELAR'),
('KNEEL','ARRODILLARSE'),
('BEAR','SOPORTAR'),
('DEAL','TRATAR'),
('DRINK','BEBER'),
('EAT','COMER'),
('FALL','CAER')


create table RegularVerbs ( 
IDIrregular int identity (1,1) primary key ,
English varchar (50) not null ,
Spanish varchar (50) not null )

insert into RegularVerbs values 
('BREATH','RESPIRAR'),
('CALL','LLAMAR'),
('CARE','PREOCUPARSE'),
('CHANGE','CAMBIAR'),
('CLIMB','TREPAR'),
('CONFESS','CONFESAR'),
('CROSS','CRUZAR'),
('DESERVE','MERECER'),
('ENTER','ENTRAR'),
('CARRY','LLEVAR'),
('CHALLENGE','DESAFIAR'),
('CAMP','ACAMPAR'),
('CHEAT','HACER TRAMPA')