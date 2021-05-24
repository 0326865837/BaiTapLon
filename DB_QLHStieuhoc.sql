
use master 
go 

create database QLHStieuhoc 
go 

use QLHStieuhoc 
go 

create table ADMIN
(
	username nvarchar(20) not null primary key, 
	password nvarchar(30) not null

)

insert into ADMIN values 
('admin','1'),
('admin1','2'),
('admin2','3')

create table GIAOVIEN 
(
   magiaovien nvarchar(30) not null primary key, 
   tengiaovien nvarchar(50) , 
   gioitinh nvarchar(10), 
   socmnd char(20), 
   sodienthoai char(20),
   tobomon nchar(30), 
   mota nvarchar(300)
)

insert into GIAOVIEN values 
('GV001',N'Đặng Quỳnh Nga',N'Nữ','031223361','0383334356',N'Tự Nhiên',N'Cô Nga có 5 năm kinh nghiệm giảng dạy cùng với tấm bằng cử nhân đại học Sư Phạm 1 Hà Nội' ),
('GV002',N'Hoàng Trung Phú',N'Nam','029381923','0385554319',N'Xã Hội',N'Thầy Phú có 15 năm kinh nghiệm giảng dạy cùng với tấm bằng cử nhân đại học Sư Phạm 1 Hà Nội' ),
('GV003',N'Hoàng Bá Thọ',N'Nam','016523361','0383334356',N'Tự Nhiên', null ),
('GV004',N'Hoàng Thị Thắm',N'Nữ','0235223361','0383331111',N'Tự Nhiên',null),
('GV005',N'Vũ Minh Trang',N'Nữ','002223361','0383352222',N'Ngoại Ngữ',null ),
('GV006',N'Đặng Tuấn Tú',N'Nữ','066692336','0383222123',N'Ngoại Ngữ',null )



create table MONHOC 
(
    mamonhoc nvarchar (30) not null primary key, 
	tenmonhoc nvarchar(50) , 
	magiaovien nvarchar(30) not null, 
	hocky int, 
	mota nvarchar(300), 
	constraint fk1 foreign key(magiaovien) references GIAOVIEN(magiaovien) on update cascade on delete cascade 
)

insert into MONHOC values
('mh001',N'Lịch Sử', 'GV002', 1, N'Môn lịch sử dành cho bậc tiểu học giúp cung cấp cho các em kiến thức về văn hóa dân tộc VN' ),
('mh002',N'Tiếng Việt', 'GV001', 2, N'Môn Tiếng Việt bao gồm chương trình tập đọc và tập viết cho các em bậc tiểu học' ),
('mh003',N'Toán', 'GV003', 1, N'Môn Toán cơ bản bao gồm chương trình tính toán cơ bản cung cấp kiến thức cho các em bậc tiểu học' ),
('mh004',N'Tập Vẽ', 'GV002', 1, N'Môn tập vẽ rèn cho các em khả năng sáng tạo dành cho các em bậc tiểu học' ),
('mh005',N'Tiếng Anh', 'GV005', 2, N'Môn Tiếng Anh bao gồm pháp âm cơ bản giúp các em làm quen với ngôn ngữ ')


create table KHOILOP 
(
	makhoi nvarchar(15) not null primary key, 
	tenkhoi nvarchar(40) , 
	soluong int 
)

insert into KHOILOP values
('mk001', N'Khối Lớp 1',60),
('mk002', N'Khối Lớp 2',50),
('mk003', N'Khối Lớp 3',70),
('mk004', N'Khối Lớp 4',70),
('mk005', N'Khối Lớp 5',50)



create table LOP 
(
   malop nvarchar(20) not null primary key, 
   tenlop nvarchar(40) , 
   makhoi nvarchar(15) not null,
   mota nvarchar(300), 
   constraint fk2 foreign key(makhoi) references KHOILOP(makhoi) on update cascade on delete cascade 
)

insert into LOP values
('ml001','Lớp 1A','mk001', N'Lớp dành cho các em con nhà giàu'), 
('ml002','Lớp 1B','mk001', N'Lớp dành cho các em bố mẹ ngèo')


create table HOCSINH 
(
	mahocsinh nvarchar(50) not null primary key, 
	tenhocsinh nvarchar(40) not null, 
	gioitinh nvarchar(10), 
	ngaysinh date, 
	ngaynhaphoc date, 
	diachi nvarchar(100), 
	malop nvarchar(20) not null,
	mota nvarchar(300), 
	constraint fk3 foreign key(malop) references LOP(malop) on update cascade on delete cascade 
)

insert into HOCSINH values
('hs001',N'Nguyễn Văn Nam',N'Nam','02/02/2002','03/05/2009',N'Phường Minh Khai, Quận Bắc Từ Liêm, Thành Phố HN','ml001',N'Em Nam được phân vào lớp con nhà giàu'),
('hs002',N'Hoàng Thị Thúy',N'Nữ','01/02/2002','03/15/2009',N'Phường Minh Phương, Quận Bắc Từ Liêm, Thành Phố HN','ml001',N'Em Thúy được phân vào lớp con nhà giàu'),
('hs003',N'Nguyễn Ngọc Hải',N'Nam','02/20/2002','03/09/2009',N'Phường Minh Khai, Quận Bắc Từ Liêm, Thành Phố HN','ml002',N'Em Nam được phân vào lớp con nhà nghèo'),
('hs004',N'Hoàng Tùng Lâm',N'Nam','08/02/2002','03/07/2009',N'Phường Hải Cát, Quận Bắc Từ Liêm, Thành Phố HN','ml002',N'Em Nam được phân vào lớp con nhà nghèo')


create table KETQUAHT
(
	mahocsinh nvarchar(50) not null, 
	tenhocsinh nvarchar(40) not null, 
	malop nvarchar(20) not null, 
	mamonhoc nvarchar(30) not null,
	diemtb float,  
	diemthilan1 float, 
	diemthilan2 float, 
    diemtongket float, 
	hankiem nvarchar(10) , 
	hocky int, 
	mota nvarchar(300),
	constraint pk1 primary key(mamonhoc,mahocsinh,malop), 
	constraint fk4 foreign key(mahocsinh)  references HOCSINH(mahocsinh) on update cascade on delete cascade, 
	constraint fk5 foreign key(mamonhoc)   references MONHOC(mamonhoc) on update cascade on delete cascade, 
	constraint fk7 foreign key(malop)      references LOP(malop) 
)

insert into KETQUAHT values
('hs001',N'Nguyễn Văn Nam',  'ml001', 'mh003',7.5, 6.5 ,null,6.8, N'Tốt',1,N'Học sinh chăm chỉ, chịu khó, nge lời'), 
('hs002',N'Hoàng Thị Thúy',  'ml001', 'mh001',9.0, 10.0,null,9.7, N'Xuất Sắc',1,N'Học sinh chăm chỉ, chịu khó, nge lời'), 
('hs003',N'Nguyễn Ngọc Hải', 'ml002', 'mh002',8.0, 4.5 ,null,5.7, N'Xuất Sắc',1,N'Học sinh chăm chỉ, chịu khó, nge lời'), 
('hs004',N'Hoàng Tùng Lâm',  'ml002', 'mh004',6.0, 8.0 ,null,7.3, N'Tốt',1,N'Học sinh chăm chỉ, chịu khó, nge lời')


select * from ADMIN 
select * from GIAOVIEN
select * from MONHOC 
select * from LOP
select * from KHOILOP
select * from HOCSINH
select * from KETQUAHT