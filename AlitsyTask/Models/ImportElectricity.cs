using System;
using System.ComponentModel.DataAnnotations;

namespace AlitsyTask.Models
{
    public class ImportElectricity
    {
        
        public int ImportElectricity_ID { get; set; }
        public string BillType_Name { get; set; }
        public string EntryMethod_Name { get; set; }
        public int PeakCharge { get; set; }
        public int PeakQuantity { get; set; }
        public double PeakEnergyRate { get; set; }
        public int ShoulderCharge { get; set; }
        public int ShoulderQuantity { get; set; }
        public double ShoulderEnergyRate { get; set; }
        public int OffPeakCharge { get; set; }
        public int OffPeakQuantity { get; set; }
        public double OffPeakEnergyRate { get; set; }
        public string GST { get; set; }

        public ImportElectricity()
        {

        }
    }

}

