
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
('GV001',N'??ng Qu?nh Nga',N'N?','031223361','0383334356',N'T? Nhi�n',N'C� Nga c� 5 n?m kinh nghi?m gi?ng d?y c�ng v?i t?m b?ng c? nh�n ??i h?c S? Ph?m 1 H� N?i' ),
('GV002',N'Ho�ng Trung Ph�',N'Nam','029381923','0385554319',N'X� H?i',N'Th?y Ph� c� 15 n?m kinh nghi?m gi?ng d?y c�ng v?i t?m b?ng c? nh�n ??i h?c S? Ph?m 1 H� N?i' ),
('GV003',N'Ho�ng B� Th?',N'Nam','016523361','0383334356',N'T? Nhi�n', null ),
('GV004',N'Ho�ng Th? Th?m',N'N?','0235223361','0383331111',N'T? Nhi�n',null),
('GV005',N'V? Minh Trang',N'N?','002223361','0383352222',N'Ngo?i Ng?',null ),
('GV006',N'??ng Tu?n T�',N'N?','066692336','0383222123',N'Ngo?i Ng?',null )



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
('mh001',N'L?ch S?', 'GV002', 1, N'M�n l?ch s? d�nh cho b?c ti?u h?c gi�p cung c?p cho c�c em ki?n th?c v? v?n h�a d�n t?c VN' ),
('mh002',N'Ti?ng Vi?t', 'GV001', 2, N'M�n Ti?ng Vi?t bao g?m ch??ng tr�nh t?p ??c v� t?p vi?t cho c�c em b?c ti?u h?c' ),
('mh003',N'To�n', 'GV003', 1, N'M�n To�n c? b?n bao g?m ch??ng tr�nh t�nh to�n c? b?n cung c?p ki?n th?c cho c�c em b?c ti?u h?c' ),
('mh004',N'T?p V?', 'GV002', 1, N'M�n t?p v? r�n cho c�c em kh? n?ng s�ng t?o d�nh cho c�c em b?c ti?u h?c' ),
('mh005',N'Ti?ng Anh', 'GV005', 2, N'M�n Ti?ng Anh bao g?m ph�p �m c? b?n gi�p c�c em l�m quen v?i ng�n ng? ')


create table KHOILOP 
(
	makhoi nvarchar(15) not null primary key, 
	tenkhoi nvarchar(40) , 
	soluong int 
)

insert into KHOILOP values
('mk001', N'Kh?i L?p 1',60),
('mk002', N'Kh?i L?p 2',50),
('mk003', N'Kh?i L?p 3',70),
('mk004', N'Kh?i L?p 4',70),
('mk005', N'Kh?i L?p 5',50)



create table LOP 
(
   malop nvarchar(20) not null primary key, 
   tenlop nvarchar(40) , 
   makhoi nvarchar(15) not null,
   mota nvarchar(300), 
   constraint fk2 foreign key(makhoi) references KHOILOP(makhoi) on update cascade on delete cascade 
)

insert into LOP values
('ml001','L?p 1A','mk001', N'L?p d�nh cho c�c em con nh� gi�u'), 
('ml002','L?p 1B','mk001', N'L?p d�nh cho c�c em b? m? ng�o')


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
('hs001',N'Nguy?n V?n Nam',N'Nam','02/02/2002','03/05/2009',N'Ph??ng Minh Khai, Qu?n B?c T? Li�m, Th�nh Ph? HN','ml001',N'Em Nam ???c ph�n v�o l?p con nh� gi�u'),
('hs002',N'Ho�ng Th? Th�y',N'N?','01/02/2002','03/15/2009',N'Ph??ng Minh Ph??ng, Qu?n B?c T? Li�m, Th�nh Ph? HN','ml001',N'Em Th�y ???c ph�n v�o l?p con nh� gi�u'),
('hs003',N'Nguy?n Ng?c H?i',N'Nam','02/20/2002','03/09/2009',N'Ph??ng Minh Khai, Qu?n B?c T? Li�m, Th�nh Ph? HN','ml002',N'Em Nam ???c ph�n v�o l?p con nh� ngh�o'),
('hs004',N'Ho�ng T�ng L�m',N'Nam','08/02/2002','03/07/2009',N'Ph??ng H?i C�t, Qu?n B?c T? Li�m, Th�nh Ph? HN','ml002',N'Em Nam ???c ph�n v�o l?p con nh� ngh�o')


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
('hs001',N'Nguy?n V?n Nam',  'ml001', 'mh003',7.5, 6.5 ,null,6.8, N'T?t',1,N'H?c sinh ch?m ch?, ch?u kh�, nge l?i'), 
('hs002',N'Ho�ng Th? Th�y',  'ml001', 'mh001',9.0, 10.0,null,9.7, N'Xu?t S?c',1,N'H?c sinh ch?m ch?, ch?u kh�, nge l?i'), 
('hs003',N'Nguy?n Ng?c H?i', 'ml002', 'mh002',8.0, 4.5 ,null,5.7, N'Xu?t S?c',1,N'H?c sinh ch?m ch?, ch?u kh�, nge l?i'), 
('hs004',N'Ho�ng T�ng L�m',  'ml002', 'mh004',6.0, 8.0 ,null,7.3, N'T?t',1,N'H?c sinh ch?m ch?, ch?u kh�, nge l?i')


select * from ADMIN 
select * from GIAOVIEN
select * from MONHOC 
select * from LOP
select * from KHOILOP
select * from HOCSINH
select * from KETQUAHT
