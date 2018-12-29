--Nam
create proc USP_InsertBlockEmp
@id int , @dateUn date, @reason nvarchar(200),@modified date
as
begin
	INSERT INTO Employee.Block (Emp_ID,Reason,BlockDate,UnBlockDate,ModifiedDate)
	values (@id,@reason,@modified,@dateUn,@modified)
end

go
create proc USP_InsertQuitEmp
@id int ,@reason nvarchar(200),@modified date
as
begin
	INSERT INTO Employee.Quit(Emp_ID,Reason,QuitDate,ModifiedDate)
	values (@id,@reason,@modified,@modified)
end
go
create proc USP_UnBlockBlockEmp
@id int ,@date date
as
begin
	update Employee.Block set UnBlockDate=@date
	where Emp_ID=@id
end

go
create proc USP_InsertAccountLog
@id int
as
begin
	INSERT INTO Account.AccountLog(Account_ID)
	values (@id)
end
go

create proc USP_AddManager_id
@id int ,@id_manager int
as
begin
	update Employee.Employee set Manager_ID=@id_manager
	where Employee_ID=@id
end

select Censor, count(s.Post_Status_ID)
from Post.Post_Status s
where s.Status='2'
group by Censor
go

create proc USP_GetPostCountBydate
as
select top(10) CAST( p.PostTime AS date) as [date],count(p.Post_ID) as [count]
from Post.Post p
group by CAST( p.PostTime AS date)
order by CAST( p.PostTime AS date) desc 

exec USP_GetPostCountBydate

--Quoc

CREATE proc [dbo].[USP_InsertBlockCust]
@id1 int, @dateBl datetime, @dateUn datetime, @reason nvarchar(200), @id2 int, @modified datetime
as
begin
	INSERT INTO Customer.Block (Cus_ID,Reason,BlockDate,UnBlockDate,Emp_Block,ModifiedDate)
	values (@id1,@reason,@dateBl,@dateUn,@id2,@modified)
end
GO

CREATE proc [dbo].[USP_UnBlockBlockCust]
@id int, @date1 datetime, @date2 datetime
as
begin
	update Customer.Block set 
	UnBlockDate=@date1,
	ModifiedDate=@date2
	where Cus_ID=@id
end

GO




