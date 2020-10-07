namespace BehavioralPatterns.MementoPattern
{
    public class LedTv
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool UsbSupport { get; set; }

        public LedTv(string size, string price, bool usbSupport)
        {
            Size = size;
            Price = price;
            UsbSupport = usbSupport;
        }

        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + UsbSupport + "]";
        }
    }
}
