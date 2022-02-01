using System.Windows.Controls;

namespace BRX_ArcGis
{
    internal abstract class VerticalLargeSplitButton : AfaRibbonSplitButton 
    {
        //
        protected override Orientation ButtonOrientation => Orientation.Vertical;

        protected override bool ShowTextUnderButton => true;
    }
}
