----------------------------------------------------------------
-- Script Name:	SQL3LAB
-- Developer:  Brandon Veasey     
-- Creation Date: 09/13/2016 	
-- Description:   Create table shells, insert data into tables, and select data from tables
----------------------------------------------------------------

-- *************************************************************
-- TAL Distributors � Create Tables and Insert Data
-- *************************************************************

-----------------------------
-- Create the Sales REP Table
-----------------------------

CREATE TABLE BVEASEY.REP
(REP_NUM CHAR(2) PRIMARY KEY,
LAST_NAME CHAR(15) NOT NULL,
FIRST_NAME CHAR(15) NOT NULL,
STREET CHAR(15) NOT NULL,
CITY CHAR(15) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL,
COMMISSION DECIMAL(7,2) DEFAULT 0.00,
RATE DECIMAL(3,2) );

---------------------------------------
-- Insert Data Into the Sales REP Table
---------------------------------------

INSERT INTO BVEASEY.REP
VALUES
('15','Campos','Rafael','724 Vinca Dr.','Grove','CA','90092',23457.50,0.06);

INSERT INTO BVEASEY.REP
VALUES
('30','Gradey','Megan','632 Liatris St.','Fullton','CA','90085',41317.00,0.08);

INSERT INTO BVEASEY.REP
VALUES
('45','Tian','Hui','1785 Tyler Ave.','Northfield','CA','90098',27789.25,0.06);

INSERT INTO BVEASEY.REP
VALUES
('60','Sefton','Janet','267 Oakley St.','Congaree','CA','90097',0.00,0.06);

--------------------------------------------------
-- Insert Additional Data Into the Sales REP Table
--------------------------------------------------

INSERT INTO BVEASEY.REP
VALUES
('65','Banks','David','101 W. 3rd St.','Los Angeles','CA','90001',17775.75,0.06);

INSERT INTO BVEASEY.REP
VALUES
('70','Winslow','Mellissa','155 Grant Rd.','Mesa','CA','90104',2250.50,0.05);

INSERT INTO BVEASEY.REP (REP_NUM, LAST_NAME, FIRST_NAME, STREET, CITY, STATE, POSTAL_CODE, COMMISSION) 
VALUES
('75','Lowe','Samuel','9812 Oak Ave.','Fullton','CA','90085',0.00,NULL);

-----------------------------
-- Create the CUSTOMERS Table
-----------------------------

CREATE TABLE BVEASEY.CUSTOMERS
(CUSTOMER_NUM CHAR(3) PRIMARY KEY,
CUSTOMER_NAME CHAR(35) NOT NULL,
STREET CHAR(20) NOT NULL,
CITY CHAR(15) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL,
BALANCE DECIMAL(8,2) DEFAULT 0.0,
CREDIT_LIMIT DECIMAL(8,2),
REP_NUM CHAR(2) NOT NULL);

---------------------------------------
-- Insert Data Into the CUSTOMERS Table
---------------------------------------

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('126','Toys Galore','28 Laketon St.','Fullton','CA','90085',1210.25,7500.00,'15');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('260','Brookings Direct','452 Columbus Dr.','Grove','CA','90092',575.00,10000.00,'30');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('334','The Everything Shop','342 Magee St.','Congaree','CA','90097',2345.75,7500.00,'45');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('386','Johnson''s Department Store','124 Main St.','Northfield','CA','90098',879.25,7500.00,'30');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('440','Grove Historical Museum Store','3456 Central Ave.','Fullton','CA','90085',345.00,5000.00,'45');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('502','Cards and More','167 Hale St.','Mesa','CA','90104',5025.75,5000.00,'15');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('586','Almondton General Store','3345 Devon Ave.','Almondton','CA','90125',3456.75,15000.00,'45');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('665','Cricket Gift Shop','372 Oxford St.','GROVE','CA','90092',678.90,7500.00,'30');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('713','Cress Store','12 Rising Sun Ave.','Congaree','CA','90097',4234.60,10000.00,'15');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('796','Unique Gifts','786 Passmore St.','Northfield','CA','90098',124.75,7500.00,'45');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('824','Kline''s','945 Gilham St.','Mesa','CA','90104',2475.99,15000.00,'30');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('893','All Season Gifts','382 Wildwood Ave.','Fullton','CA','90085',935.75,7500.00,'15');

