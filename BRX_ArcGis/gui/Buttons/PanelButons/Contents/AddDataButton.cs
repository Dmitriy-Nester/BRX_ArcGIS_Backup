namespace BRX_ArcGis 
{
    internal class AddDataButton : Bricscad.Windows.RibbonButton 
    {
        public AddDataButton() 
        {
            this.Text = "Add Data";
            AddDataCommandHandlers handler = new AddDataCommandHandlers();
            handler.mode = AddDataCommandHandlers.Mode.PortalWindow;
            this.CommandHandler = handler;
        }
    }
} 