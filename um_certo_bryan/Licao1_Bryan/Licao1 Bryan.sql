Create Database db_Licao1;

Use db_Licao1;


Create Table tbl_Usuario(
	Id_Usu int primary key auto_increment,
	Nome_Usu varchar(50) not null,
	Cargo varchar (50) not null,
	Nasc datetime
);

insert into tbl_Usuario(Nome_Usu, Cargo, Nasc)

	values ('Maria','Aluna','2020/10/10'), ('Bob','Aluno','2020/10/10'), ('Fernanda','Aluna','2020/10/10'), ('Mario','Professor','1990/10/10'), ('José','Professor','2020/10/10');
	
    Insert Into tbl_Usuario(Nome_Usu, Cargo, Data)Values('Bryan', 'Lindo','16/09/2004');
    Insert Into tbl_Usuario(Nome_Usu, Cargo, Data)Values('Bryan', 'Lindo', Str_To_Date('16/09/2004','%d/%m/%Y'));
select* from tbl_Usuario;

Update tbl_Usuario Set Nome_Usu = 'Bryan', Cargo = 'Estudante', Data = Str_To_Date('16/09/2000 00:00:00', '%d/%m/%Y')Where Id_Usu = '1';