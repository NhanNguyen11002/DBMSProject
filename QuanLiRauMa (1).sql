create database QuanLiRauMa
go
use QuanLiRauMa
go
create table CUSTOMER(
	c_phone_number varchar(11) primary key,
	birthday date,
	c_address nvarchar(50),
	type_cus varchar(10)
)
go
--
create table ORDER_LIST(
	order_id int identity(1,1) primary key,
	c_phone_number varchar(11) references CUSTOMER(c_phone_number),
	create_day date,
	shop_id varchar(8),
)
go
--
create table ORDER_PRODUCT(
	order_id int references ORDER_LIST(order_id),
	product_id int,
	quantity int,
	price real,
	PRIMARY KEY(order_id, product_id),
)
go
--
create table PRODUCTS(
	product_id int identity(1,1) PRIMARY KEY,
	cost real NOT NULL,
	production_cost real NOT NULL,
	name_product nvarchar(150) NOT NULL,
	type nvarchar(10) NOT NULL,
)
go
alter table ORDER_PRODUCT 
add constraint fk_product_id 
foreign key (product_id) 
references PRODUCTS(product_id)
--
CREATE TABLE OFFICE(
	office_id varchar(8) primary key,
	office_name nvarchar(35),
	phone_number varchar(11),
	office_address nvarchar(40),
	office_email nvarchar(100),
)
GO
--
CREATE TABLE SHOP (
	shop_id varchar(8) primary key,
	shop_address nvarchar(40),
	phone_number varchar(11),
	office_id varchar(8),
	FOREIGN KEY (office_id) references OFFICE(office_id),
	manager_id int
)
go
alter table ORDER_LIST add constraint fk_shop_id foreign key (shop_id) references SHOP(shop_id)
--
create table PRODUCT_IN_SHOP(
	product_id int NOT NULL,
	shop_id varchar(8) NOT NULL,
	status varchar(10),
	FOREIGN KEY (product_id) references PRODUCTS(product_id),
	FOREIGN KEY (shop_id) references SHOP(shop_id),
	PRIMARY KEY (product_id,shop_id),
)
--v
CREATE TABLE EMP_ROLE(
	emp_role_id int identity(1,1) primary key,
	emp_role_name nvarchar(30),
	salary_shift int,
)
--
create table EMPLOYEE(
	emp_id int identity(1,1) PRIMARY KEY,
	emp_name nvarchar(40) NOT NULL,
	phone_number varchar(11),
	emp_role int NOT NULL,
	begin_date date NOT NULL,
	shop_id varchar(8),
	username varchar(40),
	password varchar(40),
	FOREIGN KEY (shop_id) REFERENCES SHOP(shop_id),
	FOREIGN KEY (emp_role) REFERENCES EMP_ROLE(emp_role_id),
)
--
create table VOUCHER (
	voucher_id varchar(20) primary key,
	discount real,
	mo_ta nvarchar(50),
	start_day date,
	end_day date,
	voucher_constraint varchar(10),	
)
go
--
create table PAYMENT (
	payment_method nvarchar(20),
	voucher_id varchar(20),
	payment_status varchar(10),
	payment_amount real,
	order_id int ,
	FOREIGN KEY (order_id) references ORDER_LIST(order_id),
	FOREIGN KEY (voucher_id) references VOUCHER(voucher_id),
)
go
--
create table VOUCHER_ITEM (
	voucher_id varchar(20) references VOUCHER(voucher_id),
	c_phone_number varchar(11) references CUSTOMER(c_phone_number),
	used varchar(3),
	Date_use date
)
go
--
CREATE TABLE COST(
	shop_id varchar(8) references SHOP(shop_id),
	water real,
	electricity real,
	ground real,
	month_in_year int
)
--
--
CREATE TABLE SALARY(
	salary_id int identity(1,1) primary key,
	emp_id int,
	salary_amount int,
	shift_count int,
	salary_month int,
	FOREIGN KEY (emp_id) REFERENCES EMPLOYEE(emp_id),
)
CREATE TABLE INCOME(
	shop_id varchar(8),
	income_month int,
	income_amount int,
	FOREIGN KEY (shop_id) REFERENCES SHOP(shop_id)
)
--ROLE: customer, order_list, order_product, products, office, shop, product_in_shop, emp_role, employee, voucher, payment, voucher_item, cost, salary, income
create role [Nhân viên] authorization dbo
grant select,update on EMPLOYEE to [Nhân viên] as dbo 
grant select on EMP_ROLE to [Nhân viên] as dbo 
go

create role [Quản lý cửa hàng] authorization dbo
grant select, update, insert, delete on CUSTOMER to [Quản lý cửa hàng] as dbo --
grant select, update, insert, delete on ORDER_LIST to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on ORDER_PRODUCT to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on PRODUCTS to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on OFFICE to [Quản lý cửa hàng] as dbo --
grant select, update, insert, delete on SHOP to [Quản lý cửa hàng] as dbo --
grant select, update, insert, delete on PRODUCT_IN_SHOP to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on EMP_ROLE to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on EMPLOYEE to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on VOUCHER to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on PAYMENT to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on VOUCHER_ITEM to [Quản lý cửa hàng] as dbo--
grant select, update, insert, delete on SALARY to [Quản lý cửa hàng] as dbo--
go


--THÊM DỮ LIỆU
GO
BEGIN 
ALTER TABLE [dbo].[COST]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 400000, 600000, 5000000, 8)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 390000, 800000, 5000000, 9)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 550000, 760000, 5000000, 10)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 460000, 800000, 5000000, 11)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 320000, 800000, 5000000, 12)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 600000, 800000, 4500000, 9)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 600000, 700000, 4500000, 10)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 650000, 680000, 4500000, 11)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 400000, 780000, 4500000, 12)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 450000, 450000, 5500000, 9)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 600000, 470000, 5500000, 10)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 650000, 420000, 5500000, 11)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 620000, 430000, 5500000, 12)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 400000, 600000, 5000000, 9)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 500000, 680000, 5000000, 10)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 600000, 580000, 5000000, 11)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 450000, 750000, 5000000, 12)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 600000, 700000, 4500000, 9)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 700000, 800000, 4500000, 10)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 680000, 900000, 4500000, 11)
	INSERT [dbo].[COST] ([shop_id], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 720000, 1200000, 4500000, 12)
