CREATE TABLE [dbo].[EmployeeTB] (
    [employeeid]      NVARCHAR (50) CONSTRAINT [DF__EmployeeT__Emplo__47DBAE45] DEFAULT ((1)) NOT NULL,
    [employeename]    NVARCHAR (50) NOT NULL,
    [role]            NVARCHAR (50) NOT NULL,
    [employeeaddress] NVARCHAR (50) NOT NULL,
    [employeephoneno] NVARCHAR (50) NOT NULL,
    [fathersname]     NVARCHAR (50) NOT NULL,
    [mothersname]     NVARCHAR (50) NOT NULL,
    [citizenshipno]   NVARCHAR (50) NOT NULL,
    [email]           NVARCHAR (50) NOT NULL,
    
    CONSTRAINT [PK_EmployeeTB] PRIMARY KEY CLUSTERED ([employeeid] ASC)
);

