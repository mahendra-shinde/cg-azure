CREATE table customers
(
 CustomerId int primary key identity,
 FirstName varchar(20) not null,
 LastName varchar(20) not null,
 PhoneNo varchar(10),
 EMail varchar(50)
)

INSERT into customers(FirstName, LastName, PhoneNo, EMail)
values ('Dharmendra','Deol','6787687688','dharam@xys.com');


INSERT into CUstomers(FirstName, LastName, PhoneNo, EMail)
values ('Hema','Malini','6787687118','hema@xys.com');