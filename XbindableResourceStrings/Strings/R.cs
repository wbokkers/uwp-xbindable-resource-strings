using Windows.ApplicationModel.Resources;
using System;
 
namespace ResourceStrings
{
    public static class R 
    {
        private static readonly ResourceLoader s_res; 

        static R() 
        {
            try
            {
                s_res = ResourceLoader.GetForViewIndependentUse("Strings");
            }
            catch (TypeInitializationException)
            {
                throw new Exception("Unable to locate the .resw file(s) Strings.resw");
            }
        }

		// String accesors:
		//----
		public static string HelloWorld => RetrieveString("HelloWorld");
		public static string ImportantMessage => RetrieveString("ImportantMessage");
		public static string ShowMessage => RetrieveString("ShowMessage");

        static string RetrieveString(string resourceKey) => s_res.GetString(resourceKey);
    }
}
