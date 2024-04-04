-- database: :memory:

PRAGMA writable_schema = 1;
delete from sqlite_master where type in ('table', 'index', 'trigger');
PRAGMA writable_schema = 0;
VACUUM;
pragma integrity_check;

create table Equipment(
Equipment_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
EquipmentSlot text not null
);

create table Status(
Max_health text,
Current_HP text,
Max_MP text,
Current_MP text,
Strength text,
Agility text,
Intelligence text,
Stamina text,
Luck text,
Attack text,
Accuracy text,
Defense text,
Evasion text
);

create table StatModifier(
StatModValue INTEGER PRIMARY KEY,
Name text--,
--StatName foreign key not null
);
