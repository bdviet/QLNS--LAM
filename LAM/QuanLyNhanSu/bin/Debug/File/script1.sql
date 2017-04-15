use master
go
if  exists (select * from sysobjects where name='KiemTraLogin')
	drop procedure dbo.KiemTraLogin
	go

create procedure dbo.KiemTraLogin
	@loginname nvarchar(50)
as
	Select * from syslogins where name=@loginname

go