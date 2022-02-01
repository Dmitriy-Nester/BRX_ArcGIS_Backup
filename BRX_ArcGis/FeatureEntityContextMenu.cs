using Bricscad.Windows;
using Teigha.Runtime;

namespace BRX_ArcGis
{
    public static class FeatureEntityContextMenu
    {
        private static ContextMenuExtension _cme;
        public static void Attach() 
        {            
            FeatureEntityContextMenu._cme = new ContextMenuExtension();
            //FeatureEntityContextMenu._cme.Title = "Test title";
            MenuItem item = new MenuItem("Test item");
            item.Click += new System.EventHandler(FeatureEntityContextMenu.evStub);
            FeatureEntityContextMenu._cme.MenuItems.Add(item); //*/
            RXClass rx = RXObject.GetClass(typeof(Teigha.DatabaseServices.BlockReference));
            item.Visible = true;
            Bricscad.ApplicationServices.Application.AddObjectContextMenuExtension(rx, FeatureEntityContextMenu._cme);
        }
        
        private static void evStub(object o, System.EventArgs e) 
        {
            Bricscad.ApplicationServices.Application.ShowAlertDialog("Event 1 called");
        }
    }
}