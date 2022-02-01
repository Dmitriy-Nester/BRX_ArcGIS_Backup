using Bricscad.Windows;
using Bricscad.Ribbon;
using System;
using Bricscad.ApplicationServices;

namespace BRX_ArcGis.Ribbon
{
  internal static class AfaRibbon
  {
    private const string AfaMainRibbonKeyTip = "AG";
    private const string AfaMainRibbonTabId = "{A467A74D-3726-490A-9686-9D9FD614F9F1}";
    private const string AfaMainRibbonTabTitle = "ArcGIS";
    private static bool _workspaceEventInitialized;

    public static void SetupRibbon(RibbonControl ribbon)
    {
            RibbonControl ribbon1 = ComponentManager.Ribbon;
            if (ribbon1.FindTab(AfaRibbon.AfaMainRibbonTabId) != null)
            {
                //Bricscad.ApplicationServices.Application.ShowAlertDialog("RET:SetupRibbon TABID");
                return;
            }
            RibbonTab ribbonTab = new RibbonTab();
            ribbonTab.Title = AfaRibbon.AfaMainRibbonTabTitle;
            ribbonTab.Id = AfaRibbon.AfaMainRibbonTabId;
            ribbonTab.Name = AfaRibbon.AfaMainRibbonKeyTip;
            ribbon.ActiveTab = ribbonTab;
            ribbon.Tabs.Add(ribbonTab);
            ribbonTab.Panels.Add(new BRX_ArcGis.Ribbon.Panel.ProjectPanel());
            ribbonTab.Panels.Add(new BRX_ArcGis.Ribbon.Panel.ContentsPanel());
            ribbonTab.Panels.Add(new BRX_ArcGis.Ribbon.Panel.NavigatePanel());
            ribbonTab.Panels.Add(new BRX_ArcGis.Ribbon.Panel.EditPanel());
            ribbonTab.Panels.Add(new BRX_ArcGis.Ribbon.Panel.ResourcePanel());
            if (AfaRibbon._workspaceEventInitialized)
            {
                //Bricscad.ApplicationServices.Application.ShowAlertDialog("RET:SetupRibbon WEI");
                return;
            }
      // ISSUE: method pointer
      //Application.SystemVariableChanged += new SystemVariableChangedEventHandler((object) null, EventHandler(Application_SystemVariableChanged));
      //((ObservableCollection<RibbonTab>) ComponentManager.Ribbon.Tabs).CollectionChanged += new NotifyCollectionChangedEventHandler(AfaRibbon.Tabs_CollectionChanged);
            AfaRibbon._workspaceEventInitialized = true;

        }

    //private static void Tabs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) => RibbonHelper.OnRibbonFound(new Action<RibbonControl>(AfaRibbon.SetupRibbon));

    private static void Application_SystemVariableChanged(
      object sender,
      SystemVariableChangedEventArgs e)
    {
      if (e.Name == null || !string.Equals(e.Name, "WSCURRENT", StringComparison.OrdinalIgnoreCase))
        return;
      AfaRibbon.CreateRibbon();
    }

    internal static void CreateRibbon()
    {
            RibbonPaletteSet ribbonPaletteSet = RibbonServices.RibbonPaletteSet;
            if (ribbonPaletteSet == null)
            {
                Bricscad.Ribbon.RibbonServices.CreateRibbonPaletteSet();
                AfaRibbon.CreateRibbon();
            }
            else 
            {
                RibbonControl ribbonControl = ribbonPaletteSet.RibbonControl;
                if (ribbonControl == null || ribbonControl.FindTab(AfaRibbon.AfaMainRibbonTabId) != null)
                {
                    Bricscad.ApplicationServices.Application.ShowAlertDialog("RET:CreateRibbon");
                    return;
                }
                AfaRibbon.SetupRibbon(ribbonControl);
            }
    }
  }
}