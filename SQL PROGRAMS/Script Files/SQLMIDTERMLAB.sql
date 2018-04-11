-------------------------------------------------------------------------
-- Script Name:		SQLMIDTERMLAB
-- Developer:		Brandon Veasey    
-- Creation Date:	09/29/2016
-- Description:		Create Tables, Insert Data, and SIngle Table Queries
-------------------------------------------------------------------------

-- **********************************************************************
-- Solmaris Condominium Group Database Creation and Population - 5 Tables
-- **********************************************************************

----------------------------------
-- Create the Sales LOCATION Table
----------------------------------

CREATE TABLE BVEASEY.LOCATION
(LOCATION_NUM INT PRIMARY KEY NOT NULL,
LOCATION_NAME  CHAR(25) NOT NULL,
ADDRESS CHAR(25) NOT NULL,
CITY CHAR(25) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL);

--------------------------------------
-- Insert Data Into the LOCATION Table
--------------------------------------

INSERT INTO BVEASEY.LOCATION
VALUES
(1,'Solmaris Ocean','100 Ocean Ave.','Bowton','FL','31313');

INSERT INTO BVEASEY.LOCATION
VALUES
(2,'Solmaris Bayside','405 Bayside Blvd.','Glander Bay','FL','31044');

-------------------------------------------------
-- Insert Additional Data Into the LOCATION Table
-------------------------------------------------

INSERT INTO BVEASEY.LOCATION
VALUES
(3,'Solmaris Seaside','555 Seaside Way','Jacksonville','FL','32201');

-------------------------
-- Create the OWNER Table
-------------------------

CREATE TABLE BVEASEY.OWNER
(OWNER_NUM CHAR(5) PRIMARY KEY NOT NULL,
LAST_NAME CHAR(25) NOT NULL,
FIRST_NAME CHAR(25) NOT NULL,
ADDRESS CHAR(25) NOT NULL,
CITY CHAR(25) NOT NULL,
STATE CHAR(2) NOT NULL,
POSTAL_CODE CHAR(5) NOT NULL);

-----------------------------------
-- Insert Data Into the OWNER Table
-----------------------------------

INSERT INTO BVEASEY.OWNER
VALUES
('AD057','Adney','Bruce and Jean','100 Ocean Ave.','Bowton','FL','31313');

INSERT INTO BVEASEY.OWNER
VALUES
('AN175','Anderson','Bill','18 Wilcox St.','Brunswick','GA','31522');

INSERT INTO BVEASEY.OWNER
VALUES
('BL720','Blake','Jack','2672 Condor St.','Mills','SC','29707');

INSERT INTO BVEASEY.OWNER
VALUES
('EL025','Elend','Bill and Sandy','100 Ocean Ave.','BOWTON','FL','31313');

INSERT INTO BVEASEY.OWNER
VALUES
('FE182','Feenstra','Daniel','7822 Coventry Dr.','Rivard','FL','31062');

INSERT INTO BVEASEY.OWNER
VALUES
('JU092','Juarez','Maria','892 Oak St.','Kaleva','FL','31521');

INSERT INTO BVEASEY.OWNER
VALUES
('KE122','Kelly','Alyssa','527 Waters St.','Norton','MI','49441');

INSERT INTO BVEASEY.OWNER
VALUES
('NO225','Norton','Peter and Caitlin','281 Lakewood Ave.','Lawndale','PA','19111');

INSERT INTO BVEASEY.OWNER
VALUES
('RO123','Robinson','Mike and Jane','900 Spring Lake Dr.','Springs','MI','49456');

INSERT INTO BVEASEY.OWNER
VALUES
('SM072','Smeltz','Jim and Cathy','922 Garland Dr.','Lewiston','FL','32765');

INSERT INTO BVEASEY.OWNER
VALUES
('TR222','Trent','Michael','405 Bayside Blvd.','Glander Bay','FL','31044');

INSERT INTO BVEASEY.OWNER
VALUES
('WS032','Wilson','Henry and Karen','25 Nichols St.','Lewiston','FL','32765');

----------------------------------------------
-- Insert Additional Data Into the OWNER Table
----------------------------------------------

INSERT INTO BVEASEY.OWNER
VALUES
('WN090','Williamson','George','331 West 12th St.','Wilmington','DE','19801');

INSERT INTO BVEASEY.OWNER
VALUES
('YO117','Yoder','Mark and Jane','555 S. DuPont Hwy.','Dover','DE','19904');

INSERT INTO BVEASEY.OWNER
VALUES
('ZO200','Zook','Michael and Marsha','6116 Beachview Dr.','Rehoboth Beach','DE','19971');

------------------------------
-- Create the CONDO_UNIT Table
------------------------------

