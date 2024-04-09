-- database: :memory:
-- NUKE EVERYTHING

PRAGMA writable_schema = 1;
delete from sqlite_master where type in ('table', 'index', 'trigger');
PRAGMA writable_schema = 0;
VACUUM;
pragma integrity_check;

-- test code environment


-- big math time
UPDATE Status
SET Max_health = CAST(CAST(Max_health AS INTEGER) + (
    SELECT SUM(CAST(StatModifier.Max_health_modifier AS INTEGER))
    FROM StatusStatModifier
    JOIN StatModifier ON StatusStatModifier.StatModValue = StatModifier.StatModValue
    WHERE StatusStatModifier.Status_ID = Status.Status_ID
) AS TEXT)
WHERE Status_ID = (SELECT Status_ID FROM Entity WHERE Entity_ID = 1);

SELECT Status.Max_health
FROM Entity
JOIN Status ON Entity.Status_ID = Status.Status_ID
WHERE Entity.Entity_ID = 1;

UPDATE Status
SET Max_health = CAST(CAST(Max_health AS INTEGER) - (
    SELECT SUM(CAST(StatModifier.Max_health_modifier AS INTEGER))
    FROM StatusStatModifier
    JOIN StatModifier ON StatusStatModifier.StatModValue = StatModifier.StatModValue
    WHERE StatusStatModifier.Status_ID = Status.Status_ID
) AS TEXT)
WHERE Status_ID = (SELECT Status_ID FROM Entity WHERE Entity_ID = 1);

-- random stuff

-- Query Statements
select * from Equipment;
select * from Status;
select * from StatModifier;
select * from Entity;
select * from Team;
SELECT * FROM StatusStatModifier;
SELECT * FROM BattleMaster;

-- Check current/ max hp of 'player1' entity
SELECT Status.Current_HP, Status.Max_health FROM Entity INNER JOIN Status ON Entity.Status_ID = Status.Status_ID WHERE Entity.Name = 'Player1';

SELECT Current_HP FROM Entity INNER JOIN Status WHERE Entity.Name = 'Player1'; -- gives me all current hp without caring for STATUS_ID


-- the GIGA STATEMENT

UPDATE Status
SET Max_health = CAST(CAST(Max_health AS INTEGER) + (
    SELECT SUM(CAST(StatModifier.Max_health_modifier AS INTEGER))
    FROM StatusStatModifier
    JOIN StatModifier ON StatusStatModifier.StatModValue = StatModifier.StatModValue
    WHERE StatusStatModifier.Status_ID = Status.Status_ID
) AS TEXT)
WHERE Status_ID = (SELECT Status_ID FROM Entity WHERE Entity_ID = 1);

SELECT Status.Max_health
FROM Entity
JOIN Status ON Entity.Status_ID = Status.Status_ID
WHERE Entity.Entity_ID = 1;

UPDATE Status
SET Max_health = CAST(CAST(Max_health AS INTEGER) - (
    SELECT SUM(CAST(StatModifier.Max_health_modifier AS INTEGER))
    FROM StatusStatModifier
    JOIN StatModifier ON StatusStatModifier.StatModValue = StatModifier.StatModValue
    WHERE StatusStatModifier.Status_ID = Status.Status_ID
) AS TEXT)
WHERE Status_ID = (SELECT Status_ID FROM Entity WHERE Entity_ID = 1);

-- BattleMaster sample data query
SELECT BattleMaster.Battle_ID, BattleMaster.Name AS BattleName, BattleMaster.Special_Event, Team.Name AS TeamName
FROM BattleMaster
JOIN Team ON BattleMaster.TeamID = Team.TeamID;

-- Data Inserts

-- Battle Master
INSERT INTO BattleMaster (Battle_ID, Name, Special_Event, TeamID, Afflicted_Status_effects)
VALUES
(1, 'Battle1', 'Ambush', 1, 'Stunned'),
(2, 'Battle2', 'Boss Fight', 2, 'Poisoned'),
(3, 'Battle3', 'Siege', 1, 'Slowed'),
(4, 'Battle4', 'Normal Battle', 1, null);


-- Team
INSERT INTO Team (Name, Entity_ID) VALUES 
('Team1', 1), -- Player1
('Team2', 2); -- Enemy1
-- Equipment
insert into Equipment (Name, EquipmentSlot) VALUES ('Sword', 'Weapon');
insert into Equipment (Name, EquipmentSlot) VALUES ('Shield', 'Offhand');
insert into Equipment (Name, EquipmentSlot) VALUES ('Helmet', 'Head');
insert into Equipment (Name, EquipmentSlot) VALUES ('Boots', 'Feet');
INSERT INTO Equipment (Name, EquipmentSlot) VALUES ('Ring', 'Accessory');

-- Status

INSERT INTO Status (Max_health, Current_HP, Max_MP, Current_MP, Strength, Agility, Intelligence, Stamina, Luck, Attack, Accuracy, Defense, Evasion)
VALUES 
('100', '80', '50', '40', '10', '15', '20', '25', '5', '25', '80%', '20', '15%'),
('120', '110', '70', '65', '15', '20', '25', '30', '8', '30', '85%', '25', '20%'),
('80', '70', '40', '35', '8', '12', '18', '20', '3', '20', '75%', '15', '10%'),
('150', '140', '80', '75', '20', '25', '30', '35', '10', '35', '90%', '30', '25%'),
('90', '85', '60', '55', '12', '18', '22', '28', '6', '28', '82%', '22', '18%');

