-- database: :memory:
-- SQLite
drop table if exists stuff;

create table people(
id integer primary key autoincrement not null,
name text,
age integer,
phone text,
town text, 
address text,
eye_colour text,
height_metres real
);

insert into people(name, age, phone, town, address, eye_colour, height_metres) values ("bob", 32, "021 456 898", "Dunedin", "3 George St", "brown", 1.89);
insert into people(name, age, phone, town, address, eye_colour, height_metres) values ("jane", 21, "022 654 4568", "Dunedin", "2 Moray Pl", "hazel", 1.69);
insert into people(name, age, phone, town, address, eye_colour, height_metres) values ("ngaire", 56, "021 325 9874", "Mosgiel", "6 William St", "grey", 1.50);
insert into people(name, age, phone, town, address, eye_colour, height_metres) values ("josh", 27, "023 122 7895", "Port Chalmers", "9 Argyle St", "brown", 1.74);
insert into people(name, age, phone, town, address, eye_colour, height_metres) values ("pete", 27, "023 122 7895", "Port Chalmers", "9 Argyle St", "blue", 1.70);

Select * from people;

-- Criteria added to a select statement
select * from people
where phone like "021%";

select * from people
where phone not like "021%";

select * from people 
where height_metres > 1.7;

select * from people 
where height_metres >= 1.7;

select * from people 
where name not like "bob";

select * from people
where town like "Dunedin" or town like "Port Chalmers";

select * from people
where town like "Dunedin" and eye_colour like "Brown";

select * from people
where town like "Dunedin" and eye_colour like "Hazel";

select * from people
where town like "Dunedin" and eye_colour not like "Hazel";