namespace ServiceAutoLibrary.Repository.Read.DetaliuComanda
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadDetaliuComandaRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.DetaliuComanda.IReadDetaliuComandaRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.DetaliuComanda.IReadDetaliuComandaRepository" />
    internal class ReadDetaliuComandaRepository: IReadDetaliuComandaRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadDetaliuComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadDetaliuComandaRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The DetaliuComanda.</returns>
        public ServiceAutoLibrary.DetaliuComanda GetById(int id)
        {
            return _context.DetaliComenzi.FirstOrDefault(c => c.DetaliuComandaId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;DetaliComenzi&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.DetaliuComanda> GetAll()
        {
            return _context.DetaliComenzi.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.DetaliComenzi.Any(c => c.DetaliuComandaId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Comanda.</returns>
        public ServiceAutoLibrary.Comanda GetComanda(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.ComandaId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the mecanics.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Mecanic&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Mecanic> GetMecanics(int id)
        {
            return _context.DetaliComenzi.FirstOrDefault(c => c.DetaliuComandaId == id)?.Mecanics;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Material&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Material> GetMaterials(int id)
        {
            return _context.DetaliComenzi.FirstOrDefault(c => c.DetaliuComandaId == id)?.Materials;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Operatieses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Operatie&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Operatie> Operaties(int id)
        {
            return _context.DetaliComenzi.FirstOrDefault(c => c.DetaliuComandaId == id)?.Operaties;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Imagineses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Imagine&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Imagine> Imagines(int id)
        {
            return _context.DetaliComenzi.FirstOrDefault(c => c.DetaliuComandaId == id)?.Imagines;
        }
    }
}