CREATE TABLE BVEASEY.CONDO_UNIT
(CONDO_ID INT PRIMARY KEY NOT NULL,
LOCATION_NUM INT NOT NULL,
UNIT_NUM CHAR(3) NOT NULL,
SQR_FT INT NOT NULL,
BDRMS INT NOT NULL,
BATHS INT NOT NULL,
CONDO_FEE DECIMAL(6, 2) DEFAULT 0.00,
OWNER_NUM CHAR(5) NOT NULL);

----------------------------------------
-- Insert Data Into the CONDO_UNIT Table
----------------------------------------

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(1,1,'102',675,1,1,475.00,'AD057');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(2,1,'201',1030,2,1,550.00,'EL025');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(3,1,'306',1575,3,2,625.00,'AN175');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(4,1,'204',1164,2,2,575.00,'BL720');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(5,1,'405',1575,3,2,625.00,'FE182');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(6,1,'401',1030,2,2,550.00,'KE122');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(7,1,'502',745,1,1,490.00,'JU092');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(8,1,'503',1680,3,3,670.00,'RO123');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(9,2,'A03',725,1,1,190.00,'TR222');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(10,2,'A01',1084,2,1,235.00,'NO225');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(11,2,'B01',1084,2,2,250.00,'SM072');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(12,2,'C01',750,1,1,190.00,'AN175');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(13,2,'C02',1245,2,2,250.00,'WS032');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(14,2,'C06',1540,3,2,300.00,'RO123');

---------------------------------------------------
-- Insert Additional Data Into the CONDO_UNIT Table
---------------------------------------------------

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(15,3,'AA1',2000,3,2,700.00,'ZO200');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(16,3,'CC2',1025,2,1,575.00,'YO117');

INSERT INTO BVEASEY.CONDO_UNIT
VALUES
(17,3,'BB3',1175,2,2,615.00,'WN090');
SELECT * FROM BVEASEY.CONDO_UNIT

------------------------------------
-- Create the SERVICE_CATEGORY Table
------------------------------------

CREATE TABLE BVEASEY.SERVICE_CATEGORY
(CATEGORY_NUM INT PRIMARY KEY NOT NULL,
CATEGORY_DESCRIPTION CHAR(35) NOT NULL);

----------------------------------------------
-- Insert Data Into the SERVICE_CATEGORY Table
----------------------------------------------

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(1,'Plumbing');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(2,'Heating/Air Conditioning');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(3,'Painting');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(4,'Electrical Systems');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(5,'Carpentry');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(6,'Janitorial');

---------------------------------------------------------
-- Insert Additional Data Into the SERVICE_CATEGORY Table
---------------------------------------------------------

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(7,'Appliance Service');

INSERT INTO BVEASEY.SERVICE_CATEGORY
VALUES
(8,'Security Systems');

-----------------------------------
-- Create the SERVICE_REQUEST Table
-----------------------------------

CREATE TABLE BVEASEY.SERVICE_REQUEST
(SERVICE_ID INT PRIMARY KEY NOT NULL,
CONDO_ID INT NOT NULL,
CATEGORY_NUM INT NOT NULL,
DESCRIPTION CHAR(255) NOT NULL,
STATUS CHAR(255) NULL,
EST_HOURS DECIMAL(4, 2) DEFAULT 0.00,
SPENT_HOURS DECIMAL(4, 2) DEFAULT 0.00,
NEXT_SERVICE_DATE DATE NULL);

