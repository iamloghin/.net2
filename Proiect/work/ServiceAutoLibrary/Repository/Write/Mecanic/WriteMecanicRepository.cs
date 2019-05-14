namespace ServiceAutoLibrary.Repository.Write.Mecanic
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteMecanicRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Write.Mecanic.IWriteMecanicRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Write.Mecanic.IWriteMecanicRepository" />
    internal class WriteMecanicRepository: IWriteMecanicRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteMecanicRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteMecanicRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified mecanic.
        /// </summary>
        /// <param name="mecanic">The mecanic.</param>
        public void Create(ServiceAutoLibrary.Mecanic mecanic)
        {
            _context.Mecanics.Add(mecanic);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var mecanic = _context.Mecanics.First(m => m.MecanicId == id);
            _context.Mecanics.Remove(mecanic);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Mecanics.Any(m => m.MecanicId == id);
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
