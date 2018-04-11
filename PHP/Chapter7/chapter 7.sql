----------------------------------
-- Inner Join from the message table
USE FORUM;
SELECT m.message_id, m.subject, f.name 
FROM messages AS m INNER JOIN forums AS f
ON m.forum_id = f.forum_id
WHERE f.name = 'MySQL';
----------------------------------

CREATE DATABASE ENROLLMENTS;
USE ENROLLMENTS;

-- -----------------------------------------------------
-- Table 'enrollments'.'course'
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS 'enrollments'.'course' (
  'course_id' SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT ,
  'name' VARCHAR(50) NOT NULL ,
  PRIMARY KEY ('course_id') )
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table 'enrollments'.'user'
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS 'enrollments'.'user' (
  'user_id' SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT ,
  'name' VARCHAR(30) NOT NULL ,
  'course_id' SMALLINT(5) UNSIGNED NULL ,
  PRIMARY KEY ('user_id') ,
  CONSTRAINT 'course'
    FOREIGN KEY ('user_id' )
    REFERENCES 'enrollments'.'course' ('course_id' )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;

----------------------------------
-- Populate the course table
INSERT INTO course (name) VALUES ('HTML'), ('CSS3'), ('JavaScript'), ('PHP'), ('MySQL');
----------------------------------

----------------------------------
-- Populate the user table
INSERT INTO user (name,course_id) VALUES ('Alice',1), ('Bob',1), ('Caroline',2), ('David',5), ('Emma',NULL);
----------------------------------

----------------------------------
-- Demonstrate inner join
SELECT user.name, course.name FROM 'user' INNER JOIN 'course' on user.course_id = course.course_id; 
----------------------------------

----------------------------------
-- Demonstrate left join
SELECT user.name, course.name FROM 'user' LEFT JOIN 'course' on user.course_id = course.course_id; 
----------------------------------

----------------------------------
-- Demonstrate right join
SELECT user.name, course.name FROM 'user' RIGHT JOIN 'course' on user.course_id = course.course_id; 
-- Change to a left join
SELECT user.name, course.name FROM 'course' LEFT JOIN 'user' on user.course_id = course.course_id; 
----------------------------------

----------------------------------
-- Count the number of students enrolled in each course
SELECT course.name, COUNT(user.name) FROM 'course' 
LEFT JOIN 'user' ON user.course_id = course.course_id 
GROUP BY course.course_id; 
----------------------------------

----------------------------------
-- full outer join using a union
SELECT user.name, course.name FROM 'user' LEFT JOIN 'course' on user.course_id = course.course_id UNION 
SELECT user.name, course.name FROM 'user' RIGHT JOIN 'course' on user.course_id = course.course_id; 

----------------------------------

----------------------------------
-- left join from messages
USE FORUM;
SELECT f.*, m.subject 
FROM forums AS f 
LEFT JOIN messages AS m
ON f.forum_id = m.forum_id;
----------------------------------

----------------------------------
-- self join
SELECT m1.subject, m2.subject AS Reply 
FROM messages AS m1 LEFT JOIN messages AS m2 
ON m1.message_id = m2.parent_id WHERE m1.parent_id=0;
----------------------------------

----------------------------------
-- 3 table join
SELECT u.username, m.subject, f.name 
FROM users AS u 
INNER JOIN messages AS m USING (user_id) 
INNER JOIN forums AS f USING (forum_id) 
ORDER BY m.date_entered DESC 
LIMIT 5;
----------------------------------

----------------------------------
-- Select all messages for the user troutster
SELECT m.message_id, m.subject, f.name FROM users AS u
INNER JOIN messages AS m
USING (user_id)
INNER JOIN forums AS f
USING (forum_id)
WHERE u.username = 'troutster';
----------------------------------

----------------------------------
-- Retrieve the username, message subject, and forum name for every user
SELECT u.username, m.subject, f.name 
FROM users AS u
LEFT JOIN messages AS m USING (user_id)
LEFT JOIN forums AS f USING (forum_id);
----------------------------------

----------------------------------
-- Find the users that have had the five most resent postings, 
-- while also selecting the message subject, and the forum name
SELECT u.username, m.subject, f.name FROM users AS u
INNER JOIN messages AS m USING (user_id)
INNER JOIN forums AS f USING (forum_id)
ORDER BY m.date_entered DESC
LIMIT 5;
----------------------------------

----------------------------------
-- Grouping
USE BANKING;
SELECT COUNT(*) FROM customers;

SELECT SUM(balance) AS Total, 
COUNT(account_id) AS Number, customer_id
FROM accounts
GROUP BY (customer_id);

SELECT SUM(balance) AS Total, 
COUNT(account_id) AS Number, 
CONCAT(c.last_name, ', ', c.first_name) AS Name
FROM accounts AS a
INNER JOIN customers AS c
USING (customer_id)
GROUP BY (a.customer_id)
ORDER BY Name;

SELECT GROUP_CONCAT(balance),
CONCAT(c.last_name, ', ', c.first_name) AS Name
FROM accounts AS a
INNER JOIN customers AS c
USING (customer_id)
GROUP BY (a.customer_id)
ORDER BY Name;
-----------------------------------

-----------------------------------
-- Advanced selections
USE FORUM;
SELECT message_id,
CASE WHEN date_entered > NOW()
THEN 'Future'
ELSE 'Past'
END AS Posted FROM messages
LIMIT 10;

-- For each forum, find the date and time of the most recent post, 
-- or return N/A if the forum has no posts.
SELECT f.name, COALESCE(MAX(m.date_entered), 'N/A') AS last_post
FROM forums AS f
LEFT JOIN messages AS m
USING (forum_id)
GROUP BY (m.forum_id)
ORDER BY m.date_entered DESC;

-- For each message, append the string (Reply) to the subject 
-- if the message is a reply to another message.
SELECT message_id,
CASE parent_id WHEN 0 THEN subject
ELSE CONCAT(subject, ' (Reply)')
END AS subject FROM messages
LIMIT 10;

-- For each user, find the number of messages they’ve posted, 
-- converting zeros to the string None
SELECT username,
IF(COUNT(message_id) > 0,
COUNT(message_id), 'None') AS Posts
FROM users AS u
LEFT JOIN messages AS m
USING (user_id)
GROUP BY (u.user_id);
------------------------------------

------------------------------------
-- add a FULLTEXT index
ALTER TABLE messages ADD FULLTEXT (body, subject);

-- perform a FULLTEXT search
SELECT subject, body FROM messages
WHERE MATCH (body, subject)
AGAINST('html xhtml');

-- If you use the same MATCH…AGAINST expression as a selected value, 
-- the actual relevance will be returned
SELECT subject, body, 
MATCH (body, subject) AGAINST('database') AS R 
FROM messages 
WHERE 
MATCH (body, subject) AGAINST('database');

-- A simple FULLTEXT search that finds HTML, XHTML, or (X)HTML 
SELECT subject, body, MATCH(body, subject)
AGAINST('*HTML >XHTML' IN BOOLEAN MODE) AS R FROM
messages WHERE MATCH(body, subject)
AGAINST('*HTML >XHTML' IN BOOLEAN MODE) ORDER BY R DESC;

-- Find matches involving databases, with an emphasis on normal forms
SELECT subject, body FROM messages
WHERE MATCH (body, subject)
AGAINST('>"normal form"* +database*'
IN BOOLEAN MODE);

-- Find matches involving databases, with an emphasis on normal forms, 
-- with greater importance on XHTML, returning the results in order of relevance
SELECT subject, body, MATCH(body, subject)
AGAINST('*HTML >XHTML' IN BOOLEAN MODE) AS R FROM messages
WHERE MATCH (body, subject)
AGAINST ('*HTML >XHTML' IN BOOLEAN MODE)
ORDER BY R DESC;

-- Explain
USE banking;
EXPLAIN SELECT SUM(balance) AS Total, 
COUNT(account_id) AS Number, 
CONCAT(c.last_name, ', ', c.first_name) AS Name
FROM accounts AS a INNER JOIN customers AS c
USING (customer_id) GROUP BY (a.customer_id) ORDER BY Name;

------------------------------------
-- add the pin and salt columns to banking
USE banking;
ALTER TABLE customers ADD COLUMN pin VARBINARY(16) NOT NULL;
ALTER TABLE customers ADD COLUMN nacl CHAR(20) NOT NULL;

-- update the first customer's PIN
UPDATE customers SET nacl = SUBSTRING(MD5(RAND()), -20) WHERE customer_id=1;
UPDATE customers SET pin=AES_ENCRYPT(1234, nacl) WHERE customer_id=1;

-- retrieve the PIN in an unencrypted form
SELECT customer_id, AES_DECRYPT(pin, nacl) AS pin FROM customers WHERE customer_id=1;
-- look at the record without decrypting it
SELECT * FROM customers WHERE customer_id=1;
