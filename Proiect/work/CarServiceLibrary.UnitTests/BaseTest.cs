namespace CarServiceLibrary.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CarService;
    using CarService.Service;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BaseTest
    {
        AutoService _autoService;
        private static readonly Random Random = new Random();

        public static string RandomString(int length, bool numbers = false)
        {
            var chars = numbers ? "0123456789" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _autoService = new AutoService();
        }

        //[TestCleanup]
        public void TestCleanup()
        {
            _autoService.DeleteAllEntitiesOnTable("DetaliuComandaMaterial");
            _autoService.DeleteAllEntitiesOnTable("Imagini");
            _autoService.DeleteAllEntitiesOnTable("Operatii");
            _autoService.DeleteAllEntitiesOnTable("DetaliiComanda");
            _autoService.DeleteAllEntitiesOnTable("Comenzi");
            _autoService.DeleteAllEntitiesOnTable("Autos");
            _autoService.DeleteAllEntitiesOnTable("Clienti");
            _autoService.DeleteAllEntitiesOnTable("Materiale");
            _autoService.DeleteAllEntitiesOnTable("Mecanici");
            _autoService.DeleteAllEntitiesOnTable("Sasiuri");
        }

        [TestMethod]
        public void CreateClientAutoSasiuComandaDetaliuComanda()
        {
            try
            {
                var newClient = new Client()
                {
                    Adresa = "Decebal 4",
                    Email = RandomString(15),
                    Judet = "Neamt",
                    Localitate = "Targu Neamt",
                    Nume = "Loghin",
                    Prenume = "Alexandru",
                    Telefon = RandomString(10, true)
                };

                var newSasiu = new Sasiu()
                {
                    CodSasiu = "2F",
                    Denumire = "Audi 64 BMW"
                };

                var serieSasiu =
                    $"AM0000{newSasiu.CodSasiu}123AS000";

                var newAuto = new Auto()
                {
                    Client = newClient,
                    NumarAuto = RandomString(10),
                    Sasiu = newSasiu,
                    SerieSasiu = serieSasiu
                };

                var comanda = new Comanda()
                {
                    Auto = newAuto,
                    Client = newAuto.Client,
                    DataProgramare = DateTime.Now.AddDays(Random.Next(1, 20)),
                    DataFinalizare = DateTime.Now.AddDays(Random.Next(20, 40)),
                    DataSystem = DateTime.Now,
                    Descriere = "Reparat motor",
                    StareComanda = (StareComanda)Enum.ToObject(typeof(StareComanda), Random.Next(1, 4))
                };

                var newDetaliuComanda = new DetaliuComanda()
                {
                    Comanda = comanda,
                    Operaties = new List<Operatie>()
                                    {
                                        new Operatie()
                                            {
                                                Denumire = RandomString(10),
                                                TimpExecutie = 12
                                            },
                                        new Operatie()
                                            {
                                                Denumire = RandomString(10),
                                                TimpExecutie = 43
                                            }
                                    }
                };

                var response = _autoService.CreateDetaliuComanda(newDetaliuComanda);
                Assert.IsTrue(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void CreateClientsList()
        {
            var clientsList = new List<Client>();
            int noClients = 10;
            while (noClients-- > 0)
            {
                clientsList.Add(new Client() {
                            Adresa = RandomString(30),
                            Email = RandomString(15),
                            Judet = RandomString(10),
                            Localitate = RandomString(10),
                            Nume = RandomString(10),
                            Prenume = RandomString(10),
                            Telefon = RandomString(10, true)
                        });
            }

            foreach (var client in clientsList)
            {
                var test = _autoService.CreateClient(client);
                Assert.IsTrue(test);
            }
        }

        [TestMethod]
        public void CreateMecanicsList()
        {
            var mecanicsList = new List<Mecanic>();
            int noMecanics = 20;
            while (noMecanics-- > 0)
            {
                mecanicsList.Add(new Mecanic() {
                                     Nume = RandomString(10),
                                     Prenume = RandomString(10)
                                 });
            }
            foreach (var mecanic in mecanicsList)
            {
                var test = _autoService.CreateMecanic(mecanic);
                Assert.IsTrue(test);
            }
        }

        [TestMethod]
        public void XCleanAll()
        {
            TestCleanup();
        }
    }
}