---------------------------------------------
-- Insert Data Into the SERVICE_REQUEST Table
---------------------------------------------

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(1,2,1,'Back wall in pantry has mold indicating water seepage. Diagnose and repair.','Service rep has verified the problem. Plumbing contractor has been called.',4,2,'10-12-2015');

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(2,5,2,'Air conditioning doesn’t cool.','Service rep has verified problem. Air conditioning contractor has been called.',3,1,'10-12-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(3,4,6,'Hardwood floors must be refinished.','Service call has been scheduled.',8,0,'10-16-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(4,1,4,'Switches in kitchen and adjoining dining room are reversed. ','Open',1,0,'10-13-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST (SERVICE_ID, CONDO_ID,  CATEGORY_NUM, DESCRIPTION, STATUS, EST_HOURS, SPENT_HOURS)
VALUES
(5,2,5,'Molding in pantry must be replaced.','Cannot schedule until water leak is corrected.',2,0);

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(6,14,3,'Unit needs to be repainted due to previous tenant damage.','Scheduled',7,0,'10-19-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST (SERVICE_ID, CONDO_ID,  CATEGORY_NUM, DESCRIPTION, STATUS, EST_HOURS, SPENT_HOURS)
VALUES
(7,11,4,'Tenant complained that using microwave caused short circuits on two occasions.','Service rep unable to duplicate problem. Tenant to notify condo management if problem recurs.',1,1);

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(8,9,3,'Kitchen must be repainted. Walls discolored due to kitchen fire. ','Scheduled',5,0,'10-16-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(9,7,6,'Shampoo all carpets.','Open',5,0,'10-19-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(10,9,5,'Repair window sills.','Scheduled',4,0,'10-20-2015');

--------------------------------------------------------
-- Insert Additional Data Into the SERVICE_REQUEST Table
--------------------------------------------------------

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(11,17,8,'Security system fails to change modes when reset.','Open',1.5,0,'10-24-2015'); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(12,15,7,'Stove trips circuit breaker.','Service rep has verified the problem. Appliance tech has been called.',2.25,1.25,NULL); 

INSERT INTO BVEASEY.SERVICE_REQUEST
VALUES
(13,16,2,'Air conditioning fan not circulating air.','Air conditioning contractor has been called.',6,4.25,'10-31-2015');

-- *********************************************************************
-- Generate Query Results
-- *********************************************************************

-- 1.
SELECT * FROM BVEASEY.LOCATION;

-- 2.
SELECT * FROM BVEASEY.OWNER;

-- 3.
SELECT * FROM BVEASEY.CONDO_UNIT;

-- 4.
SELECT * FROM BVEASEY.SERVICE_CATEGORY;

-- 5.
SELECT SERVICE_ID, CONDO_ID, DESCRIPTION
FROM BVEASEY.SERVICE_REQUEST;

-- 6.
SELECT SERVICE_ID, STATUS, EST_HOURS
FROM BVEASEY.SERVICE_REQUEST;

-- 7.
SELECT SERVICE_ID, SPENT_HOURS, NEXT_SERVICE_DATE
FROM BVEASEY.SERVICE_REQUEST;

-- 8.
SELECT OWNER_NUM, LAST_NAME, FIRST_NAME
FROM BVEASEY.OWNER;

-- 9.
SELECT LOCATION_NUM, LOCATION_NAME
FROM BVEASEY.LOCATION
WHERE LOCATION_NAME LIKE '%side%';

-- 10.
SELECT LAST_NAME, FIRST_NAME, CITY
FROM BVEASEY.OWNER
WHERE CITY = 'Bowton';

-- 11.
SELECT LAST_NAME, FIRST_NAME, CITY
FROM BVEASEY.OWNER
WHERE CITY <> 'Bowton';

-- 12.
SELECT LOCATION_NUM, UNIT_NUM, SQR_FT
FROM BVEASEY.CONDO_UNIT
WHERE SQR_FT <= 1200;

-- 13.
SELECT LOCATION_NUM, UNIT_NUM, BDRMS
FROM BVEASEY.CONDO_UNIT
WHERE BDRMS = 3;

-- 14.
SELECT UNIT_NUM, LOCATION_NUM, BDRMS
FROM BVEASEY.CONDO_UNIT
WHERE BDRMS = 2 and LOCATION_NUM = 2;

-- 15.
SELECT CONDO_ID, CONDO_FEE
FROM BVEASEY.CONDO_UNIT
WHERE CONDO_FEE BETWEEN 550.00 AND 650.00;

-- 16.
SELECT SERVICE_ID, NEXT_SERVICE_DATE
FROM BVEASEY.SERVICE_REQUEST
WHERE NEXT_SERVICE_DATE IS NULL;

-- 17.
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM BVEASEY.CONDO_UNIT
WHERE LOCATION_NUM = 1 and CONDO_FEE < 500.00;

-- 18.
SELECT CONDO_ID, CATEGORY_NUM, EST_HOURS, EST_HOURS * 35.00
as ESTIMATED_COST
FROM BVEASEY.SERVICE_REQUEST;

-- 19.
SELECT OWNER_NUM, LAST_NAME, STATE
FROM BVEASEY.OWNER
WHERE state in ('FL', 'GA', 'SC');

-- 20.
SELECT LOCATION_NUM, UNIT_NUM, SQR_FT, CONDO_FEE
FROM BVEASEY.CONDO_UNIT
order by SQR_FT, CONDO_FEE;

-- 21.
SELECT LOCATION_NUM, count(BDRMS)
as ONE_BEDROOM_CONDOS
FROM BVEASEY.CONDO_UNIT
where BDRMS = 1
group by LOCATION_NUM
order by LOCATION_NUM;
 
 -- 22.
SELECT sum(CONDO_FEE)
as TOTAL_FEES
FROM BVEASEY.CONDO_UNIT;

-- 23.
SELECT SERVICE_ID, DESCRIPTION
FROM BVEASEY.SERVICE_REQUEST
WHERE DESCRIPTION LIKE '%pantry%';

-- 24.
SELECT * FROM BVEASEY.SERVICE_REQUEST
WHERE NEXT_SERVICE_DATE is not null;

-- 25.
SELECT OWNER_NUM, LAST_NAME, ADDRESS
FROM BVEASEY.OWNER
WHERE ADDRESS LIKE '%St.%';