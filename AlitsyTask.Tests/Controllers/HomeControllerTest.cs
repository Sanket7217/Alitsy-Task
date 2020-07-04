using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AlitsyTask;
using AlitsyTask.Controllers;
using AlitsyTask.Models;
using System.Data.SqlClient;

namespace AlitsyTask.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        HomeController homeController = new HomeController();
        [Test]
        public void Index()
        {
         
            ImportElectricity importElectricity = new ImportElectricity();
            importElectricity.ImportElectricity_ID = 1;
            importElectricity.BillType_Name = "Flat";
            importElectricity.EntryMethod_Name = "Fast";
            importElectricity.PeakCharge = 1;
            importElectricity.PeakQuantity = 2;
            importElectricity.PeakEnergyRate = 0.5;
            importElectricity.ShoulderCharge = 1;
            importElectricity.ShoulderQuantity = 2;
            importElectricity.ShoulderEnergyRate = 0.5;
            importElectricity.OffPeakCharge = 01;
            importElectricity.OffPeakQuantity = 02;
            importElectricity.OffPeakEnergyRate = 0.5;

        
            Assert.Catch<Exception>(()=>homeController.save(importElectricity));
           // Assert.Throws<SqlException>(() => homeController.Save(importElectricity));
        }

    }
}
