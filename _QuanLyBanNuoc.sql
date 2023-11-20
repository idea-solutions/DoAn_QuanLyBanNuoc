USE [master]
GO
/****** Object:  Database [_QuanLyBanNuoc]    Script Date: 20/11/2023 9:50:26 PM ******/
CREATE DATABASE [_QuanLyBanNuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'_QuanLyBanNuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\_QuanLyBanNuoc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'_QuanLyBanNuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\_QuanLyBanNuoc.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [_QuanLyBanNuoc] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [_QuanLyBanNuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ANSI_NULLS ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ANSI_PADDING ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ARITHABORT ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET RECOVERY FULL 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET  MULTI_USER 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [_QuanLyBanNuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [_QuanLyBanNuoc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [_QuanLyBanNuoc] SET QUERY_STORE = OFF
GO
USE [_QuanLyBanNuoc]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 20/11/2023 9:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 20/11/2023 9:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[ACCOUNTID] [nchar](10) NOT NULL,
	[PASSWORD] [nchar](10) NOT NULL,
	[FULLNAME] [nvarchar](max) NOT NULL,
	[PHONENUM] [char](10) NOT NULL,
	[DATE] [date] NOT NULL,
 CONSTRAINT [PK_dbo.ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[ACCOUNTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 20/11/2023 9:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[IDBAN] [char](6) NOT NULL,
	[DACHON] [bit] NULL,
 CONSTRAINT [PK_dbo.BAN] PRIMARY KEY CLUSTERED 
(
	[IDBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NUOC]    Script Date: 20/11/2023 9:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NUOC](
	[IDNUOC] [char](5) NOT NULL,
	[TENNUOC] [nvarchar](50) NOT NULL,
	[GIA] [bigint] NOT NULL,
 CONSTRAINT [PK_dbo.NUOC] PRIMARY KEY CLUSTERED 
(
	[IDNUOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_TABLE]    Script Date: 20/11/2023 9:50:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_TABLE](
	[IDBAN] [char](6) NOT NULL,
	[IDORDER] [int] NOT NULL,
	[ACCOUNTID] [nchar](10) NOT NULL,
	[IDNUOC] [char](5) NOT NULL,
	[SOLUONGNUOC] [int] NOT NULL,
	[TONGTIEN] [bigint] NOT NULL,
	[THOIGIAN] [datetime] NULL,
 CONSTRAINT [PK_dbo.ORDER_TABLE] PRIMARY KEY CLUSTERED 
(
	[IDBAN] ASC,
	[IDORDER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202311170429431_CreateDb', N'DoAn_QuanLyBanNuoc.Migrations.Configuration', 0x1F8B0800000000000400D55BCD6EE33610BE17E83B083AB545364AB2DD451BD85B38B6B36BD4B1B3B1BDED2DA025DA112A51AA4405368A3E590F7DA4BE4247FF2229CA92FC932CF6B2A1C86F86C399E1901FFDDF3FFF767ED9D896F28C3DDF744857BD3CBF50154C74C730C9BAAB0674F5E627F5970FDF7ED3191AF646F992F67B1BF68391C4EFAA4F94BAD79AE6EB4FD846FEB96DEA9EE33B2B7AAE3BB6860C47BBBAB8F859BBBCD43040A880A5289D878050D3C6D11FF067DF213A766980AC3BC7C0969FB4C3975984AA4C908D7D17E9B8AB0E9C1E79FC1C2032DEDE2032091CFD3C1AA42A3DCB44A0CF0C5B2B554184381451D0F67AE1E319F51CB29EB9D080ACF9D6C5D06F852C1F27B3B8CEBBD79DD0C55538212D1F9842E9814F1DBB21E0E5DBC4421A3FBC959DD5CC8260C321D89A6EC3594776ECAABD7E7FBA98CC55859775DDB7BCB09FDCCAE7C9D83345EC7196F907B851F8EF4CE907160D3CDC2538A01EB2CE94FB606999FAAF783B77FEC0A44B02CB2AEA0ADAC237A6019AEE3DC7C51EDD3EE0153B83D140553476B8C68FCF468B43E3A9826F80B3ABCA1DDA8C3159D3270803F0EE5B73838DB4817A01B8CA8298101938FD7302CAA3A5853357D22A05DFF766B3DFA60F27977BBB188F27BDBB61855CF82F273841DE73C69FA693E16471B7C78C13390D050F7AF36CBA0344F11C72CD6E90097A36D7511C7070B068C387C779EF660CA80FD88AFAF84FA61B279B34261E997EB79E633F3856EE71C5CF8F3327F0745061EEC8FBCC91B7C69455B3A3E5D15C19E38C2E2DE2BC30FE85637D34B8E94DF8C592F48CB46E9E131211522F7D7F0C27CDB48DC58E087D7B55025258B519753CFC1113EC814F1BF78852ECC1F63271C84E612F96F54683C962DAAF90FAEE18B69D4DC78BE9E46351B4CCBED5407340998F869302CAFB1F9BA37C9A8E3E8E7217CB7352DD14946DD987493F696AA94A3F698AAAAB62144225EA41BB4C35EE93A016FFBDA94AF1FA97E8147E9029C57F13B4123A94A9553B5147666B91A061DC6B4CCCAF34D90E7A7D284652A9370E2C242287AB001AF838BFF3CB62A09533C50EDFC29BC2812FEE4EB1F6CDFDE9257698F970B24B2CBF9D1EA4A6866DA4E15ED4DAA91B2549DEADA559B48E5FF77CDFD1CD489F3C4B32AAB0531C1243D9116DF12A25B10AEB044E6CBAE0B6201D2A1FC16872C46C37C811191BB1C83F08C8E0F0D8C324BC88E883B921844C42C5E830896EBAC8AA9E1637AC51F9AC6532F82F03EC6262808AD516D84B7826830BF65DD6E96805DFA87619C17D652B2CF7E57C89E358AFEF35F222E2946E239B59BDA52B4BC78D1C476684FDC49FC075CA2A6AD94A579EEEF3C5CE0AF8FA3E5459B89FD28D2AA6586729A597758D9CA9C21A7B2B7170978AB73518436104F6121D3E8FC3926A7013B6E30D2D29D4163E4E6A353FA90F78E708716798B2B3F25525DF48798713FC8B8560DC474061BEEE4082545FA648D921811F1AC67AD9D8D28AB0607346385BAB147A498A74DE0D76571199DAE9640557DA5D371430AA8CABB1B3AC6101B15C134D50BD27D6DB150B134896ADC20AD27DF0686628BD0D112DB133C5D74EF28599E4E1586192AAB4BEB755D28A3A4B3D3995A6C55C5ACAB96912D2AD73875C17CE3205122E6951663103D77F336B4E4AD93186A6FB25DC54A66D26893A1E5A63EE2B88064D6F4DCFA70344D11285A79DBE610BDDF8442B493EA9342E978A4B9766A57440F8FFE45E61074F56B2372520B730413BDCDEA25B5DD189C491111D8A2CE4C9EF76FB8E15D864E78E27C7CA49AA2254DE5A1F29A79D8A48796B039D321A89D1296BAD8F14F3424594B84544E868DC32093583E0155C88F25E56CB07ABB3510B37AC00ACE18A95A365464ECE7C452B4B8E8155180937C2A294D23B5538870C8DF444C2AA547E4A91A330CC44118AF9501F2F27288A60796B03A48CA46090B2D657132451E97590E808BDB27954948E3A6634A497D76CE28ADB5ECDAAC4B5E04196258A81E6EB523EECB8E19C5D0333319336D6C789AE758B1851C3891757281EF92E99F4AC88E48AC54E52B8ED7EC625547271175501C33C9B4658C5CDB63EC5F679D8E17CF6A7D5B74C986FDEE10E1173857D1AB30EEAD5C5E515F706ECF5BCC7D27CDFB0EA3DCA6AC19C1CF23514D19F90273C0BD8F3A9D34140F9774CE4197921EE7736DA7CBFF7DBA44368587C766420BA8BDC69F596A715B176DA0734B12985BBAD1131F0A6ABFE150DB95646BF3F46A3CE94A907D17CAD5C287FF33CF07E2F6ACC305B348490C5438DD96443A5336AE1522CB9D9C0B231A12B51E4DD211ED4B4312FFF9C6669AE5BC170EF69C260A3DC1BBF985D6DFD24E35071D62A76F68A02F6A9C3D2A407B28A585E9D92D7170CD3DC8739CA3EDD3F04D2BE3D235FCB9D8F427AEFC37033378DA7A6B54FC46157DF837CC5C4F55E2CF5CBADBCE48877141ABAF9DA7F5DD4F3BE3CF3CB7981FC92FC582C72535F780DB4B1487A482E64F8B7C2724E383E6C43E1B47460C9E3ADEA0884719998868CB28C502E83AECB344B89E632D097A3A079BEB992552C5995AF83631608E55730CD6372C86584F109A7DC802016EFF220B5157EB809C9D537D73944F8334E827526A9657D4664E5A4E995D328EDC2D5D577982238D8A19E47CD15D2297CD6B1EF47CF6CBF202B802E437B898D119906D40D284C19DB4B6B5B344698A3ABE4472C38AB7367EA46EF600F310550D30CCFA6537213989691E97D5B722A904084C93FF9C94FB89634FCE9CF7A9B2189BFFD910125E6CBF6AC39B65D0BC0FC2999A167DC46B7858FC7788DF46D7A252B07D9BD10ACD93B0313AD3D64FB09463E1EFE041F36ECCD87FF01C4E4FA95BF3C0000, N'6.4.4')
GO
INSERT [dbo].[ACCOUNT] ([ACCOUNTID], [PASSWORD], [FULLNAME], [PHONENUM], [DATE]) VALUES (N'admin     ', N'Huynh69@  ', N'Chủ quán nước', N'0365204529', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[ACCOUNT] ([ACCOUNTID], [PASSWORD], [FULLNAME], [PHONENUM], [DATE]) VALUES (N'vanduc    ', N'Huynh69@  ', N'Nguyễn Văn Đức', N'0982423432', CAST(N'2001-06-13' AS Date))
GO
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN001', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN002', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN003', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN004', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN005', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN006', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN007', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN008', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN009', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN010', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN011', 0)
INSERT [dbo].[BAN] ([IDBAN], [DACHON]) VALUES (N'BAN012', 0)
GO
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0001', N'Nước Cam', 5000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0002', N'Nước Chanh', 7000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0003', N'Trà Đào', 10000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0004', N'Trà Tắc', 12000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0005', N'Trà Vải', 15000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0006', N'Trà Sữa', 20000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0007', N'Nước Mía', 5000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0008', N'Nước Khoáng', 6000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0009', N'Pepsi', 10000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0010', N'CocaCola', 10000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0011', N'Nước khoáng Lavi', 5000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0012', N'Trà Mãng Cầu', 25000)
INSERT [dbo].[NUOC] ([IDNUOC], [TENNUOC], [GIA]) VALUES (N'N0013', N'Trà Chanh', 12000)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ACCOUNTID]    Script Date: 20/11/2023 9:50:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_ACCOUNTID] ON [dbo].[ORDER_TABLE]
(
	[ACCOUNTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_IDBAN]    Script Date: 20/11/2023 9:50:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_IDBAN] ON [dbo].[ORDER_TABLE]
(
	[IDBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_IDNUOC]    Script Date: 20/11/2023 9:50:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_IDNUOC] ON [dbo].[ORDER_TABLE]
(
	[IDNUOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDER_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.ACCOUNT_ACCOUNTID] FOREIGN KEY([ACCOUNTID])
REFERENCES [dbo].[ACCOUNT] ([ACCOUNTID])
GO
ALTER TABLE [dbo].[ORDER_TABLE] CHECK CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.ACCOUNT_ACCOUNTID]
GO
ALTER TABLE [dbo].[ORDER_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.BAN_IDBAN] FOREIGN KEY([IDBAN])
REFERENCES [dbo].[BAN] ([IDBAN])
GO
ALTER TABLE [dbo].[ORDER_TABLE] CHECK CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.BAN_IDBAN]
GO
ALTER TABLE [dbo].[ORDER_TABLE]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.NUOC_IDNUOC] FOREIGN KEY([IDNUOC])
REFERENCES [dbo].[NUOC] ([IDNUOC])
GO
ALTER TABLE [dbo].[ORDER_TABLE] CHECK CONSTRAINT [FK_dbo.ORDER_TABLE_dbo.NUOC_IDNUOC]
GO
USE [master]
GO
ALTER DATABASE [_QuanLyBanNuoc] SET  READ_WRITE 
GO
