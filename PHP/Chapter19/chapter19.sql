# ----------
# Chapter 19
# ----------

CREATE DATABASE ecommerce;

USE ecommerce;

CREATE TABLE artists (
artist_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
first_name VARCHAR(20) DEFAULT NULL,
middle_name VARCHAR(20) DEFAULT NULL,
last_name VARCHAR(40) NOT NULL,
PRIMARY KEY (artist_id),
UNIQUE full_name (last_name, first_name, middle_name)
) ENGINE=MyISAM;

INSERT INTO artists (artist_id, first_name, middle_name, last_name) VALUES
(1, 'Sandro', NULL, 'Botticelli'),
(2, 'Roy', NULL, 'Lichtenstein'),
(3, 'Rene', NULL, 'Magritte'),
(4, 'Claude', NULL, 'Monet'),
(5, 'John', 'Singer', 'Sargent'),
(6, 'Georges-Pierre', NULL, 'Seurat');

CREATE TABLE prints (
print_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
artist_id INT UNSIGNED NOT NULL,
print_name VARCHAR(60) NOT NULL,
price DECIMAL(6,2) UNSIGNED NOT NULL,
size VARCHAR(60) DEFAULT NULL,
description VARCHAR(255) DEFAULT NULL,
image_name VARCHAR(60) NOT NULL,
PRIMARY KEY (print_id),
INDEX (artist_id),
INDEX (print_name),
INDEX (price)
) ENGINE=MyISAM;

INSERT INTO prints (print_id, artist_id, print_name, price, size, description, image_name) VALUES
(2, 2, 'Whaam', 32.99, NULL, NULL, 'whaam.png'),
(3, 2, 'Drowning Girl', 44.95, NULL, NULL, 'girl.png'),
(4, 1, 'The Birth of Venus', 1500.00, '67.9 in x 109.6 in', 'A 1486 painting depicting the goddess Venus, having emerged from the sea as a fully grown woman.', 'venus.png'),
(5, 1, 'Saint Augustine', 1250.00, '152cm x 112cm', '1480', 'augustine.png'),
(6, 3, 'The Empire of Light', 49.95, NULL, '1950-1954', 'light.png'),
(7, 4, 'Impression, soleil levant', 44.95, '18.9 in x 24.8 in', '1872 Oil on canvas', 'soleil.png'),
(8, 1, 'The Adoration of the Magi', 56.00, NULL, 'Year: 1475', 'magi.png'),
(9, 5, 'The Daughters of Edward Darley Boit', 89.95, '87.4 x 87.6 in', 'Medium: oil on canvas\r\nDate: 1882', 'boit.png');


CREATE TABLE customers (
customer_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
email VARCHAR(60) NOT NULL,
pass CHAR(40) NOT NULL,
PRIMARY KEY (customer_id),
UNIQUE (email),
INDEX login (email, pass)
) ENGINE=MyISAM;

CREATE TABLE orders (
order_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
customer_id INT UNSIGNED NOT NULL,
total DECIMAL(10,2) UNSIGNED NOT NULL,
order_date TIMESTAMP,
PRIMARY KEY (order_id),
INDEX (customer_id),
INDEX (order_date)
) ENGINE=InnoDB;

CREATE TABLE order_contents (
oc_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
order_id INT UNSIGNED NOT NULL,
print_id INT UNSIGNED NOT NULL,
quantity TINYINT UNSIGNED NOT NULL DEFAULT 1,
price DECIMAL(6,2) UNSIGNED NOT NULL,
ship_date DATETIME default NULL,
PRIMARY KEY (oc_id),
INDEX (order_id),
INDEX (print_id),
INDEX (ship_date)
) ENGINE=InnoDB;