--------------------------------------------------
-- Insert Additional Data Into the CUSTOMERS Table
--------------------------------------------------

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('899','Toddler Toys','20 Mall Rd.','Fullton','CA','90085',1000.00,10000.00,'75');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('900','Classic Toys','1 Ashville Center','Mesa','CA','90104',0.00,7500.00,'30');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('901','Moore Gifts','206 Greenway Pl.','Grove','CA','90092',2265.50,NULL,'70');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('902','The Toy Store','5 Vine Center','Northfield','CA','90098',0.00,NULL,'45');

INSERT INTO BVEASEY.CUSTOMERS
VALUES
('903','Little People Gifts','18898 South St.','Los Angeles','CA','90001',5975.25,15000.00,'65');

SELECT * FROM bveasey.REP

--------------------------
-- Create the ORDERS Table
--------------------------

CREATE TABLE BVEASEY.ORDERS
(ORDER_NUM CHAR(5) PRIMARY KEY,
ORDER_DATE DATE,
CUSTOMER_NUM CHAR(3) NOT NULL);

------------------------------------
-- Insert Data Into the ORDERS Table
------------------------------------

INSERT INTO BVEASEY.ORDERS
VALUES
('51608','10-12-2015','126');

INSERT INTO BVEASEY.ORDERS
VALUES
('51610','10-12-2015','334');

INSERT INTO BVEASEY.ORDERS
VALUES
('51613','10-13-2015','386');

INSERT INTO BVEASEY.ORDERS
VALUES
('51614','10-13-2015','260');

INSERT INTO BVEASEY.ORDERS
VALUES
('51617','10-15-2015','586');

INSERT INTO BVEASEY.ORDERS
VALUES
('51619','10-15-2015','126');

INSERT INTO BVEASEY.ORDERS
VALUES
('51623','10-15-2015','586');

INSERT INTO BVEASEY.ORDERS
VALUES
('51625','10-16-2015','796');

-----------------------------------------------------
-- Insert Additional Data Into the ORDERS Table
-----------------------------------------------------

INSERT INTO BVEASEY.ORDERS
VALUES
('51626','10-16-2015','900');

INSERT INTO BVEASEY.ORDERS
VALUES
('51627','10-17-2015','440');

INSERT INTO BVEASEY.ORDERS
VALUES
('51628','10-17-2015','903');

INSERT INTO BVEASEY.ORDERS
VALUES
('51629','10-17-2015','260');

INSERT INTO BVEASEY.ORDERS
VALUES
('51630','10-18-2015','665');

INSERT INTO BVEASEY.ORDERS
VALUES
('51631','10-18-2015','713');

INSERT INTO BVEASEY.ORDERS
VALUES
('51632','10-19-2015','902');

INSERT INTO BVEASEY.ORDERS
VALUES
('51633','10-19-2015','126');

INSERT INTO BVEASEY.ORDERS
VALUES
('51634','10-19-2015','901');

INSERT INTO BVEASEY.ORDERS
VALUES
('51635','10-19-2015','502');

INSERT INTO BVEASEY.ORDERS
VALUES
('51636','10-20-2015','899');

INSERT INTO BVEASEY.ORDERS
VALUES
('51637','10-20-2015','334');

------------------------
-- Create the ITEM Table
------------------------

CREATE TABLE BVEASEY.ITEM
(ITEM_NUM CHAR(4) PRIMARY KEY,
DESCRIPTION CHAR(30) NOT NULL,
ON_HAND INT DEFAULT 0,
CATEGORY CHAR(3) NOT NULL,
STOREHOUSE CHAR(1) NOT NULL,
PRICE DECIMAL(6,2) NOT NULL);

----------------------------------
-- Insert Data Into the ITEM Table
----------------------------------

INSERT INTO BVEASEY.ITEM
VALUES
('AH74','Patience',9,'GME','3',22.99);

INSERT INTO BVEASEY.ITEM
VALUES
('BR23','Skittles',21,'GME','2',29.99);

INSERT INTO BVEASEY.ITEM
VALUES
('CD33','Wood Block Set (48 piece)',36,'TOY','1',89.49);

INSERT INTO BVEASEY.ITEM
VALUES
('DL51','Classic Railway Set',12,'TOY','3',107.95);

INSERT INTO BVEASEY.ITEM
VALUES
('DR67','Giant Star Brain Teaser',24,'PZL','2',31.95);

