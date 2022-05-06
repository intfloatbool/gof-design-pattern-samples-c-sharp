using System.Collections.Generic;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete
{
    public class WhiteStyleWindow : IWindow
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public string Title { get; set; } = "WhiteStyleWindow";
        public IEnumerable<IWidget> SubWidgets { get; set; }
    }
}