-- Stat Mod

INSERT INTO StatModifier (StatModValue, Name, Max_health_modifier, Current_HP_modifier, Max_MP_modifier, Current_MP_modifier, Strength_modifier, Agility_modifier, Intelligence_modifier, Stamina_modifier, Luck_modifier, Attack_modifier, Accuracy_modifier, Defense_modifier, Evasion_modifier)
VALUES 
(1, 'Health Boost', '+10', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, 'Strength Potion', NULL, NULL, NULL, NULL, '+5', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(3, 'Agility Elixir', NULL, NULL, NULL, NULL, NULL, '+3', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(4, 'Mana Crystal', NULL, NULL, '+20', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(5, 'Luck Charm', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '+2', NULL, NULL, NULL, NULL),
(6, 'Defense Potion', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '+10', NULL);

-- Stat Mod Mod
INSERT INTO StatusStatModifier (Status_ID, StatModValue)
VALUES 
(1, 1), -- Status 1, StatModifier 1
(1, 2), -- Status 1, StatModifier 2
(2, 2); -- Status 2, StatModifier 2

-- Entity
INSERT INTO Entity (Name, Equipment, Status_ID)
VALUES ('Player1', 'Sword', 1);

INSERT INTO Entity (Name, Equipment, Status_ID)
VALUES ('Enemy1', 'None', 2);

-- Main Code

create table Equipment(
Equipment_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
EquipmentSlot text not null
);

create table Status(
Status_ID INTEGER PRIMARY KEY AUTOINCREMENT,
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

CREATE TABLE StatModifier(
    StatModValue INTEGER PRIMARY KEY,
    Name TEXT,
    Max_health_modifier TEXT,
    Current_HP_modifier TEXT,
    Max_MP_modifier TEXT,
    Current_MP_modifier TEXT,
    Strength_modifier TEXT,
    Agility_modifier TEXT,
    Intelligence_modifier TEXT,
    Stamina_modifier TEXT,
    Luck_modifier TEXT,
    Attack_modifier TEXT,
    Accuracy_modifier TEXT,
    Defense_modifier TEXT,
    Evasion_modifier TEXT/*
    FOREIGN KEY (Max_health_modifier) REFERENCES Status(Max_health),
    FOREIGN KEY (Current_HP_modifier) REFERENCES Status(Current_HP),
    FOREIGN KEY (Max_MP_modifier) REFERENCES Status(Max_MP),
    FOREIGN KEY (Current_MP_modifier) REFERENCES Status(Current_MP),
    FOREIGN KEY (Strength_modifier) REFERENCES Status(Strength),
    FOREIGN KEY (Agility_modifier) REFERENCES Status(Agility),
    FOREIGN KEY (Intelligence_modifier) REFERENCES Status(Intelligence),
    FOREIGN KEY (Stamina_modifier) REFERENCES Status(Stamina),
    FOREIGN KEY (Luck_modifier) REFERENCES Status(Luck),
    FOREIGN KEY (Attack_modifier) REFERENCES Status(Attack),
    FOREIGN KEY (Accuracy_modifier) REFERENCES Status(Accuracy),
    FOREIGN KEY (Defense_modifier) REFERENCES Status(Defense),
    FOREIGN KEY (Evasion_modifier) REFERENCES Status(Evasion) */
);

CREATE TABLE StatusStatModifier (
    Status_ID INTEGER,
    StatModValue INTEGER,
    FOREIGN KEY (Status_ID) REFERENCES Status(Status_ID),
    FOREIGN KEY (StatModValue) REFERENCES StatModifier(StatModValue),
    PRIMARY KEY (Status_ID, StatModValue)
);

create table Entity(
Entity_ID INTEGER PRIMARY KEY AUTOINCREMENT,
Name TEXT,
Afflicted_Status_effects TEXT,
Equipment TEXT,
Status_ID INTEGER,
FOREIGN KEY (Status_ID) REFERENCES Status(Status_ID)
);

create table Team(
TeamID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
Entity_ID INTEGER,
foreign key (Entity_ID) REFERENCES Entity(Entity_ID)
);

CREATE TABLE BattleMaster (
    Battle_ID INTEGER PRIMARY KEY NOT NULL,
    Name TEXT,
    Special_Event TEXT,
    TeamID INTEGER NOT NULL,
    Afflicted_Status_effects TEXT,
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

--FAKE CODE VERSION BELOW

/*
create table Entity(
Entity_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
EquipmentSlot FOREIGN key not null,
Name text,
TeamID foreign key not null,
Afflicted_Status_effects text,
Equipment text
);
*/

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
EquipmentSlot text not null
);

create table StatModifier(
Name text,
StatName foreign key not null
);

create table Status(
Entity_ID FOREIGN KEY not null,
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

create table Entity(
Entity_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
Name text,
TeamID foreign key not null,
Afflicted_Status_effects text,
Equipment text
);
