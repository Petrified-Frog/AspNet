CREATE TABLE Products(
	Id int not null primary key identity(1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100),
	Price money not null,
	Category nvarchar(20) not null,
	Vendor nvarchar(20) not null
)

CREATE TABLE Customers(
	Id int not null primary key identity(1,1),
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(50) not null unique
)

Scaffold-DbContext "[connectionstring]" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -Context SqlContext -OutputDir Data/Entities