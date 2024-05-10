using System;

namespace OOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mng = new Manager();
            mng.Name = "John";
            Console.WriteLine("Maneger :" + mng.Name);

            Console.WriteLine("\n Clients Name & Points :...");
        
            Client cl1 = mng.AddClient("Alex");
            cl1.Buy("Book1");
            Console.WriteLine("\n"+cl1.Name);
            Console.WriteLine(cl1.GetPoints());
            cl1.Buy("Bag2");
            Console.WriteLine(cl1.GetPoints());

            Client cl2 = mng.AddClient("Marry");
            Console.WriteLine("\n"+cl2.Name);
            Console.WriteLine(cl2.GetPoints());

            Console.ReadKey();
        }
    }
    public class Client
    {
        public string Name;
        private int point=0;

        public int GetPoints()
        {
            return point;
        }
        public void Buy(string product)
        {
            // Buy The Product
            point++;
        }
    }
    public class Manager
    {
        public string Name;
        public Client AddClient(string clientName)
        {
            Client client1 = new Client();
            client1.Name = clientName;
            return client1;
        }
    }
        

        
}
