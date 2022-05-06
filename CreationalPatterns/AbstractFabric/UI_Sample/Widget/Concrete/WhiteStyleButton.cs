using System;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete
{
    public class WhiteStyleButton : IButton
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public void Click()
        {
            Console.WriteLine("WhiteStyle Button has just clicked!");
        }
    }
}