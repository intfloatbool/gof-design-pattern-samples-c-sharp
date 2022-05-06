using System;
using System.Collections.Generic;
using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.Widget;
using GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample.WidgitKits;

namespace GOF_DesignPatters.CreationalPatterns.AbstractFabric.UI_Sample
{
    public class DefaultUserInterfaceDrawler
    {
        public void SetupInterface(IWidgetFactory widgetFactory)
        {
            IWindow window = widgetFactory.CreateWindow();
            ITextLabel label = widgetFactory.CreateTextLabel();
            IButton button = widgetFactory.CreateButton();

            window.SubWidgets = new List<IWidget>
            {
                label, button
            };
            
            Console.WriteLine();
            Console.WriteLine("[DefaultUserInterfaceDrawler] interface has drawn!"); 
            Console.WriteLine();
            Console.WriteLine($"[DefaultUserInterfaceDrawler] window.title: {window.Title}");
            Console.WriteLine($"[DefaultUserInterfaceDrawler] label.text: {label.Text}");
            button.Click();
        }
    }
}