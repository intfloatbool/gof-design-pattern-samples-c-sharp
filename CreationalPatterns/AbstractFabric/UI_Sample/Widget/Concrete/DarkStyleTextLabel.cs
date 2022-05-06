namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget.Concrete
{
    public class DarkStyleTextLabel : ITextLabel
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public string Text { get; set; } = "DarkStyleTextLabel";
    }
}