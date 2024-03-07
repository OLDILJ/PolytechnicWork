-- database: :memory:


create table owner(
    name text primary key not null,
    address text
);

create table vets(
    vet_name text primary key not null,
    clinic_location text
);

create table appt (
    appt_time text,
    pet_name text,
    vet_name text,
    foreign key (pet_name) references pet(pet_name),
    foreign key (vet_name) references vets(vet_name)
);

/* text is used for the PK in this example try and use numbers instead */

create table pet(
    pet_name text primary key not null,
    pet_species text,
    pet_dob text,
    owner_name text,
    foreign key (owner_name) references owner(name)
);

drop TABLE owner;
drop Table pet;
drop TABLE appt;
drop TABLE vets;

insert into owner(name, address) values ("Jim", "Dunedin");
insert into owner(name, address) values ("Jane", "Mosgiel");
insert into owner(name, address) values ("Kerri", "Port Chalmers");

insert into pet(pet_name, pet_species, pet_dob, owner_name)
values ("Rufus", "Dog", "12/10/2017", "Jim");

insert into pet(pet_name, pet_species, pet_dob, owner_name)
values ("Jaws", "Goldfish", "null", "Jane");

insert into pet(pet_name, pet_species, pet_dob, owner_name)
values ("Hank", "Cat", "01/01/2005", "Jim");

insert into pet(pet_name, pet_species, pet_dob, owner_name)
values ("Steenky", "Frog", "null", "Kerri");

select * from vets;
SELECT * from pet;
select * from owner;
SELECT * FROM appt;

Select * from owner inner join pet on (owner.name = pet.owner_name);

select * from owner inner join pet on (owner.name = pet.owner_name) where owner.name like "Jim";

select * from owner inner join pet on (owner.name = pet.owner_name) where pet.pet_species like "cat";

select pet_name from pet where pet.pet_species like "dog";

select * from owner inner join pet on (owner.name = pet.owner_name) where owner.name like "J%";

insert into vets(vet_name, clinic_location) values ("Dr Bob",
"Portobello");

insert into vets(vet_name, clinic_location) values ("Dr Anne",
"South Dunedin");

insert into appt(appt_time, pet_name, vet_name) values
("28/11/2019","Rufus","Dr Bob");
insert into appt(appt_time, pet_name, vet_name) values
("05/12/2019","Jaws","Dr Anne");
insert into appt(appt_time, pet_name, vet_name) values
("10/12/2019","Rufus","Dr Bob");
insert into appt(appt_time, pet_name, vet_name) values
("07/02/2020","Steenky","Dr Anne");
insert into appt(appt_time, pet_name, vet_name) values
("07/02/2020","Hank","Dr Anne");

select * from pet inner join appt on (pet.pet_name = appt.pet_name)
inner join vets on (appt.vet_name = vets.vet_name);
select pet.pet_name, vets.vet_name, appt.appt_time from pet inner join appt on (pet.pet_name = appt.pet_name)
inner join vets on (appt.vet_name = vets.vet_name);

SELECT * from owner inner join pet on (owner_name = pet.owner_name)
inner JOIN appt on (pet.pet_name = appt.pet_name) inner join vets on (appt.vet_name = vets.vet_name);
SELECT owner.name, pet.pet_name, appt.appt_time from owner inner join pet on (owner_name = pet.owner_name)
inner JOIN appt on (pet.pet_name = appt.pet_name) inner join vets on (appt.vet_name = vets.vet_name);

/*  
    Use wildcards i.e "J%" to find people whose name STARTS with J 
    Note there are actual programs that do this better so the use cases are low
*/