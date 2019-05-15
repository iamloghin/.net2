namespace CarService.WCF
{
    using System;
    using System.ServiceModel;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            var host = new ServiceHost(typeof(Service.AutoService), new Uri("http://localhost:8080/service"));

            foreach (var se in host.Description.Endpoints)
            {
                Console.WriteLine("A (address): {0} \nB (binding): {1}\nC(Contract): {2}\n", se.Address, se.Binding.Name, se.Contract.Name);
            }

            host.Open();

            Console.WriteLine("WCF started...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }
}
