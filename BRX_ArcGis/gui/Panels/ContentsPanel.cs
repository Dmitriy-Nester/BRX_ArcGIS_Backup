using Bricscad.Windows;
namespace BRX_ArcGis.Ribbon.Panel
{
    internal class ContentsPanel : AfaPanel 
    {
        public ContentsPanel() : base("Contents") 
        {
            this.AddButton(new AddDataSplitButton());
            RibbonRowPanel panel = new RibbonRowPanel();
            panel.Items.Add(new BRX_ArcGis.GisContentButton());
            panel.Items.Add(new Bricscad.Windows.RibbonRowBreak());
            this.AddRowPanel(panel);
        }
    }
}