USE [CMSSystem]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ImportElectricity_Procedure]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ImportElectricity_Procedure]
GO

CREATE PROCEDURE [dbo].[ImportElectricity_Procedure]
(

@BillType_Name nvarchar(100),
@EntryMethod_Name nvarchar(100),
@PeakCharge int,
@PeakQuantity int,
@PeakEnergyRate float,
@ShoulderCharge int ,
@ShoulderQuantity int,
@ShoulderEnergyRate float,
@OffPeakCharge int ,
@OffPeakQuantity int,
@OffPeakEnergyRate float,
@GST nvarchar(100)

)
AS
BEGIN
INSERT INTO ImportElectricity
(

BillType_Name ,
EntryMethod_Name ,
PeakCharge ,
PeakQuantity ,
PeakEnergyRate ,
ShoulderCharge  ,
ShoulderQuantity ,
ShoulderEnergyRate ,
OffPeakCharge  ,
OffPeakQuantity ,
OffPeakEnergyRate,
GST
)
Values
(
@BillType_Name ,
@EntryMethod_Name ,
@PeakCharge ,
@PeakQuantity ,
@PeakEnergyRate ,
@ShoulderCharge  ,
@ShoulderQuantity ,
@ShoulderEnergyRate ,
@OffPeakCharge  ,
@OffPeakQuantity ,
@OffPeakEnergyRate ,
@GST
)
END
GO