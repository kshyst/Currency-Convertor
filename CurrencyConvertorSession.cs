
namespace CurrencyConvertor
{
    class Session
    {
        private int Mode = 3;

        public Session() { }

        public void StartSession()
        {
            while (Mode != 0)
            {
                Console.WriteLine("Welcome ! What Do You Want To Do???");
                Console.WriteLine("[1] Convert Toman To Dollar");
                Console.WriteLine("[2] Convert Dollar To Toman");
                Console.WriteLine("[0] Exit");
                Mode = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (Mode)
                {
                    case 0:
                        Environment.Exit(0);
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Enter Toman");
                        float money1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Your Money in Dollars = " + money1.TomanToDollar());
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Enter Dollar");
                        float money2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Your Money in Tomans = " + money2.DollarToToman());
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
} 
