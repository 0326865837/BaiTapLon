create database quanlyhocsinhcap2


create table Class(
	ClassId varchar(100) primary key,
	ClassName varchar(100)
)

create table Student(
	id int identity,
	StudentId varchar(100) primary key,
	StudentName varchar(200),
	Gender varchar(10),
	StudentAddress varchar(300),
	Birthday Datetime,
	ClassId varchar(100),
	PhoneNumber varchar(100),
	StuImage varchar(300),
	constraint fk1 foreign key (ClassId) references Class(ClassId)  
)


create table Subjects(
	SubId varchar(100) primary key,
	SubName varchar(200)
)

create table ScoreList(
	ScoreId int identity,
	Score float,
	StudentId varchar(100),
	SubId varchar(100),
	constraint fk3 foreign key (SubId) references Subjects(SubId),
	constraint fk4 foreign key (StudentId) references Student(StudentId),
)

---drop table ScoreList

insert into Subjects values
('dialy','Địa lý'),
('lichsu','lịch sử'),
('gdcd','Giáo dục công dân'),
('toan001','Toan'),
('van001','Van'),
('anh001','anh')

select * from Subjects
select * from Student

insert into ScoreList( Score, StudentId,SubId) values
(9,'767676','toan001'),
(7,'767676','van001'),
(8,'767676','anh001')

delete  from ScoreList where ScoreId = '1'
drop table ScoreList
select * from Class
select * from Subjects

select SubName,StudentName, Score from ScoreList, Student, Subjects 
where Student.StudentId = ScoreList.StudentId 
	and ScoreList.SubId = Subjects.SubId 

	
select * 
from ScoreList
inner join Student on  Student.StudentId = ScoreList.StudentId 
inner join Subjects on ScoreList.SubId = Subjects.SubId
where Subjects.SubId='toan001'
--where Student.StudentId = ScoreList.StudentId 
	--and ScoreList.SubId = Subjects.SubId and ClassId = 'lop001' 