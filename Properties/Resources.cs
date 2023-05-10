using System;
using System.Web;
using System.Resources;
using Westwind.Globalization;

namespace WebManuals.Properties
{
    public class GeneratedResourceSettings
    {
        // You can change the ResourceAccess Mode globally in Application_Start        
        public static ResourceAccessMode ResourceAccessMode = DbResourceConfiguration.Current.ResourceAccessMode;
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Westwind.Globalization.StronglyTypedResources", "3.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource
    {
        public static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    var temp = new ResourceManager("WebManuals.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        private static ResourceManager resourceMan = null;

		public static System.String ManualsFilter
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsFilter",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeMechanical
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeMechanical",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeEmbroidery
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeEmbroidery",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeHeavyDuty
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeHeavyDuty",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsSelectHeader
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsSelectHeader",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsReset
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsReset",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsDisplayHeader
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsDisplayHeader",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsPageHeader
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsPageHeader",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeQuilting
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeQuilting",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeSergers
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeSergers",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsOpen
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsOpen",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsPageDesc
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsPageDesc",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

		public static System.String ManualsTypeComputerized
		{
			get
			{
				return GeneratedResourceHelper.GetResourceString("Resource","ManualsTypeComputerized",ResourceManager,GeneratedResourceSettings.ResourceAccessMode);
			}
		}

	}

}