INSERT INTO BVEASEY.ITEM
VALUES
('DW23','Mancala',40,'GME','3',50.00);

INSERT INTO BVEASEY.ITEM
VALUES
('FD11','Rocking Horse',8,'TOY','3',124.95);

INSERT INTO BVEASEY.ITEM
VALUES
('FH24','Puzzle Gift Set',65,'PZL','1',38.95);

INSERT INTO BVEASEY.ITEM
VALUES
('KA12','Cribbage Set',56,'GME','3',75.00);

INSERT INTO BVEASEY.ITEM
VALUES
('KD34','Pentominoes Brain Teaser',60,'PZL','2',14.95);

INSERT INTO BVEASEY.ITEM
VALUES
('KL78','Pick Up Sticks',110,'GME','1',10.95);

INSERT INTO BVEASEY.ITEM
VALUES
('MT03','Zauberkasten Brain Teaser',45,'PZL','1',45.79);

INSERT INTO BVEASEY.ITEM
VALUES
('NL89','Wood Block Set (62 piece)',32,'TOY','3',119.75);

INSERT INTO BVEASEY.ITEM
VALUES
('TR40','Tic Tac Toe',75,'GME','2',13.99);

INSERT INTO BVEASEY.ITEM
VALUES
('TW35','Fire Engine',30,'TOY','2',118.95);

---------------------------------------------
-- Insert Additional Data Into the ITEM Table
---------------------------------------------

INSERT INTO BVEASEY.ITEM
VALUES
('AQ22','Race Car',24,'TOY','2',79.79);

INSERT INTO BVEASEY.ITEM
VALUES
('EL33','Army Tank',10,'TOY','3',125.25);

INSERT INTO BVEASEY.ITEM
VALUES
('MV99','Lincoln Log Set',16,'GME','1',25.25);

INSERT INTO BVEASEY.ITEM
VALUES
('WD16','Stack�em Tower ',36,'PZL','3',49.95);

INSERT INTO BVEASEY.ITEM
VALUES
('ZZ77','Pin The Tail',48,'GME','2',19.99);

SELECT * FROM bveasey.ITEM
------------------------------
-- Create the ORDER_LINE Table
------------------------------

CREATE TABLE BVEASEY.ORDER_LINE
(ORDER_NUM CHAR(5) NOT NULL,
ITEM_NUM CHAR(4) NOT NULL,
NUM_ORDERED INT,
QUOTED_PRICE DECIMAL(6,2) NOT NULL,
PRIMARY KEY (ORDER_NUM, ITEM_NUM) );

----------------------------------------
-- Insert Data Into the ORDER_LINE Table
----------------------------------------

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51608','CD33',5,86.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51610','KL78',25,10.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51610','TR40',10,13.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51613','DL51',5,104.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51614','FD11',1,124.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51617','NL89',4,115.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51617','TW35',3,116.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51619','FD11',2,121.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51623','DR67',5,29.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51623','FH24',12,36.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51623','KD34',10,13.10);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51625','MT03',8,45.79);

---------------------------------------------------
-- Insert Additional Data Into the ORDER_LINE Table
---------------------------------------------------

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51626','WD16',1,45.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51626','ZZ77',2,17.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51627','AQ22',2,74.79);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51628','EL33',1,120.25);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51628','MV99',1,20.25);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51628','WD16',1,44.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51628','ZZ77',1,14.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51629','AQ22',2,75.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51630','EL33',1,125.25);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51631','MV99',2,21.25);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51631','ZZ77',2,15.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51632','WD16',1,49.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51633','CD33',1,83.49);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51633','KD34',1,12.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51633','TR40',2,10.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51634','AH74',1,22.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51635','KL78',3,8.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51635','TR40',3,10.99);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51636','NL89',NULL,110.74);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51637','DR67',NULL,30.95);

INSERT INTO BVEASEY.ORDER_LINE
VALUES
('51637','EL33',NULL,121.25);

SELECT * FROM bveasey.ORDER_LINE

-- *************************************************************
-- Colonial Adventure Tours � Create Tables and Insert Data
-- *************************************************************

-------------------------
-- Create the GUIDE Table
-------------------------

