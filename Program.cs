namespace HotelTask.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            string hotelName;
            do
            {
                Console.WriteLine(" 1. Sisteme giris ; 0. sistemden cixis ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "0":
                        f = true;
                        break;
                    case "1":
                        Console.WriteLine("sisteme giris:");
                        Console.WriteLine("1.Hotel yarat)\r\n2.Butun Hotelleri gor\r\n3.Hotel sec (hotelin adini daxil ederek secilecek)\r\n0.Exit");
                        string operation2= Console.ReadLine();
                        switch (operation2)
                        {
                            case "0":
                                f = true;
                                break;
                            case "1":
                                hotelName = Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine();
                                break;
                            case "3":
                                break;
                            
                            default:
                                break;
                        }
                        break;

                    default:
                }

            } while (!f);

        }
    }
}
