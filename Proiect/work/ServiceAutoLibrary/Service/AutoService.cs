using System.Data.Entity.Validation;
using System.Text;
using System.Threading;
using ServiceAutoLibrary.Common.Exceptions;

namespace ServiceAutoLibrary.Service
{
    using System;
    using System.Collections.Generic;
    using ServiceAutoLibrary.Repository.Read.Auto;
    using ServiceAutoLibrary.Repository.Read.Client;
    using ServiceAutoLibrary.Repository.Read.Comanda;
    using ServiceAutoLibrary.Repository.Read.DetaliuComanda;
    using ServiceAutoLibrary.Repository.Read.Imagine;
    using ServiceAutoLibrary.Repository.Read.Material;
    using ServiceAutoLibrary.Repository.Read.Mecanic;
    using ServiceAutoLibrary.Repository.Read.Operatie;
    using ServiceAutoLibrary.Repository.Read.Sasiu;
    using ServiceAutoLibrary.Repository.Write.Auto;
    using ServiceAutoLibrary.Repository.Write.Client;
    using ServiceAutoLibrary.Repository.Write.Comanda;
    using ServiceAutoLibrary.Repository.Write.DetaliuComanda;
    using ServiceAutoLibrary.Repository.Write.Imagine;
    using ServiceAutoLibrary.Repository.Write.Material;
    using ServiceAutoLibrary.Repository.Write.Mecanic;
    using ServiceAutoLibrary.Repository.Write.Operatie;
    using ServiceAutoLibrary.Repository.Write.Sasiu;

    /// <inheritdoc />
    /// <summary>
    /// Class AutoService.
    /// Implements the <see cref="T:ServiceAutoLibrary.Service.IAutoService" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Service.IAutoService" />
    public class AutoService: IAutoService
    {
        private static ServiceAutoModelContainer _context;

        private ReadAutoRepository _autoRead;
        private ReadClientRepository _clientRead;
        private ReadComandaRepository _comandaRead;
        private ReadDetaliuComandaRepository _detaliuComandaRead;
        private ReadImagineRepository _imagineRead;
        private ReadMaterialRepository _materialRead;
        private ReadMecanicRepository _mecanicRead;
        private ReadOperatieRepository _operatieRead;
        private ReadSasiuRepository _sasiuRead;

        private WriteAutoRepository _autoWrite;
        private WriteClientRepository _clientWrite;
        private WriteComandaRepository _comandaWrite;
        private WriteDetaliuComandaRepository _detaliuComandaWrite;
        private WriteImagineRepository _imagineWrite;
        private WriteMaterialRepository _materialWrite;
        private WriteMecanicRepository _mecanicWrite;
        private WriteOperatieRepository _operatieWrite;
        private WriteSasiuRepository _sasiuWrite;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AutoService()
        {
            _context = new ServiceAutoModelContainer();
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <param name="operatieId">The operatie identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool AddOperatie(int detaliuComandaId, int operatieId)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Adds the mecanic.
        /// </summary>
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <param name="operatieId">The operatie identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool AddMecanic(int detaliuComandaId, int operatieId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Searches the client.
        /// </summary>
        /// <param name="searchClientString">Search by SerieSasiu, Telefon, Email</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="NotImplementedException"></exception>
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
        /// <param name="clientId">The client identifier.</param>
        /// <returns>IList&lt;Auto&gt;.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IList<Auto> GetClientAutos(int clientId)
        {
            try
            {
                _autoRead = new ReadAutoRepository(_context);
                return _autoRead.GetAutoByClient(clientId);
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
        /// <exception cref="NotImplementedException"></exception>
        public IList<Mecanic> GetAvailabelMecanics()
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Determines whether this instance [can be refuzata] the specified comanda identifier.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <returns><c>true</c> if this instance [can be refuzata] the specified comanda identifier; otherwise, <c>false</c>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CanBeRefuzata(int comandaId)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Sets the comanda status.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        /// <param name="descriere">The descriere.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SetComandaStatus(int comandaId, StareComanda stareComanda, string descriere)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Comandas the add material.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <param name="materialId">The material identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ComandaAddMaterial(int comandaId, int materialId)
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
