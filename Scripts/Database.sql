USE Library
GO
CREATE TABLE [dbo].[Users]
(
	[user_id] INT IDENTITY (1,1) PRIMARY KEY,
	[Username] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE [dbo].[Books]
(
	[book_id] INT IDENTITY (1,1) PRIMARY KEY,
	[book_title] NVARCHAR(50) NOT NULL,
	[category] INT NOT NULL
)
GO

CREATE TABLE [dbo].[Authors]
(
	[author_id] INT IDENTITY (1,1) PRIMARY KEY,
	[author_name] NVARCHAR (50) NOT NULL
)
GO

CREATE TABLE [dbo].[Publishers]
(
	[publisher_id] INT IDENTITY (1,1) PRIMARY KEY,
	[publisher_name] NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE [dbo].[BookAuthor]
(
	[book_id] INT NOT NULL,
	[author_id] INT NOT NULL,
	FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books]([book_id]),
	FOREIGN KEY ([author_id]) REFERENCES [dbo].[Authors]([author_id])
)
GO

CREATE TABLE [dbo].[Category]
(
	[category_id] INT IDENTITY (1,1) PRIMARY KEY,
	[category_name] NVARCHAR(25) NOT NULL
)
GO

CREATE TABLE [dbo].[BookCopy]
(
	[book_copy_id] INT IDENTITY (1,1) PRIMARY KEY,
	[year_published] INT NOT NULL,
	[book_id] INT NOT NULL,
	FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books]([book_id]),
	[publisher_id] INT NOT NULL,
	FOREIGN KEY ([publisher_id]) REFERENCES [dbo].[Publishers] ([publisher_id])
)
GO

CREATE TABLE [dbo].[patrons]
(
	[patron_id] INT IDENTITY (1,1) PRIMARY KEY,
	[patron_first] NVARCHAR(50) NOT NULL,
	[patron_surname] NVARCHAR(50) NOT NULL,
	[patron_address] NVARCHAR(255) NOT NULL,
	[patron_email] NVARCHAR(255) NOT NULL,
	[patron_phone] NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE [dbo].[Loans]
(
	[loan_id] INT IDENTITY (1,1) PRIMARY KEY,
	[book_copy_id] INT NOT NULL,
	[patron_id] INT NOT NULL,
	[loan_date] DATE NOT NULL,
	[return_date] DATE NOT NULL,
	[returned] BIT NOT NULL,
	FOREIGN KEY ([book_copy_id]) REFERENCES [dbo].[BookCopy]([book_copy_id]),
	FOREIGN KEY ([patron_id]) REFERENCES [dbo].[patrons]([patron_id])
)
GO

CREATE TABLE [dbo].[Reservations]
(
	[reservation_id] INT IDENTITY (1,1) PRIMARY KEY,
	[book_id] INT NOT NULL,
	[patron_id] INT NOT NULL,
	[reservation_date] DATE NOT NULL,
	[reservation_expiry] DATE NOT NULL,
	FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books]([book_id]),
	FOREIGN KEY ([patron_id]) REFERENCES [dbo].[patrons]([patron_id])
)
GO

CREATE TABLE [dbo].[WaitList]
(
	[waitlist_id] INT IDENTITY (1,1) PRIMARY KEY,
	[book_id] INT NOT NULL,
	[patron_id] INT NOT NULL,
	[waitlist_date] DATE NOT NULL,
	FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books]([book_id]),
	FOREIGN KEY ([patron_id]) REFERENCES [dbo].[patrons]([patron_id])
)
GO