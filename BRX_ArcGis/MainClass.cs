using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRX_ArcGis
{
    public class MainClass: Teigha.Runtime.IExtensionApplication
    {
        public static BRXSession CurrentSession;
        public void Initialize() 
        {
            //Bricscad.ApplicationServices.Application.ShowAlertDialog("Ass we can!!!!");
            try
            {
                MainClass.CurrentSession = new BRXSession();
            }
            catch (ArcGISForCad.App.AfcInitializationException ex) 
            {
                Bricscad.ApplicationServices.Application.ShowAlertDialog(ex.ToString());
            }
            FeatureEntityContextMenu.Attach();
            //Bricscad.Ribbon.RibbonServices.CreateRibbonPaletteSet
            Ribbon.AfaRibbon.CreateRibbon();
            int lcid = Teigha.Runtime.SystemObjects.DynamicLinker.ProductLcid;
            MainClass.CurrentSession.SetCulture(new System.Globalization.CultureInfo(lcid));
        }

        public void Terminate() 
        {
        }
        public MainClass() {}
    }
}
