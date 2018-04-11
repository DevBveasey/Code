----------------------------------------------------------------
-- Script Name:		SQL6LAB
-- Developer:       	Brandon Veasey
-- Creation Date:	10/25/2016
-- Description:		Create, Insert, Update, Delete, Alter, and Display Table Data              
----------------------------------------------------------------

-- *************************************************************
-- TAL Distributors – Create, Insert, Update, Delete, Alter
-- *************************************************************

-- A.
CREATE TABLE BVEASEY.NONGAME
(ITEM_NUM CHAR(4) PRIMARY KEY,
DESCRIPTION CHAR(30) NOT NULL,
ON_HAND INT DEFAULT 0,
CATEGORY CHAR(3),
PRICE DECIMAL(6,2) NOT NULL);

-- B.
INSERT INTO BVEASEY.NONGAME
SELECT ITEM_NUM, DESCRIPTION, ON_HAND, CATEGORY, PRICE
FROM BVEASEY.ITEM
WHERE CATEGORY != 'GME';

-- C.
UPDATE BVEASEY.NONGAME
SET DESCRIPTION = 'Classic Train Set'
WHERE ITEM_NUM = 'DL51';

-- D.
UPDATE BVEASEY.NONGAME
SET PRICE = PRICE + (PRICE * 0.02)
WHERE CATEGORY = 'TOY';

-- E.
INSERT INTO BVEASEY.NONGAME
VALUES( 'TL92', 'Dump Truck', '10', 'TOY', '59.95');

-- F.
DELETE FROM BVEASEY.NONGAME
WHERE CATEGORY = 'PZL';

-- G.
UPDATE BVEASEY.NONGAME
SET CATEGORY = NULL
WHERE ITEM_NUM = 'FD11';

-- H.
ALTER TABLE BVEASEY.NONGAME
ADD ON_HAND_VALUE DECIMAL(7,2);

-- I.
UPDATE BVEASEY.NONGAME
SET ON_HAND_VALUE = PRICE * ON_HAND;

-- J.
ALTER TABLE BVEASEY.NONGAME
ALTER COLUMN DESCRIPTION CHAR(40);

-- K.
UPDATE BVEASEY.NONGAME
SET ON_HAND = ON_HAND + 6
WHERE DESCRIPTION IN ('race car', 'army tank', 'dump truck', 'fire engine');

-- L.
UPDATE BVEASEY.NONGAME
SET CATEGORY = 'TSP'
WHERE DESCRIPTION LIKE '%SeT%';

-- *************************************************************
-- Colonial Adventure Tours – Create, Insert, Update, Delete, Alter
-- *************************************************************

-- A.
CREATE TABLE BVEASEY.PADDLING
(TRIP_ID INT NOT NULL PRIMARY KEY,
TRIP_NAME CHAR(75) NOT NULL,
STATE CHAR(2) NOT NULL,
DISTANCE INT,
MAX_GRP_SIZE INT NOT NULL,
SEASON CHAR(20) NOT NULL);

-- B.
INSERT INTO BVEASEY.PADDLING
SELECT TRIP_ID, TRIP_NAME, STATE, DISTANCE, MAX_GRP_SIZE, SEASON
FROM BVEASEY.TRIP
WHERE TYPE = 'Paddling';

-- C.
UPDATE BVEASEY.PADDLING
SET MAX_GRP_SIZE = MAX_GRP_SIZE + 2
WHERE STATE = 'CT';

-- D.
INSERT INTO BVEASEY.PADDLING
VALUES( '43', 'Lake Champlain Tour', 'VT','16', '12', 'Summer');

-- E.
DELETE FROM BVEASEY.PADDLING
WHERE TRIP_ID = 23;

-- F.
UPDATE BVEASEY.PADDLING
SET DISTANCE = NULL
WHERE TRIP_ID = 34;

-- G.
ALTER TABLE BVEASEY.PADDLING
ADD DIFFICULTY_LEVEL CHAR(3);

-- H.
UPDATE BVEASEY.PADDLING
SET DIFFICULTY_LEVEL = 'MOD';

-- I.
UPDATE BVEASEY.PADDLING
SET DIFFICULTY_LEVEL = 'HRD'
WHERE TRIP_NAME = 'Lake Champlain Tour';

-- J.
ALTER TABLE BVEASEY.PADDLING
ALTER COLUMN SEASON CHAR(25);

-- K.
UPDATE BVEASEY.PADDLING
SET DISTANCE = DISTANCE - 3
WHERE TRIP_NAME LIKE ('%Tour%')
AND DISTANCE IS NOT NULL;

-- L.
UPDATE BVEASEY.PADDLING
SET SEASON = 'Mid-Summer'
WHERE TRIP_NAME LIKE ('%River%');

-- *************************************************************
-- Generate Query Results
-- *************************************************************

-- 1.
SELECT * FROM BVEASEY.NONGAME;

-- 2.
SELECT * FROM BVEASEY.PADDLING;
