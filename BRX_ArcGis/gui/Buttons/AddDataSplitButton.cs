namespace BRX_ArcGis
{
    internal class AddDataSplitButton : VerticalLargeSplitButton 
    {
        protected override bool SynchWithCurrent => false;
        public AddDataSplitButton() 
        {
            BRX_ArcGis.AddDataButton addDataButton = new BRX_ArcGis.AddDataButton();
            this.Items.Add(addDataButton);
            this.Text = addDataButton.Text;
            BRX_ArcGis.AddByUrlButton addByUrlButton = new BRX_ArcGis.AddByUrlButton();
            this.Items.Add(addByUrlButton);
        }
    }
}