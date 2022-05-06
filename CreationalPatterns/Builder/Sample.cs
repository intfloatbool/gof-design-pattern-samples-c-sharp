using System;
using GOF_DesignPatters.CreationalPatterns.Builder.ShopOrderSample;

namespace GOF_DesignPatters.CreationalPatterns.Builder
{
    public static class Sample
    {
        public static void Run()
        {
            var programmingPcOrder =
                new ComputerShopOrderBuilder()
                    .SetGigabytesStorage(500)
                    .SetGigabytesRAM(16)
                    .SetCPU("Intel Core i5")
                    .SetOS(OSType.LINUX)
                    .Build();

            var gamingPcOrder =
                new ComputerShopOrderBuilder()
                    .SetGigabytesStorage(2000)
                    .SetGigabytesRAM(32)
                    .SetCPU("AMD Ryzen 7")
                    .SetOS(OSType.WINDOWS)
                    .Build();
            
            Console.WriteLine($"PROGRAMMING PC ORDER: \n{programmingPcOrder}");
            Console.WriteLine();
            Console.WriteLine($"GAMING PC ORDER: \n{gamingPcOrder}");
        }
    }
}