using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebManuals.Models;
using System.Runtime.Serialization;

namespace WebManuals
{
    public class MainViewModel
    {
        public IEnumerable<Models.languages> Languages { get; set; }
        public IEnumerable<modeltypes> Modeltypes { get; set; }
        public IEnumerable<manuals> Manuals { get; set; }        
        public manuals UploadManuals { get; set; }
        public LocalizedManualDetails LocalizedManualDetails { get; set; }
        public List<MasterTypesVM> MasterTypes { get; set; }
        public List<ManageManualsVM> ManageManuals { get; set; }
        public List<Country> Country { get; set; }
        public string Status { get; set; }
    }
    public class MasterTypesVM {
        public int Manualid { get; set; }
        public string Manual_name { get; set; }
        public string Manual_master_model { get; set; }
    }
    public class ManageManualsVM {
        public int manual_groupid { get; set; }
        public string manual_group_name { get; set; }
        public int manualid { get; set; }
        public string manual_name { get; set; }       
        public Nullable<int> manual_languageid { get; set; }
        public string manual_language_name { get; set; }
        public Nullable<int> manual_modeltypeid { get; set; }
        public string manual_modeltype_name { get; set; }
        public string manual_url { get; set; }       
        public string manual_master_model { get; set; }
        
    }
    [DataContract]
    public class Country
    {
        [DataMember]
        public string ip { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string continent_code { get; set; }
        [DataMember]
        public string continent_name { get; set; }
        [DataMember]
        public string country_code { get; set; }
        [DataMember]
        public string country_name { get; set; }
        [DataMember]
        public string region_code { get; set; }
        [DataMember]
        public string region_name { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string zip { get; set; }
        [DataMember]
        public double latitude { get; set; }
        [DataMember]
        public double longitude { get; set; }
        [DataMember]
        public Location location { get; set; }        
        //public Language language { get; set; }

    }
    [DataContract]

    public class Language
    {
        [DataMember]
        public string code { get; set; }
        public string name { get; set; }
        public string native { get; set; }
    }
    [DataContract]

    public class Location
    {
        public object geoname_id { get; set; }
        public string capital { get; set; }
        [DataMember]
        public List<Language> languages { get; set; }
        public string country_flag { get; set; }
        public string country_flag_emoji { get; set; }
        public string country_flag_emoji_unicode { get; set; }
        public string calling_code { get; set; }
        public bool is_eu { get; set; }
    }

    
}