use books;

create table Orders
(
	OrderNr			int not null,
	[Total Order]	int not null
);

insert into [Books].dbo.Orders(
	OrderNr,
	[Total Order]
)
values
(
	1,
	500
),
(
	100200,
	200
),
(
	500000,
	300
),
(
	1000005,
	1000
);

select
	$partition.OrderPartFunct(OrderNr) filegroup,
	OrderNr
from
	[dbo].[Orders]