namespace CarService.Repository.Write.DetaliuComanda
{
    using System;
    using System.Linq;
    using System.Data.Entity.Migrations;

    using DetaliuComanda = CarService.DetaliuComanda;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteDetaliuComandaRepository.
    /// Implements the <see cref="IWriteDetaliuComandaRepository" />
    /// </summary>
    /// <seealso cref="IWriteDetaliuComandaRepository" />
    internal class WriteDetaliuComandaRepository: IWriteDetaliuComandaRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteDetaliuComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteDetaliuComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the specified detaliu comanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        public void Create(DetaliuComanda detaliuComanda)
        {
            _context.DetaliiComanda.Add(detaliuComanda);
        }

        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var detaliuComanda = _context.DetaliiComanda.First(d => d.Id == id);
            _context.DetaliiComanda.Remove(detaliuComanda);
        }

        public void Update(CarService.DetaliuComanda detaliuComanda)
        {
            _context.DetaliiComanda.AddOrUpdate(detaliuComanda);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.DetaliiComanda.Any(d => d.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
