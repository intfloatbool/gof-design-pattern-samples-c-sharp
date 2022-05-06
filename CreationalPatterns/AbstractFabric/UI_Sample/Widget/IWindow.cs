using System.Collections.Generic;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget
{
    public interface IWindow : IWidget
    {
        string Title { get; set; }
        IEnumerable<IWidget> SubWidgets { get; set; }
    }
}