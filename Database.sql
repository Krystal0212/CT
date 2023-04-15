use master
drop database creditTask
create database creditTask
use creditTask

create table username(
	id varchar(10),
	username nvarchar(20),
	pass nvarchar(30),
)
create table Item(
	id int Identity(1,1) primary key,
	Ma varchar(10),
	Ten nvarchar(30),
	soluong int,
	gia money
)

create table Agent(
	id int Identity(1,1) primary key,
	agentId varchar(10),
	agentName nvarchar(30),
	address nvarchar(30),
)

create table Orders(
	id int Identity(1,1) primary key,
	orderId varchar(10),
	orderDate datetime not null default CURRENT_TIMESTAMP,
	agentID varchar(10),
)

create table order_Detail(
	id_detail int Identity(1,1) primary key,
	id varchar(10),
	orderId varchar(10),
	itemId varchar(10),
	quantity int,
	unitAmount int
)

insert into username values('admin','Anh Tu','admin')

insert into Item values('IT001','Laptop',1,19490)
insert into Item values('IT002','Monitor',1,1990)
insert into Item values('IT003','Samsung S22 Ultra',1,25490)
insert into Item values('IT004','Printer',1,21190)
insert into Item values('IT005','Iphone 13 Plus 512GB',1,23000)
insert into Item values('IT006','Iphone 13 Pro 128GB',1,23090)
insert into Item values('IT007','Router',1,7990)
insert into Item values('IT008','Ipad Pro M1 1TB',1,25000)
insert into Item values('IT009','Ipad Pro M2 1TB',1,28000)
insert into Item values('IT010','Ipad Air 5 Wifi 256GB',1,15000)
insert into Item values('IT011','Ipad Mini 6 Wifi 64GB',1,13000)
insert into Item values('IT012','Ipad Mini 6 4G 128GB',1,15000)
insert into Item values('IT013','Samsung Tab S7 256GB',1,13000)
insert into Item values('IT014','Switch',1,10)
insert into Item values('IT015','Macbook Air M2 16GB 512GB',1,35000)

insert into Agent values('A001','Nguyen Viet Quoc','Ha Noi')
insert into Agent values('A002','Ngoc Chau','Tay Ninh')
insert into Agent values('A003','Thuy Tien','Dong Thap')
insert into Agent values('A004','Do Ha','Thanh Hoa')
insert into Agent values('A005','Nguyen Le Ngoc Thao','TP Ho Chi Minh')
insert into Agent values('A006','Minh Kha','Soc Trang')
insert into Agent values('A007','Quoc Dat','Khanh Hoa')
insert into Agent values('A008','Mai Phuong','Dong Nai')
insert into Agent values('A009','Thanh Tam','TP Ho Chi Minh')
insert into Agent values('A010','Tien Dung','Da Nang')
insert into Agent values('A011','Thanh Nhan','Can Tho')
insert into Agent values('A012','Nguyen Khanh Duy','Dong Nai')
insert into Agent values('A013','Nguyen Tran Truong Tu','TP Vung Tau')
insert into Agent values('A014','Chi Dung','Tien Giang')
insert into Agent values('A015','Kim Duyen','Can Tho')

insert into Orders values('OD001','1/12/2023','A002')
insert into Orders values('OD002','2/23/2023','A002')
insert into Orders values('OD003','3/25/2023','A002')
insert into Orders values('OD004','5/2/2023','A005')
insert into Orders values('OD005','7/29/2023','A006')
insert into Orders values('OD006','9/4/2023','A007')
insert into Orders values('OD007','2/6/2023','A007')
insert into Orders values('OD008','4/7/2023','A007')
insert into Orders values('OD009','6/12/2023','A002')
insert into Orders values('OD010','12/17/2023','A010')
insert into Orders values('OD011','10/23/2023','A011')
insert into Orders values('OD012','9/3/2023','A011')
insert into Orders values('OD013','10/11/2023','A012')
insert into Orders values('OD014','12/11/2023','A013')
insert into Orders values('OD015','11/12/2023','A013')

insert into order_Detail values('DETAIL0001','OD001','IT001',80,80)
insert into order_Detail values('DETAIL0002','OD001','IT002',120,120)
insert into order_Detail values('DETAIL0003','OD001','IT002',20,20)
insert into order_Detail values('DETAIL0004','OD001','IT002',70,70)
insert into order_Detail values('DETAIL0005','OD002','IT003',100,100)
insert into order_Detail values('DETAIL0006','OD003','IT005',100,100)
insert into order_Detail values('DETAIL0007','OD003','IT005',70,70)
insert into order_Detail values('DETAIL0008','OD004','IT002',100,100)
insert into order_Detail values('DETAIL0009','OD006','IT010',90,90)
insert into order_Detail values('DETAIL0010','OD010','IT010',100,100)
insert into order_Detail values('DETAIL0011','OD010','IT010',100,100)
insert into order_Detail values('DETAIL0012','OD011','IT012',20,20)
insert into order_Detail values('DETAIL0013','OD012','IT013',100,100)
insert into order_Detail values('DETAIL0014','OD014','IT014',50,50)
insert into order_Detail values('DETAIL0015','OD015','IT015',100,100)

select * from item

select * from Agent

select * from Orders

select * from order_Detail

select count(*) from item

select distinct agentName from Agent where agentId in (

select agentId from Orders where orderID in (

select order_Detail.orderId from order_Detail, Item where Item.Ma = order_Detail.itemId

	)
)

select top 3 * from order_Detail ORDER BY itemId DESC


select * from item where Ma in (

SELECT  top 3 itemId
FROM order_Detail
GROUP BY itemId
HAVING COUNT(itemId) > 0
ORDER BY COUNT(itemId) desc
)
select * from Agent where agentId in (SELECT  top 3 agentId FROM Orders GROUP BY agentId HAVING COUNT(agentId) > 1 ORDER BY COUNT(agentId) desc)


select * from Item

