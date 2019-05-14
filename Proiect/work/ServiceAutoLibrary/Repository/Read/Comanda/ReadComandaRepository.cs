namespace ServiceAutoLibrary.Repository.Read.Comanda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Auto;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadComandaRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.Comanda.IReadComandaRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.Comanda.IReadComandaRepository" />
    internal class ReadComandaRepository: IReadComandaRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadAutoRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadComandaRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Coamnda.</returns>
        /// <inheritdoc />
        public ServiceAutoLibrary.Comanda GetById(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Comenzi&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Comanda> GetAll()
        {
            return _context.Comenzi.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Comenzi.Any(c => c.ComandaId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the stare comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the stare comanda.</returns>
        public string GetStareComanda(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id)?.StareComanda.ToString();
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data system.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data system</returns>
        public DateTime GetDataSystem(int id)
        {
            return  _context.Comenzi.FirstOrDefault(c => c.ComandaId == id).DataSystem;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data programare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data programare.</returns>
        public DateTime GetDataProgramare(int id)
        {
            return  _context.Comenzi.FirstOrDefault(c => c.ComandaId == id).DataProgramare;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data finalizare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data finalizare.</returns>
        public DateTime GetDataFinalizare(int id)
        {
            return  _context.Comenzi.FirstOrDefault(c => c.ComandaId == id).DataFinalizare;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the km board.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>An integer that represents the km auto board.</returns>
        public int GetKmBoard(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id).KmBord;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the comanda descriere.</returns>
        public string GetDescriere(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id)?.Descriere;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the valoare piese.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the valoare piese.</returns>
        public decimal GetValoarePiese(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id).ValoarePiese;
        }
    }
}
