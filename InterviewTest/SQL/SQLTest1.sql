﻿--
--  Information about Customers and their Orders are kept in two tables:
-- 
--  TABLE Order
--      Id INTEGER NOT NULL PRIMARY KEY,
--      Name NVARCHAR(50) NOT NULL
--      CustomerId INTEGER
-- 
--  TABLE Customer
--      Id INTEGER NOT NULL PRIMARY KEY,
--      FirstName NVARCHAR(50) NOT NULL,
--      LastName NVARCHAR(50) NOT NULL,
--      EmailAddress NVARCHAR(50) NOT NULL
--  
--  Write a query that returns all customers that do NOT have any orders.

