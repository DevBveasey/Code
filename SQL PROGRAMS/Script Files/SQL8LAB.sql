----------------------------------------------------------------
-- Script Name:	:   	SQL8LAB
-- Developer:       	Brandon Veasey
-- Creation Date:	11/17/2016
-- Description:		Functions and Procedures
----------------------------------------------------------------

-- *************************************************************
-- TAL Distributors � Generate Query Results
-- *************************************************************

-- 1.
SELECT ITEM_NUM, UPPER(DESCRIPTION) AS UPPERCASE_DESCRIPTION
FROM BVEASEY.ITEM;

-- 2.
SELECT CUSTOMER_NUM, CUSTOMER_NAME, CITY
FROM BVEASEY.CUSTOMERS
WHERE UPPER(CITY) = 'GROVE';

-- 3.
SELECT CUSTOMER_NUM, CUSTOMER_NAME,BALANCE, ROUND(BALANCE,0) AS ROUNDED_BALANCE
FROM BVEASEY.CUSTOMERS
WHERE BALANCE > 0;

-- 4.
SELECT CAST(AVG(BALANCE) AS DECIMAL(10,2)) AS AVG_BAL_2_DECIMALS
FROM BVEASEY.CUSTOMERS;

-- 5.
SELECT CUSTOMER_NUM, CUSTOMER_NAME,BALANCE, FLOOR(BALANCE) AS BALANCE_NO_DECIMALS 
FROM BVEASEY.CUSTOMERS
WHERE BALANCE > 0;

-- 6.
SELECT ORDER_NUM, ORDERS.CUSTOMER_NUM, CUSTOMER_NAME, ORDER_DATE, DATEADD(DAY, 14, ORDER_DATE) AS DATE_PLUS_14_DAYS
FROM BVEASEY.ORDERS, BVEASEY.CUSTOMERS
WHERE ORDERS.CUSTOMER_NUM = CUSTOMERS.CUSTOMER_NUM;

-- 7.
SELECT ORDER_NUM, ORDERS.CUSTOMER_NUM, CUSTOMER_NAME, ORDER_DATE, DATEADD(MONTH, 3, ORDER_DATE) AS DATE_PLUS_3_MONTHS
FROM BVEASEY.ORDERS, BVEASEY.CUSTOMERS
WHERE ORDERS.CUSTOMER_NUM = CUSTOMERS.CUSTOMER_NUM;

-- 8.
SELECT ORDER_NUM, ORDERS.CUSTOMER_NUM, CUSTOMER_NAME, ORDER_DATE, DATEADD(YEAR, 1, ORDER_DATE) AS DATE_PLUS_1_YEAR
FROM BVEASEY.ORDERS, BVEASEY.CUSTOMERS
WHERE ORDERS.CUSTOMER_NUM = CUSTOMERS.CUSTOMER_NUM;

-- 9.
SELECT GETDATE() AS TODAYS_DATE_AND_TIME;

-- 10.
SELECT REP_NUM, RTRIM(FIRST_NAME) + ' ' + RTRIM(LAST_NAME) AS FULL_NAME 
FROM BVEASEY.REP;

-- 11.
SELECT CUSTOMER_NUM, CUSTOMER_NAME, RTRIM(STREET) + ' ' + RTRIM(CITY) + ', ' + RTRIM(STATE) + ' ' + RTRIM(POSTAL_CODE)
AS FULL_ADDRESS
FROM BVEASEY.CUSTOMERS;

-- 12.
SELECT ITEM_NUM, RTRIM(DESCRIPTION) + ' ' + RTRIM(CAST(PRICE AS CHAR))
AS ITEM_INFORMATION
FROM BVEASEY.ITEM;

-- A.
CREATE PROCEDURE BVEASEY.DISP_CUST_CREDIT
@custnum CHAR(3)
AS 
BEGIN
	SELECT CUSTOMER_NUM, CUSTOMER_NAME, CREDIT_LIMIT
	FROM BVEASEY.CUSTOMERS
	WHERE CUSTOMER_NUM = @custnum
END;

