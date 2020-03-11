use [AdventureWorks2016CTP3]
go
insert HumanResources.Shift(Name, StartTime, EndTime, ModifiedDate)
values('Test Shift 1', getdate() + 1, getdate() + 2, GETDATE())