Create Table Boooks(
BookId int identity(1,1) NOT NULL,
IsDeleted bit NOT NULL,
CreatedOn datetimeoffset(7) NOT NULL,
CreatedBy int NOT NULL,
ModifiedOn datetimeoffset(7) NOT NULL,
ModifiedBy int NOT NULL,
SId int NOT NULL,
CId int NOT NULL,

BookName nvarchar(100) NOT NULL,
Price decimal NULL,
Author nvarchar(100) NULL,
Desciption nvarchar(100) null

constraint PK_Boooks
primary key clustered(
BookId ASC
)
);

ALTER TABLE Boooks ADD CONSTRAINT DF_Boooks_IsDeleted DEFAULT ((0)) FOR IsDeleted
GO

-- set isdelete by default active

ALTER TABLE Boooks ADD CONSTRAINT DF_Boooks_CreatedOn DEFAULT (SYSDATETIMEOFFSET()) FOR CreatedOn
GO

ALTER TABLE Boooks ADD CONSTRAINT DF_Boooks_ModifiedOn DEFAULT (SYSDATETIMEOFFSET()) FOR ModifiedOn
GO


-- insert data into boooks table.
insert into Boooks(CreatedBy,ModifiedBy,SId,CId,BookName,Price,Author,Desciption)
values(1,1,101,201,'Atomic Habit',200,'James Clear','A Book About Building Good Habits.');


SELECT * FROM Boooks;
