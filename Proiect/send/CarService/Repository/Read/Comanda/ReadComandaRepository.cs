using CarService.Repository.Read.Auto;

namespace CarService.Repository.Read.Comanda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadComandaRepository.
    /// Implements the <see cref="T:CarService.Repository.Read.Comanda.IReadComandaRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Read.Comanda.IReadComandaRepository" />
    internal class ReadComandaRepository: IReadComandaRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadAutoRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Coamnda.</returns>
        public CarService.Comanda GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Comenzi.FirstOrDefault(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Comenzi&gt;.</returns>
        public IReadOnlyList<CarService.Comanda> GetAll()
        {
            return _context.Comenzi.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Comenzi.Any(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the stare comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the stare comanda.</returns>
        public string GetStareComanda(Guid id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.Id == id)?.StareComanda.ToString();
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data system.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data system</returns>
        public DateTime GetDataSystem(Guid id)
        {
            return  _context.Comenzi.FirstOrDefault(c => c.Id == id).DataSystem;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data programare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data programare.</returns>
        public DateTime GetDataProgramare(Guid id)
        {
            return  _context.Comenzi.FirstOrDefault(c => c.Id == id).DataProgramare;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data finalizare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data finalizare.</returns>
        public DateTime? GetDataFinalizare(Guid id)
        {
            return !Exists(id) ? null :   _context.Comenzi.FirstOrDefault(c => c.Id == id)?.DataFinalizare;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the km board.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>An integer that represents the km auto board.</returns>
        public int? GetKmBoard(Guid id)
        {
            return !Exists(id) ? null :  _context.Comenzi.FirstOrDefault(c => c.Id == id)?.KmBoard;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the comanda descriere.</returns>
        public string GetDescriere(Guid id)
        {
            return !Exists(id) ? null :  _context.Comenzi.FirstOrDefault(c => c.Id == id)?.Descriere;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the valoare piese.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the valoare piese.</returns>
        public decimal? GetValoarePiese(Guid id)
        {
            return !Exists(id) ? null :  _context.Comenzi.FirstOrDefault(c => c.Id == id)?.ValoarePiese;
        }
    }
}