CREATE TABLE BVEASEY.GUIDE
(GUIDE_NUM   CHAR(4) NOT NULL PRIMARY KEY,
LAST_NAME CHAR(15) NOT NULL,
FIRST_NAME CHAR(15) NOT NULL,
ADDRESS CHAR(25) NOT NULL,
CITY CHAR(25) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL,
PHONE_NUM CHAR (12) NULL,
HIRE_DATE DATE NOT NULL );
-----------------------------------
-- Insert Data Into the GUIDE table
-----------------------------------

INSERT INTO BVEASEY.GUIDE
VALUES
('AM01','Abrams','Miles','54 Quest Ave.','Williamsburg','MA','01096','617-555-6032','6-3-2012');

INSERT INTO BVEASEY.GUIDE
VALUES
('BR01','Boyers','Rita','140 Oakton Rd.','Jaffrey','NH','03452','603-555-2134','3-4-2012');

INSERT INTO BVEASEY.GUIDE
VALUES
('DH01','Devon','Harley','25 Old Ranch Rd.','Sunderland','MA','01375','781-555-7767','1-8-2012');

INSERT INTO BVEASEY.GUIDE
VALUES
('GZ01','Gregory','Zach','7 Moose Head Rd.','Dummer','NH','03588','603-555-8765','11-4-2012');

INSERT INTO BVEASEY.GUIDE
VALUES
('KS01','Kiley','Susan','943 Oakton Rd.','Jaffrey','NH','03452','603-555-1230','4-8-2013');

INSERT INTO BVEASEY.GUIDE
VALUES
('KS02','Kelly','Sam','9 Congaree Ave.','Fraconia','NH','03580','603-555-0003','6-10-2013');

