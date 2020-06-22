CREATE TABLE [dbo].[stu]
(
	[stu_id] INT NOT NULL PRIMARY KEY, 
    [stu_no] NVARCHAR(50) NULL, 
    [stu_name] NVARCHAR(50) NULL, 
    [stu_sex] INT NULL, 
    [stu_age] INT NULL, 
    [stu_grade] NVARCHAR(50) NULL, 
    [stu_profession] NVARCHAR(50) NULL, 
    [stu_class] NVARCHAR(50) NULL, 
    [stu_native_place] NVARCHAR(50) NULL, 
    [stu_contact] NVARCHAR(50) NULL, 
    [stu_address] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[admin]
(
	[admin_no] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [admin_pass] NVARCHAR(50) NULL
)