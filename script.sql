USE [master]
GO
/****** Object:  Database [DBQLNS]    Script Date: 22/11/2017 10:32:00 CH ******/
CREATE DATABASE [DBQLNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBQLNS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DBQLNS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBQLNS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DBQLNS_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBQLNS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBQLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBQLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBQLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBQLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBQLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBQLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBQLNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBQLNS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DBQLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBQLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBQLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBQLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBQLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBQLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBQLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBQLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBQLNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBQLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBQLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBQLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBQLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBQLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBQLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBQLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBQLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBQLNS] SET  MULTI_USER 
GO
ALTER DATABASE [DBQLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBQLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBQLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBQLNS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DBQLNS]
GO
/****** Object:  Table [dbo].[_acc]    Script Date: 22/11/2017 10:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_acc](
	[id_User] [int] NULL,
	[tenTaikhoan] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[trangthai] [int] NULL,
	[quyensudung] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[_luongCaNhan]    Script Date: 22/11/2017 10:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_luongCaNhan](
	[id_User] [int] NULL,
	[heSo] [float] NULL,
	[thuongCanhan] [float] NULL,
	[phatCanhan] [float] NULL,
	[ngayBatdauthang] [date] NULL,
	[soNgaynghi] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[_luongTong]    Script Date: 22/11/2017 10:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_luongTong](
	[chietKhau] [float] NULL,
	[luong/ngay] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[_user]    Script Date: 22/11/2017 10:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_user](
	[id_User] [int] NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[birthDay] [date] NULL,
	[CMND] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Sex] [nchar](10) NULL,
	[ngayVaocty] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[thongBao]    Script Date: 22/11/2017 10:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thongBao](
	[id_User] [int] NULL,
	[tieuDe] [nvarchar](100) NULL,
	[noiDung] [nchar](1000) NULL,
	[kieuSend] [nchar](10) NULL,
	[state] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (165486357, N'nvhuong88', N'huonglan', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (148537596, N'vbac24', N'bac24', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (187654107, N'hoa_nc97', N'anhhoa98', 1, N'Quản Lý Nhân Sự')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (1254638756, N'dat09', N'dat98', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (165485357, N'viethung22', N'viethung', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (145257527, N'ngocanh93', N'ngocanh', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (187549646, N'vandan64', N'vandan02', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (181542475, N'thanhdung', N'dung96', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (165489375, N'ducprodoi9', N'ducpro', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (197467356, N'hienhien999', N'hienhien', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (176538978, N'hienngai90', N'hienhien', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (154478575, N'canhphuc03', N'phuc03', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (187542548, N'quochuy03', N'anhhuy', 1, N'Nhân Viên')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (187546852, N'lanhlanh', N'lanhlanh', 1, N'Quản Lý Tài Chính')
INSERT [dbo].[_acc] ([id_User], [tenTaikhoan], [matkhau], [trangthai], [quyensudung]) VALUES (175425869, N'lenghia83', N'lenghia', 1, N'Quản Lý Nhân Sự')
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (165486357, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (148537596, 1, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (175425869, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (187654107, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (1254638756, 1, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (165485357, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (145257527, 1, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (187549646, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (181542475, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (165489375, 1, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (197467356, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (176538978, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (154478575, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (187542548, 1, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongCaNhan] ([id_User], [heSo], [thuongCanhan], [phatCanhan], [ngayBatdauthang], [soNgaynghi]) VALUES (187546852, 1.2, 0, 0, CAST(0x8E3D0B00 AS Date), 0)
INSERT [dbo].[_luongTong] ([chietKhau], [luong/ngay]) VALUES (0.4, 210000)
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (165486357, N'Nguyễn Thị', N'Hường', CAST(0x331A0B00 AS Date), 165486357, N'nvhuong88@gmail.com', N'Việt Phát -165Km13', N'N?        ', CAST(0x7F3D0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (148537596, N'Nguyễn Văn', N'Bắc', CAST(0x29230B00 AS Date), 148537596, N'vbac24@gmail.com', N'Phạm Ngọc Thạch, quận 2', N'Nam       ', CAST(0x46340B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (187654107, N'Nguyễn Công', N'Hòa', CAST(0xCD210B00 AS Date), 187586859, N'conghoanguyen98@gmail.com', N'KTX khu B', N'Nam       ', CAST(0x16310B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (1254638756, N'Ngô Tuấn', N'Đạt', CAST(0xF41A0B00 AS Date), 1254638756, N'dat09@gmail.com', N'12 Lê Duẩn', N'Nam       ', CAST(0xD13A0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (165485357, N'Nguyễn Việt', N'Hưng', CAST(0x6A180B00 AS Date), 165485357, N'viethung98@gmail.com', N'24 Khánh Hòa', N'Nam       ', CAST(0xA83A0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (145257527, N'Dương Thị Ngọc', N'Ánh', CAST(0x161E0B00 AS Date), 145257527, N'ngocanh93@yahoo.com', N'108 Thái Bình', N'N?        ', CAST(0xA9350B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (187549646, N'Trần Văn', N'Dần', CAST(0x1AF10A00 AS Date), 187549646, N'trandan64@yahoo.com', N'209 Phúc Thành', N'Nam       ', CAST(0xF53C0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (181542475, N'Đăng Thanh', N'Dũng', CAST(0x3C1F0B00 AS Date), 181542475, N'thanhdung96@yahoo.com', N'373 Hùng Thành', N'Nam       ', CAST(0x8D390B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (165489375, N'Hà Văn', N'Đức', CAST(0x94010B00 AS Date), 165489375, N'ducprodoi9@gmail.com', N'Hóc Môn Hà Tĩnh', N'Nam       ', CAST(0xB33A0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (197467356, N'Cao Thị', N'Hiên', CAST(0x0F030B00 AS Date), 197467356, N'hienphuong@gmail.com', N'678 Hùng Thành Lạng Sơn', N'N?        ', CAST(0x213C0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (176538978, N'Trần Thị', N'Hiền', CAST(0x861E0B00 AS Date), 176538978, N'hienngai98@gmail.com', N'Ngã Tư Điện Biên Phủ', N'Nam       ', CAST(0x253C0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (154478575, N'Trịnh Cảnh', N'Phúc', CAST(0x5C230B00 AS Date), 154478575, N'conghoanguyen@gmail.com', N'Ktx Khu A', N'Nam       ', CAST(0x633D0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (187542548, N'Trương Quốc', N'Huy', CAST(0x642A0B00 AS Date), 187542548, N'huyhuy28@gmail.com', N'Chợ Chiều', N'Nam       ', CAST(0x8E3D0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (187546852, N'Nguyễn Văn', N'Lành', CAST(0x151C0B00 AS Date), 187546852, N'lanhlanh22@gmail.com', N'Trần Phú', N'Nam       ', CAST(0x793D0B00 AS Date))
INSERT [dbo].[_user] ([id_User], [firstName], [lastName], [birthDay], [CMND], [Email], [Address], [Sex], [ngayVaocty]) VALUES (175425869, N'Lê Thị', N'Nghĩa', CAST(0x720C0B00 AS Date), 175425869, N'lethinghia83@gmail.com', N'108 Lò Đúc', N'N?        ', CAST(0x173C0B00 AS Date))
INSERT [dbo].[thongBao] ([id_User], [tieuDe], [noiDung], [kieuSend], [state]) VALUES (187654107, N'Yêu Cầu Xác Minh', N'Bạn Vui lòng đến bộ phận nhân sự để xác minh thông tin                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', N'Thông Báo ', -2)
INSERT [dbo].[thongBao] ([id_User], [tieuDe], [noiDung], [kieuSend], [state]) VALUES (165485357, N'Đánh nhau', N'Lúc sáng tôi có thấy hai người đánh nhau ở cổng công ty, mong công ty tìm hiểu nguyên nhân để tránh gây hoang mang cho nhân viên khi đi làm việc.
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'Phản Hồi  ', 1)
INSERT [dbo].[thongBao] ([id_User], [tieuDe], [noiDung], [kieuSend], [state]) VALUES (187654107, N'Về việc cúp điện toàn công ty', N'Vào ngày 22 /11, lịch cắt điện các tỉnh thành trong cả nước. Cập nhật thông báo lich cat dien nhanh nhất, chính xác nhất. Lịch cắt điện Bình Dương, Lịch cắt điện, sẽ được thông báo cụ thể sau                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         ', N'Thông Báo ', -2)
INSERT [dbo].[thongBao] ([id_User], [tieuDe], [noiDung], [kieuSend], [state]) VALUES (181542475, N'Thông Báo Nhận Lương', N'Vào ngày 28 / 11 mọi người vui lòng đến bộ phận tài chính để nhận lương tháng 11.
Chân thành cảm ơn!                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'Thông Báo ', -2)
INSERT [dbo].[thongBao] ([id_User], [tieuDe], [noiDung], [kieuSend], [state]) VALUES (187654107, N'Xác Minh', N'Tôi đã xác minh từ trước                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'Phản Hồi  ', 1)
USE [master]
GO
ALTER DATABASE [DBQLNS] SET  READ_WRITE 
GO
