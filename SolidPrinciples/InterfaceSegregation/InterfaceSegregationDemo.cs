
namespace SolidPrinciples.InterfaceSegregation
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
        }
    }

    public interface SmartPhone
    {
        public void TakePhoto();

        public void ConnectWifi();
    }

    public interface OldFashionPhone
    {
        public void Call();

        public void SendSMS();
    }

    public class SamsungGalaxyA72 : OldFashionPhone, SmartPhone
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
            Console.WriteLine("Connect a Wifi network");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Take a photograph");
        }
    }

    public class Nokia3310 : OldFashionPhone
    {
        public void Call()
        {
            Console.WriteLine("Call a number");
        }

        public void SendSMS()
        {
            Console.WriteLine("Send SMS to a number");
        }
    }
}
