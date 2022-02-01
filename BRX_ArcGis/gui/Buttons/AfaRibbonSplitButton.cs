using System.Windows.Controls;

namespace BRX_ArcGis
{
    internal abstract class AfaRibbonSplitButton : Bricscad.Windows.RibbonSplitButton
    {
        protected abstract Orientation ButtonOrientation { get; }
        protected AfaRibbonSplitButton() => this.Initialize();
        protected abstract bool ShowTextUnderButton { get; }
        protected abstract bool SynchWithCurrent { get; }        

        protected void Initialize()
        {
            this.ButtonStyle = Bricscad.Windows.RibbonButtonStyle.LargeWithHorizontalText;
            //this.
        }
    }
} 