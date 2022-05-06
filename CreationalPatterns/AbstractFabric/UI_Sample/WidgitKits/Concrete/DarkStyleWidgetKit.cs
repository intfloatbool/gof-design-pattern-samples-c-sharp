using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget;
using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.WidgitKits.Concrete
{
    public class DarkStyleWidgetKit : IWidgetFactory
    {
        public IWindow CreateWindow()
        {
            return new DarkStyleWindow();
        }

        public ITextLabel CreateTextLabel()
        {
            return new DarkStyleTextLabel();
        }

        public IButton CreateButton()
        {
            return new DarkStyleButton();
        }
    }
}