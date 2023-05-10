using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebManuals.Helper;
using WebManuals.Models;

namespace WebManuals.Controllers
{

    public class BaseController : Controller
    {
        private static WebManuals.Models.webmanualsEntities db = new WebManuals.Models.webmanualsEntities();
        protected override void ExecuteCore()
        {


            int culture = 0;
            bool.TryParse(System.Configuration.ConfigurationManager.AppSettings["iplogging:Enabled"], out bool logenabled);
            string ipfromconfig = ConfigurationManager.AppSettings["countryip"];
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["en-US"], out culture);
                try
                {
                    string ip = Request.UserHostAddress;//"89.224.0.0";//"68.71.100.72";
                    Country country = new Country();
                    bool isIpPrivate = IsPrivateIP(ip);
                    if (isIpPrivate)
                    {

                        country = GetLocationByIpAddress(ipfromconfig);
                    }
                    else
                    {
                        //country = GetUserLanguageByIp(ip);
                        country = GetLocationByIpAddress(ip);

                    }
                    if (country is null)
                    {
                        CultureHelper.CurrentCulture = 1;
                        this.Session["CurrentCulture"] = culture;

                        if (logenabled)
                        {
                            Log(ipfromconfig);
                        }
                    }
                    else
                    {
                        if (country.location is null)
                        {
                            CultureHelper.CurrentCulture = 1;
                            this.Session["CurrentCulture"] = culture;
                            if (logenabled)
                            {
                                Log(ipfromconfig, country);
                            }
                        }
                        else
                        {
                            var ip_language_name = country.location.languages[0].code.ToUpper();
                            string ip_language_tag = ip_language_name + "-" + country.country_code;
                            int.TryParse(System.Configuration.ConfigurationManager.AppSettings[ip_language_tag], out culture);
                            this.Session["CurrentCulture"] = culture;
                            //logging                        

                            if (logenabled)
                            {
                                Log(country);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    CultureHelper.CurrentCulture = 1;
                }
                //this.Session["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)this.Session["CurrentCulture"];
            }

            CultureHelper.CurrentCulture = culture;


            base.ExecuteCore();
        }
        public bool IsPrivateIP(string ipAddress)
        {
            if (ipAddress == ConfigurationManager.AppSettings["localip"])
            //if (ip == "::1")
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public Country GetLocationByIpAddress(string ipAddress)
        {
            Country country = new Country();
            using (var httpClient = new HttpClient())
            {
                try
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var responseMessage = httpClient.GetAsync(new Uri("http://api.ipstack.com/" + ipAddress + "?access_key=" + ConfigurationManager.AppSettings["access_key"])).Result;
                    var responseContent = responseMessage.Content.ReadAsStringAsync().Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(responseContent));
                        DataContractJsonSerializer ser = new DataContractJsonSerializer(country.GetType());
                        country = ser.ReadObject(ms) as Country;
                        ms.Close();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }

            }
            return country;
        }
        //public static Country GetUserLanguageByIp(string ip)
        //{           
        //    Country ipInfo = new Country();
        //    if (ip == ConfigurationManager.AppSettings["localip"])               
        //    {
        //        ip = ConfigurationManager.AppSettings["countryip"];

        //    }
        //    string ipstack = "?access_key=" + ConfigurationManager.AppSettings["access_key"];
        //    string info = new WebClient().DownloadString("http://api.ipstack.com/" + ip + ipstack);
        //    //      {
        //    //          "success": false,
        //    //          "error": {
        //    //              "code": 104,
        //    //              "info": "Your monthly usage limit has been reached. Please upgrade your Subscription Plan."
        //    //          }
        //    //      }
        //    Country deserializedCountry = new Country();
        //    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(info));
        //    DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedCountry.GetType());
        //    deserializedCountry = ser.ReadObject(ms) as Country;
        //    ms.Close();           

        //    return deserializedCountry;
        //}
        public static void Log(Country deserializedCountry)
        {
            var modelip = new ipinfo()
            {
                ip = deserializedCountry.ip,
                type = deserializedCountry.type,
                continent_code = deserializedCountry.continent_code,
                continent_name = deserializedCountry.continent_name,
                country_code = deserializedCountry.country_code,
                country_name = deserializedCountry.country_name,
                region_code = deserializedCountry.region_code,
                region_name = deserializedCountry.region_name,
                city = deserializedCountry.city,
                latitude = deserializedCountry.latitude,
                longitude = deserializedCountry.longitude,
                DateInserted = DateTime.Now
            };
            db.ipinfo.Add(modelip);
            db.SaveChanges();
        }
        public static void Log(string ip, Country deserializedCountry)
        {
            var modelip = new ipinfo()
            {
                ip = ip,
                DateInserted = DateTime.Now
            };
            db.ipinfo.Add(modelip);
            db.SaveChanges();
        }
        public static void Log(string ip)
        {
            var modelip = new ipinfo()
            {
                ip = ip,
                DateInserted = DateTime.Now
            };
            db.ipinfo.Add(modelip);
            db.SaveChanges();
        }
        protected override bool DisableAsyncSupport
        {
            get { return true; }
        }
    }
}