-- database: :memory:

///FAKE CODE VERSION BELOW

create table Entity(
Entity_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
EquipmentSlot FOREIGN key not null,
Name text,
TeamID foreign key not null,
Afflicted_Status_effects text,
Equipment text
);

create table Team(
Team Primary key not null,
Name text,
Entity_ID foreign key not null,
TeamID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT
);

create table BattleMaster(
Battle_ID Primary key not null,
Name text,
Special_Event text,
TeamID FOREIGN key not null,
Afflicted_Status_effects text
);

create table Equipment(
Equipment_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
EquipmentSlot PRIMARY key not null,
);

create table StatModifier(
Name text,
StatName foreign key not null
);

create table Entity(
Entity_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
TeamID foreign key not null,
Afflicted_Status_effects text,
Equipment text
);

create table Entity(
Entity_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
TeamID foreign key not null,
Afflicted_Status_effects text,
Equipment text
);
