using System;
using System.Collections.Generic;
using System.Text;

namespace DatasetService
{
    public class Cheese
    {
        public int CheeseId { get; set; }
        public string CheeseNameEn { get; set; }
        public string CheeseNameFr { get; set; }
        public string ManufacturerNameEn { get; set; }
        public string ManufacturerNameFr { get; set; }
        public string ManufacturerProvCode { get; set; }
        public string ManufacturingTypeEn { get; set; }
        public string ManufacturingTypeFr { get; set; }
        public string WebSiteEn { get; set; }
        public string WebSiteFr { get; set; }
        public decimal? FatContentPercent { get; set; } 
        public decimal? MoisturePercent { get; set; }
        public string ParticularitiesEn { get; set; }
        public string ParticularitiesFr { get; set; }
        public string FlavourEn { get; set; }
        public string FlavourFr { get; set; }
        public string CharacteristicsEn { get; set; }
        public string CharacteristicsFr { get; set; }
        public string RipeningEn { get; set; }
        public string RipeningFr { get; set; }
        public int Organic { get; set; }
        public string CategoryTypeEn { get; set; }
        public string CategoryTypeFr { get; set; }
        public string MilkTypeEn { get; set; }
        public string MilkTypeFr { get; set; }
        public string MilkTreatmentTypeEn { get; set; }
        public string MilkTreatmentTypeFr { get; set; }
        public string RindTypeEn { get; set; }
        public string RindTypeFr { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
