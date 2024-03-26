create table Entity(
Team Primary key not null,
name text,
turn_order foreign key not null,
type text,
engine_capacity integer,
engine_power integer,
dry_weight integer,
price_2020 real
);
