namespace BRX_ArcGis.Ribbon.Panel 
{
    internal class ProjectPanel : AfaPanel
    {
        public ProjectPanel() : base("Project") 
        {
          this.AddButton(new CoordinateSystemSplitButton());
          this.AddButton(new ProjectAreaSplitButton());
        }
    }
} 