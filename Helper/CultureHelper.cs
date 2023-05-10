using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Threading;
using System.Globalization;

namespace WebManuals.Helper
{
    public class CultureHelper
    {
        protected HttpSessionState session;

        //constructor   
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }
        // Properties  
        //1-English,2-French,3-Czech,4-Danish,5-German,6-Spanish,7-Finnish,8-Italian,9-Dutch,10-Norwegian,11-Swedish, 12-Portuguese, 13-Russian, 14-Turkish
        /*<add key="en-US" value="1"/>
        <add key="fr-FR" value="2"/>                
        <add key="cs-CZ" value="3"/>
        <add key="da-DK" value="4"/>
        <add key="de-DE" value="5"/>
        <add key="es-ES" value="6"/>
        <add key="fi-FI" value="7"/>
        <add key="it-IT" value="8"/>
        <add key="nl-NL" value="9"/>
        <add key="nb-NO" value="10"/>
        <add key="sv-SE" value="11"/>
        <add key="pt-PT" value="12"/>
        <add key="ru-RU" value="13"/>
        <add key="tr-TR" value="14"/>*/
        public static int CurrentCulture
        {
            get
            {
                
                if (Thread.CurrentThread.CurrentUICulture.Name == "en-US")
                {
                    return 1;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "fr-FR")
                {
                    return 2;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "cs-CZ")
                {
                    return 3;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "da-DK")
                {
                    return 4;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "de-DE")
                {
                    return 5;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "es-ES")
                {
                    return 6;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "fi-FI")
                {
                    return 7;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "it-IT")
                {
                    return 8;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "nl-NL")
                {
                    return 9;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "nb-NO")
                {
                    return 10;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "sv-SE")
                {
                    return 11;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "pt-PT")
                {
                    return 12;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
                {
                    return 13;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "tr-TR")
                {
                    return 14;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "sl-SI")
                {
                    return 15;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "hu-HU")
                {
                    return 16;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "pl-PL")
                {
                    return 17;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ar-SA")
                {
                    return 18;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "zh-CN")
                {
                    return 19;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "id-ID")
                {
                    return 20;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ko-KR")
                {
                    return 21;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "th-TH")
                {
                    return 22;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "el-GR")
                {
                    return 23;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "he-IL")
                {
                    return 24;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "vi-VN")
                {
                    return 25;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "zh-TW")
                {
                    return 26;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                
                if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                }
                else if (value == 2)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                }
                else if (value == 3)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("cs-CZ");
                }
                else if (value == 4)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("da-DK");
                }
                else if (value == 5)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                }
                else if (value == 6)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                }
                else if (value == 7)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fi-FI");
                }
                else if (value == 8)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                }
                else if (value == 9)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("nl-NL");
                }
                else if (value == 10)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("nb-NO");
                }
                else if (value == 11)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
                }
                else if (value == 12)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");
                }
                else if (value == 13)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
                }
                else if (value == 14)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
                }
                else if (value == 15)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("sl-SI");
                }
                else if (value == 16)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hu-HU");
                }
                else if (value == 17)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                }
                else if (value == 18)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
                }
                else if (value == 19)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
                }
                else if (value == 20)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("id-ID");
                }
                else if (value == 21)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko-KR");
                }
                else if (value == 22)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("th-TH");
                }
                else if (value == 23)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("el-GR");
                }
                else if (value == 24)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("he-IL");
                }
                else if (value == 25)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
                }
                else if (value == 26)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-TW");
                }
                else
                {
                    //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            }
        }

    }
}