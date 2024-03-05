-- database: :memory:


create table owner(
    name text primary key not null,
    address text
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

select * from owner;
SELECT * from pet;

Select * from owner inner join pet on (owner.name = pet.owner_name);

select * from owner inner join pet on (owner.name = pet.owner_name) where owner.name like "Jim";

select * from owner inner join pet on (owner.name = pet.owner_name) where pet.pet_species like "cat";

select pet_name from pet where pet.pet_species like "dog";

select * from owner inner join pet on (owner.name = pet.owner_name) where owner.name like "J%";



/*  
    Use wildcards i.e "J%" to find people whose name STARTS with J 
    Note there are actual programs that do this better so the use cases are low
*/