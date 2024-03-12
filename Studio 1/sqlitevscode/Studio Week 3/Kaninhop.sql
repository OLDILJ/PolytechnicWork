-- database: :memory:
create table Owner(
    name text primary key not null
);
create table Rabbits(
    name text primary key not null,
    breed text,
    owner_name text,
    foreign key (owner_name) references Owner(name)
);
create table Events(
    name text primary key not null,
    tournament_name text,
    foreign key (tournament_name) references Tournament(name)
);
create table EventRabbit(
    EventID text,
    RabbitID text,
    score INTEGER,
    foreign key (EventID) references Events(name),
    foreign key (RabbitID) references Rabbits(name)
);
create table Tournament(
    name text primary key not null
);


select * from Owner;
select * from Rabbits;
select * from Events;
select * from EventRabbit;
select * from Tournament;

SELECT * FROM Owner INNER JOIN Rabbits INNER JOIN EventRabbit INNER JOIN Events INNER JOIN Tournament;
select * from EventRabbit;
select * from EventRabbit ORDER BY score asc;
SELECT (RabbitID,score) from EventRabbit;
select * from owner inner join Rabbits on (Owner.name = Rabbits.owner_name) where Owner.name like "Zim";
select * from owner inner join EventRabbit inner join Rabbits on (owner.name = Rabbits.owner_name) where owner.name like "Bim";
drop Table Owner;
drop Table Rabbits;
drop Table Events;
drop Table EventRabbit;
drop Table Tournament;

insert into Owner(name) values ("Jim");
insert into Owner(name) values ("Bim");
insert into Owner(name) values ("Lim");
insert into Owner(name) values ("Kim");
insert into Owner(name) values ("Tim");
insert into Owner(name) values ("Zim");

insert into Rabbits(owner_name, breed, name) values ("Jim", "Flemish Giant", "Moses");
insert into Rabbits(owner_name, breed, name) values ("Bim","Britannia Petite","Fluffy");
insert into Rabbits(owner_name, breed, name) values ("Lim","Himalayan", "Talbot");
insert into Rabbits(owner_name, breed, name) values ("Lim","Dwarf Hotot","Chance");
insert into Rabbits(owner_name, breed, name) values ("Kim","Lionhead","Zypp");
insert into Rabbits(owner_name, breed, name) values ("Kim","Dwarf Hotot","Baloo");
insert into Rabbits(owner_name, breed, name) values ("Tim", "Flemish Giant", "Lambchop");
insert into Rabbits(owner_name, breed, name) values ("Tim","Britannia Petite", "Buck");
insert into Rabbits(owner_name, breed, name) values ("Zim","Dwarf", "Gir");
insert into Rabbits(owner_name, breed, name) values ("Zim","Havana", "Fandango");

insert into Events(name,tournament_name) values ("O_Dash", "Otago Kaninhop Tourney");
insert into Events(name,tournament_name) values ("O_High Jump", "Otago Kaninhop Tourney");
insert into Events(name,tournament_name) values ("I_Dash", "Invercargill Kaninhop Tourney");
insert into Events(name,tournament_name) values ("I_High Jump", "Invercargill Kaninhop Tourney");

insert into Tournament(name) VALUES ("Otago Kaninhop Tourney");
insert into Tournament(name) VALUES ("Invercargill Kaninhop Tourney");

insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Moses", 9);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Fluffy", 8);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Talbot", 10);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_High Jump", "Chance", 10);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Zypp", 6);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_High Jump", "Baloo", 5);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Lambchop", 5);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_High Jump", "Buck", 7);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_High Jump", "Gir", 12);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_High Jump", "Fandango", 7);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Moses", 2);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Fluffy", 3);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Talbot", 2);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_Dash", "Chance", 3);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Zypp", 2);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_Dash", "Baloo", 3);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Lambchop", 4);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_Dash", "Buck", 2);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("I_Dash", "Gir", 1);
insert into EventRabbit(EventID,RabbitID,score) VALUES ("O_Dash", "Fandango", 3);
