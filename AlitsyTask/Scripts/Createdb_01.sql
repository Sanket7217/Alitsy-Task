IF  NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'CMSSystem')
    BEGIN
        CREATE DATABASE [CMSSystem]
    END;
Go
