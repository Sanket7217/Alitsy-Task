USE [CMSSystem]

IF NOT EXISTS (select * from sys.tables where name = 'ImportElectricity')
CREATE TABLE [dbo].[ImportElectricity](
	[ImportElectricity_ID] [int] IDENTITY(1,1) NOT NULL,
	[BillType_Name] [varchar](100) NULL,
	[EntryMethod_Name] [varchar](100) NULL,
	[PeakCharge] [int] NULL,
	[PeakQuantity] [int] NULL,
	[PeakEnergyRate] [decimal](14,10) NULL,
	[ShoulderCharge] [int] NULL,
	[ShoulderQuantity] [int] NULL,
	[ShoulderEnergyRate] [decimal](14,10) NULL,
	[OffPeakCharge] [int] NULL,
	[OffPeakQuantity] [int] NULL,
	[OffPeakEnergyRate] [decimal](14,10) NULL,
	[GST] [varchar](100) NULL
) ON [PRIMARY]
GO

IF NOT EXISTS(SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE (TABLE_NAME='ImportElectricity' AND COLUMN_NAME='GST'))
BEGIN	
	ALTER TABLE ImportElectricity ADD [GST] varchar(100) NULL
END
GO

