using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget;
using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.WidgitKits.Concrete
{
    public class WhiteStyleWidgetKit : IWidgetFactory
    {
        public IWindow CreateWindow()
        {
            return new WhiteStyleWindow();
        }

        public ITextLabel CreateTextLabel()
        {
            return new WhiteStyleTextLabel();
        }

        public IButton CreateButton()
        {
            return new WhiteStyleButton();
        }
    }
}