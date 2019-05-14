namespace ServiceAutoLibrary.Repository.Write.DetaliuComanda
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteDetaliuComandaRepository.
    /// Implements the <see cref="IWriteDetaliuComandaRepository" />
    /// </summary>
    /// <seealso cref="IWriteDetaliuComandaRepository" />
    internal class WriteDetaliuComandaRepository: IWriteDetaliuComandaRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteDetaliuComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteDetaliuComandaRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified detaliu comanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        public void Create(ServiceAutoLibrary.DetaliuComanda detaliuComanda)
        {
            _context.DetaliComenzi.Add(detaliuComanda);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var detaliuComanda = _context.DetaliComenzi.First(d => d.DetaliuComandaId == id);
            _context.DetaliComenzi.Remove(detaliuComanda);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.DetaliComenzi.Any(d => d.DetaliuComandaId == id);
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
