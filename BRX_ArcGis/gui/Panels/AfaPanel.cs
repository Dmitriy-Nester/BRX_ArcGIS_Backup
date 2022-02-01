using Bricscad.Windows;

namespace BRX_ArcGis.Ribbon.Panel
{   internal class AfaPanel
    {
        public RibbonPanel Panel { get; }
        public RibbonPanelSource PanelSource { get; set; }

        public static implicit operator RibbonPanel(AfaPanel p) => p.Panel;

        public string Name { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public AfaPanel(string name) 
        {
            this.PanelSource = new RibbonPanelSource();
            this.PanelSource.Title = name;
            this.Panel = new RibbonPanel();
            this.Panel.Source = this.PanelSource;
        }

        protected void AddItem(RibbonItem item) => this.Panel.Source.Items.Add(item);
        public void AddButton(RibbonButton button) => this.AddItem(button);
        public void AddRowPanel(RibbonRowPanel subPanel) => this.AddItem(subPanel);
    }
}