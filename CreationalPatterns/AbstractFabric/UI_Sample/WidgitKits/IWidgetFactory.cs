using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.WidgitKits
{
    public interface IWidgetFactory
    {
        IWindow CreateWindow();
        ITextLabel CreateTextLabel();
        IButton CreateButton();
    }
}