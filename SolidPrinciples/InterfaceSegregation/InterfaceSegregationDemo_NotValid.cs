
namespace SolidPrinciples.InterfaceSegregation_NotValid
{
    public class InterfaceSegregationDemo
    {
        public static void Main()
        {
            SamsungGalaxyA72 samsung = new SamsungGalaxyA72();
            samsung.Call();
            samsung.SendSMS();
            samsung.TakePhoto();
            samsung.ConnectWifi();

            Nokia3310 nokia = new Nokia3310();
            nokia.Call();
            nokia.SendSMS();
            nokia.TakePhoto(); // Can not implement this method
            nokia.ConnectWifi(); // Can not implement this method
        }
    }

    public interface IMobilephone
    {
        public void Call();

        public void SendSMS();

        public void TakePhoto();

        public void ConnectWifi();
    }

    public class SamsungGalaxyA72 : IMobilephone
    {
        public void Call()
        {
            Console.WriteLine("Call a number");
        }

        public void ConnectWifi()
        {
            Console.WriteLine("Connect a Wifi network");
        }

        public void SendSMS()
        {
            Console.WriteLine("Send SMS to a number");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Take a photograph");
        }
    }

    public class Nokia3310 : IMobilephone
    {
        public void Call()
        {
            Console.WriteLine("Call a number");
        }

        public void SendSMS()
        {
            Console.WriteLine("Send SMS to a number");
        }

        public void ConnectWifi()
        {
            throw new NotImplementedException();
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
