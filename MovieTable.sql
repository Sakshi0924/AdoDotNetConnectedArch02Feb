use WFADotNet;


--Creating Movie Table
create table Movietable(
	MovieId Int primary key not null identity(1,1),
	MovieName varchar(20),
	Actor varchar(20),
	Tickets Int
	);

--Inserting values in MovieTable
insert into Movietable values('Lagaan','Aamir Khan',20);
insert into Movietable values('Hera Pheri','Akshay Kumar',25);
insert into Movietable values('Vicky Donor','Annu Kapoor',22);
insert into Movietable values('Don','Chunkey Pandey',21);
insert into Movietable values('Holiday','Govinda',18);
insert into Movietable values('Super 30','Hrithik Roshan',20);
insert into Movietable values('OMG','Mithun Chakraborty',25);
insert into Movietable values('Sholay','Dharmendra',20);
insert into Movietable values('KGF','Yash',27);
insert into Movietable values('Bahubali','Prabhas',28);

--Stored procedure for ShowMovie
create proc sp_ShowMovie
@movieId int
as
begin 
select MovieName,Actor,Tickets from Movietable
where MovieId=@movieId;
end

execute sp_ShowMovie 5

--Stored procedure for UpdateMovieDetails
create proc sp_UpdateMovieDetails
@movieId int,
@mName varchar(20),
@actor varchar(20),
@tickets int
as
begin
update Movietable set MovieName=@mName,Actor=@actor,Tickets=@tickets
where MovieId=@movieId
End

select * from Movietable;

Execute sp_UpdateMovieDetails 9,"URI","Vicky Kaushal",25

--Stored procedure for Show Only Movie Name
create proc sp_ShowOnlyMName
@movieId int
as
begin
select MovieName from MovieTable where MovieId=@movieId
end

execute sp_ShowOnlyMName 5
