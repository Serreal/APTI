create database SnapBooks_11_033_2020_15_26u
on
(name = Books, filename = 'D:\Practice\Snapshots\MasterData_snapshot.mdf'),
(name = SecData1, filename = 'D:\Practice\Snapshots\SecData1_snapshot.mdf'),
(name = SecData2, filename = 'D:\Practice\Snapshots\SecData2_snapshot.mdf'),
(name = SecData3, filename = 'D:\Practice\Snapshots\SecData3_snapshot.mdf')
as snapshot of Books;
go

use [SnapBooks_11_033_2020_15_26u];
select * from [dbo].[Orders];
go

use Books
go

delete from [dbo].[Orders]
select * from [dbo].[Orders]

insert into Books.[dbo].[Orders]
select * from [SnapBooks_11_033_2020_15_26u].[dbo].[Orders];

select * from dbo.Orders;

use master;

restore database books
from database_snapshot = 'SnapBooks_11_033_2020_15_26u';