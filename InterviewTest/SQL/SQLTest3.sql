
--
-- Note:  This task will be completed verbally.
-- 
-- The Employee table below is used by an application to store user records.  The EmailAddress is used to authenticate users via Active Directory and the EmployeeID 
-- is used in audit trails and is referenced as a foreign key in other tables.

-- TABLE Employee
--		EmployeeID INTEGER NOT NULL
--		FirstName NVARCHAR(50) NOT NULL,
--		LastName NVARCHAR(50) NOT NULL,
--		DateOfHire DATETIMEOFFSET(7) NOT NULL,
--		EmailAddress NVARCHAR(100) NOT NULL

-- Your task is to keep this Employee table up to date with an Excel file that is transferred via FTP to a specific folder.  You need to ensure that:
--		1.  Only valid / current employees can login.
--		2.  Any inactive employees are not allowed to login.
--		3.  The Employee table is updated in less than 5 minutes every evening.
--		4.  Referential integrity in tables that depend on the Employee table is maintained.
-- 
-- Please explain what design choices you would make to achieve the above.
--