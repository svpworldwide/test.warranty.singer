using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebManuals.LocalResource;

namespace WebManuals.Models
{
    public class LocalizedManualDetails
    {
        [Display(Name = "ManualsPageHeader", ResourceType = typeof(Resource))]
        public string ManualsPageHeader { get; set; }

        [Display(Name = "ManualsPageDesc", ResourceType = typeof(Resource))]
        public string ManualsPageDesc { get; set; }

        [Display(Name = "ManualsTypeMechanical", ResourceType = typeof(Resource))]
        public string ManualsTypeMechanical { get; set; }

        [Display(Name = "ManualsTypeComputerized", ResourceType = typeof(Resource))]
        public string ManualsTypeComputerized { get; set; }

        [Display(Name = "ManualsTypeHeavyDuty", ResourceType = typeof(Resource))]
        public string ManualsTypeHeavyDuty { get; set; }

        [Display(Name = "ManualsTypeEmbroidery", ResourceType = typeof(Resource))]
        public string ManualsTypeEmbroidery { get; set; }

        [Display(Name = "ManualsTypeQuilting", ResourceType = typeof(Resource))]
        public string ManualsTypeQuilting { get; set; }

        [Display(Name = "ManualsTypeSergers", ResourceType = typeof(Resource))]
        public string ManualsTypeSergers { get; set; }

        [Display(Name = "ManualsSelectHeader", ResourceType = typeof(Resource))]
        public string ManualsSelectHeader { get; set; }

        [Display(Name = "ManualsDisplayHeader", ResourceType = typeof(Resource))]
        public string ManualsDisplayHeader { get; set; }
    }
}