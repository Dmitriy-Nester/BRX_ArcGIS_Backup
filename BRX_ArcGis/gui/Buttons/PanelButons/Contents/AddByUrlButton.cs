namespace BRX_ArcGis 
{
    internal class AddByUrlButton : Bricscad.Windows.RibbonButton 
    {
        public AddByUrlButton() 
        {
            this.Text = "Add Data by URL";
            AddDataCommandHandlers handler = new AddDataCommandHandlers();
            handler.mode = AddDataCommandHandlers.Mode.ByURL;
            this.CommandHandler = handler;
        }
    }
}