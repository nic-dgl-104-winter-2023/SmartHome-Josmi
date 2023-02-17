namespace index
{
    class Program
    {
        protected string deviceStatus = "online"
        public string deviceType= "unknown";
        public string name;
        public string category;
        public class SmartDevice(string name, string category) {

       
        public void  turnOn() {
            deviceStatus = "on";
        }

        public void  turnOff() {
            deviceStatus = "off";
        }
   }
    static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SmartDevice SmartDevice = new SmartDevice("Jos","student");
            Console.WriteLine(this.name);
        }
    }
}
