-- database: :memory:
drop table if exists motorcycle;

create table motorcycle(
bike_id integer primary key autoincrement,
make text,
model text,
year integer,
type text,
engine_capacity integer,
engine_power integer,
dry_weight integer,
price_2020 real
);

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Suzuki", "GN-250e", 2013, "Standard", 250, NULL, 128, 3500); 

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Suzuki", "TU-250", 2009, "Standard", 250, NULL, 140, 7000); 

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Honda", "Nifty 50", 1985, "Scooter", 150, NULL, 45, 12); 

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Piaggio", "Vespa 150", 1956, "Scooter - Anti-tank", 146, NULL, NULL, 23000); 

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Piaggio", "X8", 2006, "Scooter", 125, NULL, 81, 5000); 

insert into motorcycle(make, model, year,type, engine_capacity, engine_power, dry_weight, price_2020) 
values ("Siambretta", "125 Standard", 1956, "Scooter", 125, NULL, NULL, 1000); 

select * from motorcycle;

-- give the Nifty 50 a power rating of one.  Display all fields and records from the table
-- changed update from ID based to name based
update motorcycle set engine_power = 1 where model = "Nifty 50";
select * from motorcycle;

-- update the Suzuki motorcycles to have an engine power of 22 horsepower
update motorcycle set engine_power = 22 where make = "Suzuki";
update motorcycle set engine_power = 22 where make = "Suzuki";
select * from motorcycle;

-- delete the Piaggio Vespa 150 anti-tank scooter. Display all fields and records from the table

delete from motorcycle where make = "Vespa 150";
select * from motorcycle;

-- delete all suzuki motorcycles from the table
delete from motorcycle where make like 'suzuki';
select * from motorcycle;

-- delete the entire table. SHow all records
delete from motorcycle;
select * from motorcycle;