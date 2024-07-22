-- database: :memory:
/*
A database to allocate one special toy to each child - no sharing!
This database illustrates how to create a one-to-one relationship between two tables.
*/

drop table if exists children;
drop table if exists toys;

/* Tell SQLite to enforce the rules with foreign and primary keys. */
PRAGMA foreign_keys = ON;

create table children(
child_name text primary key,
age integer
);
create table toys(
toy_name primary key,
description text,
child_name text unique,
foreign key (child_name) references children(child_name)
);

insert into children(child_name, age) values("Bill", 8);
insert into children(child_name, age) values("Sally", 3);
insert into children(child_name, age) values("Jane", 5);

/* Add toys to the toys table, but allocate a different child to each toy */
insert into toys(toy_name, description, child_name) values("Darth Vader","Star Wars","Sally");
insert into toys(toy_name, description, child_name) values("Mr Flopsy","Rabbit","Bill");

/* 
Here we add a new toy, but this time we're trying to add Bill again. Because Bill already has an entry in this table, and there is a UNIQUE constraint on the foreign key in the Toys table, this should throw an error
You will see that Jane has not been allocated a toy, but this should cause us no problems, so we have an optional, one-to-one relationship between these two tables. 

insert into toys(toy_name, description, child_name) values("Truck","Tonka truck","Bill");
*/

select * from children
inner join toys on (children.child_name = toys.child_name);

-- an outer join show all children and if they have a toy
select * from children
left join toys on (children.child_name = toys.child_name);