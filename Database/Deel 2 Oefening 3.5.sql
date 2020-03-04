use Books;
create table Orders
	(
		OrderNr			int not null,
		[Total Order]	int not null
	);

insert into dbo.Orders values
	(
		(1, 500),
		(100200, 200),
		(500000, 300),
		(1000005, 1000)
	);