INSERT INTO BVEASEY.GUIDE
VALUES
('MR01','Marston','Ray','24 Shenandoah Rd.','Springfield','MA','01101','781-555-2323','9-14-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('RH01','Rowan','Hal','12 Heather Rd.','Mount Desert','ME','04660','207-555-9009','6-2-2014');

INSERT INTO BVEASEY.GUIDE
VALUES
('SL01','Stevens','Lori','15 Riverton Rd.','Coventry','VT','05825','802-555-3339','9-5-2014');

INSERT INTO BVEASEY.GUIDE
VALUES
('UG01','Unser','Glory','342 Pineview St.','Danbury','CT','06810','203-555-8534','2-2-2015');
----------------------------------------------
-- Insert Additional Data Into the GUIDE Table
----------------------------------------------

INSERT INTO BVEASEY.GUIDE
VALUES
('MG01','Martin','George','12 The Circle','Newport','VT','05855','802-555-6347','2-20-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('JG01','Jarrell','Gladys','100 Pine Ave.','Bristol','CT','06010','860-555-9821','2-24-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('JT01','Jones','Thomas','6336 Forrest Dr.','Alford','ME','01230','413-555-3377','3-9-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('HD01','Hastings','David','3322 West 3rd St.','Burlington','VT','05401','802-555-6814','3-9-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('SL02','Smith','Linda','1221 Main St.','Portland','MA','01311','207-555-1770','4-12-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('MR02','Martin','Ralph','617 Broadway Ave.','West Haven','CT','06516','203-555-6319','4-30-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('AM02','Adams','Michael','1001 Evergreen Pl.','Barre','VT','05641','NULL','5-12-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('LT01','Lomack','Teresa','512 Tower Dr.','Holland','ME','01521','413-555-5108','6-14-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('RH02','Russell','Howard','6719 Brickyard Rd.','Shelton','CT','06484','203-555-0799','7-30-2015');

INSERT INTO BVEASEY.GUIDE
VALUES
('AA01','Antione','Albert','777 Pine St.','Bedford','CT','01730','781-555-3212','9-1-2015');

----------------------------
-- Create the CUSTOMER Table
----------------------------

CREATE TABLE BVEASEY.CUSTOMER
(CUSTOMER_NUM CHAR(4) NOT NULL PRIMARY KEY,
LAST_NAME CHAR(30) NOT NULL,
FIRST_NAME CHAR(30) NOT NULL,
ADDRESS CHAR(35) NOT NULL,
CITY CHAR(35) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL,
PHONE_NUM CHAR (12) NULL);

--------------------------------------
-- Insert Data Into the CUSTOMER Table
--------------------------------------

INSERT INTO BVEASEY.CUSTOMER
VALUES
('101','Northfold','Liam','9 Old Mill Rd.','Londonderry','NH','03053','603-555-7563');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('102','Ocean','Arnold','2332 South St. Apt 3','Springfield','MA','01101','413-555-3212');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('103','Kasuma','Sujata','132 Main St. #1','East Hartford','CT','06108','860-555-0703');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('104','Goff','Ryan','164A South Bend Rd.','Lowell','MA','01854','781-555-8423');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('105','McLean','Kyle','345 Lower Ave.','Wolcott','NY','14590','585-555-5321');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('106','Morontoia','Joseph','156 Scholar St.','Johnston','RI','02919','401-555-4848');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('107','Marchand','Quinn','76 Cross Rd.','Bath','NH','03740','603-555-0456');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('108','Rulf','Uschi','32 Sheep Stop St.','Edinboro','PA','16412','814-555-5521');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('109','Caron','Jean Luc','10 Greenfield St.','Rome','ME','04963','207-555-9643');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('110','Bers','Martha','65 Granite St.','York','NY','14592','585-555-0111');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('112','Jones','Laura','373 Highland Ave.','Somerville','MA','02143','857-555-6258');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('115','Vaccari','Adam','1282 Ocean Walk','Ocean CITY','NJ','08226','609-555-5231');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('116','Murakami','Iris','7 Cherry Blossom St.','Weymouth','MA','02188','617-555-6665');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('119','Chau','Clement','18 Ark Ledge Ln.','Londonderry','VT','05148','802-555-3096');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('120','Gernowski','Sadie','24 Stump Rd.','Athens','ME','04912','207-555-4507');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('121','Bretton-Borak','Siam','10 Old Main St.','Cambridge','VT','05444','802-555-3443');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('122','Hefferson','Orlagh','132 South St. Apt 7','Manchester','NH','03101','603-555-3476');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('123','Barnett','Larry','25 Stag Rd.','Fairfield','CT','06824','860-555-9876');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('124','Busa','Karen','12 Foster St.','South Windsor','CT','06074','857-555-5532');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('125','Peterson','Becca','51 Fredrick St.','Albion','NY','14411','585-555-0900');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('126','Brown','Brianne','154 Central St.','Vernon','CT','06066','860-555-3234');

-------------------------------------------------
-- Insert Additional Data Into the CUSTOMER Table
-------------------------------------------------

INSERT INTO BVEASEY.CUSTOMER
VALUES
('127','Wells','James','35187 Luther Towers','York','PA','17401','717-555-0017');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('128','Cannon','Alicia','77 Branch Ave.','Albany','NY','12201','518-555-3276');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('129','Miner','Gerald','1221 Silver Goose Rd.','Cambridge','MD','21613','410-555-8126');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('130','Ashford','Kimberly','6799 Greenbrier Dev.','Newark','DE','19871','302-555-5612');

INSERT INTO BVEASEY.CUSTOMER
VALUES
('131','Yang','Y.E.','90022 Highland Park Dr.','Athens','ME','04912','NULL');

-------------------------------
-- Create the RESERVATION Table
-------------------------------

CREATE TABLE BVEASEY.RESERVATION
(RESERVATION_ID CHAR(7) NOT NULL PRIMARY KEY,
TRIP_ID INT NOT NULL,
TRIP_DATE DATE NOT NULL,
NUM_PERSONS INT NULL,
TRIP_PRICE DECIMAL(6, 2) NOT NULL,
OTHER_FEES DECIMAL(6, 2) DEFAULT 0.00,
CUSTOMER_NUM CHAR(4) NOT NULL);

-----------------------------------------
-- Insert Data Into the RESERVATION Table
-----------------------------------------

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600001',40,'3-26-2016',2,55.00,0.00,'101');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600002',21,'6-8-2016',2,95.00,0.00,'101');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600003',28,'9-12-2016',1,35.00,0.00,'103');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600004',26,'10-16-2016',4,45.00,15.00,'104');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600005',39,'6-25-2016',5,55.00,0.00,'105');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600006',32,'6-18-2016',1,80.00,20.00,'106');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600007',22,'7-9-2016',8,75.00,10.00,'107');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600008',28,'9-12-2016',2,35.00,0.00,'108');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600009',38,'9-11-2016',2,90.00,40.00,'109');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600010',2,'5-14-2016',3,25.00,0.00,'102');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600011',3,'9-15-2016',3,25.00,0.00,'102');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600012',1,'6-12-2016',4,15.00,0.00,'115');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600013',8,'7-9-2016',1,20.00,5.00,'116');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600014',12,'10-1-2016',2,40.00,5.00,'119');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600015',10,'7-23-2016',1,20.00,0.00,'120');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600016',11,'7-23-2016',6,75.00,15.00,'121');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600017',39,'6-18-2016',3,20.00,5.00,'122');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600018',38,'9-18-2016',4,85.00,15.00,'126');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600019',25,'8-29-2016',2,110.00,25.00,'124');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600020',28,'8-27-2016',2,35.00,10.00,'124');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600021',32,'6-11-2016',3,90.00,20.00,'112');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600022',21,'6-8-2016',1,95.00,25.00,'119');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600024',38,'9-11-2016',1,70.00,30.00,'121');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600025',38,'9-11-2016',2,70.00,45.00,'125');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600026',12,'10-1-2016',2,40.00,0.00,'126');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600029',4,'9-19-2016',4,105.00,25.00,'120');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600030',15,'7-25-2016',6,60.00,15.00,'104');