-- B.
CREATE PROCEDURE BVEASEY.DISP_ITEM_CATEGORY 
@itemcategory CHAR(3)
AS
BEGIN
	DECLARE @itemnum CHAR(4)
	DECLARE @itemdesc CHAR(30)
	DECLARE @storehse char(1)
	DECLARE @price DECIMAL(6,2)
	DECLARE mycursor CURSOR READ_ONLY

	FOR
		SELECT ITEM_NUM, DESCRIPTION, STOREHOUSE, PRICE
		FROM BVEASEY.ITEM
		WHERE CATEGORY = @itemcategory

	OPEN mycursor
	FETCH NEXT FROM mycursor
	INTO @itemnum, @itemdesc, @storehse, @price

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @itemnum + ' ' + @itemdesc + ' ' + @storehse + ' ' + CAST(@price AS VARCHAR)
			FETCH NEXT FROM mycursor
			INTO @itemnum, @itemdesc, @storehse, @price
		END
END;

CLOSE mycursor
DEALLOCATE mycursor

-- *************************************************************
-- Colonial Adventure Tours � Generate Query Results
-- *************************************************************

-- 13.
SELECT GUIDE_NUM, LOWER(FIRST_NAME) AS LOWERCASE_FIRST, UPPER(LAST_NAME) AS UPPERCASE_LAST
FROM BVEASEY.GUIDE;

-- 14.
SELECT CAST(AVG(TRIP_PRICE) AS DECIMAL(10,2)) AS AVG_TRIP_PRICE_2_DECIMALS
FROM BVEASEY.RESERVATION;

-- 15.
SELECT RESERVATION_ID, TRIP_PRICE, FLOOR(TRIP_PRICE) AS TRIP_PRICE_NO_DECIMALS 
FROM BVEASEY.RESERVATION;

-- 16.
SELECT CUSTOMER_NUM, TRIP_DATE, DATEADD(DAY, 2, TRIP_DATE) AS PLUS_2_DAYS
FROM BVEASEY.RESERVATION
ORDER BY TRIP_DATE;

-- 17.
SELECT GUIDE_NUM, RTRIM(FIRST_NAME) + ' ' + RTRIM(LAST_NAME) AS FULL_NAME 
FROM BVEASEY.GUIDE;

-- 18.
SELECT TRIP_ID, TRIP_NAME
FROM BVEASEY.TRIP
WHERE UPPER(TRIP_NAME) LIKE '%RIDE%';

-- A.
CREATE PROCEDURE BVEASEY.DISP_GUIDE
@guidenum CHAR(4)
AS 
BEGIN
	SELECT GUIDE_NUM, RTRIM(FIRST_NAME) + ' ' + RTRIM(LAST_NAME) AS GUIDE_FULL_NAME
	FROM BVEASEY.GUIDE
	WHERE GUIDE_NUM = @guidenum
END;

-- B.
CREATE PROCEDURE BVEASEY.DISP_CUST_RESERVATION
@customernum CHAR(4)
AS
BEGIN
	DECLARE @reservationid CHAR(7)
	DECLARE @tripid INT
	DECLARE @numpersons INT
	DECLARE @tripprice DECIMAL(6, 2)
	DECLARE mycursor CURSOR READ_ONLY

	FOR
		SELECT RESERVATION_ID, TRIP_ID, NUM_PERSONS, TRIP_PRICE
		FROM BVEASEY.RESERVATION
		WHERE  CUSTOMER_NUM = @customernum

	OPEN mycursor
	FETCH NEXT FROM mycursor
	INTO @reservationid, @tripid, @numpersons, @tripprice

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @reservationid + ' ' + CAST(@tripid AS VARCHAR) + ' ' + CAST(@numpersons AS VARCHAR) + ' ' + CAST(@tripprice AS VARCHAR)
			FETCH NEXT FROM mycursor
			INTO @reservationid, @tripid, @numpersons, @tripprice
		END
END;

CLOSE mycursor
DEALLOCATE mycursor

-- *************************************************************
-- Generate Stored Procedure Query Results
-- *************************************************************

-- 19.
EXECUTE BVEASEY.DISP_CUST_CREDIT '586';

-- 20.
EXECUTE BVEASEY.DISP_ITEM_CATEGORY 'PZL';

-- 21.
EXECUTE BVEASEY.DISP_GUIDE'BR01';

-- 22.
EXECUTE BVEASEY.DISP_CUST_RESERVATION '101';
