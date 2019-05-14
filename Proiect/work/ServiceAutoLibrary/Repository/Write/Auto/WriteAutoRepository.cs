namespace ServiceAutoLibrary.Repository.Write.Auto
{
    using System.Linq;
        
    /// <inheritdoc />
    /// <summary>
    /// Class WriteAutoRepository.
    /// Implements the <see cref="IWriteAutoRepository" />
    /// </summary>
    /// <seealso cref="IWriteAutoRepository" />
    internal class WriteAutoRepository: IWriteAutoRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteAutoRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteAutoRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
            
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified automatic.
        /// </summary>
        /// <param name="auto">The automatic.</param>
        public void Create(ServiceAutoLibrary.Auto auto)
        {
            _context.Autos.Add(auto);
        }
            
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var auto = _context.Autos.First(a => a.AutoId == id);
            _context.Autos.Remove(auto);
        }
            
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Autos.Any(a => a.AutoId == id);
        }
            
        /// <inheritdoc />
        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <inheritdoc />
        /// <summary>Sets the numar automatic.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="numarAuto">The numar automatic.</param>
        public void SetNumarAuto(int id, string numarAuto)
        {
            _context.Autos.First(a => a.AutoId == id).NumarAuto = numarAuto;
        }

        /// <inheritdoc />
        /// <summary>Sets the serie sasiu.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="serieSasiu">The serie sasiu.</param>
        public void SetSerieSasiu(int id, string serieSasiu)
        {
            _context.Autos.First(a => a.AutoId == id).SerieSasiu = serieSasiu;
        }
    }
}
