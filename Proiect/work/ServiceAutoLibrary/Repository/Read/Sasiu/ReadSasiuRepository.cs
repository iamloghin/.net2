namespace ServiceAutoLibrary.Repository.Read.Sasiu
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadSasiuRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.Sasiu.IReadSasiuRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.Sasiu.IReadSasiuRepository" />
    internal class ReadSasiuRepository: IReadSasiuRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadSasiuRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadSasiuRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Sasiu.</returns>
        public ServiceAutoLibrary.Sasiu GetById(int id)
        {
            return _context.Sasiuri.FirstOrDefault(s => s.SasiuId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Sasiuri&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Sasiu> GetAll()
        {
            return _context.Sasiuri.ToList();
        }


        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Sasiuri.Any(s => s.SasiuId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the cod sasiu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the cod sasiu.</returns>
        public string GetCodSasiu(int id)
        {
            return _context.Sasiuri.FirstOrDefault(s => s.SasiuId == id).CodSasiu;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the sasiu denumire.</returns>
        public string GetDenumire(int id)
        {
            return _context.Sasiuri.FirstOrDefault(s => s.SasiuId == id)?.Denumire;
        }
    }
}
