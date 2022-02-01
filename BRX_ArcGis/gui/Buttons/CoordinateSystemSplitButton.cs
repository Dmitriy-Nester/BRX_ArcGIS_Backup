using System.Windows.Controls;

namespace BRX_ArcGis
{ 

    internal class CoordinateSystemSplitButton : VerticalLargeSplitButton 
    {
        protected override bool SynchWithCurrent => false;
        public CoordinateSystemSplitButton() 
        {
            this.Text = "Coordinate System";
            this.Behavior = Bricscad.Windows.RibbonSplitButtonBehavior.SplitFollowStaticText;
            BRX_ArcGis.CoordinateSystemButton crdBtn = new BRX_ArcGis.CoordinateSystemButton();
            this.Items.Add(crdBtn);
            BRX_ArcGis.CoordinateSystemListButton lstBtn = new BRX_ArcGis.CoordinateSystemListButton();
            this.Items.Add(lstBtn);
            BRX_ArcGis.CoordinateSystemRemoveButton remBtn = new BRX_ArcGis.CoordinateSystemRemoveButton();
            this.Items.Add(remBtn);
        }
    }
}