ALTER TABLE [dbo].[COST]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[CUSTOMER]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0938422311', CAST(N'2000-01-01' AS Date), N'KH Vãng lai', N'NONE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0289991025', CAST(N'2001-10-07' AS Date), N'Q7 - Tp Hồ Chí Minh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0355878898', CAST(N'2000-07-26' AS Date), N'Mỏ Cày -Bến Tre', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0356264391', CAST(N'2000-04-09' AS Date), N'Tân Bình - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0356524956', CAST(N'2002-10-03' AS Date), N'Thủ Đức - Tp Hồ Chí Minh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0356548452', CAST(N'2003-01-30' AS Date), N'Q4- Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0356588892', CAST(N'2002-04-17' AS Date), N'Thủ Đức - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0395498451', CAST(N'2022-06-05' AS Date), N'Tp,Hồ Chí Minh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0399745256', CAST(N'2005-11-05' AS Date), N'Phú Nhuận -Tp Hồ Chí Minh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0563221678', CAST(N'2001-06-13' AS Date), N'Châu Đức - Vũng Tàu', N'GOLD')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0649858842', CAST(N'2002-09-05' AS Date), N'Hà Nội', N'MEMBER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0814069391', CAST(N'2002-12-26' AS Date), N'Q3-Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0815653456', CAST(N'1998-12-15' AS Date), N'Mỏ Cày - Bến Tre', N'MEMBER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0815698565', CAST(N'1998-07-03' AS Date), N'Tân Bình - Tp Hồ Chí Minh', N'GOLD')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0845656365', CAST(N'2007-04-08' AS Date), N'Thủ Đức - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0895626225', CAST(N'2004-04-27' AS Date), N'Châu Thành - Trà Vinh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0896555636', CAST(N'2001-06-21' AS Date), N'Châu Thành - Trà Vinh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0908745624', CAST(N'2004-02-16' AS Date), N'Q8 - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0909453441', CAST(N'1995-12-24' AS Date), N'Q5 - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0909456277', CAST(N'1972-10-15' AS Date), N'Phú Nhuận- Tp Hồ Chí Minh', N'MEMBER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0909457588', CAST(N'2004-11-02' AS Date), N'Q9 - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0945255332', CAST(N'2002-09-10' AS Date), N'Q9 - Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0945255641', CAST(N'2005-03-15' AS Date), N'Sơn Tịnh - Quãng Ngãi', N'MEMBER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0956478898', CAST(N'2004-05-06' AS Date), N'Tân Bình- Tp Hồ Chí Minh', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0965565325', CAST(N'2000-03-29' AS Date), N'Ba Tri - Bến Tre', N'BRONZE')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0980000001', CAST(N'2002-01-01' AS Date), N'Thủ Đức, Tp Hồ Chí Minh', N'SILVER')
	INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [c_address], [type_cus]) VALUES (N'0980000002', CAST(N'2000-01-10' AS Date), N'Q2-Tp Hồ Chí Minh', N'BRONZE')
ALTER TABLE [dbo].[CUSTOMER]
CHECK CONSTRAINT ALL
END
--
GO

BEGIN
ALTER TABLE [dbo].[EMP_ROLE]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[EMP_ROLE] ([emp_role_name], [salary_shift]) VALUES (N'SuperAdmin',200000)
	INSERT [dbo].[EMP_ROLE] ([emp_role_name], [salary_shift]) VALUES (N'Quản lý cửa hàng',120000)
	INSERT [dbo].[EMP_ROLE] ([emp_role_name], [salary_shift]) VALUES (N'Nhân viên',100000)
	INSERT [dbo].[EMP_ROLE] ([emp_role_name], [salary_shift]) VALUES (N'Bảo vệ',80000)
