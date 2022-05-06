using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample;
using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.WidgitKits.Concrete;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric
{
    public static class Sample
    {
        public static void Run()
        {
           // UI Sample
           var drawler = new DefaultUserInterfaceDrawler();
           drawler.SetupInterface(new WhiteStyleWidgetKit());
           drawler.SetupInterface(new DarkStyleWidgetKit());
        }
    }
}