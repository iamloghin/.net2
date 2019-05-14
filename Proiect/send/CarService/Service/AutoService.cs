namespace CarService.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.Exceptions;
    using CarService.Repository.Read.Auto;
    using CarService.Repository.Read.Client;
    using CarService.Repository.Read.Mecanic;
    using CarService.Repository.Write.Auto;
    using CarService.Repository.Write.Client;
    using CarService.Repository.Write.Comanda;
    using CarService.Repository.Write.DetaliuComanda;
    using CarService.Repository.Write.Imagine;
    using CarService.Repository.Write.Material;
    using CarService.Repository.Write.Mecanic;
    using CarService.Repository.Write.Operatie;
    using CarService.Repository.Read.Comanda;
    using CarService.Repository.Read.DetaliuComanda;
    using CarService.Repository.Read.Imagine;
    using CarService.Repository.Read.Material;
    using CarService.Repository.Read.Operatie;

    /// <inheritdoc />
    /// <summary>
    /// Class AutoService.
    /// Implements the <see cref="T:CarService.Service.IAutoService" />
    /// </summary>
    /// <seealso cref="T:CarService.Service.IAutoService" />
    public class AutoService: IAutoService
    {
        private static CarServiceModelContainer _context;

        private ReadAutoRepository _autoRead;
        private ReadClientRepository _clientRead;
        private ReadComandaRepository _comandaRead;
        private ReadDetaliuComandaRepository _detaliuComandaRead;
        private ReadImagineRepository _imagineRead;
        private ReadMaterialRepository _materialRead;
        private ReadMecanicRepository _mecanicRead;
        private ReadOperatieRepository _operatieRead;

        private WriteAutoRepository _autoWrite;
        private WriteClientRepository _clientWrite;
        private WriteComandaRepository _comandaWrite;
        private WriteDetaliuComandaRepository _detaliuComandaWrite;
        private WriteImagineRepository _imagineWrite;
        private WriteMaterialRepository _materialWrite;
        private WriteMecanicRepository _mecanicWrite;
        private WriteOperatieRepository _operatieWrite;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoService"/> class.
        /// </summary>
        public AutoService() => _context = new CarServiceModelContainer();

        public void DeleteAllEntitiesOnTable(string tableName)
        {
            var count = _context.Database.SqlQuery<int>("SELECT COUNT(OBJECT_ID(@p0, 'U'))", tableName);
            if (count.Any() && count.First() > 0)
            {
                _context.Database.ExecuteSqlCommand($"DELETE FROM {tableName}");
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="T:CarService.Common.Exceptions.DbEntityCustomException"></exception>
        public bool CreateClient(Client client)
        {
            try
            {
                _clientWrite = new WriteClientRepository(_context);

                _clientWrite.Create(client);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the automatic.
        /// </summary>
        /// <param name="auto">The automatic.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateAuto(Auto auto)
        {
            try
            {
                _autoWrite = new WriteAutoRepository(_context);

                _autoWrite.Create(auto);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the material.
        /// </summary>
        /// <param name="material">The material.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateMaterial(Material material)
        {
            try
            {
                _materialWrite = new WriteMaterialRepository(_context);

                _materialWrite.Create(material);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the detaliu comanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            try
            {
                _detaliuComandaWrite = new WriteDetaliuComandaRepository(_context);

                _detaliuComandaWrite.Create(detaliuComanda);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the imagine.
        /// </summary>
        /// <param name="imagine">The imagine.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateImagine(Imagine imagine)
        {
            try
            {
                _imagineWrite = new WriteImagineRepository(_context);

                _imagineWrite.Create(imagine);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the operatie.
        /// </summary>
        /// <param name="operatie">The operatie.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateOperatie(Operatie operatie)
        {
            try
            {
                _operatieWrite = new WriteOperatieRepository(_context);

                _operatieWrite.Create(operatie);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the mecanic.
        /// </summary>
        /// <param name="mecanic">The mecanic.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateMecanic(Mecanic mecanic)
        {
            try
            {
                _mecanicWrite = new WriteMecanicRepository(_context);

                _mecanicWrite.Create(mecanic);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the comanda.
        /// </summary>
        /// <param name="comanda">The comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool CreateComanda(Comanda comanda)
        {
            try
            {
                _comandaWrite = new WriteComandaRepository(_context);

                _comandaWrite.Create(comanda);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Adds the operatie.
        /// </summary>
        /// <param name="operatie">The operatie.</param>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool AddOperatie(Operatie operatie, DetaliuComanda detaliuComanda)
        {
            try
            {
                _operatieWrite = new WriteOperatieRepository(_context);
                _detaliuComandaWrite = new WriteDetaliuComandaRepository(_context);

                _operatieWrite.Create(operatie);
                detaliuComanda.Operaties.Add(operatie);
                _detaliuComandaWrite.Update(detaliuComanda);

                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Adds the mecanics.
        /// </summary>
        /// <param name="selectedMecanics">The selected mecanics.</param>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool AddMecanics(List<Mecanic> selectedMecanics, DetaliuComanda detaliuComanda)
        {
            try
            {
                _detaliuComandaWrite = new WriteDetaliuComandaRepository(_context);
                foreach (var selectedMecanic in selectedMecanics)
                {
                    detaliuComanda.Mecanici.Add(selectedMecanic);
                }
                _detaliuComandaWrite.Update(detaliuComanda);

                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Updates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool UpdateClient(Client client)
        {
            try
            {
                _clientWrite = new WriteClientRepository(_context);

                _clientWrite.Update(client);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Updates the detaliuComanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliuComanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public bool UpdateDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            try
            {
                _detaliuComandaWrite = new WriteDetaliuComandaRepository(_context);

                _detaliuComandaWrite.Update(detaliuComanda);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public bool UpdateMaterial(Material material)
        {
            try
            {
                _materialWrite = new WriteMaterialRepository(_context);

                _materialWrite.Update(material);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public bool DeleteMecanic(Mecanic mecanic)
        {
            try
            {
                _mecanicWrite = new WriteMecanicRepository(_context);

                _mecanicWrite.Delete(mecanic.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public bool DeleteOperatie(Operatie operatie)
        {
            try
            {
                _operatieWrite = new WriteOperatieRepository(_context);

                _operatieWrite.Delete(operatie.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public bool DeleteMaterial(Material material)
        {
            try
            {
                _materialWrite = new WriteMaterialRepository(_context);

                _materialWrite.Delete(material.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="searchClientString">The search client string.</param>
        /// <returns>Client.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public Client GetClient(string searchClientString)
        {
            try
            {
                _clientRead = new ReadClientRepository(_context);

                if (searchClientString.Contains("@"))
                {
                    return _clientRead.GetByEmail(searchClientString);
                }

                if (searchClientString.Contains("+") || IsDigitsOnly(searchClientString))
                {
                    return _clientRead.GetByTelefon(searchClientString);
                }

                return _clientRead.GetBySerieSasiu(searchClientString);
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the client autos.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IList&lt;Auto&gt;.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public IList<Auto> GetClientAutos(Guid id)
        {
            try
            {
                _autoRead = new ReadAutoRepository(_context);
                return _autoRead.GetAutoByClient(id);
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public IList<Material> GetAllMaterials()
        {
            try
            {
                _materialRead = new ReadMaterialRepository(_context);
                return _materialRead.GetAll().ToList();
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the availabel mecanics.
        /// </summary>
        /// <returns>IList&lt;Mecanic&gt;.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public IList<Mecanic> GetAvailabelMecanics()
        {
            try
            {
                _mecanicRead = new ReadMecanicRepository(_context);
                return _mecanicRead.GetAvailables();
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public IList<Material> GetAvailabelMaterials()
        {
            try
            {
                _materialRead = new ReadMaterialRepository(_context);
                return _materialRead.GetAvailables();
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all mecanics.
        /// </summary>
        /// <returns>IList&lt;Mecanic&gt;.</returns>
        /// <exception cref="DbEntityCustomException"></exception>
        public IList<Mecanic> GetAllMecanics()
        {
            try
            {
                _mecanicRead = new ReadMecanicRepository(_context);
                return _mecanicRead.GetAll().ToList();
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }

        public IList<DetaliuComanda> GetAllDetaliuComandas()
        {
            try
            {
                _detaliuComandaRead = new ReadDetaliuComandaRepository(_context);
                return _detaliuComandaRead.GetAll().ToList();
            }
            catch (Exception e)
            {
                var message = DbEntityCustomException.BuildMessageExceptions(e);
                throw new DbEntityCustomException(message);
            }
        }


        /// <inheritdoc />
        /// <summary>
        /// Determines whether this instance [can be refuzata] the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if this instance [can be refuzata] the specified identifier; otherwise, <c>false</c>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CanBeRefuzata(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets the comanda status.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        /// <param name="descriere">The descriere.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SetComandaStatus(Guid id, StareComanda stareComanda, string descriere)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Comandas the add material.
        /// </summary>
        /// <param name="materialId">The material identifier.</param>
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ComandaAddMaterial(Guid materialId, Guid detaliuComandaId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the programare clients list.
        /// </summary>
        /// <param name="dataProgramare">The data programare.</param>
        /// <returns>IList&lt;Client&gt;.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IList<Client> GetProgramareClientsList(DateTime dataProgramare)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether [is digits only] [the specified string].
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns><c>true</c> if [is digits only] [the specified string]; otherwise, <c>false</c>.</returns>
        private static bool IsDigitsOnly(string str)
        {
            foreach (var c in str)
            {
                if (c < '0')
                    return false;
                if (c > '9')
                    return false;
            }

            return true;
        }
    }
}