ALTER TABLE [dbo].[EMP_ROLE]
CHECK CONSTRAINT ALL
END
GO
-- select * from emp_role
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'SuperAdmin', N'03935000999', 1, CAST(N'2022-08-01' AS Date), Null, N'superadmin', N'123456')
-- TRIGGER tự động thêm login vào sv, user vào database khi thêm nv, xóa login, user khi xóa nv
go
create trigger [dbo].[create_grant_user]
on [dbo].[EMPLOYEE]
	after insert
	as begin
	declare @emp_role_name nvarchar(50)
	declare @username nvarchar(50)
	declare @password nvarchar(50)
	select @emp_role_name = emp_role.emp_role_name,@username = username, @password = password from inserted inner join EMP_ROLE on inserted.emp_role = EMP_ROLE.emp_role_id
	if (@emp_role_name = N'Quản lý cửa hàng')
	begin
		EXEC('CREATE LOGIN ' + @username + ' WITH PASSWORD = ''' + @password + ''', DEFAULT_DATABASE = QuanLiRauMa, DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
			CREATE USER '+ @username +' FOR LOGIN '+ @username +' WITH DEFAULT_SCHEMA=[dbo] ')
		exec('alter role  [Quản lý cửa hàng] add member ['+@username+'] ')
		exec('alter role  [db_securityadmin] add member ['+@username+'] ')
		exec('alter role  [db_accessadmin] add member ['+@username+'] ')
		exec('alter server role securityadmin add member '+@username+'')
	end	
	else 
	begin
		EXEC('CREATE LOGIN ' + @username + ' WITH PASSWORD = ''' + @password + ''', DEFAULT_DATABASE = QuanLiRauMa, DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
			CREATE USER '+ @username +' FOR LOGIN '+ @username +' WITH DEFAULT_SCHEMA=[dbo] ')
		exec('alter role [Nhân viên] add member ['+@username+'] ')
	end
end
go
--drop trigger [dbo].[create_grant_user]
--INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Nghĩa', N'03935000100', 2, CAST(N'2022-08-01' AS Date), N'SH01', N'adminNghia123456', N'123456')
-- alter role  [Quản lý cửa hàng] add member adminNghia1
create trigger [dbo].[delete_user]
on [dbo].[EMPLOYEE]
	after delete
	as begin
	declare @username nvarchar(50)
	select @username = username from deleted
			EXEC('drop user '+@username)
			exec('drop login '+@username)
end
go


--SET idENTITY_INSERT [dbo].[EMPLOYEE] ON 
BEGIN
ALTER TABLE [dbo].[EMPLOYEE]
NOCHECK CONSTRAINT ALL
	
	

	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Nghĩa', N'03935000100', 2, CAST(N'2022-08-01' AS Date), N'SH01', N'adminNghia', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Thành Long', N'03935000101', 4, CAST(N'2022-08-01' AS Date), N'SH01', N'bvThanhLong', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Văn Nam', N'03935000102', 3, CAST(N'2022-08-01' AS Date), N'SH01', N'nvVanNam', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Khởi Nguyên', N'03935000103', 3, CAST(N'2022-08-01' AS Date), N'SH01', N'nvKhoiNguyen', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Trần Thanh Hằng', N'03935000104', 3, CAST(N'2022-08-01' AS Date), N'SH01', N'nvThanhHang', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Ngọc Linh', N'03935000105', 3, CAST(N'2022-08-01' AS Date), N'SH01', N'nvNgocLinh', N'123456')
	
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Trọng', N'03935000110', 2, CAST(N'2022-09-01' AS Date), N'SH02', N'adminTrong', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Hữu Trường', N'03935000121', 4, CAST(N'2022-09-01' AS Date), N'SH02', N'bvHuuTruong', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Văn Lợi', N'03935000132', 3, CAST(N'2022-09-01' AS Date), N'SH02', N'nvVanLoi', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Thanh Lân', N'03935000143', 3, CAST(N'2022-09-01' AS Date), N'SH02', N'nvThanhLan', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Trần Huyền Trân', N'03935000154', 3, CAST(N'2022-09-01' AS Date), N'SH02', N'nvHuyenTran', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Thị Thùy Lan', N'03935000160', 3, CAST(N'2022-09-01' AS Date), N'SH02', N'nvThuyLan', N'123456')

	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Nhân', N'03935000210', 2, CAST(N'2022-09-01' AS Date), N'SH03', N'adminNhan', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Hữu Anh', N'03935000321', 4, CAST(N'2022-09-01' AS Date), N'SH03', N'bvHuuAnh', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Văn Hùng', N'03935000432', 3, CAST(N'2022-09-01' AS Date), N'SH03', N'nvVanHung', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Lực Điền', N'03935000543', 3, CAST(N'2022-09-01' AS Date), N'SH03', N'nvLucDien', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Trần Huyền Trinh', N'03935000654', 3, CAST(N'2022-09-01' AS Date), N'SH03', N'nvHuyenTrinh', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Văn Chí', N'03935000760', 3, CAST(N'2022-09-01' AS Date), N'SH03', N'nvVanChi', N'123456')

	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Bùi Phước', N'03935001110', 2, CAST(N'2022-09-01' AS Date), N'SH04', N'adminPhuoc', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Ngọc Hân', N'03935002121', 4, CAST(N'2022-09-01' AS Date), N'SH04', N'bvNgocHan', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Văn Chiến', N'03935003132', 3, CAST(N'2022-09-01' AS Date), N'SH04', N'nvVanChien', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Thanh Duy', N'03935004143', 3, CAST(N'2022-09-01' AS Date), N'SH04', N'nvThanhDuy', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Trần Văn Phúc', N'03935005154', 3, CAST(N'2022-09-01' AS Date), N'SH04', N'nvVanPhuc', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Thị Thùy Tiên', N'03935006160', 3, CAST(N'2022-09-01' AS Date), N'SH04', N'nvThuyTien', N'123456')

	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Hoa', N'03935010110', 2, CAST(N'2022-09-01' AS Date), N'SH05', N'adminHoa', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Hữu Hướng', N'03935020121', 4, CAST(N'2022-09-01' AS Date), N'SH05', N'nvHuuHuong', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Văn Long', N'03935030132', 3, CAST(N'2022-09-01' AS Date), N'SH05', N'nvVanLong', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Nguyễn Cẩn Thận', N'03935040143', 3, CAST(N'2022-09-01' AS Date), N'SH05', N'bvCanThan', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Trần Huyền Bí', N'03935050154', 3, CAST(N'2022-09-01' AS Date), N'SH05', N'nvHuyenBi', N'123456')
	INSERT [dbo].[EMPLOYEE] ([emp_name], [phone_number], [emp_role], [begin_date], [shop_id], [username], [password]) VALUES (N'Lê Thị Thu hương', N'03935060160', 3, CAST(N'2022-09-01' AS Date), N'SH05', N'nvThuHuong', N'123456')
	
ALTER TABLE [dbo].[EMPLOYEE]
CHECK CONSTRAINT ALL
END
--SET idENTITY_INSERT [dbo].[EMPLOYEE] OFF
--
GO

BEGIN
ALTER TABLE [dbo].[SALARY]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (3,7040000,88,8)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (4,8300000,83,8) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (5,8100000,81,8) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (6,8500000,85,8) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (7,8600000,86,8)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (3,6720000,84,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (4,8000000,80,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (5,7800000,78,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (6,7500000,75,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (7,7700000,77,9)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (9,6640000,83,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (10,7900000,79,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (11,7800000,78,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (12,8000000,80,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (13,8100000,81,9)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (15,6800000,85,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (16,8100000,81,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (17,8200000,82,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (18,8000000,80,9) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (19,7900000,79,9)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (21,6640000,83,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (22,7700000,77,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (23,7500000,75,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (24,7800000,78,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (25,7900000,79,9)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (27,6880000,86,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (28,8100000,81,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (29,8400000,84,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (30,8000000,80,9)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (31,7800000,78,9)


	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (3,6800000,85,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (4,8100000,81,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (5,7900000,79,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (6,7600000,76,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (7,7800000,78,10)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (9,6720000,84,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (10,8000000,80,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (11,7900000,79,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (12,8100000,81,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (13,8200000,82,10)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (15,6880000,86,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (16,8200000,82,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (17,8300000,83,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (18,8100000,81,10) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (19,8000000,80,10)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (21,6720000,84,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (22,7800000,78,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (23,7700000,77,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (24,7900000,79,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (25,8100000,81,10)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (27,7040000,88,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (28,8300000,83,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (29,8600000,86,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (30,8200000,82,10)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (31,8000000,80,10)


	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (3,6640000,83,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (4,8000000,80,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (5,7200000,72,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (6,7400000,74,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (7,7500000,75,11)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (9,6560000,82,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (10,7700000,77,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (11,7800000,78,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (12,7800000,78,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (13,7900000,79,11)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (15,6720000,84,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (16,8000000,80,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (17,8000000,81,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (18,7900000,79,11) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (19,7700000,77,11)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (21,6560000,82,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (22,7700000,77,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (23,7600000,76,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (24,7800000,78,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (25,8000000,80,11)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (27,6880000,86,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (28,8200000,82,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (29,8300000,83,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (30,8100000,81,11)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (31,7900000,79,11)


	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (3,7040000,87,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (4,8300000,83,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (5,7500000,75,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (6,7700000,77,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (7,7800000,78,12)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (9,6800000,85,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (10,8000000,80,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (11,8100000,81,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (12,8100000,81,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (13,8200000,82,12)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (15,7040000,87,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (16,8300000,83,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (17,8400000,84,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (18,8200000,82,12) 
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (19,8000000,80,12)
	
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (21,6800000,85,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (22,8000000,80,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (23,7900000,79,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (24,8100000,81,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (25,8300000,83,12)

	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (27,7120000,89,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (28,8500000,85,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (29,8600000,86,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (30,8400000,84,12)
	INSERT [dbo].SALARY ([emp_id],[salary_amount],[shift_count],[salary_month]) VALUES (31,8200000,82,12)

ALTER TABLE [dbo].[EMPLOYEE]
CHECK CONSTRAINT ALL
END
GO

BEGIN
ALTER TABLE [dbo].[OFFICE]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[OFFICE] ([office_id], [office_name], [phone_number], [office_address], [office_email]) VALUES (N'OF_HCM', N'Văn Phòng Đại Diện Tp Hồ Chí Minh', N'19001010', N'Quận 1, Tp Hồ Chí Minh',N'MassMixHCM@gmail.com')
	INSERT [dbo].[OFFICE] ([office_id], [office_name], [phone_number], [office_address], [office_email]) VALUES (N'OF_HN', N'Văn Phòng Đại Diện Hà Nội', N'19001020', N'HoànKiếm, Tp Hà Nội',N'MassMixHN@gmail.com')
ALTER TABLE [dbo].[OFFICE]
CHECK CONSTRAINT ALL	
END
--
GO
--SET idENTITY_INSERT [dbo].[ORDER_LIST] ON 
BEGIN
ALTER TABLE [dbo].[ORDER_LIST]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289981025', CAST(N'2022-08-27' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289971025', CAST(N'2022-08-27' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0399745256', CAST(N'2022-08-27' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289961025', CAST(N'2022-08-27' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0399745256', CAST(N'2022-08-29' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289961025', CAST(N'2022-09-07' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0355878898', CAST(N'2022-09-07' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0355878898', CAST(N'2022-09-08' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0356524956', CAST(N'2022-09-08' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0895626225', CAST(N'2022-09-08' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0895626225', CAST(N'2022-10-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0895626225', CAST(N'2022-10-08' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0895626225', CAST(N'2022-10-08' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289991025', CAST(N'2022-10-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0399745256', CAST(N'2022-10-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289951025', CAST(N'2022-11-08' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289941025', CAST(N'2022-11-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0815698565', CAST(N'2022-11-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0909453441', CAST(N'2022-11-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0980000001', CAST(N'2022-11-08' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289991025', CAST(N'2022-12-17' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0356264391', CAST(N'2022-12-17' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0356548452', CAST(N'2022-12-17' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0356588892', CAST(N'2022-12-20' AS Date), N'SH05')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0563221678', CAST(N'2022-12-21' AS Date), N'SH05')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0895626225', CAST(N'2022-08-22' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0908745624', CAST(N'2022-08-24' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0909456277', CAST(N'2022-08-12' AS Date), N'SH03')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0945255332', CAST(N'2022-09-14' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0965565325', CAST(N'2022-09-21' AS Date), N'SH05')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0909453441', CAST(N'2022-09-17' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0814069391', CAST(N'2022-10-17' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0815698565', CAST(N'2022-10-18' AS Date), N'SH03')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0845656365', CAST(N'2022-10-18' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0909453441', CAST(N'2022-11-19' AS Date), N'SH05')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0814069391', CAST(N'2022-11-21' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0814069391', CAST(N'2022-11-21' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0815698565', CAST(N'2022-12-23' AS Date), N'SH02')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0845656365', CAST(N'2022-12-28' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0980000001', CAST(N'2022-12-29' AS Date), N'SH05')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0289931025', CAST(N'2022-08-25' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0814069391', CAST(N'2022-09-25' AS Date), N'SH04')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0980000001', CAST(N'2022-10-16' AS Date), N'SH01')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0909457588', CAST(N'2022-11-16' AS Date), N'SH03')
	INSERT [dbo].[ORDER_LIST] ([c_phone_number], [create_day], [shop_id]) VALUES (N'0399745256', CAST(N'2022-12-16' AS Date), N'SH04')
ALTER TABLE [dbo].[ORDER_LIST]
CHECK CONSTRAINT ALL
END
--SET idENTITY_INSERT [dbo].[ORDER_LIST] OFF
--
GO
BEGIN
ALTER TABLE [dbo].[ORDER_PRODUCT]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (1, 1, 4, 100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (1, 17, 2, 250000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 2, 2, 80000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 10, 2, 60000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 11, 2, 200000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (4, 25, 6, 1320000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (5, 3, 10, 350000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (9, 5, 8, 200000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (9, 22, 10, 2500000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (10, 20, 6, 720000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (15, 3, 1, 35000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (17, 2, 1, 40000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (18, 5, 1, 25000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (19, 3, 1, 35000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (20, 7, 1, 32000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (21, 3, 1, 35000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 1, 1, 25300)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 3, 1, 35000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 6, 2, 50000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 25, 2, 440000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (23, 5, 4, 100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (23, 10, 2, 60000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (24, 4, 2, 50000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 2, 2, 80000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 6, 2, 50000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 7, 2, 64000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 23, 2, 200000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (26, 6, 6, 150000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (26, 22, 2, 500000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (27, 5, 4, 100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (27, 14, 8, 1040000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 7, 4, 128000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 14, 4, 520000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 25, 3, 660000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 9, 1, 28000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 10, 1, 30000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 11, 2, 200000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 3, 4, 140000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 4, 4, 100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 25, 4, 880000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (31, 4, 3, 75000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (31, 5, 3, 75000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (32, 3, 2, 70000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (32, 18, 10, 1100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (33, 1, 15, 379500)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (33, 4, 4, 100000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (35, 2, 4, 160000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (35, 13, 4, 800000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (36, 4, 10, 250000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (36, 15, 10, 1200000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 3, 15, 525000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 26, 3, 840000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 29, 3, 720000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 2, 3, 120000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 5, 5, 125000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 19, 5, 700000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 25, 4, 880000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 4, 1, 25000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 10, 5, 150000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 19, 4, 560000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (40, 1, 1, 25300)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (40, 3, 1, 35000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (41, 7, 1, 32000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 14, 1, 130000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 26, 1, 280000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 29, 3, 720000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (43, 27, 2, 450000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (43, 30, 3, 660000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (44, 4, 2, 50000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (44, 29, 4, 960000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (45, 3, 4, 140000)
	INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (45, 6, 2, 50000)
ALTER TABLE [dbo].[ORDER_PRODUCT]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[PAYMENT]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 350000, 1)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 0, 2)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', N'SILVERVC', N'DONE', 340000, 3)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1320000, 4)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'SILVERVC', N'DONE', 350000, 5)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 2700000, 9)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'THANG4VV', N'DONE', 720000, 10)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', N'SALE105 ', N'DONE', 35000, 15)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 40000, 17)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', N'SALE105', N'DONE', 25000, 18)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', N'SALE105', N'DONE', 35000, 19)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', N'SALE105', N'DONE', 32000, 20)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 35000, 21)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 550300, 22)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'SALE105 ', N'DONE', 160000, 23)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 50000, 24)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 394000, 25)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', N'TRIAN2', N'DONE', 650000, 26)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', N'TRIAN2', N'DONE', 1140000, 27)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1308000, 28)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 258000, 29)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1120000, 30)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 150000, 31)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 1170000, 32)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 479500, 33)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 960000, 35)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 1450000, 36)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 2085000, 37)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1825000, 38)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 735000, 39)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 60300, 40)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 32000, 41)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp', NULL, N'DONE', 1130000, 42)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1110000, 43)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 1010000, 44)
	INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng', NULL, N'DONE', 190000, 45)

ALTER TABLE [dbo].[PAYMENT]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH04', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH05', N'N')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH01', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH02', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH05', N'N')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH02', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH04', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH01', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH05', N'N')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH01', N'Y')
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH04', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH05', N'N')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH01', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH05', N'N')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH01', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH02', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH03', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH02', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH04', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH05', N'Y')

	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (31, N'SH01', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (31, N'SH02', N'Y')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (31, N'SH03', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (31, N'SH04', N'N')
	INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (31, N'SH05', N'Y')
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]
CHECK CONSTRAINT ALL
END
--
GO
--SET idENTITY_INSERT [dbo].[PRODUCTS] ON
BEGIN
ALTER TABLE [dbo].[PRODUCTS]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (24000, 6000, N'Rau Má Mix Sầu Riêng Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (22000, 6000, N'Rau Má Mix Đậu Xanh Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (22000, 6000, N'Khoai Môn Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (22000, 6000, N'Đậu Xanh Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (22000, 6000, N'Rau Má Mix Khoai Môn Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (20000, 5000, N'Rau Má Sữa Dừa', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (12000, 3000, N'Rau Má Nguyên Chất', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (30000, 8000, N'Rau Má Đậu Xanh Mix Macchiato', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (30000, 8000, N'Rau Má Sữa Hạt Sen Mix Hạnh Nhân', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (30000, 8000, N'Rau Má Sữa Hạt Sen Mix Sương Sáo', N'DRINK')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (30000, 8000, N'Rau Má Sữa Hạt Sen Mix Macchiato', N'DRINK')

	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (18000, 3000, N'Bánh Tráng Mix Khô Gà Lá Chanh', N'FOOD')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (18000, 3000, N'Bánh Tráng Mix Phô Mai', N'FOOD')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (18000, 3000, N'Bánh Tráng Mix Khô Bò', N'FOOD')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (18000, 3000, N'Bánh Tráng Mix Tôm Hành', N'FOOD')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (18000, 3000, N'Bánh Tráng Mix Sa Tế Tôm', N'FOOD')

	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Thạch Nha Đam', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Trân Châu Tuyết Trắng', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Trân Châu Lá Dứa', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Thạch Lá Dứa', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Thạch Củ Năng', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Sương Sáo Hạt Chia', N'TOPPING')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (7000, 2000, N'Thạch Sương Sáo', N'TOPPING')

	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Rau má mix đậu xanh sữa dừa + Trân châu lá dứa + Thạch củ năng + Sương sáo hạt chia', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Rau má mix đậu xanh sữa dừa + Thạch nha đam + Thạch lá dứa + Trân châu tuyết trắng', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Rau má Mix Khoai Môn Sữa Dừa + Thạch lá dứa + Thạch củ năng + Sương sáo hạt chia', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Rau má sữa dừa + Thạch củ năng + Sương sáo hạt chia + Trân châu tuyết trắng', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Đậu xanh sữa dừa + Trân châu lá dứa + Thạch củ năng + Thạch lá dứa', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (32000, 9000, N'Khoai môn sữa dừa + Sương sáo hạt chia + Thạch lá dứa + Trân châu tuyết trắng', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (34000, 9000, N'Rau má mix sầu riêng sữa dừa + Thạch nha đam + Sương sáo hạt chia + Thạch lá dứa', N'COMBO')
	INSERT [dbo].[PRODUCTS] ([cost], [production_cost], [name_product], [type]) VALUES (34000, 9000, N'Rau má mix sầu riêng sữa dừa + thạch củ năng + thạch lá dứa + trân châu tuyết trắng', N'COMBO')
ALTER TABLE [dbo].[PRODUCTS]
CHECK CONSTRAINT ALL
END
--SET idENTITY_INSERT [dbo].[PRODUCTS] OFF
--
GO
BEGIN
ALTER TABLE [dbo].[SHOP]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[SHOP] ([shop_id], [shop_address], [phone_number], [office_id],[manager_id]) VALUES (N'SH01', N'Hoàng Diệu 2,P.Linh Trung, Thủ Đức', N'19001020', N'OF_HCM',2)
	INSERT [dbo].[SHOP] ([shop_id], [shop_address], [phone_number], [office_id],[manager_id]) VALUES (N'SH02', N'Thảo Điền, Q2, Tp Hồ Chí Minh', N'19001030', N'OF_HCM',8)
	INSERT [dbo].[SHOP] ([shop_id], [shop_address], [phone_number], [office_id],[manager_id]) VALUES (N'SH03', N'Hồ Gươm, Hà Nội', N'19002044', N'OF_HN',14)
	INSERT [dbo].[SHOP] ([shop_id], [shop_address], [phone_number], [office_id],[manager_id]) VALUES (N'SH04', N'Đường 48, P.Hiệp Bình Chánh, Thủ Đức', N'19002535', N'OF_HCM',20)
	INSERT [dbo].[SHOP] ([shop_id], [shop_address], [phone_number], [office_id],[manager_id]) VALUES (N'SH05', N'Đống Đa, Hà Nội', N'19002277', N'OF_HN',26)
ALTER TABLE [dbo].[SHOP] ADD CONSTRAINT fk_manager_id Foreign key (manager_id) references EMPLOYEE(emp_id)
ALTER TABLE [dbo].[SHOP]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[VOUCHER]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'TUUTRUONG', 0.1, N'Mùa tựu trường giảm 10%', CAST(N'2022-08-15' AS Date), CAST(N'2022-08-25' AS Date), N'BRONZE')
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'TRUNGTHU', 0.2, N'Trung thu yêu thương giảm 20%', CAST(N'2022-09-05' AS Date), CAST(N'2022-09-15' AS Date), N'BRONZE')
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'20T10', 0.2, N'20 tháng 10 giảm giá 20%', CAST(N'2022-10-15' AS Date), CAST(N'2022-10-25' AS Date), N'SIVER ')
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'HALLOWEEN', 0.15, N'Hallowennnnn giảm 15%', CAST(N'2022-10-25' AS Date), CAST(N'2022-11-05' AS Date), N'BRONZE')
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'20T11', 0.2, N'Ngày nhà giáo Việt Nam giảm 20%', CAST(N'2022-11-15' AS Date), CAST(N'2022-11-25' AS Date), N'BRONZE')
	INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [mo_ta], [start_day], [end_day], [voucher_constraint]) VALUES (N'THANG12', 0.1, N'Tháng cuối cùng trong năm giảm 10%', CAST(N'2022-12-01' AS Date), CAST(N'2022-12-10' AS Date), N'BRONZE')
ALTER TABLE [dbo].[VOUCHER]
CHECK CONSTRAINT ALL
END
--
GO
BEGIN
ALTER TABLE [dbo].[VOUCHER_ITEM]
NOCHECK CONSTRAINT ALL
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0356524956', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0814069391', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0895626225', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0896555636', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0956478898', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TUUTRUONG', N'0980000002', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0356264391', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0563221678', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0815698565', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0845656365', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0908745624', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRUNGTHU', N'0909453441', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0356524956', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0814069391', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0895626225', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0896555636', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0956478898', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T10', N'0980000002', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0289991025', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0355878898', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0815653456', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0909456277', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0945255332', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0945255641', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'HALLOWEEN', N'0980000001', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0356264391', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0563221678', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0815698565', N'yes', CAST(N'2022-11-20' AS Date))
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0845656365', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0908745624', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'20T11', N'0909453441', N'yes', CAST(N'2022-11-20' AS Date))
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG12', N'0356548452', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG12', N'0356588892', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG12', N'0399745256', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG12', N'0909457588', N'no', NULL)
	INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG12', N'0965565325', N'no', NULL)
ALTER TABLE [dbo].[VOUCHER_ITEM]
CHECK CONSTRAINT ALL
END
--
GO


/****** Object:  View [dbo].[Over1MonthWork]    Script Date: 9/29/2022 6:55:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_idENTIFIER ON
GO

CREATE VIEW [dbo].[Over1MonthWork]
AS
SELECT emp_id, emp_name, emp_role, begin_date
FROM   dbo.EMPLOYEE
WHERE (DATEDIFF(DAY, begin_date, GETDATE()) >= 30) AND (DATEDIFF(DAY, begin_date, GETDATE()) <= 90)
GO
--
GO

/****** Object:  View [dbo].[Fee]    Script Date: 9/29/2022 6:56:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_idENTIFIER ON
GO

CREATE VIEW [dbo].[Fee]
AS
SELECT SUM(electricity) as [Tiền điện],SUM(water) AS [Tiền nước], SUM(ground) AS [Tiền mặt bằng], shop_id
FROM   dbo.COST
WHERE (month_in_year >= MONTH(GETDATE()) - 3)
GROUP BY shop_id
GO
--
GO

/****** Object:  View [dbo].[HCMShop]    Script Date: 9/29/2022 6:56:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_idENTIFIER ON
GO

CREATE VIEW [dbo].[HCMShop]
AS
SELECT shop_id, shop_address, phone_number
FROM   dbo.SHOP
WHERE (office_id = 'OF_HCM')
GO
--
GO



--Trigger 1
CREATE TRIGGER [dbo].[Create_Payment_orderid]
ON [dbo].[ORDER_LIST]
AFTER  Insert
AS BEGIN 
DECLARE @order_id int

SELECT @order_id=order_id FROM inserted

	Insert into PAYMENT values ('TT',null,'No',0,@order_id)
  
END
GO
ALTER TABLE [dbo].[ORDER_LIST] ENABLE TRIGGER [Create_Payment_orderid]
GO
--Trigger 2
CREATE TRIGGER [dbo].[UPDATE_PAYMENT_AMOUNT]
ON [dbo].[ORDER_PRODUCT] 
WITH EXECUTE AS CALLER
AFTER INSERT, UPDATE, DELETE
AS
BEGIN 
DECLARE @order_id int
declare @vi varchar(20)
DECLARE @discount real
DECLARE @payment_amount real

-- lấy mã hóa đơn đang thao tác


SELECT order_id FROM inserted
UNION 
SELECT order_id FROM deleted

SELECT @order_id = order_id FROM ORDER_PRODUCT

select @vi = voucher_id
from
(
	SELECT distinct voucher_id
	from ORDER_PRODUCT inner join PAYMENT on ORDER_PRODUCT.order_id = PAYMENT.order_id
	where ORDER_PRODUCT.order_id= @order_id
) q
if @vi is null
select @discount = 0
else 
(
	select @discount = discount
	from ORDER_PRODUCT inner join PAYMENT on ORDER_PRODUCT.order_id = PAYMENT.order_id inner join VOUCHER on PAYMENT.voucher_id = VOUCHER.voucher_id
	where VOUCHER.voucher_id = @vi
)

if @discount = 0
(
SELECT @payment_amount = SUM(ORDER_PRODUCT.price)
FROM ORDER_PRODUCT
WHERE order_id = @order_id
)
-- tính tổng tiền theo hóa đơn đó
else
(
SELECT @payment_amount = SUM(ORDER_PRODUCT.price)*(1-@discount)
FROM ORDER_PRODUCT
WHERE order_id = @order_id
)
-- CẬP NHẬT CỘT TỔNG TIỀN Ở BẢN HÓA ĐƠN ỨNG VỚI HÓA ĐƠN ĐÓ
UPDATE PAYMENT	
SET payment_amount = @payment_amount 
WHERE PAYMENT.order_id =  @order_id 
END
GO
ALTER TABLE [dbo].[ORDER_PRODUCT] ENABLE TRIGGER [UPDATE_PAYMENT_AMOUNT]
GO

--Trigger 3
CREATE TRIGGER [dbo].[AFTER_PAYMET_SET_TYPE_CUS]
ON [dbo].[PAYMENT]
WITH EXECUTE AS CALLER
AFTER UPDATE
AS
BEGIN
	DECLARE @Payment_status varchar(10);
	DECLARE @c_phone_cus  varchar(11);
	DECLARE @voucher_id int
	SELECT 
		@Payment_status = payment_status,
		@c_phone_cus = c_phone_number,
		@voucher_id = voucher_id
	FROM inserted INNER JOIN ORDER_LIST ON ORDER_LIST.order_id = inserted.order_id;
	If( @Payment_status = 'DONE')
	BEGIN 
		IF(@voucher_id IS NOT NULL)
		BEGIN
				PRINT 'THONG BAO';
				PRINT @c_phone_cus;
				PRINT @voucher_id;
				UPDATE VOUCHER_ITEM
				SET used = 'yes',Date_use = GETDATE()
				WHERE c_phone_number = @c_phone_cus AND voucher_id = @voucher_id
		END
		DECLARE @Sum1 REAL ;
		SELECT @Sum1 = SUM(PAYMENT.payment_amount)
		FROM PAYMENT INNER JOIN ORDER_LIST
		ON ORDER_LIST.order_id = PAYMENT.order_id
		WHERE ORDER_LIST.c_phone_number=@c_phone_cus;
		print @Sum1
		IF(@c_phone_cus <> '01')
		BEGIN
				IF(@Sum1 BETWEEN 500000 AND 1000000 )
				BEGIN 
					PRINT 'Thang cap khach hang dong '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='BRONZE' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 BETWEEN 1000001 AND 1500000 )
				BEGIN
					PRINT 'Thang cap khach hang bac '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='SILVER' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 > 2500000 )
				BEGIN 
					PRINT 'Thang cap khach hang vang '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='GOLD' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 <500000 )
				BEGIN 
					PRINT 'Khong du dieu kien '
				END
		END
	END

END;
GO
ALTER TABLE [dbo].[PAYMENT] ENABLE TRIGGER [AFTER_PAYMET_SET_TYPE_CUS]
GO
--Trigger 4
CREATE TRIGGER [dbo].[ADD_VOUCHER] ON [dbo].[VOUCHER] FOR INSERT,
			UPDATE AS BEGIN
				DECLARE
					@c_Phone varCHAR ( 11 ),@Voucher_Type varCHAR ( 10 ), @Voucher_id varchar(20);
				SELECT
					@Voucher_Type = voucher_constraint, @Voucher_id = voucher_id 
				FROM
					inserted;
				DECLARE
					voucher_cursor CURSOR FOR SELECT
					c_phone_number 
				FROM
					CUSTOMER 
				WHERE
					CUSTOMER.type_cus = @Voucher_Type;
				OPEN voucher_cursor FETCH NEXT 
				FROM
					voucher_cursor INTO @c_Phone
				WHILE
						@@FETCH_STATUS = 0 BEGIN
							INSERT INTO VOUCHER_ITEM
						VALUES
							( @Voucher_id,@c_Phone, 'no', NULL ) FETCH NEXT 
						FROM
							voucher_cursor INTO @c_Phone 
						END CLOSE voucher_cursor;
					DEALLOCATE voucher_cursor;
					
				END;
GO
ALTER TABLE [dbo].[VOUCHER] ENABLE TRIGGER [ADD_VOUCHER]
GO
------------Ngài Nhân------------------------------------------------------------------------------------------
create procedure dbo.add_new_customer
@c_phone_number varchar(11),
@birthday date,
@c_address nvarchar(50),
@type_cus varchar(10)
as
	insert into CUSTOMER(c_phone_number, birthday, c_address, type_cus) 
	values(@c_phone_number,@birthday,@c_address,@type_cus);
go
grant exec on dbo.add_new_customer to [Quản lý cửa hàng] as [dbo]
go


create procedure dbo.edit_customer
@c_phone_number varchar(11),
@birthday date,
@c_address nvarchar(50),
@type_cus varchar(10)
as
	update CUSTOMER
	set birthday = @birthday, c_address = @c_address, type_cus = @type_cus
	where c_phone_number = @c_phone_number
go
grant exec on dbo.edit_customer to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.delete_customer
@c_phone_number varchar(11)
as
	delete from CUSTOMER where c_phone_number = @c_phone_number
go
grant exec on dbo.delete_customer to [Quản lý cửa hàng] as [dbo]
go

CREATE FUNCTION [dbo].[show_menu_in_shop] (@shop_id varCHAR(8))
--In ra những món trong menu của shop--
RETURNS TABLE
AS
RETURN 
		SELECT PRODUCTS.product_id,PRODUCTS.name_product,PRODUCTS.cost
		FROM PRODUCTS INNER JOIN PRODUCT_IN_SHOP
		ON (PRODUCTS.product_id = PRODUCT_IN_SHOP.product_id)
				AND	(PRODUCT_IN_SHOP.status='Y')
		WHERE PRODUCT_IN_SHOP.shop_id=@shop_id
GO
--!!!!!!
grant select on [dbo].[show_menu_in_shop] to [Quản lý cửa hàng] as [dbo]
go

CREATE PROC [dbo].[checkout_order] 
	@order_id INT,
	@payment_method NvarCHAR(20),
	@voucher_id varCHAR(20),
	@payment_amount real
AS
	UPDATE PAYMENT
	SET 
		payment_method = @payment_method,
		payment_status='DONE',
		voucher_id = @voucher_id,
		payment_amount = @payment_amount
	WHERE
		order_id = @order_id;
GO
grant exec on [dbo].[checkout_order] to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.add_new_order_list
@c_phone_number varchar(11),
@create_day date,
@shop_id varchar(8)
as
	insert into Order_list(c_phone_number,create_day,shop_id) values (@c_phone_number,@create_day,@shop_id)
go
grant exec on dbo.add_new_order_list to [Quản lý cửa hàng] as [dbo]
go

CREATE FUNCTION [dbo].[show_product_in_order] (@order_id INT)
-- In ra sản phẩm trong order --
RETURNS TABLE
AS
RETURN
	SELECT PRODUCTS.name_product Tên, 
					ORDER_PRODUCT.quantity Số_lượng,
					ORDER_PRODUCT.price Giá
	FROM ORDER_PRODUCT INNER JOIN PRODUCTS
	ON ORDER_PRODUCT.product_id = PRODUCTS.product_id
	WHERE ORDER_PRODUCT.order_id = @order_id
GO
ALTER AUTHORIZATION ON [dbo].[show_product_in_order] TO  SCHEMA OWNER 
GO
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
grant select on [dbo].[show_product_in_order] to [Quản lý cửa hàng] as [dbo]
go

CREATE PROCEDURE [dbo].[view_voucher_of_cus]
@c_phone_number CHAR(11)
AS
BEGIN
	SELECT VOUCHER_ITEM.voucher_id FROM VOUCHER_ITEM 
	INNER JOIN VOUCHER ON VOUCHER_ITEM.voucher_id = VOUCHER.voucher_id
	WHERE (c_phone_number=@c_phone_number AND used = 'no') and end_day > GETDATE( )
END;
GO
grant exec on [dbo].[view_voucher_of_cus] to [Quản lý cửa hàng] as [dbo]
go

-- Xóa đơn hàng dùng transaction--
CREATE PROCEDURE [dbo].[delete_order_trans]
		@order_id INT
AS
	BEGIN
		BEGIN TRANSACTION;
		SAVE TRANSACTION savespoint;
			BEGIN	TRY
					DELETE FROM PAYMENT WHERE order_id = @order_id;
					DELETE FROM ORDER_PRODUCT	WHERE order_id = @order_id;
					DELETE FROM ORDER_LIST WHERE order_id = @order_id;
					COMMIT TRANSACTION
			END TRY
			BEGIN CATCH
					IF @@TRANCOUNT > 0
					BEGIN
							ROLLBACK TRANSACTION savespoint;
					END
			END CATCH
	END;
GO
grant exec on [dbo].[delete_order_trans] to [Quản lý cửa hàng] as [dbo]
go


------------Ngài Nhân------------------------------------------------------------------------------------------
------------Ngài Nghĩa------------------------------------------------------------------------------------------
-- Proc tính tiền mặt bằng, nước, điện theo tháng cho từng shop
CREATE PROC Shop_MBDN @shop_id varchar(8)
AS
	select water N'Tiền nước',electricity N'Tiền điện',ground N'Tiền mặt bằng',month_in_year N'Tháng'
	from COST
	where shop_id = @shop_id
	order by month_in_year
GO

--Proc tính doanh thu theo tháng của shop(id)
CREATE PROC Doanh_Thu_Month @shop_id varchar(8)
AS 
	Select Q.DoanhThu_Month N'Tháng', sum(Q.payment_amount) as [Doanh Thu]
	from
		(
		Select ORDER_LIST.shop_id, month(create_day) as DoanhThu_Month, payment_amount
		from PAYMENT inner join ORDER_LIST on PAYMENT.order_id = ORDER_LIST.order_id
		where ORDER_LIST.shop_id = @shop_id and PAYMENT.payment_status = 'DONE'
		) Q
	group by Q.DoanhThu_Month
GO

-- Function tính income theo tháng của shop(id)
CREATE FUNCTION INCOME_Month (@shop_id varchar(8)) Returns @table table ([Tháng] int , [Thu nhập] int)
AS
	BEGIN
		insert @table 
			Select month_in_year, (TIENLOI - Tien_Luong - water - electricity - ground) Income
			from
				(-- Tiền lời
					Select Q.Month, sum(Q.TIEN_LOI) as TIENLOI
					from
						(
							Select ORDER_LIST.shop_id, month(create_day) as Month, (payment_amount - Production_Cost) as TIEN_LOI
							from PAYMENT inner join ORDER_LIST on PAYMENT.order_id = ORDER_LIST.order_id 
							inner join
							( --Production_cost
								Select order_id, ORDER_PRODUCT.product_id, quantity, production_cost*quantity as Production_Cost
								from ORDER_PRODUCT inner join PRODUCTS on ORDER_PRODUCT.product_id = PRODUCTS.product_id
							) C on PAYMENT.order_id = C.order_id
							where ORDER_LIST.shop_id = @shop_id  and PAYMENT.payment_status = 'DONE'
						) Q
					Group by Q.Month
				) as TL inner join COST on TL.Month = COST.month_in_year inner join -- Tiền điện,nước, mặt bằng
				(--Lương NV
					SELECT salary_month, SUM(salary_amount) as Tien_Luong
					FROM EMPLOYEE inner join SALARY on EMPLOYEE.emp_id = SALARY.emp_id
					WHERE shop_id = @shop_id
					GROUP BY salary_month
				) as Luong_Nv on TL.Month = Luong_Nv.salary_month 
			where COST.shop_id = @shop_id
	RETURN
END
go

--Lương Shop trả cho nv theo từng tháng
CREATE FUNCTION Func_LuongShop_Month(@Shop varchar(8) null) RETURNS table
AS
	return (
		SELECT salary_month N'Tháng', SUM(salary_amount) N'Tiền lương'
		FROM EMPLOYEE inner join SALARY on EMPLOYEE.emp_id = SALARY.emp_id
		WHERE shop_id = @Shop
		GROUP BY salary_month
		)
GO

-- Proc danh sách đơn hàng chưa thanh toán
CREATE PROC Unpaid_Payment @Shop_id varchar(8)
AS
	Select PAYMENT.order_id, voucher_id, name_product N'Tên sản phẩm', quantity N'Số lượng', price N'Tổng tiền', payment_amount N'Tiền đã trả'
	from PAYMENT inner join ORDER_PRODUCT on PAYMENT.order_id = ORDER_PRODUCT.order_id 
				 inner join PRODUCTS on ORDER_PRODUCT.product_id = PRODUCTS.product_id
				 inner join ORDER_LIST on ORDER_PRODUCT.order_id = ORDER_LIST.order_id
	where shop_id = @Shop_id and PAYMENT.payment_status = 'NOT'
go

-- Voucher có thể sử dụng trong ngày
CREATE FUNCTION Valid_Voucher ()
Returns @table table (VOUCHER varchar(20) null,[Mô tả] nvarchar(50) null)
AS
	BEGIN
		insert @table select voucher_id,mo_ta
					  from VOUCHER
					  where GETDATE() between start_day and end_day
	RETURN
	END
GO

--Top 5 sản phẩm bán chạy
CREATE FUNCTION Top5BestProduct(@Shop varchar(8) null) RETURNS table
AS
	return 
	select top 5 Q.product_id, [Số lượng], name_product [Tên sản phẩm]
	from PRODUCTS inner join
	(
		select product_id, sum(quantity) as [Số lượng]
		from ORDER_PRODUCT inner join ORDER_LIST on ORDER_PRODUCT.order_id = ORDER_LIST.order_id
		where shop_id = @Shop
		group by product_id
	) Q on PRODUCTS.product_id = Q.product_id
GO
--Sản phẩm đã bán trong ngày
CREATE FUNCTION SoldProductToday(@Shop varchar(8) null) RETURNS table
AS
	return 
	Select ORDER_LIST.order_id, name_product [Tên sản phẩm], quantity [Số lượng]
	from ORDER_LIST inner join ORDER_PRODUCT on ORDER_LIST.order_id = ORDER_PRODUCT.order_id 
					inner join PRODUCTS on ORDER_PRODUCT.product_id = PRODUCTS.product_id
					inner join PAYMENT on ORDER_LIST.order_id = PAYMENT.order_id
	where shop_id = @Shop and payment_status = 'DONE' and create_day = GETDATE()
GO
------------Ngài Nghĩa------------------------------------------------------------------------------------------
------------Phước-----------------------------------------------------------------------------------------------
go
create proc dbo.add_new_employee
@emp_name nvarchar(40),
@phone_number varchar(11),
@emp_role int,
@begin_date date,
@shop_id varchar(8),
@username varchar(40)
as
	insert into EMPLOYEE(emp_name,phone_number, emp_role, begin_date, shop_id, username, password ) 
	values( @emp_name,@phone_number, @emp_role, @begin_date, @shop_id, @username, '1');
--
go
grant exec on dbo.add_new_employee to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.edit_employee
@emp_id int,
@emp_name nvarchar(40),
@phone_number varchar(11),
@emp_role int,
@begin_date date,
@shop_id varchar(8),
@username varchar(40)
as
	update EMPLOYEE
	set emp_name = @emp_name, phone_number = @phone_number, emp_role = @emp_role, begin_date = @begin_date, shop_id = @shop_id, username = @username
	where emp_id = @emp_id
--
go
grant exec on dbo.edit_employee to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.delete_employee
@emp_id int
as
	delete from Employee where emp_id = @emp_id
--
go
grant exec on dbo.delete_employee to [Quản lý cửa hàng] as [dbo]
go

create proc dbo.add_new_voucher
@voucher_id varchar(20),
@discount real,
@mo_ta nvarchar(50),
@start_day date,
@end_day date,
@voucher_constraint varchar(10)
as
	insert into Voucher(voucher_id,discount, mo_ta, start_day, end_day, voucher_constraint ) 
	values( @voucher_id,@discount, @mo_ta, @start_day, @end_day, @voucher_constraint);
--
go
grant exec on dbo.add_new_voucher to [Quản lý cửa hàng] as [dbo]
go

create proc dbo.edit_voucher
@voucher_id varchar(20),
@discount real,
@mo_ta nvarchar(50),
@start_day date,
@end_day date,
@voucher_constraint varchar(10)
as
	update VOUCHER
	set voucher_id = @voucher_id, discount = @discount, mo_ta = @mo_ta, start_day = @start_day, end_day = @end_day, voucher_constraint = @voucher_constraint
	where voucher_id = @voucher_id
--
go
grant exec on dbo.edit_voucher to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.delete_voucher
@voucher_id varchar(20)
as
	delete from Voucher where voucher_id = @voucher_id
--
go
grant exec on dbo.delete_voucher to [Quản lý cửa hàng] as [dbo]
go

CREATE Function [dbo].[show_product_in_shop] (@shop_id varchar(8))
-- In ra danh sách sản phẩm theo shop
RETURNS TABLE
AS
RETURN 
select distinct Products.product_id, cost, production_cost, name_product, type 
                from Products inner join PRODUCT_IN_SHOP on Products.product_id = Product_in_shop.product_id 
                where shop_id = @shop_id
--
go
--!!!!!!!!!!!!!!!!!!!
grant select on [dbo].[show_product_in_shop] to [Quản lý cửa hàng] as [dbo]
go

create proc dbo.add_new_product
@cost real,
@production_cost real,
@name_product nvarchar(150),
@type nvarchar(10)
as
	insert into Products( cost, production_cost, name_product, type ) 
	values(@cost, @production_cost, @name_product, @type);
--
go
grant exec on dbo.add_new_product to [Quản lý cửa hàng] as [dbo]
go

create proc dbo.edit_product
@product_id int,
@cost real,
@production_cost real,
@name_product nvarchar(150),
@type nvarchar(10)
as
	update PRODUCTS
	set cost = @cost, production_cost = @production_cost, name_product = @name_product, type = @type
	where product_id = @product_id
--
go
grant exec on dbo.edit_product to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.delete_product
@product_id int
as
	delete from Products where product_id = @product_id
--
go
grant exec on dbo.delete_product to [Quản lý cửa hàng] as [dbo]
go

CREATE Function [dbo].[show_order_in_shop] (@shop_id varchar(8))
-- In ra danh sách đơn hàng theo shop
RETURNS TABLE
AS
RETURN 
select order_list.order_id, c_phone_number, create_day, shop_id, payment_method, voucher_id, 
                payment_amount, payment_status from order_list inner join payment 
				on order_list.order_id = payment.order_id where shop_id =@shop_id
--
go
--!!!!!!!!!!!!!!!!!!!!!!!
grant select on [dbo].[show_order_in_shop] to [Quản lý cửa hàng] as [dbo]
go

CREATE Function [dbo].[show_employee_in_shop] (@shop_id varchar(8))
-- In ra danh sách nhân viên theo shop
RETURNS TABLE
AS
RETURN 
select emp_id, emp_name, phone_number,emp_role_name, begin_date, shop_id, username 
	from Employee inner join Emp_Role on Employee.emp_role = Emp_Role.emp_role_id 
	where shop_id = @shop_id
--
go
--!!!!!!!!!!!!!!!!!!!!!!!!!!!
grant select on [dbo].[show_employee_in_shop] to [Quản lý cửa hàng] as [dbo]
go


create proc dbo.add_product_in_shop
@product_id int,
@shop_id varchar(8),
@status varchar(10)
as
	insert into Product_in_shop(product_id, shop_id, status ) 
	values(@product_id, @shop_id, @status);
--
go
grant exec on dbo.add_product_in_shop to [Quản lý cửa hàng] as [dbo]
go

create proc dbo.edit_product_in_shop
@product_id int,
@shop_id varchar(8),
@status varchar(10)
as
update PRODUCT_IN_SHOP
	set product_id = @product_id, shop_id = @shop_id, status = @status
	where product_id = @product_id
--
go
grant exec on dbo.edit_product_in_shop to [Quản lý cửa hàng] as [dbo]
go

create procedure dbo.delete_product_in_shop
@product_id int
as
	delete from Product_in_shop where product_id = @product_id
grant exec on dbo.delete_product_in_shop to [Quản lý cửa hàng] as [dbo]
go
--