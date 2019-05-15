namespace CarServiceLibrary.UnitTests
{
    using System;
    using System.Collections.Generic;

    using CarService;
    using CarService.Service;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BaseTest
    {
        AutoService _autoService;

        [TestInitialize]
        public void TestInitialize()
        {
            _autoService = new AutoService();
        }

        //[TestCleanup]
        public void TestCleanup()
        {
            _autoService.DeleteAllEntitiesOnTable("DetaliuComandaMaterial");
            _autoService.DeleteAllEntitiesOnTable("DetaliiComanda");
            _autoService.DeleteAllEntitiesOnTable("Comenzi");
            _autoService.DeleteAllEntitiesOnTable("Autos");
            _autoService.DeleteAllEntitiesOnTable("Clienti");
            _autoService.DeleteAllEntitiesOnTable("Materiale");
            _autoService.DeleteAllEntitiesOnTable("Operatii");
            _autoService.DeleteAllEntitiesOnTable("Imagini");
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
                    Email = "logalex96@gmail.com",
                    Judet = "Neamt",
                    Localitate = "Targu Neamt",
                    Nume = "Loghin",
                    Prenume = "Alexandru",
                    Telefon = "0747295142"
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
                    NumarAuto = "000FHSA123",
                    Sasiu = newSasiu,
                    SerieSasiu = serieSasiu
                };

                var comanda = new Comanda()
                {
                    Auto = newAuto,
                    Client = newAuto.Client,
                    DataProgramare = DateTime.Now.AddDays(7),
                    DataSystem = DateTime.Now,
                    Descriere = "Reparat motor",
                    StareComanda = StareComanda.InAsteptare
                };

                var newDetaliuComanda = new DetaliuComanda()
                {
                    Comanda = comanda
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
            var clientsList = new List<Client>()
            {
                new Client()
                {
                    Adresa = "Stefan Cel Mare 2",
                    Email = "vali2019@gmail.com",
                    Judet = "Neamt",
                    Localitate = "Targu Neamt",
                    Nume = "Stefanache",
                    Prenume = "Vali",
                    Telefon = "1111111111"
                },
                new Client()
                {
                    Adresa = "Decebal 1",
                    Email = "alexloghin29@gmail.com",
                    Judet = "Iasi",
                    Localitate = "Iasi",
                    Nume = "Amara",
                    Prenume = "Tudor",
                    Telefon = "0747292312"
                },
                new Client()
                {
                    Adresa = "Steliache",
                    Email = "asdasd@gmail.com",
                    Judet = "Bacau",
                    Localitate = "Bacau",
                    Nume = "Stefan",
                    Prenume = "Strugari",
                    Telefon = "0742222312"
                }
            };

            foreach (var client in clientsList)
            {
                var test = _autoService.CreateClient(client);
                Assert.IsTrue(test);
            }
        }

        [TestMethod]
        public void CreateMecanicsList()
        {
            var mecanicsList = new List<Mecanic>()
            {
                new Mecanic
                {
                    Nume = "Amara",
                    Prenume = "Gill"
                },
                new Mecanic
                {
                    Nume = "Underwood",
                    Prenume = "Haney"
                },
                new Mecanic
                {
                    Nume = "Bradley",
                    Prenume = "Woodward"
                },
                new Mecanic
                {
                    Nume = "Zavala",
                    Prenume = "Hood"
                },
                new Mecanic
                {
                    Nume = "Leon",
                    Prenume = "Pruitt"
                }
            };

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
