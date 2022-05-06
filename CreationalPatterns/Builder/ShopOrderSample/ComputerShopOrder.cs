using System.Text;

namespace GOF_DesignPatters.CreationalPatterns.Builder.ShopOrderSample
{
    public class ComputerShopOrder
    {
        public OSType? OperationSystem { get; set; }
        public int? GigabytesRAM { get; set; }
        public int? GigabytesStorage { get; set; }
        public string VideoCard { get; set; }
        public string CPU { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .Append('\n')
                .Append(OperationSystem.HasValue ? OperationSystem.Value.ToString() : string.Empty)
                .Append('\n')
                .Append(GigabytesRAM.HasValue ? GigabytesRAM.Value.ToString() : string.Empty)
                .Append('\n')
                .Append(GigabytesStorage.HasValue ? GigabytesStorage.Value.ToString() : string.Empty)
                .Append('\n')
                .Append(VideoCard)
                .Append('\n')
                .Append(CPU)
                .ToString();
        }
    }
}