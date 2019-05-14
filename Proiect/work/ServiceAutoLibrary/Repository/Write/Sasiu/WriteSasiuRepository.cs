namespace ServiceAutoLibrary.Repository.Write.Sasiu
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteSasiuRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Write.Sasiu.IWriteSasiuRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Write.Sasiu.IWriteSasiuRepository" />
    internal class WriteSasiuRepository: IWriteSasiuRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteSasiuRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteSasiuRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified sasiu.
        /// </summary>
        /// <param name="sasiu">The sasiu.</param>
        public void Create(ServiceAutoLibrary.Sasiu sasiu)
        {
            _context.Sasiuri.Add(sasiu);
        }

        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var sasiu = _context.Sasiuri.First(s => s.SasiuId == id);
            _context.Sasiuri.Remove(sasiu);
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
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
