using System.Collections.Generic;

namespace BRX_ArcGis
{    
    public class BRXSession : ArcGISForCad.App.AfcSession
    {
        //System.Collections.Generic.
        //ArcGISForCad.App.
        public BRXSession() 
        {
            BRXSession.UpdateDisplayTheme();
            BRXSession.ConfigureModel();
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.Initialize();
            //Bricscad.ApplicationServices.Application.AddDefaultContextMenuExtension()
        }

        private static void UpdateDisplayTheme()
        {

        }

        private static void ConfigureModel()
        {

        }

        /*
        override public void SetCulture(System.Globalization.CultureInfo culture)
        {
            //Strings.Culture = culture;
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        } //*/
        //Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.
    }

}