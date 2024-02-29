-- database: :memory:
-- SQLite
drop TABLE motorcycle;

create table motorcycle(
make text,
model text,
year integer,
type text,
engine_capacity integer,
engine_power integer,
dry_weight integer,
price_2020 real
);

insert into motorcycle(make, model, year, type, engine_capacity, engine_power, dry_weight, price_2020)
VALUES("suzuki", "gn-250e", 2013, "Standard", 250, NULL, 128, 3500);
insert into motorcycle(make, model, year, type, engine_capacity, engine_power, dry_weight, price_2020)
VALUES("suzukii", "gn-2500e", 2015, "Standard", 252, NULL, 121, 35200);


SELECT make, model, price_2020 FROM motorcycle;
SELECT * FROM motorcycle;

SELECT * from motorcycle WHERE make like "suzuki";
