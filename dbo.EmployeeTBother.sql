CREATE TABLE [dbo].[EmployeeTBother] (
    [employeeid]      NVARCHAR(50) NOT NULL,
    [employeename]    NVARCHAR (50) NOT NULL,
    [role]            NVARCHAR (50) NOT NULL,
    [employeeaddress] NVARCHAR (50) NOT NULL,
    [employeephoneno] NVARCHAR (50) NOT NULL,
    [fathersname]     NVARCHAR (50) NOT NULL,
    [mothersname]     NVARCHAR (50) NOT NULL,
    [citizenshipno]   NVARCHAR (50) NOT NULL,
    [email]           NVARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_EmployeeTBother] PRIMARY KEY ([employeeid]) 
   
);

