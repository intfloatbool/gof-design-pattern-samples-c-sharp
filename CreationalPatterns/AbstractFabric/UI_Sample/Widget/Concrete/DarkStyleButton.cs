using System;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete
{
    public class DarkStyleButton : IButton
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public void Click()
        {
            Console.WriteLine("DarkStyleButton has just clicked!");
        }
    }
}