----------------------------------------------------
-- Insert Additional Data Into the RESERVATION Table
----------------------------------------------------

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600031',5,'5-2-2016',3,60.00,20.00,'130');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600032',42,'8-11-2016',NULL,60.00,25.00,'128');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600033',9,'7-10-2016',NULL,45.00,0.00,'101');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600034',43,'10-4-2016',2,70.00,15.00,'131');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600035',19,'4-29-2016',2,50.00,5.00,'129');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600036',46,'6-25-2016',NULL,30.00,0.00,'115');

INSERT INTO BVEASEY.RESERVATION
VALUES
('1600037',31,'7-22-2016',4,86.00,35.00,'127');

------------------------
-- Create the TRIP Table
------------------------

CREATE TABLE BVEASEY.TRIP
(TRIP_ID INT NOT NULL PRIMARY KEY,
TRIP_NAME CHAR(75) NOT NULL,
START_LOCATION CHAR(50) NOT NULL,
STATE CHAR(2) NOT NULL,
DISTANCE INT NOT NULL,
MAX_GRP_SIZE INT NOT NULL,
TYPE CHAR(20) NOT NULL,
SEASON CHAR(20) NOT NULL);

----------------------------------
-- Insert Data Into the TRIP Table
----------------------------------

INSERT INTO BVEASEY.TRIP
VALUES
(1,'Arethusa Falls ','Harts Location','NH',5,10,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(2,'Mt Ascutney - North Peak','Weathersfield','VT',5,6,'Hiking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(3,'Mt Ascutney - West Peak','Weathersfield','VT',6,10,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(4,'Bradbury Mountain Ride','Lewiston-Auburn','ME',25,8,'Biking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(5,'Baldpate Mountain ','North Newry','ME',6,10,'Hiking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(6,'Blueberry Mountain','Batchelders Grant','ME',8,8,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(7,'Bloomfield - Maidstone','Bloomfield','CT',10,6,'Paddling','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(8,'Black Pond','Lincoln','NH',8,12,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(9,'Big Rock Cave','Tamworth','NH',6,10,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(10,'Mt. Cardigan - Firescrew','Orange','NH',7,8,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(11,'Chocorua Lake Tour','Tamworth','NH',12,15,'Paddling','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(12,'Cadillac Mountain RIDE','Bar Harbor','ME',8,16,'Biking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(13,'Cadillac Mountain','Bar Harbor','ME',7,8,'Hiking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(14,'Cannon Mtn','Franconia','NH',6,6,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(15,'Crawford Path Presidentials Hike','Crawford Notch','NH',16,4,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(16,'Cherry Pond','Whitefield','NH',6,16,'Hiking','Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(17,'Huguenot Head Hike','Bar Harbor','ME',5,10,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(18,'Low Bald Spot Hike','Pinkam Notch','NH',8,6,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(19,'Mason''s Farm ','North Stratford','CT',12,7,'Paddling','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(20,'Lake Mephremagog Tour','Newport','VT',8,15,'Paddling','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(21,'Long Pond','Rutland','MA',8,12,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(22,'Long Pond Tour','Greenville','ME',12,10,'Paddling','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(23,'Lower Pond Tour','Poland','ME',8,15,'Paddling','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(24,'Mt Adams ','Randolph','NH',9,6,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(25,'Mount Battie ride','Camden','ME',20,8,'Biking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(26,'Mount Cardigan Hike','Cardigan','NH',4,16,'Hiking','Late Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(27,'Mt. Chocorua','Albany','NH',6,10,'Hiking','Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(28,'Mount Garfield Hike','Woodstock','NH',5,10,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(29,'Metacomet-Monadnock Trail Hike','Pelham','MA',10,12,'Hiking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(30,'McLennan Reservation Hike','Tyringham','MA',6,16,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(31,'Missisquoi River - VT','Lowell','VT',12,10,'Paddling','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(32,'Northern Forest Canoe Trail','Stark','NH',15,10,'Paddling','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(33,'Park Loop Ride','Mount Desert Island','ME',27,8,'Biking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(34,'Pontook Reservoir Tour','Dummer','NH',15,14,'Paddling','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(35,'Pisgah STATE Park RIDE','Northborough','NH',12,10,'Biking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(36,'Pondicherry Trail Ride','White Mountains','NH',15,16,'Biking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(37,'Seal Beach Harbor','Bar Harbor','ME',5,16,'Hiking','Early Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(38,'Sawyer River Ride','Mount Carrigain','NH',10,18,'Biking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(39,'Welch and Dickey Mountains Hike','Thorton','NH',5,10,'Hiking','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(40,'Wachusett Mountain','Princeton','MA',8,8,'Hiking','Early Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(41,'Westfield River Loop','Fort Fairfield','ME',20,10,'Biking','Late Spring');

---------------------------------------------
-- Insert Additional Data Into the TRIP Table
---------------------------------------------

INSERT INTO BVEASEY.TRIP
VALUES
(42,'Mirror Lake Tour','Tamworth','NH',16,12,'Paddling','Summer');

INSERT INTO BVEASEY.TRIP
VALUES
(43,'Big Sky Mountain','North Newry','ME',10,6,'Hiking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(44,'Blackbird Forrest','Weathersfield','VT',22,15,'Biking','Early Fall');

INSERT INTO BVEASEY.TRIP
VALUES
(45,'Twin Falls','Bloomsfield','CT',14,8,'Hiking','Late Spring');

INSERT INTO BVEASEY.TRIP
VALUES
(46,'Overbridge River','Newport','VT',20,4,'Paddling','Summer');


-------------------------------
-- Create the TRIP_GUIDES Table
-------------------------------

CREATE TABLE BVEASEY.TRIP_GUIDES
(TRIP_ID INT NOT NULL,
GUIDE_NUM CHAR(4) NOT NULL
PRIMARY KEY (TRIP_ID, GUIDE_NUM) );

-----------------------------------------
-- Insert Data Into the TRIP_GUIDES Table
-----------------------------------------

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(1,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(1,'RH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(2,'AM01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(2,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(3,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(4,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(4,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(5,'KS01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(5,'UG01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(6,'RH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(7,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(8,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(9,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(10,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(11,'DH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(11,'KS01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(11,'UG01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(12,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(13,'RH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(14,'KS02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(15,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(16,'KS02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(17,'RH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(18,'KS02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(19,'DH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(20,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(21,'AM01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(22,'UG01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(23,'DH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(23,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(24,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(25,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(26,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(27,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(28,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(29,'DH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(30,'AM01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(31,'SL01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(32,'KS01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(33,'UG01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(34,'KS01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(35,'GZ01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(36,'KS02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(37,'RH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(38,'KS02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(39,'BR01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(40,'DH01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(41,'BR01');

----------------------------------------------------
-- Insert Additional Data Into the TRIP_GUIDES Table
----------------------------------------------------

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(42,'JG01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(43,'SL02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(44,'AA01');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(45,'AM02');

INSERT INTO BVEASEY.TRIP_GUIDES
VALUES
(46,'LT01');

-- *************************************************************
-- Generate Query Results
-- *************************************************************

-- 1. 
SELECT * FROM bveasey.REP

-- 2.
SELECT * FROM bveasey.CUSTOMERS

-- 3.
SELECT * FROM bveasey.ORDERS

-- 4.
SELECT * FROM bveasey.ITEM

-- 5.
SELECT * FROM bveasey.ORDER_LINE

-- 6.
SELECT * FROM bveasey.GUIDE

-- 7.
SELECT * FROM bveasey.CUSTOMER

-- 8.
SELECT * FROM bveasey.RESERVATION

-- 9.
SELECT * FROM bveasey.TRIP

-- 10. 
SELECT * FROM bveasey.TRIP_GUIDES