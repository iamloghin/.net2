namespace ServiceAutoLibrary.Repository.Write.Imagine
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteImagineRepository.
    /// Implements the <see cref="IWriteImagineRepository" />
    /// </summary>
    /// <seealso cref="IWriteImagineRepository" />
    internal class WriteImagineRepository: IWriteImagineRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteImagineRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteImagineRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified imagine.
        /// </summary>
        /// <param name="imagine">The imagine.</param>
        public void Create(ServiceAutoLibrary.Imagine imagine)
        {
            _context.Imagini.Add(imagine);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var imagine = _context.Imagini.First(i => i.ImagineId == id);
            _context.Imagini.Remove(imagine);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Imagini.Any(i => i.ImagineId == id);
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
