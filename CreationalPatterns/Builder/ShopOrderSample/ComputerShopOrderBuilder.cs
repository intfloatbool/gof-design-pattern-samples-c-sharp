using System;

namespace GOF_DesignPatters.CreationalPatterns.Builder.ShopOrderSample
{
    public class ComputerShopOrderBuilder
    {
        private OSType? _operationSystem;
        private int? _gigabytesRAM;
        private int? _gigabytesStorage;
        private string _videoCard;
        private string _cpu;

        public ComputerShopOrderBuilder SetOS(OSType osType)
        {
            _operationSystem = osType;
            return this;
        }

        public ComputerShopOrderBuilder SetGigabytesRAM(int gigabytes)
        {
            _gigabytesRAM = gigabytes;
            return this;
        }
        
        public ComputerShopOrderBuilder SetGigabytesStorage(int gigabytes)
        {
            _gigabytesStorage = gigabytes;
            return this;
        }
        
        public ComputerShopOrderBuilder SetVideoCard(string videoCard)
        {
            _videoCard = videoCard;
            return this;
        }
        
        public ComputerShopOrderBuilder SetCPU(string cpu)
        {
            _cpu = cpu;
            return this;
        }
        
        public ComputerShopOrder Build()
        {
            var shopOrder = new ComputerShopOrder
            {
                OperationSystem = _operationSystem,
                GigabytesRAM = _gigabytesRAM,
                GigabytesStorage = _gigabytesStorage,
                VideoCard = _videoCard,
                CPU = _cpu
            };

            Clear();

            return shopOrder;
        }

        private void Clear()
        {
            _operationSystem = null;
            _gigabytesRAM = null;
            _gigabytesStorage = null;
            _videoCard = String.Empty;
            _cpu = String.Empty;;
        }
    }
}