using System.Xaml;
namespace BRX_ArcGis 
{
    internal class AddDataCommandHandlers : System.Windows.Input.ICommand 
    {
        private static string UrlAddDescription = "UrlAddDescription";
        private static string AddDataDescription = "AddDataDescription";
        protected bool flagShow = false;
        public enum Mode 
        {
            ByURL,
            PortalWindow,
            Unknown
        }
        public Mode mode { set; get; }

        private static Mode GetMode() 
        {
            Mode result = Mode.Unknown;
            string name = System.Threading.Thread.CurrentThread.Name;
            if (name == UrlAddDescription)
            {
                result = Mode.ByURL;
            }
            else if (name == AddDataDescription) 
            {
                result = Mode.PortalWindow;
            }
            return result;
        }
        private static System.Windows.Window CreateWindowByMode(Mode mode) 
        {
            if (mode == Mode.ByURL)
            {
                var _ = new Microsoft.Xaml.Behaviors.DefaultTriggerAttribute(typeof(ArcGISForCad.UI.MapLayers.Views.AddDataByUrlView), 
                                                typeof(Microsoft.Xaml.Behaviors.TriggerBase), null);
                return new ArcGISForCad.UI.MapLayers.Views.AddDataByUrlView();//AddDataByUrlWindow();
            }
            else 
            {
                return new AddDataWindow();                
            }
        }
        private static void ShowWindow() 
        {
            Mode mode = AddDataCommandHandlers.GetMode();
            if (mode == Mode.Unknown)
            {
                return;
            }
            System.Windows.Window window = CreateWindowByMode(mode);
            Bricscad.ApplicationServices.Application.ShowModalWindow(window);
        }

        public void Execute(object parameter) 
        {
            if (this.flagShow == true)
                return;
            this.flagShow = true;
            System.Threading.Thread handle = new System.Threading.Thread(new System.Threading.ThreadStart(ShowWindow));
            handle.SetApartmentState(System.Threading.ApartmentState.STA);
            switch (this.mode)
            {
                case Mode.ByURL:
                    handle.Name = AddDataCommandHandlers.UrlAddDescription;
                    break;
                case Mode.PortalWindow:
                    handle.Name = AddDataCommandHandlers.AddDataDescription;
                    break;
            }
            handle.Start();
            handle.Join();
            this.flagShow = false;
        }

        public bool CanExecute(object parameter) 
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged
        {
            add
            {
            }
            remove
            {
            }
        }
    }
}