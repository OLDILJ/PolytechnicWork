-- database: :memory:
-- NUKE EVERYTHING

PRAGMA writable_schema = 1;
delete from sqlite_master where type in ('table', 'index', 'trigger');
PRAGMA writable_schema = 0;
VACUUM;
pragma integrity_check;

-- test code environment

CREATE TABLE AfflictedStatusEffect (
    AfflictedStatusEffect_ID INTEGER PRIMARY KEY,
    StatusEffect_ID INTEGER,
    Battle_ID INTEGER,
    FOREIGN KEY (StatusEffect_ID) REFERENCES StatusEffect(StatusEffect_ID),
    FOREIGN KEY (Battle_ID) REFERENCES BattleMaster(Battle_ID)
);

CREATE TABLE StatusEffect (
    StatusEffect_ID INTEGER PRIMARY KEY,
    Name TEXT,
    Description TEXT
);


-- Team1

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
SELECT * from StatusStatModifier;
SELECT * from BattleMaster;
select * from AfflictedStatusEffect;
select * from StatusEffect;

-- Main Team Select
SELECT *
FROM team
ORDER BY team.Name ASC;

SELECT Team.TeamID, Team.Name, Entity.Status_ID
FROM Team
INNER JOIN Entity ON Team.Entity_ID = Entity.Entity_ID
ORDER BY Entity.Status_ID;

-- Check current/ max hp of 'player1' entity
SELECT Status.Current_HP, Status.Max_health FROM Entity INNER JOIN Status ON Entity.Status_ID = Status.Status_ID WHERE Entity.Name = 'Player1';

SELECT Current_HP FROM Entity INNER JOIN Status WHERE Entity.Name = 'Player1'; -- gives me all current hp without caring for STATUS_ID


-- the GIGA STATEMENT
-- increase Player1 MAX_HEALTH by statmodifier maxhealth mod
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
-- Inner Join
SELECT Entity.Name, Equipment.EquipmentSlot FROM Entity
INNER JOIN Equipment ON Entity.Equipment = Equipment.Name;

SELECT Entity.Name
FROM Entity
LEFT JOIN Equipment ON Entity.Equipment = Equipment.Name
WHERE Equipment.Name IS NULL;

-- Data Inserts


-- Equipment
-- Weapons
INSERT INTO Equipment (Name, EquipmentSlot) VALUES 
('Sword', 'Weapon'),
('Bow', 'Weapon'),
('Staff', 'Weapon'),
('Dagger', 'Weapon');

-- Armor
INSERT INTO Equipment (Name, EquipmentSlot) VALUES 
('Helmet', 'Head'),
('Leather Helmet', 'Head'),
('Steel Helmet', 'Head'),
('Chainmail Helmet', 'Head'),
('Robe', 'Body'),
('Leather Armor', 'Body'),
('Steel Armor', 'Body'),
('Chainmail Armor', 'Body');

-- Accessories
INSERT INTO Equipment (Name, EquipmentSlot) VALUES 
('Boots', 'Feet'),
('Water Walkers', 'Feet'),
('Gloves', 'Hands'),
('Gauntlets', 'Hands'),
('Leather Gloves', 'Hands'),
('Shield', 'Offhand'),
('Magic Shield', 'Offhand'),
('Shield', 'Offhand'),
('Necklace', 'Accessory'),
('Ring', 'Accessory');

-- Status

INSERT INTO Status (Max_health, Current_HP, Max_MP, Current_MP, Strength, Agility, Intelligence, Stamina, Luck, Attack, Accuracy, Defense, Evasion)
VALUES 
('100', '80', '50', '40', '10', '15', '20', '25', '5', '25', '80%', '20', '15%'),
('120', '110', '70', '65', '15', '20', '25', '30', '8', '30', '85%', '25', '20%'),
('80', '70', '40', '35', '8', '12', '18', '20', '3', '20', '75%', '15', '10%'),
('150', '140', '80', '75', '20', '25', '30', '35', '10', '35', '90%', '30', '25%'),
('90', '85', '60', '55', '12', '18', '22', '28', '6', '28', '82%', '22', '18%'),
('120', '110', '70', '65', '25', '15', '10', '30', '8', '30', '85%', '25', '20%');

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

-- Team1
INSERT INTO Entity (Name, Equipment, Status_ID) VALUES 
('Player1', 'Sword', 1),
('Mage', 'Staff', 4);

-- Armor and Accessories for Team1
INSERT INTO Entity (Name, Equipment, Status_ID) VALUES 
('Warrior', 'Steel Helmet', 3);

-- Team2
INSERT INTO Entity (Name, Equipment, Status_ID) VALUES
('Enemy1', 'None', 2);

-- Armor and Accessories for Team2
INSERT INTO Entity (Name, Equipment, Status_ID) VALUES 
('Goblin', 'Leather Helmet', 5),
('Orc', 'Steel Helmet', 6);

-- StatusEffect
INSERT INTO StatusEffect (StatusEffect_ID, Name, Description)
VALUES
(1,'Stunned' , '- Unable to take any action for one turn.'),
(2,'Poisoned' , '- Lose 10 HP per turn.'),
(3,'Slowed' , '- Movement speed reduced by 50%.'),
(4,'Frozen' , '- Unable to take any action until thawed.'),
(5,'Confused' , '- Chance to hit self with attacks.');

-- AfflictedStatusEffect
INSERT INTO AfflictedStatusEffect (AfflictedStatusEffect_ID, StatusEffect_ID, Battle_ID)
VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

-- Team
INSERT INTO Team (Name, Entity_ID) VALUES 
('Team1', 1), -- Player1
('Team1', 3), -- Warrior
('Team1', 4), -- Enemy1

('Team2', 2), -- Mage
('Team2', 5), -- Goblin
('Team2', 6); -- Orc

-- Battle Master
INSERT INTO BattleMaster (Battle_ID, Name, Special_Event, TeamID, Afflicted_Status_effects)
VALUES
(1, 'Battle1', 'Ambush', 1, 1),
(2, 'Battle2', 'Boss Fight', 2, 2),
(3, 'Battle3', 'Siege', 1, 3),
(4, 'Battle4', 'Normal Battle', 1, null),
(5, 'Battle5', 'Blizzard', 2, 4), 
(6, 'Battle6', 'Fog', 1, 5); 



-- Update Query
UPDATE Entity 
SET Equipment = 'Dagger' 
WHERE Name = 'Player1';

DELETE FROM Entity WHERE Entity_ID = 4;

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
    Evasion_modifier TEXT
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
    Afflicted_Status_effects INTEGER,
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

CREATE TABLE AfflictedStatusEffect (
    AfflictedStatusEffect_ID INTEGER PRIMARY KEY,
    StatusEffect_ID INTEGER,
    Battle_ID INTEGER,
    FOREIGN KEY (StatusEffect_ID) REFERENCES StatusEffect(StatusEffect_ID),
    FOREIGN KEY (Battle_ID) REFERENCES BattleMaster(Battle_ID)
);

CREATE TABLE StatusEffect (
    StatusEffect_ID INTEGER PRIMARY KEY,
    Name TEXT,
    Description TEXT
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

create table statusEffect(

)